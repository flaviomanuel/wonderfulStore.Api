using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using WonderfulStore.Core.Entities;
using WonderfulStore.Core.Interfaces;

namespace WonderfulStore.Application.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {

            var product = await _productRepository.GetByIdAsync(request.Id);

            if(product is null) throw new Exception("Produto não encontrado!");

            product.Update(request.Name, request.Price, request.Description, request.PromotionType);

            await _productRepository.UpdateAsync(product);
            return Unit.Value;
        }
    }
}