using CQRS.CqrsPattern.Commands;
using CQRS.DAL;

namespace CQRS.CqrsPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            value.Name = command.Name;
            value.Description = command.Description;
            value.Price = command.Price;
            value.Status = true;
            value.Stock = command.Stock;

            _context.SaveChanges();
        }
    }
}
