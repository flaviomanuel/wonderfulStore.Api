using MediatR;

namespace WonderfulStore.Application.Commands.DeleteProductInShoppingCart
{
    public class DeleteProductInShoppingCartCommand : IRequest<Unit>
    {
        public Guid IdProduct { get; set; }
        public Guid IdShoppingCart { get; set; }
    }
}