using CQRS_DemoProject.Context;
using CQRS_DemoProject.MediatorDesignPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRS_DemoProject.MediatorDesignPattern.Handlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly CQRSContext _context;
        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Customers.Find(request.CustomerID);
            _context.Customers.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
