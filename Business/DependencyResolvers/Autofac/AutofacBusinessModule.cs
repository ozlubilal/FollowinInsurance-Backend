using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {          
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance(); 
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<VehicleTypeManager>().As<IVehicleTypeService>().SingleInstance();
            builder.RegisterType<EfVehicleTypeDal>().As<IVehicleTypeDal>().SingleInstance();

            builder.RegisterType<InsuranceTypeManager>().As<IInsuranceTypeService>().SingleInstance();
            builder.RegisterType<EfInsuranceTypeDal>().As<IInsuranceTypeDal>().SingleInstance();

            builder.RegisterType<TrafficInsuranceTypeManager>().As<ITrafficInsuranceTypeService>().SingleInstance();
            builder.RegisterType<EfTrafficInsuranceTypeDal>().As<ITrafficInsuranceTypeDal>().SingleInstance();

            builder.RegisterType<TrafficInsuranceManager>().As<ITrafficInsuranceService>().SingleInstance();
            builder.RegisterType<EfTrafficInsuranceDal>().As<ITrafficInsuranceDal>().SingleInstance();

            builder.RegisterType<HomeInsuranceManager>().As<IHomeInsuranceService>().SingleInstance();
            builder.RegisterType<EfHomeInsuranceDal>().As<IHomeInsuranceDal>().SingleInstance();

            builder.RegisterType<PersonalInsuranceManager>().As<IPersonalInsuranceService>().SingleInstance();
            builder.RegisterType<EfPersonalInsuranceDal>().As<IPersonalInsuranceDal>().SingleInstance();

            builder.RegisterType<InsuranceStateManager>().As<IInsuranceStateService>().SingleInstance();
            builder.RegisterType<EfInsuranceStateDal>().As<IInsuranceStateDal>().SingleInstance();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
