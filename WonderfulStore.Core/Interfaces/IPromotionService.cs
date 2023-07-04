namespace WonderfulStore.Core.Interfaces
{
    public interface IPromotionService
    {
        public decimal CalculateTotalForPromotion(int quantity, decimal price);
    }
}