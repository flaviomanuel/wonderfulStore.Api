namespace WonderfulStore.Core.Entities
{
    public class Promotion : IBaseEntity
    {
        public Promotion(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            Products = new List<Product>();
        }

        public Guid Id {get; private set;}
        public string Description { get; private set; }
        public List<Product> Products { get; private set; }

    }
}