using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.MediatorPattern.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
{
    private readonly Context _context;

    public GetProductByIdQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _context.Products.FindAsync(request.Id, cancellationToken);
        return new GetProductByIdQueryResult
        {
            Id = value.Id,
            Name = value.Name,
            Stock = value.Stock,
        };
    }
}
