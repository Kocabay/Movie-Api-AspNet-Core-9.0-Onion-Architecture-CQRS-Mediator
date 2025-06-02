using MovieApi.Application.Feature.CQRSDesignPattern.Queries.CategoryQueries;
using MovieApi.Application.Feature.CQRSDesignPattern.Result.CategoryResults;
using MovieApi.Persistence.Context;

namespace MovieApi.Application.Feature.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandle
    {
        private readonly MovieContext _context;

        public GetCategoryByIdQueryHandle(MovieContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value = await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
