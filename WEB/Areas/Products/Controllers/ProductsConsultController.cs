﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.Filters;
using WEB.AppInfra.Security.SessionUserConfiguration;
using WEB.AppStart.AppSettingsMappers.Extensions;
using WEB.AppStart.AppSettingsMappers.Unities;
using WEB.Areas.Products.Models.ViewModels;
using WEB.Controllers;

namespace WEB.Areas.Products.Controllers {

    [Area("Products")]
    public class ProductsConsultController : RestrictController {
        private CookieServices CookiesServices;
        private IConfiguration Configuration;

        private readonly SessionUser         SessionUser;
        private readonly DataBaseSettings    DataBaseSettings;
        private readonly ApiServicesSettings ApiServicesSettings;

        public ProductsConsultController(CookieServices _ICookieServices,
                                         SessionUser    _SessionUser,
                                         IConfiguration _IConfiguration) {

            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
            Configuration   = _IConfiguration;

            DataBaseSettings    = Configuration.GetSectionMapped<DataBaseSettings>();
            ApiServicesSettings = Configuration.GetSectionMapped<ApiServicesSettings>();
        }

        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        [HttpGet, ServiceFilter(typeof (LoggedAccess))]
        public IActionResult ListProducts() {

            return View();
        }
    }
}