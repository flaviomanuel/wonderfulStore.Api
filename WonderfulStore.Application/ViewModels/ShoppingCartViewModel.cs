using WonderfulStore.Core.Enums;

namespace WonderfulStore.Application.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel(Guid id, ShoppingCartStatus status)
        {
            Id = id;
            Status = status;
        }

        public Guid Id { get; private set; }
        public ShoppingCartStatus Status { get; private set; }
    }
}