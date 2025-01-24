
using CQRS_DemoProject.Context;
using CQRS_DemoProject.MediatorDesignPattern.Queries;
using CQRS_DemoProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetCustomerByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Customers.FindAsync(request.CustomerID);
            return new GetCustomerByIdQueryResult
            {
                CustomerName = values.CustomerName,
                CustomerSurname = values.CustomerSurname,
            };
        }
    }
}
