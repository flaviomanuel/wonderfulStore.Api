namespace WonderfulStore.Core.Entities
{
    public class Product : IBaseEntity
    {
        public Product(string name, float price, string description, Guid? idPromotion)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;
            
            IdPromotion = idPromotion;
        }

        public Guid Id {get; private set;}
        public string Name { get; private set; }
        public float Price { get; private set; }
        public string Description { get; private set; }
        public Guid? IdPromotion { get; private set; }
        public Promotion? Promotion { get; private set; }
    }
}