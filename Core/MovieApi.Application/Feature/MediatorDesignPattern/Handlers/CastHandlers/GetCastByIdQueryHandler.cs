﻿using MediatR;
using MovieApi.Application.Feature.MediatorDesignPattern.Queries.CastQueries;
using MovieApi.Application.Feature.MediatorDesignPattern.Results.CastResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.MediatorDesignPattern.Handlers.CastHandlers
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            return new GetCastByIdQueryResult
            {
                CastId = values.CastId,
                Biography = values.Biography,
                ImageUrl = values.ImageUrl,
                Name = values.Name,
                Overview = values.Overview,
                Surname = values.Surname,
                Title = values.Title
            };
        }
    }
}
