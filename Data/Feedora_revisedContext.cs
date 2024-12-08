using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Feedora_revised.Domain;
using Feedora_revised.Configurations.Entities;

namespace Feedora_revised.Data
{
    public class Feedora_revisedContext : DbContext
    {
        public Feedora_revisedContext (DbContextOptions<Feedora_revisedContext> options)
            : base(options)
        {
        }

        public DbSet<Feedora_revised.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Feedora_revised.Domain.DeliveryPartner> DeliveryPartner { get; set; } = default!;
        public DbSet<Feedora_revised.Domain.Restaurant> Restaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new RestaurantSeed());
            builder.ApplyConfiguration(new DeliveryPartnerSeed());
        }
    }
}
