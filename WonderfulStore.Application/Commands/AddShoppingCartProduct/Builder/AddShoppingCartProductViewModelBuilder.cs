using WonderfulStore.Application.ViewModels;

namespace WonderfulStore.Application.Commands.AddShoppingCartProduct.Builder
{
    public class AddShoppingCartProductViewModelBuilder
    {
        private AddShoppingCartProductViewModel _addShoppingCartProductViewModel;

        public AddShoppingCartProductViewModelBuilder()
        {
        
        }   

        public AddShoppingCartProductViewModelBuilder Start() {
            _addShoppingCartProductViewModel = new AddShoppingCartProductViewModel();
            return this;
        }

        public AddShoppingCartProductViewModelBuilder WithFundamentalInfos(int quantity) {
            _addShoppingCartProductViewModel.Quantity = quantity;

            return this;
        }

        public AddShoppingCartProductViewModelBuilder WithProductViewModel(ProductViewModel productViewModel) {
                _addShoppingCartProductViewModel.Product = productViewModel;

                return this;
        }
        public AddShoppingCartProductViewModelBuilder WithShoppingCartViewModel(ShoppingCartViewModel shoppingCartViewModel) {
            _addShoppingCartProductViewModel.ShoppingCart = shoppingCartViewModel;

            return this;
        }

        public AddShoppingCartProductViewModel Build() {
            return _addShoppingCartProductViewModel;
        }


    }
}