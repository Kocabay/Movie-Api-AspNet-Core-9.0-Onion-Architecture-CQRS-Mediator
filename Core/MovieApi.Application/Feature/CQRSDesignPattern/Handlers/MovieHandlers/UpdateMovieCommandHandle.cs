using MovieApi.Application.Feature.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandle
    {
        private readonly MovieContext _context;
        public UpdateMovieCommandHandle(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.CoverImageUrl = command.CoverImageUrl;
            value.CreatedYear = command.CreatedYear;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.Rating = command.Rating;
            value.ReleaseDate = command.ReleaseDate;
            value.Status = command.Status;
            value.Title = command.Title;
            await _context.SaveChangesAsync();
        }
    }

}
