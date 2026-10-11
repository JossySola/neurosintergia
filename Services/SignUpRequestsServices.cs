using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;
using neurosintergia.Data.Models;

namespace neurosintergia.Services;

public class SignUpRequestsServices(IDbContextFactory<ApplicationDbContext> factory)
{
    public async Task<SignUpRequests?> GetSignUpRequests(string doctorId)
    {
        await using var context = await factory.CreateDbContextAsync();
        return await context.SignUpRequests
        .AsNoTracking()
        .SingleOrDefaultAsync(record => record.Id == doctorId);
    }

    public async Task UpdateStatus(string status, string doctorId, string adminId, string? comment)
    {
        await using var context = await factory.CreateDbContextAsync();
        var request = await context.SignUpRequests
        .SingleOrDefaultAsync(record => record.Id == doctorId)
        ?? throw new InvalidOperationException($"Signup request '{doctorId}' was not found.");

        request.Status = status;
        request.ReviewedBy = adminId;
        request.LastReviewed = DateTime.UtcNow;
        request.Comment = comment ?? "";

        await context.SaveChangesAsync();
    }

    public async Task ApproveRequest(
        string doctorId,
        string adminId,
        bool grupoI,
        bool grupoII,
        bool grupoIII,
        bool grupoIV,
        bool grupoV,
        bool grupoVI)
    {
        await using var context = await factory.CreateDbContextAsync();
        var request = await context.SignUpRequests
        .SingleOrDefaultAsync(record => record.Id == doctorId)
        ?? throw new InvalidOperationException($"Signup request '{doctorId}' was not found.");

        var functionRecord = await context.Medicos_Funciones
        .SingleOrDefaultAsync(record => record.MedicoId == doctorId);

        if (functionRecord is null)
        {
            functionRecord = new Medicos_Funciones
            {
                Id = Guid.CreateVersion7().ToString(),
                MedicoId = doctorId
            };
            context.Medicos_Funciones.Add(functionRecord);
        }

        functionRecord.Grupo_I = grupoI;
        functionRecord.Grupo_II = grupoII;
        functionRecord.Grupo_III = grupoIII;
        functionRecord.Grupo_IV = grupoIV;
        functionRecord.Grupo_V = grupoV;
        functionRecord.Grupo_VI = grupoVI;

        request.Status = "Approved";
        request.ReviewedBy = adminId;
        request.LastReviewed = DateTime.UtcNow;
        request.Comment = "";

        // EF Core saves both changes in one transaction for relational providers.
        await context.SaveChangesAsync();
    }

    public async Task<int> DeleteFnRecord(string doctorId)
    {
        await using var context = await factory.CreateDbContextAsync();
        return await context.Medicos_Funciones
        .Where(record => record.MedicoId == doctorId)
        .ExecuteDeleteAsync();
    }
}
