using MediatR;

namespace Application.Products.Commands.CreateProduct
{
    public sealed record CreateProductCommand(string name,double price): IRequest<Guid>;
}
