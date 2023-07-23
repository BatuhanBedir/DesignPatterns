using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Mediator.MediatorPattern.Handlers;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
{
    private readonly Context _context;

    public GetAllProductQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products.Select(x => new GetAllProductQueryResult
        {
            Id = x.Id,
            Name = x.Name,
            Category = x.Category,
            Price = x.Price,
            Stock = x.Stock,
            StockType = x.StockType,
        }).ToListAsync();
        
    }
}
