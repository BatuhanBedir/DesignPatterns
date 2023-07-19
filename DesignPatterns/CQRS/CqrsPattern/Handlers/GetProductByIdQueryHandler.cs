using CQRS.CqrsPattern.Queries;
using CQRS.CqrsPattern.Results;
using CQRS.DAL;

namespace CQRS.CqrsPattern.Handlers;

public class GetProductByIdQueryHandler
{
    private readonly Context _context;

    public GetProductByIdQueryHandler(Context context)
    {
        _context = context;
    }
    public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
    {
        var values = _context.Products.Find(query.Id);
        return new GetProductByIdQueryResult
        {
            Id = values.Id,
            Name = values.Name,
            Price = values.Price,
            Stock = values.Stock,
        };
    }
}
