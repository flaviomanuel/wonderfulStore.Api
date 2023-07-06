using WonderfulStore.Core.Interfaces;

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

        public ShoppingCartProduct(int quantity, decimal productPrice, IPromotionService promotionService, Guid idProduct, Guid idShoppingCart)
        {
            Quantity = quantity;
            
            this.SetTotalPriceAccordingToPromotion(productPrice, promotionService);

            IdProduct = idProduct;
            IdShoppingCart = idShoppingCart;
        }

        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Guid IdProduct { get; private set; }
        public Product Product { get; private set; }


        public Guid IdShoppingCart { get; private set; }
        public ShoppingCart ShoppingCart { get; private set; }

        public void UpdateQuantity(int quantity){
            Quantity = quantity;
        }

        public void SetTotalPriceAccordingToPromotion(decimal productPrice, IPromotionService promotionService){
            TotalPrice = this.CalculateTotalPriceAccordingToPromotion(productPrice, promotionService);
        }
        private decimal CalculateTotalPriceAccordingToPromotion(decimal productPrice, IPromotionService promotionService) {
            return promotionService.CalculateTotalForPromotion(Quantity, productPrice);
        }
    }
}