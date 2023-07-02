using WonderfulStore.Core.Enums;

namespace WonderfulStore.Core.Entities
{
    public class ShoppingCart : IBaseEntity
    {
        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;

            Status = ShoppingCartStatus.Open;
            ShoppingCartProducts = new List<ShoppingCartProduct>();
        }

        public Guid Id {get; private set;}
        public DateTime CreatedAt { get; set; }
        public ShoppingCartStatus Status { get; private  set; }
        public List<ShoppingCartProduct> ShoppingCartProducts { get; private set; }


    }
}