using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfProcessDal : GenericRepository<Process>, IProcessDal
{
    //Türetilmiş sınıf içerisinden temel sınıfın elemanlarına erişmek için base anahtar sözcüğünü kulanılır.
    public EfProcessDal(Context context) : base(context)
    {
    }
}
