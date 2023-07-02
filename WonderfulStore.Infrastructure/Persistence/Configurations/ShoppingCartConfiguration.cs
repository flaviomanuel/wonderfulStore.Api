using Microsoft.EntityFrameworkCore;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Infrastructure.Persistence.Configurations
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}