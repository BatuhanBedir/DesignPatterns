using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
{
    public EfCustomerDal(Context context) : base(context)
    {
    }
}
