using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Results.CategoryResults;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
            });
            return values.ToList();
        }
    }
}
