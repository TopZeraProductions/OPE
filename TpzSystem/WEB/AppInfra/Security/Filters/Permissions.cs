using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

using WEB.AppInfra.Security.SessionUserConfiguration;

namespace WEB.AppInfra.Security.Filters {

    public class LoggedFilter : IActionFilter {

        private readonly SessionUser SessionUser ;

        public LoggedFilter(SessionUser     _SessionUser) {
            
            SessionUser     = _SessionUser;
        }

        public void OnActionExecuting(ActionExecutingContext context) {
            /*
            if (SessionUser.id == 0) {
                if (string.IsNullOrEmpty(s)) {
                    SessionServices.Write("logging", "true");
                    RedirectToAuthScreen(context);
                }
            }*/
        }

        private void RedirectToAuthScreen(ActionExecutingContext context) {
            context.Result = new RedirectToRouteResult(
                new RouteValueDictionary {
                    {"area", "Start"},
                    {"controller", "Authentication"},
                    {"action", "login"}
                }
            );
        }

        public void OnActionExecuted(ActionExecutedContext context) {}
    }
    
    public class LoggedAccess : ActionFilterAttribute {

        private readonly SessionUser SessionUser;

        public LoggedAccess(SessionUser _SessionUser) {
            
            SessionUser = _SessionUser;
        }
        
        public override void OnActionExecuting(ActionExecutingContext context) {
            if (!SessionUser.IsLogged()) {
                RedirectToAuthScreen(context);
            }
            
            base.OnActionExecuting(context);
        }
        
        public override void OnResultExecuting(ResultExecutingContext context) {
            
            base.OnResultExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context) {
            
            base.OnResultExecuted(context);
        }

        private void RedirectToAuthScreen(ActionExecutingContext context) {
            context.Result = new RedirectToRouteResult(
               new RouteValueDictionary {
                   {"area", "Start"},
                   {"controller", "Authentication"},
                   {"action", "login"}
               }
            );
        }
    }
}