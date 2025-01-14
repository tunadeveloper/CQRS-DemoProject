using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.ProductCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class RemoveProductCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
