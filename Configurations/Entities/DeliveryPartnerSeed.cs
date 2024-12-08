using Feedora_revised.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Feedora_revised.Configurations.Entities
{
    public class DeliveryPartnerSeed : IEntityTypeConfiguration<DeliveryPartner>
    {
        public void Configure(EntityTypeBuilder<DeliveryPartner> builder)
        {
            builder.HasData(
                new DeliveryPartner
                {
                    Id = 1,
                    Name = "Reina",
                    Password = "P@ssword1",
                    PhoneNum = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new DeliveryPartner
                {
                    Id = 2,
                    Name = "Oc",
                    Password = "P@ssword1",
                    PhoneNum = 6    ,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
