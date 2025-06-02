using MovieApi.Application.Feature.CQRSDesignPattern.Queries.MovieQueries;
using MovieApi.Application.Feature.CQRSDesignPattern.Result.MovieResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieByIdQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetMovieByIdQueryResult> Handle(GetMovieByIdQuery query)
        {
            var value = await _context.Movies.FindAsync(query.MovieId);
            return new GetMovieByIdQueryResult
            {
                MovieId = value.MovieId,
                Rating = value.Rating,
                Title = value.Title,
                Description = value.Description,
                ReleaseDate = value.ReleaseDate,
                Duration = value.Duration,
                CreatedYear = value.CreatedYear,
                CoverImageUrl = value.CoverImageUrl,
                Status = value.Status,
            };
        }
    }
}
