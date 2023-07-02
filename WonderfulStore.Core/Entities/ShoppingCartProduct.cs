namespace WonderfulStore.Core.Entities
{
    public class ShoppingCartProduct
    {
        public ShoppingCartProduct(int quantity, decimal totalPrice, Guid idProduct, Guid idShoppingCart)
        {
            Quantity = quantity;
            TotalPrice = totalPrice;

            IdProduct = idProduct;
            IdShoppingCart = idShoppingCart;
        }

        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Guid IdProduct { get; private set; }
        public Product Product { get; private set; }


        public Guid IdShoppingCart { get; private set; }
        public ShoppingCart ShoppingCart { get; private set; }

  
    }
}