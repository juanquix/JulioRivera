using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using JulioRivero.Tesis.Entities;
using JulioRivero.Tesis.WebMVC.App_Start;
using JulioRivero.Tesis.WebMVC.Models;

namespace JulioRivero.Tesis.WebMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            System.Data.Entity.Database.SetInitializer(new InitData());
            Configure();
        }
        private void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Impairment, ImpairmentViewModel>().ReverseMap();
                cfg.CreateMap<Deficiency, DeficiencyViewModel>().ReverseMap();
            });
            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Deficiency, DeficiencyViewModel>().ReverseMap();
            //});
        }
       
    }
}
