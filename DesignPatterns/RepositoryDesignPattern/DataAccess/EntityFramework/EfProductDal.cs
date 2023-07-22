using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    private readonly Context _context;
    public EfProductDal(Context context) : base(context)
    {
        _context = context;
    }

    public List<Product> ProductListWithCategory()
    {
        return _context.Products.Include(p => p.Category).ToList();
    }
}
