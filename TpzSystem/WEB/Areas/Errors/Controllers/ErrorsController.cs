using System.Diagnostics;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WEB.Areas.Errors.Models;

namespace WEB.Areas.Errors.Controllers {

    [Area("errors")]
    public class ErrorController : Controller {
        
        public IActionResult Error() { // start/Home/Error
            var viewModel = new ErrorViewModel();
            viewModel.RequestId     = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            viewModel.ShowRequestId = !string.IsNullOrEmpty(viewModel.RequestId);

            return View(viewModel);
        }

        [AllowAnonymous]
        public IActionResult ErrorCode(string errorCode) { // errors/error/errorcode/id
            var viewModel = new ErrorViewModel();
            viewModel.RequestId     = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            viewModel.ShowRequestId = !string.IsNullOrEmpty(viewModel.RequestId);
            viewModel.errorCode = errorCode.ToString();
            viewModel.observations = "An error was ocurring the code is: " + errorCode;
                
            return View(viewModel);
        }
    }

}