using System.Extensions;

using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Cookies.Service;
using WEB.AppInfra.Security.Filters;
using WEB.Areas.Start.Models.ViewModels;
using WEB.Controllers;

namespace WEB.Areas.Start.Controllers {

    [Area("start")]
    public class PrivacyController : RestrictController {

        private CookieServices CookieServices;
        public PrivacyController(CookieServices _ICookieServices) {
            
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
            
            var cookie = CookieServices.Read("Consent");

            if (cookie.IsEmpty()) {
                ViewModel.showBanner = true;
            } 
            
            return View(ViewModel);
        }
        
        public IActionResult registerCookieConsent(string option) {
            CookieServices.Write("Consent", option);
            
            return Json(new { message = "Opçao de consentimento de cookies registrada!!" });
        }
    }
}