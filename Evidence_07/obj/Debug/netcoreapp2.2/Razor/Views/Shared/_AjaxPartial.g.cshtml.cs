#pragma checksum "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daef735594d3454eb724a09588227ff76c8d1c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AjaxPartial), @"mvc.1.0.view", @"/Views/Shared/_AjaxPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AjaxPartial.cshtml", typeof(AspNetCore.Views_Shared__AjaxPartial))]
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
#line 2 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\_ViewImports.cshtml"
using Evidence_07.Models;

#line default
#line hidden
#line 3 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\_ViewImports.cshtml"
using Evidence_07.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daef735594d3454eb724a09588227ff76c8d1c63", @"/Views/Shared/_AjaxPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d134951c53d3103cd2a9d84988b6188a83c2507", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AjaxPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml"
 if (ViewBag.Success == true)
{

#line default
#line hidden
            BeginContext(34, 114, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n        <strong>Success!</strong> ");
            EndContext();
            BeginContext(149, 15, false);
#line 4 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml"
                             Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(164, 116, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
            EndContext();
#line 7 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(292, 105, true);
            WriteLiteral("<div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n    <strong>Failed!</strong> ");
            EndContext();
            BeginContext(398, 15, false);
#line 11 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml"
                        Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(413, 108, true);
            WriteLiteral("\r\n    <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n</div>\r\n");
            EndContext();
#line 14 "E:\ESAD-45\Module 07 ASP.NET WEB DESIGN\Evidence_July\Evidence_07\Views\Shared\_AjaxPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591