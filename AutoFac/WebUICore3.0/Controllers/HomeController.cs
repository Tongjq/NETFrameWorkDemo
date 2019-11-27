using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service;
using WebUICore3._0.Models;

namespace WebUICore3._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ContainerBuilder builder = new ContainerBuilder();
            //builder.RegisterType<UserInfoService>().As<IUserInfoService>();
            //builder.RegisterType<UserInfoService>().AsImplementedInterfaces();
            Assembly assembly = Assembly.Load("Service");
            Assembly assembly1 = Assembly.Load("Service1");
            builder.RegisterAssemblyTypes(assembly, assembly1).AsImplementedInterfaces()
                .PropertiesAutowired().SingleInstance();

            IContainer container = builder.Build();
            //IUserInfoService userInfoService = container.Resolve<IUserInfoService>();
            //IProductService proService = container.Resolve<IProductService>();





            IEnumerable<IUserInfoService> userInfoServices = container.Resolve<IEnumerable<IUserInfoService>>();

            foreach (IUserInfoService uerInfoService in userInfoServices)
            {
                uerInfoService.AddNew("zhangsan","234");
            }

            //bool isLogin = userInfoService.Login("admin", "123");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
