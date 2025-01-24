
using CQRS_DemoProject.Context;
using CQRS_DemoProject.MediatorDesignPattern.Queries;
using CQRS_DemoProject.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_DemoProject.MediatorDesignPattern.Handlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, List<GetCustomerQueryResult>>
    {
        private readonly CQRSContext _context;

        public GetCustomerQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetCustomerQueryResult>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _context.Customers.Select(x => new GetCustomerQueryResult
            {
                CustomerID = x.CustomerID,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname,
            }).AsNoTracking().ToListAsync();
        }
    }
}
