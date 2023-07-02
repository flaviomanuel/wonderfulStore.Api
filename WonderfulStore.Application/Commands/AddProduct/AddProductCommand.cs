using MediatR;

namespace WonderfulStore.Application.Commands.AddProduct
{
    public class AddProductCommand :  IRequest<Guid>
    {
        public string Name { get;  set; }
        public float Price { get;  set; }
        public string Description { get;  set; }
        public Guid? IdPromotion { get;  set; }
    }
}