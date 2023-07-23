using Mediator.DAL;
using Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.MediatorPattern.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly Context _context;

    public CreateProductCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _context.Products.AddAsync(new Product
        {
            Category = request.Category,
            Name = request.Name,
            Price = request.Price,
            Stock = request.Stock,
            StockType = request.StockType,
        });
        await _context.SaveChangesAsync();
    }
}
