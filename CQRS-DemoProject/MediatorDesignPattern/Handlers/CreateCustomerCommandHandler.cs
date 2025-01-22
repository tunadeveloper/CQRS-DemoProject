
using CQRS_DemoProject.Context;
using CQRS_DemoProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRS_DemoProject.MediatorDesignPattern.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly CQRSContext _context;

        public CreateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _context.Customers.Add(new Entities.Customer
            {
                CustomerName = request.CustomerName,
                CustomerSurname = request.CustomerSurname,
            });
            await _context.SaveChangesAsync();
        }
    }
}
