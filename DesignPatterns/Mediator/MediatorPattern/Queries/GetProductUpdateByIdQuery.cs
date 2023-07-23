using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Queries;

public class GetProductUpdateByIdQuery : IRequest<UpdateProductByIdQueryResult>
{
    public int Id { get; set; }

    public GetProductUpdateByIdQuery(int id)
    {
        Id = id;
    }
}
