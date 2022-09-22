using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Product t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
