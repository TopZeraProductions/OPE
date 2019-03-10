using System.Diagnostics;
using System.Extensions;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies.Interface;
using WEB.AppInfra.Security.SessionUser;
using Microsoft.AspNetCore.Http.Features;

using WEB.Areas.Start.Models.ViewModels;

namespace WEB.Areas.Start.Controllers {

    [Area("start")]
    public class PrivacyController : Controller {

        private ICookieServices CookieServices;
        public PrivacyController(ICookieServices _ICookieServices) {
            CookieServices = _ICookieServices;
        }
        
        public IActionResult Index() {
            return RedirectToAction("PrivacyDetails");
        }

        public IActionResult PrivacyDetails() {
            return View();
        }

        public IActionResult PartialCookieConsent() {
            var ViewModel = new CookieConsentVM();
            
            var cookie = CookieServices.ReadCookie(".AspNet.Consent");

            if (cookie.IsEmpty()) {
                ViewModel.showBanner = true;
            } 
            
            return View(ViewModel);
        }
        
        public IActionResult registerCookieConsent(string option) {
            CookieServices.WriteCookie(".AspNet.Consent", option);
            
            return Json(new { message = "Opçao de consentimento de cookies registrada!!" });
        }
    }
}