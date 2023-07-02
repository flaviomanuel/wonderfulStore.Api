namespace WonderfulStore.Application.ViewModels
{
    public class AddShoppingCartProductViewModel
    {
        public Guid IdProduct { get;  set; }
        public Guid IdShoppingCart { get;  set; }
        public int Quantity { get;  set; }
        public ProductViewModel Product {get; set;}
        public ShoppingCartViewModel ShoppingCart {get; set;}
    }
}