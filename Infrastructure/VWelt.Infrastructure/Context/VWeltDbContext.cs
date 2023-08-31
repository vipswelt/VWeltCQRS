using VWelt.Domain.Entities;
using VWelt.Application.Context;
using Microsoft.EntityFrameworkCore;
using VWelt.Domain.Entities.User;
using System.Data;

namespace VWelt.Infrastructure.Context;

public class VWeltDbContext : DbContext, IVWeltDbContext
{
    public VWeltDbContext(DbContextOptions<VWeltDbContext> options) : base(options)
    {

    }

    public IDbConnection Connection => Database.GetDbConnection();

    public bool HasChanges => ChangeTracker.HasChanges();
    public DbSet<UserProfile> UserProfiles { get; set; }

    public async Task<int> SaveToDbAsync()
    {
        return await SaveChangesAsync();
    }
}