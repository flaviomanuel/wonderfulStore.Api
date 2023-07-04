using WonderfulStore.Application.Services;
using WonderfulStore.Core.Enums;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.AddShoppingCartProduct.FactoryMethod
{
    public class PromotionServiceFactory : IPromotionServiceFactory
    {
        private readonly PromotionTake2Pay1Service _promotionTake2Pay1Service;
        private readonly Promotion3For10Service _promotion3For10Service;
        private readonly PromotionWithoutService _promotionWithoutService;
        public PromotionServiceFactory(
                PromotionTake2Pay1Service promotionTake2Pay1Service, 
                Promotion3For10Service promotion3For10Service, 
                PromotionWithoutService promotionWithoutService)
        {
            _promotionTake2Pay1Service = promotionTake2Pay1Service;
            _promotion3For10Service = promotion3For10Service;
            _promotionWithoutService = promotionWithoutService;
        }

        public IPromotionService GetService(PromotionType? promotionType)
        {
            IPromotionService promotionService;

            switch(promotionType){
                case PromotionType.Take2Pay1:
                    promotionService = _promotionTake2Pay1Service;
                    break;
                case PromotionType.Take3For10:
                    promotionService = _promotion3For10Service;
                    break;
                default:
                    promotionService = _promotionWithoutService;
                    break;
            }

            return promotionService;
        }
    }
}