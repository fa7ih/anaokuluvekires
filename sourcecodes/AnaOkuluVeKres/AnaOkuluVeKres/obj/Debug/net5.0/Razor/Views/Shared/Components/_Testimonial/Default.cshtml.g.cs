#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee9d1f9a8165b17ef2425fa7d06792cf4f4c4f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using AnaOkuluVeKres;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using AnaOkuluVeKres.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee9d1f9a8165b17ef2425fa7d06792cf4f4c4f3", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c23065a41780938ce83fd8b0cfcc9a92a22ece", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""w3l-blog-block-5 py-5"" id=""blog"">
    <div class=""container py-md-5 py-4"">
        <div class=""title-main text-center mx-auto mb-md-5 mb-4"" style=""max-width:500px;"">
            <p class=""text-uppercase"">Düşünürlerİn</p>
            <h3 class=""title-style"">Çocuk Gelişimi <span>Hakkında</span> Düşünceleri</h3>
        </div>
        <div class=""row justify-content-center"">
");
#nullable restore
#line 9 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml"
             foreach (var item in Model.Take(3))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 mt-md-0 mt-4\">\r\n                    <div class=\"blog-card-single\">\r\n                        <div class=\"grids5-info\">\r\n                            <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 694, "\"", 725, 1);
#nullable restore
#line 14 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 700, item.TestimonialImageUrl, 700, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 726, "\"", 732, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                            <div class=\"blog-info\">\r\n                                <h4><a href=\"#\">");
#nullable restore
#line 16 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml"
                                           Write(item.TestimonialNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 18 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml"
                               Write(item.TestimonialDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_Testimonial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591