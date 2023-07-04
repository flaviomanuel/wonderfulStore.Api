using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class PromotionTake2Pay1Service : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
            var totalPriceWithoutDiscount = quantity * price;

            var isDobro = (quantity % 2) == 0;
			
		    decimal discount = 0;
		 
            if(isDobro){
                discount = totalPriceWithoutDiscount * (50m/100);
            }else {
                discount = totalPriceWithoutDiscount * (33.3m/100);
            }

            decimal totalPriceWithDiscount = totalPriceWithoutDiscount - discount; 
            
            return totalPriceWithDiscount;
        }
    }
}