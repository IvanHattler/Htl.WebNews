using Htl.Data;
using Htl.Services.Services;
using Htl.WebNews.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Htl.WebNews
{
    public class BaseControllerActivator : IControllerActivator
    {
        private readonly string _connectionString;
        public BaseControllerActivator(string connectionString)
        {
            _connectionString = connectionString
                ?? throw new ArgumentNullException(nameof(connectionString));
        }
        public object Create(ControllerContext context)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddFilter("Microsoft", LogLevel.Warning)
                       .AddFilter("System", LogLevel.Warning)
                       .AddFilter("Htl.WebNews.Program", LogLevel.Debug)
                       .AddConsole();
            });

            var type = context.ActionDescriptor.ControllerTypeInfo.AsType();
            if (type == typeof(HomeController))
            {
                return CreateHomeController(loggerFactory);
            }
            else
            {
                throw new Exception("Unknown controller.");
            }
        }

        private object CreateHomeController(ILoggerFactory loggerFactory)
        {
            return new HomeController(
                                loggerFactory.CreateLogger<HomeController>(),
                                new UpdateService(
                                    new SqlUpdateRepository(
                                        new UpdateContext(
                                            _connectionString))));
        }

        public void Release(ControllerContext context, object controller)
        {

        }
    }
}
