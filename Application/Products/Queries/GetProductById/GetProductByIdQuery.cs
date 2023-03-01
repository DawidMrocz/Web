using Domain.Entities;
using MediatR;

namespace Application.Products.Queries.GetProductById
{
    public sealed record GetProductByIdQuery(Guid ProductId) : IRequest<Product>;
}
