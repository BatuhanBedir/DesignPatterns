using CQRS.CqrsPattern.Queries;
using CQRS.CqrsPattern.Results;
using CQRS.DAL;

namespace CQRS.CqrsPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Description = value.Description,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                Id = query.Id,
            };
        }
    }
}
