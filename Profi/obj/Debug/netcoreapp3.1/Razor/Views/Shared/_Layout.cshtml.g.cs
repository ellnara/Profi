#pragma checksum "C:\Users\Samedova\source\repos\Profi\Profi\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d8ab4d1dde9a4c52d4946a3b79459df112b4ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Samedova\source\repos\Profi\Profi\Views\_ViewImports.cshtml"
using Profi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samedova\source\repos\Profi\Profi\Views\_ViewImports.cshtml"
using Profi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d8ab4d1dde9a4c52d4946a3b79459df112b4ac", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c7ddce498afc78198088a7415b72bd5cefc7e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-spy", new global::Microsoft.AspNetCore.Html.HtmlString("scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#header-navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-offset", new global::Microsoft.AspNetCore.Html.HtmlString("140"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!doctype html>
<html class=no-js lang=en>
<!-- Mirrored from demo.htmlhunters.com/profi/beauty.html by HTTrack Website Copier/3.x [XR&CO'2014], Fri, 24 Jun 2022 10:28:30 GMT -->
<!-- Added by HTTrack -->
<meta http-equiv=""content-type"" content=""text/html;charset=utf-8"" /><!-- /Added by HTTrack -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d8ab4d1dde9a4c52d4946a3b79459df112b4ac4552", async() => {
                WriteLiteral(@"
    <meta charset=utf-8>
    <meta http-equiv=x-ua-compatible content=""ie=edge"">
    <meta name=viewport content=""width=device-width,initial-scale=1,shrink-to-fit=no"">
    <title>PROFI</title>
    <link rel=stylesheet href=assets/css/vendor.css>
    <link rel=stylesheet href=assets/css/style.css>
    <link rel=stylesheet href=assets/fonts/font-awesome/css/font-awesome.css>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70d8ab4d1dde9a4c52d4946a3b79459df112b4ac5908", async() => {
                WriteLiteral(@"
    <div id=page-start-anchor></div>
    <section class=""header header-fixed-xl"">
        <div class=""header-top-line bg-primary"">
            <div class=container>
                <div class=row>
                    <nav class=""navbar navbar-expand navbar-dark navbar-short justify-content-between w-100"">
                        <ul class=navbar-nav>
                            <li class=""nav-item dropdown dropdown-flat dropdown-flat-primary"">
                                <a class=""nav-link text-white dropdown-toggle"" href=# data-toggle=dropdown>
                                    <span class=text-uppercase>Landings</span>
                                </a>
                                <div class=dropdown-menu>
                                    <a class=dropdown-item href=index.html>Browse all</a> <a class=dropdown-item href=therapist.html>Massage</a> <a class=dropdown-item
                                                                                                               ");
                WriteLiteral(@"                                     href=attorney.html>Lawyer</a> <a class=dropdown-item
                                                                                                                                                                                     href=contractor.html>Contractor</a> <a class=dropdown-item
                                                                                                                                                                                                                            href=beauty.html>Beauty</a> <a class=dropdown-item
                                                                                                                                                                                                                                                           href=restaurant.html>Restaurant</a>
                                </div>
                            </li>
                            <li class=""nav-item dropdown ");
                WriteLiteral(@"dropdown-flat dropdown-flat-primary"">
                                <a class=""nav-link text-white dropdown-toggle"" href=# data-toggle=dropdown>
                                    <span class=text-uppercase>Documentation</span>
                                </a>
                                <div class=dropdown-menu>
                                    <a class=dropdown-item
                                       href=documentation/getting-started/introduction.html>Introduction</a> <a class=dropdown-item href=documentation/getting-started/build-tools.html>
                                        Build
                                        Tools
                                    </a> <a class=dropdown-item
                                            href=documentation/getting-started/customizing.html>Customizing</a> <a class=dropdown-item href=documentation/components/alerts.html>Components</a> <a class=dropdown-item href=documentation/plugins/calendar.html>Plugins</a>
                    ");
                WriteLiteral(@"            </div>
                            </li>
                            <li class=nav-item>
                                <a class=""nav-link text-white"" href=booking.html>
                                    <span class=text-uppercase>Booking form</span>
                                </a>
                            </li>
                        </ul><span class=""navbar-text text-uppercase d-flex align-items-center"">
                            <span class=""text-white-70 mr-1"">Call us today:</span> <span class=""text-white mr-1"">123-456-7890</span> <i class=""material-icons fs-1"">phone</i>
                        </span>
                    </nav>
                </div>
            </div>
        </div>
        <div class=""header-main bg-white"">
            <div class=container>
                <div class=row>
                    <nav class=""navbar navbar-expand-lg navbar-light w-100"" id=header-navbar>
                        <a class=""navbar-brand font-weight-bold"" href=index.htm");
                WriteLiteral(@"l>PROFI</a> <button class=navbar-toggler
                                                                                                   type=button data-toggle=collapse data-target=#navbarSupportedContent
                                                                                                   aria-controls=navbarSupportedContent aria-expanded=false
                                                                                                   aria-label=""Toggle navigation"">
                            <span class=navbar-toggler-icon></span>
                        </button>
                        <div class=""collapse navbar-collapse"" id=navbarSupportedContent>
                            <ul class=""navbar-nav ml-auto"">
                                <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#about>About</a>
                                </li>
                 ");
                WriteLiteral(@"               <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#services>Services</a>
                                </li>
                                <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#testimonials>Testimonials</a>
                                </li>
                                <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#our-work>Our work</a>
                                </li>
                                <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#faq>FAQ</a>
                                </li>
           ");
                WriteLiteral(@"                     <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#vouchers>Vouchers</a>
                                </li>
                                <li class=nav-item>
                                    <a class=""nav-link text-uppercase"" data-toggle=smooth-scroll
                                       href=#contacts>Contacts</a>
                                </li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
        </div>
    </section>
    ");
#nullable restore
#line 109 "C:\Users\Samedova\source\repos\Profi\Profi\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <section class=""footer bg-secondary"">
        <div class=""container py-19 py-sm-23 py-lg-25"">
            <div class=""row align-items-center"">
                <div class=""col-12 col-md-6 col-lg-5 mb-14 mb-md-0"">
                    <div class=""d-flex align-items-center justify-content-center justify-content-md-start"">
                        <a href=index.html class=footer-brand>PROFI</a>
                        <div class=""brand-icons-list ml-10 ml-sm-20"">
                            <a href=#
                               class=""brand-icon brand-icon-circle brand-icon-facebook"">
                                <i class=""fa fa-facebook-f""></i>
                            </a><a href=#
                                   class=""brand-icon brand-icon-circle brand-icon-twitter"">
                                <i class=""fa fa-twitter""></i>
                            </a><a href=# class=""brand-icon brand-icon-circle brand-icon-pinterest"">
                                <i class=""fa fa-pinte");
                WriteLiteral(@"rest-p""></i>
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-lg-2 text-center d-none d-lg-block"">
                    <a href=# class=footer-icon
                       data-toggle=smooth-scroll data-target=#page-start-anchor>
                        <i class=material-icons>arrow_upward</i>
                    </a>
                </div>
                <div class=""col-12 col-md-6 col-lg-5 text-center text-md-right"">
                    <ul class=footer-menu>
                        <li><a href=#>Privacy Policy</a></li>
                        <li><a href=#>Terms & Conditions</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <script async src=""https://www.googletagmanager.com/gtag/js?id=UA-176058743-1""></script>
    <script>
    window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); ");
                WriteLiteral("}\r\n        gtag(\'js\', new Date());\r\n\r\n        gtag(\'config\', \'UA-176058743-1\');</script>\r\n    <script src=assets/js/vendor.js></script>\r\n    <script src=assets/js/polyfills.js></script>\r\n    <script src=assets/js/app.js></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!-- Mirrored from demo.htmlhunters.com/profi/beauty.html by HTTrack Website Copier/3.x [XR&CO\'2014], Fri, 24 Jun 2022 10:28:39 GMT -->\r\n\r\n</html>\r\n\r\n");
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
