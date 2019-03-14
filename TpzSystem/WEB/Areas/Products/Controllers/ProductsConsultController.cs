using System;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        
        private static SessionUser SessionUser;
        private DataBaseSettings DataBaseSettings;
        private ApiServicesSettings ApiServicesSettings;

        public ProductsConsultController(CookieServices  _ICookieServices, 
                                         SessionUser     _SessionUser, 
                                         IConfiguration  _IConfiguration) {
            
            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
            Configuration   = _IConfiguration;
            
            DataBaseSettings    = Configuration.GetSectionMapped<DataBaseSettings>();
            ApiServicesSettings = Configuration.GetSectionMapped<ApiServicesSettings>();
        }
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }
        
        [ServiceFilter(typeof(LoggedAccess))]
        public IActionResult ListProducts() {

            ListProductsVM ViewModel = new ListProductsVM();
                
            SessionUser.id = 10;
            ViewBag.teste  = SessionUser.id;
            
            SessionUser.name = "joao";
            ViewBag.teste3 = SessionUser.name;
            SessionUser.nameCrypt = "joao";
            ViewBag.teste4        = SessionUser.nameCrypt;

            ViewModel.DataBaseSettings    = DataBaseSettings;
            ViewModel.ApiServicesSettings = ApiServicesSettings;

            return View(ViewModel);
        }
    }
}