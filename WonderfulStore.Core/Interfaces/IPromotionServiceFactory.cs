using WonderfulStore.Core.Enums;

namespace WonderfulStore.Core.Interfaces
{
    public interface IPromotionServiceFactory
    {
        IPromotionService GetService(PromotionType? promotionType);
    }
}