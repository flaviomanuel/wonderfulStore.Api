using MediatR;
using WonderfulStore.Core.Enums;

namespace WonderfulStore.Application.Commands.AddProduct
{
    public class AddProductCommand :  IRequest<Guid>
    {
        public string Name { get;  set; }
        public decimal Price { get;  set; }
        public string Description { get;  set; }
        public PromotionType? PromotionType { get;  set; }
    }
}