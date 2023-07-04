using WonderfulStore.Core.Enums;

namespace WonderfulStore.Core.Entities
{
    public class Product : IBaseEntity
    {
        public Product(string name, decimal price, string description, PromotionType? promotionType)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;

            PromotionType = promotionType;
            ShoppingCartProducts = new List<ShoppingCartProduct>();

        }

        public Guid Id {get; private set;}
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public PromotionType? PromotionType { get; private set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; private set; }


        public void Update(string name, decimal price,string description, PromotionType? promotionType)
        {
            Name = name;
            Price = price;
            Description = description;
            PromotionType = promotionType;  
        }

    }
}