#pragma checksum "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc5017f50deabe7dfc25ed9e667258b631650ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Testimonials_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Testimonials/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\_ViewImports.cshtml"
using Profi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc5017f50deabe7dfc25ed9e667258b631650ae0", @"/Areas/AdminPanel/Views/Testimonials/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d925da7901da914c8c9d3ddfea2af5de7937617", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Testimonials_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Profi.Models.Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OperationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Stars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OperationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stars));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1357, "\"", 1380, 1);
#nullable restore
#line 52 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
WriteAttributeValue("", 1372, item.Id, 1372, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1433, "\"", 1456, 1);
#nullable restore
#line 53 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
WriteAttributeValue("", 1448, item.Id, 1448, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1511, "\"", 1534, 1);
#nullable restore
#line 54 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
WriteAttributeValue("", 1526, item.Id, 1526, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Samedova\source\repos\Profi\Profi\Areas\AdminPanel\Views\Testimonials\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Profi.Models.Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591