#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21f21a94bf1f5c81a792b8453a6d09b6dc96d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Information_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Information/Default.cshtml")]
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using AnaOkuluVeKres;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using AnaOkuluVeKres.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21f21a94bf1f5c81a792b8453a6d09b6dc96d14", @"/Views/Shared/Components/_Information/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Information_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-5 ps-lg-5 mt-md-0 mt-5"">
    <div class=""contact-left"">
        <div class=""cont-details"">
            <div class=""d-flex contact-grid"">
                <div class=""cont-left text-center me-3"">
                    <i class=""fas fa-building""></i>
                </div>
                <div class=""cont-right"">
                    <h6>Okul Adresi</h6>
                    <p>");
#nullable restore
#line 10 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml"
                  Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""d-flex contact-grid mt-4 pt-lg-2"">
                <div class=""cont-left text-center me-3"">
                    <i class=""fas fa-phone-alt""></i>
                </div>
                <div class=""cont-right"">
                    <h6>
                        Bizi Arayın
                    </h6>
                    <p><a");
            BeginWriteAttribute("href", " href=\"", 796, "\"", 818, 2);
            WriteAttributeValue("", 803, "tel:", 803, 4, true);
#nullable restore
#line 21 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml"
WriteAttributeValue("", 807, ViewBag.v2, 807, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml"
                                            Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                </div>
            </div>
            <div class=""d-flex contact-grid mt-4 pt-lg-2"">
                <div class=""cont-left text-center me-3"">
                    <i class=""fas fa-envelope-open-text""></i>
                </div>
                <div class=""cont-right"">
                    <h6>Bize e-posta gönderin</h6>
                    <p><a");
            BeginWriteAttribute("href", " href=\"", 1200, "\"", 1225, 2);
            WriteAttributeValue("", 1207, "mailto:", 1207, 7, true);
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml"
WriteAttributeValue("", 1214, ViewBag.v3, 1214, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mail\">");
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Information\Default.cshtml"
                                                            Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
