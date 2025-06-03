using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.CastResults;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastByIdQuery : IRequest<GetCastByIdQueryResult>
    {
        public int CastId { get; set; }

        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }
    }
}
