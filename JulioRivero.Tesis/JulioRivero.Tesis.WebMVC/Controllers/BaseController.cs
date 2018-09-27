﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JulioRivero.Tesis.Biz;
using JulioRivero.Tesis.EFContext;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class BaseController : Controller
    {
        protected ImpairmentManager ImpairmentManager = new ImpairmentManager(new ImpairmentDao());
        protected DeficiencyManager deficiencyManager = new DeficiencyManager(new DeficiencyDao());
    }
}