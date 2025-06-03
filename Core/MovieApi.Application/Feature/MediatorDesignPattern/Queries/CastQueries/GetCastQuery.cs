using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.CastResults;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastQuery:IRequest<List<GetCastQueryResult>>
    {

    }
}
