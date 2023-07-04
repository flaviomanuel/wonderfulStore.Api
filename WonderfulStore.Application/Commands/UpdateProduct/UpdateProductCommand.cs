using MediatR;
using WonderfulStore.Core.Enums;

namespace WonderfulStore.Application.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public UpdateProductCommand(Guid id, string name, decimal price, string description, PromotionType? promotionType)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            PromotionType = promotionType;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public PromotionType? PromotionType { get; private set; }
    }
}