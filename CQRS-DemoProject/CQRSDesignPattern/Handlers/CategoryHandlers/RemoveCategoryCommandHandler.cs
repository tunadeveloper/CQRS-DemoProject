using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CategoryCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(RemoveCategoryCommand command)
        {
            var value = _context.Categories.Find(command.CategoryID);
            _context.Categories.Remove(value);
            _context.SaveChanges();
        }
    }
}
