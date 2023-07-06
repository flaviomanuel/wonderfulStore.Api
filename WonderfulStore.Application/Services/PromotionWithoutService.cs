using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class PromotionWithoutService : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
            decimal trueQuantity = (quantity == 0) ? 1 : quantity;
            
           decimal totalPrice = trueQuantity * price;
           
           return totalPrice;
        }
    }
}