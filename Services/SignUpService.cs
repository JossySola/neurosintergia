using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;
using neurosintergia.Data.Models;

namespace neurosintergia.Services;

public class SignUpService(IDbContextFactory<ApplicationDbContext> factory)
{
    public async Task<SignUpRequests?> GetSignUpRequests(string DoctorId)
    {
        using var context = factory.CreateDbContext();
        var request = await context.SignUpRequests.SingleOrDefaultAsync(record => record.Id == DoctorId);
        if (request is null) return null;
        return request;
    }
    public async Task UpdateStatus(string Status, SignUpRequests Requests, string AdminId, string? Comment)
    {
        using var context = factory.CreateDbContext();
        Requests.Status = Status;
        Requests.ReviewedBy = AdminId;
        Requests.LastReviewed = DateTime.UtcNow;
        Requests.Comment = Comment ?? "";
        await context.SaveChangesAsync();
    }
    public async Task CreateFnRecord(
        string Id,
        string MedicoId,
        bool Grupo_I,
        bool Grupo_II,
        bool Grupo_III,
        bool Grupo_IV,
        bool Grupo_V,
        bool Grupo_VI
    )
    {
        using var context = factory.CreateDbContext();
        var fn = new Medicos_Funciones
        {
            Id = Id,
            MedicoId = MedicoId,
            Grupo_I = Grupo_I,
            Grupo_II = Grupo_II,
            Grupo_III = Grupo_III,
            Grupo_IV = Grupo_IV,
            Grupo_V = Grupo_V,
            Grupo_VI = Grupo_VI
        };
        await context.SaveChangesAsync();
    }
}