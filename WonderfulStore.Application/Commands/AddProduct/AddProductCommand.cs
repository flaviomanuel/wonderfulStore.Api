using MediatR;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Commands.AddProduct
{
    public class AddProductCommand :  IRequest<Product>
    {
        public string Name { get;  set; }
        public float Price { get;  set; }
        public string Description { get;  set; }
        public Guid IdPromotion { get;  set; }
    }
}