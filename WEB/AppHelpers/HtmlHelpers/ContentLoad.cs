using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WEB.AppHelpers.HtmlHelpers {

    public static class HtmlExtensions {
        public static IHtmlContent ContentLoad(this IHtmlHelper helper, string htmlId, string Url, string htmlCss = "") {
            var html = $"<div id=\"{htmlId}\" class=\"content-load {htmlCss}\" data-url=\"{Url}\"></div>";
                
            return helper.Raw(html);
        }

    }

}