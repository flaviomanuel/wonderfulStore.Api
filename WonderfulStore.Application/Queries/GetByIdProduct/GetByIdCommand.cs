using MediatR;
using WonderfulStore.Application.ViewModels;

namespace WonderfulStore.Application.Commands.GetByIdProduct
{
    public class GetByIdProductQuery: IRequest<ProductViewModel>
    {
        public Guid Id { get; set; }
    }
}