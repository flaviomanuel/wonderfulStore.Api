namespace WonderfulStore.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Guid id, string name, decimal price, string description, Guid? idPromotion)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            IdPromotion = idPromotion;
        }
        public Guid Id {get; private set;}
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public Guid? IdPromotion { get; private set; }
    }
}