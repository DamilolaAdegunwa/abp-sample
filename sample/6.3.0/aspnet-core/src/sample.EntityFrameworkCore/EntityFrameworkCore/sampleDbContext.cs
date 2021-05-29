using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using sample.Authorization.Roles;
using sample.Authorization.Users;
using sample.MultiTenancy;

namespace sample.EntityFrameworkCore
{
    public class sampleDbContext : AbpZeroDbContext<Tenant, Role, User, sampleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public sampleDbContext(DbContextOptions<sampleDbContext> options)
            : base(options)
        {
        }
    }
}
