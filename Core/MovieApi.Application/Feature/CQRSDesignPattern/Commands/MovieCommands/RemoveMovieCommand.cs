namespace MovieApi.Application.Feature.CQRSDesignPattern.Commands.MovieCommands
{
    public class RemoveMovieCommand
    {
        public RemoveMovieCommand(int movieId)
        {
            MovieId = movieId;
        }

        public int MovieId { get; set; }

    }
}
