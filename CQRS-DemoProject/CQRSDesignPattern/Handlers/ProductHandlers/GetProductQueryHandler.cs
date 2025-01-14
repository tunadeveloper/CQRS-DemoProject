using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Results.ProductResult;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x=>new GetProductQueryResult
            {
                CategoryID = x.CategoryID,
                ProductName = x.ProductName,
                ProductID = x.ProductID,
                ProductStock = x.ProductStock,
            }).ToList();
            return values;
        }
    }
}
