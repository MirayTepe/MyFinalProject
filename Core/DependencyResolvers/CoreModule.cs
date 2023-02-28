using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Mirosoft;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.IoC;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {

        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();


            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();

            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
