#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7964ef6ab5fa59abda5442596d57015e6b1829b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactInfo/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7964ef6ab5fa59abda5442596d57015e6b1829b0", @"/Views/Shared/Components/ContactInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ContactInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-lg-4 col-md-6 footer-list-29\">\n    <h6 class=\"footer-title-29\">İletişim Bilgilerimiz </h6>\n    <p class=\"mb-2 pe-xl-5\">\n        Adresimiz : ");
#nullable restore
#line 4 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml"
               Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n    <p class=\"mb-2\">Telefon Numaramız : <a");
            BeginWriteAttribute("href", " href=\"", 219, "\"", 241, 2);
            WriteAttributeValue("", 226, "tel:", 226, 4, true);
#nullable restore
#line 6 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml"
WriteAttributeValue("", 230, ViewBag.v2, 230, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml"
                                                             Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n    <p class=\"mb-2\">Emailimiz : <a");
            BeginWriteAttribute("href", " href=\"", 297, "\"", 322, 2);
            WriteAttributeValue("", 304, "mailto:", 304, 7, true);
#nullable restore
#line 7 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml"
WriteAttributeValue("", 311, ViewBag.v3, 311, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 7 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\ContactInfo\Default.cshtml"
                                                        Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\n</div>\n");
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