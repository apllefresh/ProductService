using Autofac;
using DataAccess.Contract.Interfaces;
using DataAccess.Repositories;
using DataAccess.EF;
using AutoMapper;
using System.Collections.Generic;
using System;

namespace DataAccess.DI
{
    public class DataAccessAutofacModule : Module
    {
        private readonly string _productConnectionString;

        public DataAccessAutofacModule(string productConnectionString)
        {
            _productConnectionString = productConnectionString
                ?? throw new ArgumentNullException(nameof(productConnectionString));
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DepartmentRepository>()
                .As<IDepartmentRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductGroupRepository>()
                .As<IProductGroupRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>()
                .As<IProductRepository>()
                .InstancePerLifetimeScope();

            builder.Register(context => new DataAccessContext
            (
               connectionString: _productConnectionString
            )).AsSelf()
            .InstancePerLifetimeScope();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
                .As<Profile>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>()
                    .CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}
