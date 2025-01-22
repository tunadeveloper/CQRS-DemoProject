using CQRS_DemoProject.Context;
using CQRS_DemoProject.MediatorDesignPattern.Commands;
using MediatR;


namespace CQRS_DemoProject.MediatorDesignPattern.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly CQRSContext _context;

        public UpdateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values =_context.Customers.Find(request.CustomerID);
            values.CustomerName = request.CustomerName;
            values.CustomerSurname = request.CustomerSurname;
            await _context.SaveChangesAsync();
        }


    }
}
