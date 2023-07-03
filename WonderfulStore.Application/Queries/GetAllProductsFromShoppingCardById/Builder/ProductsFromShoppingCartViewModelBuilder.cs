using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WonderfulStore.Application.ViewModels;

namespace WonderfulStore.Application.Queries.GetAllProductsFromShoppingCardById.Builder
{
    public class ProductsFromShoppingCartViewModelBuilder
    {
        private ProductsFromShoppingCartViewModel _productsFromShoppingCartViewModel;

        public ProductsFromShoppingCartViewModelBuilder()
        {
            
        }

        public ProductsFromShoppingCartViewModelBuilder Start(){
            _productsFromShoppingCartViewModel = new ProductsFromShoppingCartViewModel();
            
            return this;
        }
        public ProductsFromShoppingCartViewModelBuilder WithFundamentalsInfos(int quantity, decimal totalPrice){
            _productsFromShoppingCartViewModel.Quantity = quantity;
            _productsFromShoppingCartViewModel.TotalPrice = totalPrice;

            return this;
        }

        public ProductsFromShoppingCartViewModelBuilder WithProduct(ProductViewModel productViewModel){
            _productsFromShoppingCartViewModel.Product = productViewModel;

            return this;
        }

        public ProductsFromShoppingCartViewModel Build(){
            return _productsFromShoppingCartViewModel;
        }
    }
}