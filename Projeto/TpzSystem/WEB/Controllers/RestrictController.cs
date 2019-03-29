using Microsoft.AspNetCore.Mvc;

using WEB.AppInfra.Security.Filters;

namespace WEB.Controllers {

    [ServiceFilter(typeof (LoggedAccess))]
    public class RestrictController : Controller { }

}