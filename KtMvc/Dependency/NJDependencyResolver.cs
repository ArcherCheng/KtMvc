using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KtMvc.Application.Service;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Service;
using KtMvc.Infrastructure.Context;
using KtMvc.Infrastructure.Repository;
using Ninject;
namespace KtMvc.Dependency
{
    public class NJDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NJDependencyResolver()
        {
            this.kernel =  new StandardKernel();
            //Product
            kernel.Bind<IProductRepository>().To<ProductRepository>();
            kernel.Bind<IProductAService>().To<ProductAService>();
            kernel.Bind<IProductService>().To<ProductService>();
            //Category
            kernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            kernel.Bind<ICategoryAService>().To<CategoryAService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            //Customer
            kernel.Bind<ICustomerRepository>().To<CustomerRepository>();
            kernel.Bind<ICustomerAService>().To<CustomerAService>();
            kernel.Bind<ICustomerService>().To<CustomerService>();

            //Order
            kernel.Bind<IOrderRepository>().To<OrderRepository>();
            kernel.Bind<IOrderAService>().To<OrderAService>();
            kernel.Bind<IOrderService>().To<OrderService>();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}