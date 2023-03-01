using Domain.Entities;
using MediatR;
using Dapper;
using System.Data;

namespace Application.Products.Queries.GetProductById
{
    internal sealed class GetProductQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IDbConnection _dbConnection;

        public GetProductQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<Product> Handle(
            GetProductByIdQuery request,
            CancellationToken cancellationToken
            )
        {
            const string sql = @"SELECT * FROM PRODUCTS WHERE Id = @ProductId";

            var product = await _dbConnection.QueryFirstOrDefaultAsync<Product>(
                sql, new { request.ProductId });

            if(product is null)
            {
                throw new Exception( sql );
            }

            return product;
        }
    }
}
