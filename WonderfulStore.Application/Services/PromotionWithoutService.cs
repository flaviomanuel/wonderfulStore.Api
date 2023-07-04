using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class PromotionWithoutService : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
           decimal totalPrice = quantity * price;
           
           return totalPrice;
        }
    }
}