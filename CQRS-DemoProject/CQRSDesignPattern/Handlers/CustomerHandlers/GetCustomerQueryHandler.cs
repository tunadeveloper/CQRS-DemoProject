using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Results.CustomerResults;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class GetCustomerQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCustomerQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetCustomerQueryResult> Handle()
        {
            var values = _context.Customers.Select(x => new GetCustomerQueryResult
            {
                CustomerID = x.CustomerID,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname
            }).ToList();
            return values;
        }
    }
}
