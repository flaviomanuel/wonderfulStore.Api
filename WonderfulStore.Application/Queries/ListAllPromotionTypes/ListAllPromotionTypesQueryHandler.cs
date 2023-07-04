using MediatR;
using WonderfulStore.Core.Enums;

namespace WonderfulStore.Application.Queries.ListAllPromotionTypes
{
    public class ListAllPromotionTypesQueryHandler : IRequestHandler<ListAllPromotionTypesQuery, List<KeyValuePair<string, int>>>
    {
        public Task<List<KeyValuePair<string, int>>> Handle(ListAllPromotionTypesQuery request, CancellationToken cancellationToken)
        {
            var dic1= new Dictionary<string, int>();

           var promotionTypes =  Enum.GetValues(typeof(PromotionType));

            foreach (int promotion in promotionTypes)
            {
                dic1.Add(Enum.GetName(typeof(PromotionType), promotion), promotion);
            }

            return Task.FromResult(dic1.ToList());
        }
    }
}