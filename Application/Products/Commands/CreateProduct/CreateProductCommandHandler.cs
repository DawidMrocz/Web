using Domain.Abstractions;
using Domain.Entities;
using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    internal sealed class CreateProductCommandHandler: IRequestHandler<CreateProductCommand,Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateProductCommand request,CancellationToken cancellationToken)
        {
            var product = new Product(Guid.NewGuid(), request.name, request.price);
            _productRepository.Insert(product);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return product.Id;
        }
    }
}
