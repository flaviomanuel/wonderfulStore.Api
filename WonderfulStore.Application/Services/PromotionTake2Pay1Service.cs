using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class PromotionTake2Pay1Service : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
            var divisao = quantity/2m;
            var resto = quantity%2m;
            
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