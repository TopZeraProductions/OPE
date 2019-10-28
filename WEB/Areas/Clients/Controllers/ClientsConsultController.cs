using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.Filters;
using WEB.AppInfra.Security.SessionUserConfiguration;
using WEB.AppStart.AppSettingsMappers.Extensions;
using WEB.AppStart.AppSettingsMappers.Unities;
using WEB.Controllers;

namespace WEB.Areas.Clients.Controllers {

    [Area("Clients")]
    public class ClientsConsultController : RestrictController {
        private CookieServices CookiesServices;
        private IConfiguration Configuration;

        private readonly SessionUser         SessionUser;
        private readonly DataBaseSettings    DataBaseSettings;
        private readonly ApiServicesSettings ApiServicesSettings;

        public ClientsConsultController(CookieServices _ICookieServices,
                                         SessionUser    _SessionUser,
                                         IConfiguration _IConfiguration) {

            CookiesServices = _ICookieServices;
            SessionUser     = _SessionUser;
            Configuration   = _IConfiguration;

            DataBaseSettings    = Configuration.GetSectionMapped<DataBaseSettings>();
            ApiServicesSettings = Configuration.GetSectionMapped<ApiServicesSettings>();
        }

        public IActionResult Index() {
            return RedirectToAction("ListClients");
        }

        [HttpGet, ServiceFilter(typeof (LoggedAccess))]
        public IActionResult ListClients() {

            return View();
        }
    }
}