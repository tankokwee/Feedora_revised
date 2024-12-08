using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Feedora_revised.Data;
using Feedora_revised.Configurations.Entities;
using Feedora_revised.Domain;
using System.Drawing;
using CarRentalManagement.Configurations.Entities;
namespace Feedora_revised.Data
{
    public class FeedoraRevisedContext(DbContextOptions<FeedoraRevisedContext> options) :
    IdentityDbContext<Feedora_revisedUser>(options)
    {
        public DbSet<Feedora_revised.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Feedora_revised.Domain.DeliveryPartner> DeliveryPartner { get; set; } = default!;
        public DbSet<Feedora_revised.Domain.Restaurant> Restaurant { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new RestaurantSeed());
            builder.ApplyConfiguration(new DeliveryPartnerSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
