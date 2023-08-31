using Microsoft.EntityFrameworkCore;

namespace VWelt.Application.Context;

public interface IVWeltDbContext
{
    DbSet<VWelt.Domain.Entities.User.UserProfile> UserProfiles { get; }

    Task<int> SaveToDbAsync();
}