using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.ViewModels
{
    public class ProductsFromShoppingCartViewModel
    {
        public ProductsFromShoppingCartViewModel(int quantity, decimal totalPrice, ProductViewModel product)
        {
            Quantity = quantity;
            TotalPrice = totalPrice;
            Product = product;
        }

        public ProductsFromShoppingCartViewModel()
        {
            
        }

        public int Quantity { get; set; }        
        public decimal TotalPrice { get; set; }        
        public ProductViewModel Product { get; set; }            
    }
}