#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c7ff9a936045aff6b39cd6b0ed5f89213e21a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__HomeTeacher_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_HomeTeacher/Default.cshtml")]
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7ff9a936045aff6b39cd6b0ed5f89213e21a2a", @"/Views/Shared/Components/_HomeTeacher/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c23065a41780938ce83fd8b0cfcc9a92a22ece", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__HomeTeacher_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""w3l-grids-block-5 py-5"">
    <div class=""container py-md-5 py-4"">
        <div class=""title-main text-center mx-auto mb-md-5 mb-4"" style=""max-width:500px;"">
            <h3 class=""title-style"">Eğitmenlerimiz</h3>
        </div>
        <div class=""row justify-content-center"">
");
#nullable restore
#line 9 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 mt-md-0 mt-4\">\r\n                <div class=\"coursecard-single\">\r\n                    <div class=\"grids5-info position-relative\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 602, "\"", 627, 1);
#nullable restore
#line 14 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
WriteAttributeValue("", 608, item.TeacherImgUrl, 608, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 628, "\"", 634, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n                        <div class=\"meta-list\">\r\n                            <a class=\"sec-2\">");
#nullable restore
#line 16 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                                        Write(item.TeacherBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </div>
                    </div>
                    <div class=""content-main-top"">
                        <div class=""content-top mb-4 mt-3"">
                            <ul class=""list-unstyled d-flex align-items-center justify-content-between"">
                                <li> <i class=""fas fa-star""></i> 4.3</li>
                            </ul>
                        </div>
                        <h4><a>");
#nullable restore
#line 25 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                          Write(item.TeacherNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                      Write(item.TeacherBiography);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
