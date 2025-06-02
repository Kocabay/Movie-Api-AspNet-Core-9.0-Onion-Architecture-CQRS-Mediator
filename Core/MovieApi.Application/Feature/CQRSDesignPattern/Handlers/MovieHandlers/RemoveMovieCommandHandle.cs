using MovieApi.Application.Feature.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandle
    {
        private readonly MovieContext _context;
        public RemoveMovieCommandHandle(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
