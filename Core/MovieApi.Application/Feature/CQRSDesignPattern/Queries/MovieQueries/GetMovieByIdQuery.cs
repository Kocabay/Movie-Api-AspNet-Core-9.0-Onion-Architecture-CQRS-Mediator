namespace MovieApi.Application.Feature.CQRSDesignPattern.Queries.MovieQueries
{
    public class GetMovieByIdQuery
    {
        public GetMovieByIdQuery(int movieId)
        {
            MovieId = movieId;
        }

        public int MovieId { get; set; }

    }
}
