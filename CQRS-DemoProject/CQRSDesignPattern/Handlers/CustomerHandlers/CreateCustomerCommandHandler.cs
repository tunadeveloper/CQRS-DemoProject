using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CustomerCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class CreateCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(CreateCustomerCommand command)
        {
          
            _context.Customers.Add(new Entities.Customer
            {
                CustomerName = command.CustomerName,
                CustomerSurname = command.CustomerSurname
            });
            _context.SaveChanges();
        }
    }
}
