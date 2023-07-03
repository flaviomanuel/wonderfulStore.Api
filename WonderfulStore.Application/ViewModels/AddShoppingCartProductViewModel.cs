namespace WonderfulStore.Application.ViewModels
{
    public class AddShoppingCartProductViewModel
    {
        public int Quantity { get;  set; }
        public ProductViewModel Product {get; set;}
        public ShoppingCartViewModel ShoppingCart {get; set;}
    }
}