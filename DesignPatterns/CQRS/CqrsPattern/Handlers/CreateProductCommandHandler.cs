using CQRS.CqrsPattern.Commands;
using CQRS.DAL;

namespace CQRS.CqrsPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Name = createProductCommand.Name,
                Description = createProductCommand.Description,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock,
            });
            _context.SaveChanges();
        }
    }
}
