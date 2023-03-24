using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        NorthwindContext northwindContext = new NorthwindContext();

        public bool CategoryExists(string isExists)
        {
            var result = northwindContext.Set<Category>().Any(c => c.CategoryName == isExists);
            return result;
        }
    }
}
