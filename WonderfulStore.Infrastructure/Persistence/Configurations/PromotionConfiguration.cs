using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Infrastructure.Persistence.Configurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder 
                .HasMany(x => x.Products)
                .WithOne(x => x.Promotion); 

            builder.HasData(
                new Promotion("2 por 1"),
                new Promotion("3 por R$10")
            );
              
        }
    }
}