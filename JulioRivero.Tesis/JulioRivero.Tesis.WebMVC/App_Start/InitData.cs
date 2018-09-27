using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JulioRivero.Tesis.EFContext;
using System.Data.Entity;

namespace JulioRivero.Tesis.WebMVC.App_Start
{
    public class InitData: CreateDatabaseIfNotExists<TesisContext>
    {
        protected override void Seed(TesisContext context)
        {
            base.Seed(context);
        }
    }
}