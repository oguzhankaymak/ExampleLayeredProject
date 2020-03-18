using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _produtDal;

        public ProductManager(IProductDal productDal)
        {
            _produtDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _produtDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _produtDal.GetList(filter: p => p.CategoryId == categoryId);
        }

        public Product GetById(int productId)
        {
            return _produtDal.Get(p => p.ProductId == productId);
        }
    }
}
