using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        private NorthwindContext northwindContext = new NorthwindContext();
        public bool ProductExists(string isExists)
        {
            var result =northwindContext.Set<Product>().Any(p => p.ProductName == isExists);
            return result;
        }
    }
}
