using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class RemoveCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(RemoveCustomerCommand command)
        {
            var value = _context.Customers.Find(command.CustomerID);
            _context.Customers.Remove(value);
            _context.SaveChanges();
        }
    }
}
