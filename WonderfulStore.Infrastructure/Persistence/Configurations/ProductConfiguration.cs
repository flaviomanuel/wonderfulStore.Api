using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Infrastructure.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(x => x.Id);
               
            builder
             .HasOne(x => x.Promotion)
             .WithMany(x => x.Products)
             .HasForeignKey(x => x.IdPromotion)
             .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}