namespace neurosintergia.Services;

using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;
using neurosintergia.Data.Models;
using Microsoft.Extensions.Logging;

public sealed record UpdateDoctorRequest(
    string Id,
    string Nombre,
    string ApellidoPaterno,
    string? ApellidoMaterno,
    DateOnly FechaNacimiento,
    string CURP,
    string MunicipioNacimiento,
    string EstadoNacimiento,
    List<Credenciales>? Credenciales
);

public sealed record DoctorRequestUpdateResult(bool Saved, bool NotificationSent);
public class DashboardAuthViewsServices(
    IDbContextFactory<ApplicationDbContext> contextFactory,
    EmailSender sender,
    ILogger<DashboardAuthViewsServices> logger
)
{
    private readonly IDbContextFactory<ApplicationDbContext> ContextFactory = contextFactory;
    
    public async Task<List<PendingSignUpRow>> GetRequestsByStatus(string status)
    {
        await using var db = await ContextFactory.CreateDbContextAsync();
        return await db.SignUpRequests
            .AsNoTracking()
            .Where(request => request.Status.ToUpper() == status.ToUpper())
            .Join(
                db.Medicos.AsNoTracking(),
                request => request.Id,
                medico => medico.Id,
                (request, medico) => new PendingSignUpRow(
                    request.Id,
                    request.Created_At,
                    request.Status,
                    request.ReviewedBy,
                    request.Comment,
                    request.LastReviewed,
                    medico.Nombre,
                    medico.ApellidoPaterno,
                    medico.ApellidoMaterno,
                    medico.FechaNacimiento,
                    medico.CURP,
                    medico.MunicipioNacimiento,
                    medico.EstadoNacimiento,
                    medico.Email,
                    medico.Credenciales
                )
            ).ToListAsync();
    }

    public async Task<string?> GetUserStatus(string UserId)
    {
        await using var db = await ContextFactory.CreateDbContextAsync();
        return await db.SignUpRequests
            .AsNoTracking()
            .Where(record => record.Id == UserId)
            .Select(record => record.Status)
            .SingleOrDefaultAsync();
    }

    public async Task<DoctorRequestUpdateResult> UpdateDoctorRequest(UpdateDoctorRequest payload)
    {
        await using var db = await ContextFactory.CreateDbContextAsync();
        var doctor = await db.Medicos
            .Include(record => record.Credenciales)
            .SingleOrDefaultAsync(record => record.Id == payload.Id)
            ?? throw new InvalidOperationException("The doctor's record was not found.");

        var request = await db.SignUpRequests
            .SingleOrDefaultAsync(record => record.Id == payload.Id)
            ?? throw new InvalidOperationException("The doctor's signup request was not found.");

        doctor.Nombre = payload.Nombre;
        doctor.ApellidoPaterno = payload.ApellidoPaterno;
        doctor.ApellidoMaterno = payload.ApellidoMaterno;
        doctor.FechaNacimiento = payload.FechaNacimiento;
        doctor.CURP = payload.CURP;
        doctor.MunicipioNacimiento = payload.MunicipioNacimiento;
        doctor.EstadoNacimiento = payload.EstadoNacimiento;
        doctor.Credenciales = payload.Credenciales;
        request.Status = "pending";

        // The doctor and request changes are committed together.
        await db.SaveChangesAsync();

        try
        {
            var emailIsSent = await sender.NotifyNewDoctorRequest();
            if (!emailIsSent.Success)
            {
                logger.LogError("Doctor request {DoctorId} was saved, but the notification email was not sent", payload.Id);
                return new DoctorRequestUpdateResult(Saved: true, NotificationSent: false);
            }

            return new DoctorRequestUpdateResult(Saved: true, NotificationSent: true);
        }
        catch (Exception error)
        {
            logger.LogError(error, "Doctor request {DoctorId} was saved, but sending the notification failed", payload.Id);
            return new DoctorRequestUpdateResult(Saved: true, NotificationSent: false);
        }
    }
}
