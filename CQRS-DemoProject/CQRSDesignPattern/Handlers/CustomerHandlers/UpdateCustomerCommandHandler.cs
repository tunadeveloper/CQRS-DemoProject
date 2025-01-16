using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateCustomerCommand command)
        {
            var value = _context.Customers.Find(command.CustomerID);
            value.CustomerName = command.CustomerName;
            value.CustomerSurname = command.CustomerSurname;
            _context.SaveChanges();
        }
    }
}
