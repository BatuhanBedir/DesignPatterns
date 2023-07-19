namespace CQRS.CqrsPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
