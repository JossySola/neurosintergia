using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using neurosintergia.Data;
using neurosintergia.Data.Models;

namespace neurosintergia.Services;

public class DashboardAuthViewsServices(
    UserManager<ApplicationUser> userManager,
    IDbContextFactory<ApplicationDbContext> contextFactory
)
{
    private readonly UserManager<ApplicationUser> UserManager = userManager;
    private readonly IDbContextFactory<ApplicationDbContext> ContextFactory = contextFactory;
    
    public async Task<List<PendingSignUpRow>> GetPendingRequests()
    {
        await using var db = await ContextFactory.CreateDbContextAsync();
        List<PendingSignUpRow> requests = await db.SignUpRequests
        .AsNoTracking()
        .Where(request => request.Status.Equals("pending", StringComparison.CurrentCultureIgnoreCase))
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
        return requests;
    }
}