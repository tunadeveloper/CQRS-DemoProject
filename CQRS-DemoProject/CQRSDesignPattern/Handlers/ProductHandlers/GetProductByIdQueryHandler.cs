using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Queries.ProductQueries;
using CQRS_DemoProject.CQRSDesignPattern.Results.CategoryResults;
using CQRS_DemoProject.CQRSDesignPattern.Results.ProductResult;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductID);
            return new GetProductByIdQueryResult
            {
                ProductID = value.ProductID,
                ProductStock = value.ProductStock,
                ProductName = value.ProductName,
                CategoryID = value.CategoryID
            };
        }
    }
}
