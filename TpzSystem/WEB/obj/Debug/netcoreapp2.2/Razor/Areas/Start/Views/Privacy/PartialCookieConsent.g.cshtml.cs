#pragma checksum "/home/joao/Github/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e2b1fbf84bfd94f251bfe4161ae6a004e50e23d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Start_Views_Privacy_PartialCookieConsent), @"mvc.1.0.view", @"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml", typeof(AspNetCore.Areas_Start_Views_Privacy_PartialCookieConsent))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e2b1fbf84bfd94f251bfe4161ae6a004e50e23d", @"/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml")]
    public class Areas_Start_Views_Privacy_PartialCookieConsent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB.Areas.Start.Models.ViewModels.CookieConsentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/joao/Github/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
  
    var urlConsent = Url.Action("registerCookieConsent", "Privacy", new { area = "Start", option = "yes" });

#line default
#line hidden
            BeginContext(171, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/home/joao/Github/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
 if (!Model.showBanner) {
    return;
}

#line default
#line hidden
            BeginContext(212, 172, true);
            WriteLiteral("\n<div id=\"cookieConsent\" class=\"alert alert-info alert-dismissible fade show\" role=\"alert\">\n    Use this space to summarize your privacy and cookie use policy. \n    \n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 384, "\"", 452, 1);
#line 13 "/home/joao/Github/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
WriteAttributeValue("", 391, Url.Action("PrivacyDetails","Privacy", new {area = "Start"}), 391, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(453, 170, true);
            WriteLiteral(">Leia mais sobre nossas politicas</a>.\n    \n    <button id=\"cookieConsentButton\"\n            type=\"button\"\n            data-dismiss=\"alert\"\n            aria-label=\"Close\"");
            EndContext();
            BeginWriteAttribute("onclick", "\n            onclick = \"", 623, "\"", 683, 3);
            WriteAttributeValue("", 647, "System.assyncRegister(\'", 647, 23, true);
#line 19 "/home/joao/Github/TopZera/OPE/TpzSystem/WEB/Areas/Start/Views/Privacy/PartialCookieConsent.cshtml"
WriteAttributeValue("", 670, urlConsent, 670, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 681, "\')", 681, 2, true);
            EndWriteAttribute();
            BeginContext(684, 79, true);
            WriteLiteral(">\n        \n        <span aria-hidden=\"true\">Accept</span>\n    </button>\n\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB.Areas.Start.Models.ViewModels.CookieConsentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591