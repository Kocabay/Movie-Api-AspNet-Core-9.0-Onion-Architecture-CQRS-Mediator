using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.TagResults;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdQuery : IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
