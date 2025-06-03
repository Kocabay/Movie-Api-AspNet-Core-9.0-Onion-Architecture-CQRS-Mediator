using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Feature.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastQueryHandler : IRequestHandler<GetCastQuery, List<GetCastQueryResult>>
    {
        private readonly MovieContext _context;

        public GetCastQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCastQueryResult>> Handle(GetCastQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.ToListAsync();
            return values.Select(x => new GetCastQueryResult
            {
                Biography = x.Biography,
                CastId = x.CastId,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Overview = x.Overview,
                Surname = x.Surname,
                Title = x.Title
            }).ToList();
        }
    }
}
