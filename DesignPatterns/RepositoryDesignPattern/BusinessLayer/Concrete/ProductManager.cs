using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void TDelete(Product t)
    {
        _productDal.Delete(t);
    }

    public Product TGetById(int id)
    {
        return _productDal.GetById(id);
    }

    public List<Product> TGetList()
    {
        return _productDal.GetList();
    }

    public void TInsert(Product t)
    {
        _productDal.Insert(t);
    }

    public List<Product> TProductListWithCategory()
    {
        return _productDal.ProductListWithCategory();
    }

    public void TUpdate(Product t)
    {
        _productDal.Update(t);
    }
}
