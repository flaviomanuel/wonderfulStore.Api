using MediatR;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Commands.GetByIdProduct
{
    public class GetByIdProductQuery: IRequest<Product>
    {
        public Guid Id { get; set; }
    }
}