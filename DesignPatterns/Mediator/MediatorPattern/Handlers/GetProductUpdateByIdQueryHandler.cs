using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.MediatorPattern.Handlers;

public class GetProductUpdateByIdQueryHandler : IRequestHandler<GetProductUpdateByIdQuery, UpdateProductByIdQueryResult>
{
    private readonly Context _context;

    public GetProductUpdateByIdQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<UpdateProductByIdQueryResult> Handle(GetProductUpdateByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Products.FindAsync(request.Id, cancellationToken);
        return new UpdateProductByIdQueryResult
        {
            Id = values.Id,
            Name = values.Name,
            Category = values.Category,
            Price = values.Price,
            Stock = values.Stock,
            StockType = values.StockType,
        };
    }
}
