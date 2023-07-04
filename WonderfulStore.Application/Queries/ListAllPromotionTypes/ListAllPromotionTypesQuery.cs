using MediatR;

namespace WonderfulStore.Application.Queries.ListAllPromotionTypes
{
    public class ListAllPromotionTypesQuery : IRequest<List<KeyValuePair<string, int>>>
    {
        
    }
}