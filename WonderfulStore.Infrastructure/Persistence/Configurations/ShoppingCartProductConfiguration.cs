using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Infrastructure.Persistence.Configurations
{
    public class ShoppingCartProductConfiguration : IEntityTypeConfiguration<ShoppingCartProduct>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartProduct> builder)
        {
           builder.ToTable("ShoppingCartProduct");

           builder.HasKey(x => new { x.IdProduct, x.IdShoppingCart});

            builder
                .HasOne(scp => scp.Product)
                .WithMany(p => p.ShoppingCartProducts)
                .HasForeignKey(scp => scp.IdProduct);

             builder
                .HasOne(scp => scp.ShoppingCart)
                .WithMany(sc => sc.ShoppingCartProducts)
                .HasForeignKey(scp => scp.IdShoppingCart);


            builder.Property( x=> x.Quantity);
            builder.Property( x=> x.TotalPrice);
        }
    }
}