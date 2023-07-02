using MediatR;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<Product>>
    {
        
    }
}