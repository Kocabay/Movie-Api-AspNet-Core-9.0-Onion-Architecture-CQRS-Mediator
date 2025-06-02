using MovieApi.Application.Feature.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });
            await _context.SaveChangesAsync();
        }
    }
}
