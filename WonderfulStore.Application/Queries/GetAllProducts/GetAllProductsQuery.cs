using MediatR;
using WonderfulStore.Application.ViewModels;
using WonderfulStore.Core.Entities;

namespace WonderfulStore.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<ProductViewModel>>
    {
        
    }
}