using Autofac;
using DomainLayer.Abstract;
using DomainLayer.Service;
using PercistanceLayer.DAL.Abstract;
using PercistanceLayer.DAL.EfCore;
using System;

namespace PercistanceLayer
{
    public class DefaulBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeService>()
                .As<IEmployeeService>()
                .SingleInstance();

            builder.RegisterType<EfEmployeeDal>()
                .As<IEmployeeDal>()
                .SingleInstance();
        }
    }
}
