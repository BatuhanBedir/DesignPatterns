using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Queries;

public class GetProductByIdQuery:IRequest<GetProductByIdQueryResult>
{
    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}
