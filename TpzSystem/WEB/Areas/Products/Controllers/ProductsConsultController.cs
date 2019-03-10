using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Security.SessionUser;
using WEB.AppStart.AppSettingsMappers.Extensions;
using WEB.AppStart.AppSettingsMappers.Unities;
using WEB.Areas.Products.Models.ViewModels;

namespace WEB.Areas.Products.Controllers {

    [Area("Products")]
    public class ProductsConsultController : Controller {
        private ICookieServices CookiesServices;
        private IConfiguration Configuration;
        
        private SessionUser SessionUser;
        private DataBaseSettings DataBaseSettings;
        private ApiServicesSettings ApiServicesSettings;

        public ProductsConsultController(ICookieServices _ICookieServices, 
                                         SessionUser     _SessionUser, 
                                         IConfiguration  _IConfiguration) {
            
            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
            Configuration   = _IConfiguration;
            
            
            DataBaseSettings    = Configuration.GetSectionMapped<DataBaseSettings>("DataBaseSettings");
            ApiServicesSettings = Configuration.GetSectionMapped<ApiServicesSettings>("ApiServicesSettings");
        }
        
        public IActionResult Index() {
            return RedirectToAction("ListProducts");
        }

        public IActionResult ListProducts() {

            ListProductsVM ViewModel = new ListProductsVM();
                
            SessionUser.id = 10;
            ViewBag.teste  = SessionUser.id;
            SessionUser.idCrypt = "10";
            ViewBag.teste2  = SessionUser.idCrypt;
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