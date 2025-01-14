using CQRS_DemoProject.Context;
using CQRS_DemoProject.CQRSDesignPattern.Commands.CategoryCommands;

namespace CQRS_DemoProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryID);
            values.CategoryName = command.CategoryName;
            _context.SaveChanges();
        }
    }
}
