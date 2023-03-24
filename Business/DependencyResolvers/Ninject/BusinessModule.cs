using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using Business.DependencyResolvers.Ninject;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()  //IoC
        {
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();  //IProductDal isteyene EfProductDal ver.
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); //insgletonscopebir kez üretildiyse bir daha üretme

            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();


        }
    }
}
