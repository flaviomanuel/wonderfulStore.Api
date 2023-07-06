using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class PromotionTake2Pay1Service : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
            decimal trueQuantity = (quantity == 0) ? 1 : quantity;

            var divisao = trueQuantity/2m;
            var resto = trueQuantity%2m;
            
            decimal finalResult = 0m;
            
            if(divisao > 0){
                finalResult = Math.Floor(divisao) * price;
            }
            if(resto > 0) {
                finalResult += price;
            }

            return  finalResult;
        }
    }
}