using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Czarnikow.Domain.Repository;
using Czarnikow.Api.Mappers;

namespace Czarnikow.Api
{
    public static class Ioc
    {
        public static StandardKernel Kernel { get; private set; }

        public static void RegisterTypes()
        {
            Kernel = new StandardKernel();

            BindDataDependencies();
            BindWebDependencies();
        }

        private static void BindWebDependencies()
        {
            Kernel.Bind<ITradeMapper>().To<TradeMapper>();
        }

        private static void BindDataDependencies()
        {
            Kernel.Bind<ITradeRepository>().To<TradeRepository>();
        }
    }
}



