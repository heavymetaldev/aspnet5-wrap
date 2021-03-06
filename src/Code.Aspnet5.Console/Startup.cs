﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code.Common;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace Code.Aspnet5.Console
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            // Add the platform handler to the request pipeline.
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                var t = SharedDotNetClass.DoSomething();
                var msg = $"Did something. result={t}";
                await context.Response.WriteAsync(msg);
                
            });
        }
    }
}
