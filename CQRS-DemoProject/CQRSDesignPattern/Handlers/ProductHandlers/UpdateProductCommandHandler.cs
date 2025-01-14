using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.ProductCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductName = command.ProductName;
            values.ProductStock = command.ProductStock;
            values.CategoryID = command.CategoryID;
            _context.SaveChanges();
        }
    }
}
