#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b140f84cd01030dc75614dd852bc5c6b378e007"
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b140f84cd01030dc75614dd852bc5c6b378e007", @"/Views/Shared/Components/_HomeTeacher/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__HomeTeacher_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
#line 9 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 mt-md-0 mt-4\">\n                <div class=\"coursecard-single\">\n                    <div class=\"grids5-info position-relative\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b140f84cd01030dc75614dd852bc5c6b378e0075005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 595, "~/UserImages/", 595, 13, true);
#nullable restore
#line 14 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
AddHtmlAttributeValue("", 608, item.ImageUrl, 608, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <div class=\"meta-list\">\n                            <a class=\"sec-2\">");
#nullable restore
#line 16 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
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
#line 25 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                                     Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\n                        <p>");
#nullable restore
#line 26 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
                      Write(item.TeacherBiography);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_HomeTeacher\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
