using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Services
{
    public class Promotion3For10Service : IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price)
        {
 	        decimal divisao = quantity / 3m;
		 	decimal resto = quantity % 3m;
		 	
	 
		 	decimal finalResult = 0m;

		 	if(divisao > 0){
				finalResult = Math.Floor(divisao) * 10m;
			}

		 	if(resto > 0) {
				decimal restanteValor = resto * price;
				
                finalResult += restanteValor;
			}

		    return finalResult;
        }
    }
}