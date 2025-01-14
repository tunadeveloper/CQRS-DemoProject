using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Queries.CategoryQueries;
using CQRS_DemoProject.CQRSDesignPattern.Results.CategoryResults;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query) { 
        var value = _context.Categories.Find(query.CategoryID);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = value.CategoryID,
                CategoryName = value.CategoryName
            };
        }
    }
}
