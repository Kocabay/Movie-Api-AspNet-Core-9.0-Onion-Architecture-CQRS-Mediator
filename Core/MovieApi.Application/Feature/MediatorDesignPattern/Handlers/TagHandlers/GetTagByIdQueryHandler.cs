using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Queries.TagQueries;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.TagResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetTagByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);
            return new GetTagByIdQueryResult
            {
                Title = values.Title,
            };
        }
    }
}
