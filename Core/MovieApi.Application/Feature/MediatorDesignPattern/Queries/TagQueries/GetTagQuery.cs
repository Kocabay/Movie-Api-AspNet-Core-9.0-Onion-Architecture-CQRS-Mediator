using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.TagResults;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagQuery : IRequest<List<GetTagQueryResult>>
    {
    }
}
