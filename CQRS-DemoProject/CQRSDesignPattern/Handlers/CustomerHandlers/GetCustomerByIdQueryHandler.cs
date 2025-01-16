using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Queries.CustomerQueries;
using CQRS_DemoProject.CQRSDesignPattern.Results.CustomerResults;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class GetCustomerByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCustomerByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetCustomerByIdQueryResult Handle(GetCustomerByIdQuery query)
        {
            var value = _context.Customers.Find(query.CustomerID);
            return new GetCustomerByIdQueryResult
            {
                CustomerID = value.CustomerID,
                CustomerName = value.CustomerName,
                CustomerSurname = value.CustomerSurname
            };
            
        }
    }
}
