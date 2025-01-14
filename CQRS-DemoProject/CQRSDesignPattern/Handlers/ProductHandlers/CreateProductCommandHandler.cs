using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.ProductCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Entities.Product
            {
                ProductName = command.ProductName,
                ProductStock = command.ProductStock,
                CategoryID = command.CategoryID,
            });
            _context.SaveChanges();
        }
    }
}
