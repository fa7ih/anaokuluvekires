#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae5a3070c4da2d586852b4a6da2a884c7065c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Testimonial_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Testimonial/Index.cshtml")]
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\_ViewImports.cshtml"
using AnaOkuluVeKres;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\_ViewImports.cshtml"
using AnaOkuluVeKres.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae5a3070c4da2d586852b4a6da2a884c7065c57", @"/Areas/Admin/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PassiveTestimonials", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActiveTestimonials", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Bu düşünürü silmek istediğinizden emin misiniz?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Düşünür Verileri</h1>\n<h6>Durumu True Olan ilk üç düşünür kullanıcıya gözükecektir</h6>\n<hr />\n");
#nullable restore
#line 12 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Kayıtlı Düşünür Bulunmamaktadır.</h4>\n");
#nullable restore
#line 15 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>Adı Soyadı</th>
            <th>Durumu</th>
            <th>Sil</th>
            <th>Aktif Et</th>
            <th>Düzenle/Detaylar</th>
            <th>Kalıcı Sil</th>
        </tr>
");
#nullable restore
#line 28 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n");
#nullable restore
#line 31 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
                  
                    sayac++;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 34 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 35 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
               Write(item.TestimonialNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 36 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
               Write(item.TestimonialImageStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae5a3070c4da2d586852b4a6da2a884c7065c577640", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1005, "\"", 1032, 1);
#nullable restore
#line 39 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1013, item.TestimonialId, 1013, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-outline-danger\">Pasif Yap</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae5a3070c4da2d586852b4a6da2a884c7065c579926", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1331, "\"", 1358, 1);
#nullable restore
#line 45 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1339, item.TestimonialId, 1339, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-outline-success\">Aktif Et</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1531, "\"", 1635, 1);
#nullable restore
#line 49 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 1538, Url.Action("DetailsTestimonial", "Testimonial", new { area = "Admin", id = item.TestimonialId }), 1538, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Düzenle/Detaylar</a></td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae5a3070c4da2d586852b4a6da2a884c7065c5712767", async() => {
                WriteLiteral("\n                        ");
#nullable restore
#line 52 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-outline-danger\">Sil</button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 51 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
AddHtmlAttributeValue("", 1761, Url.Action("Delete", "Testimonial", new { area = "Admin", id = item.TestimonialId }), 1761, 85, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 57 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n    <a href=\"/Admin/Testimonial/Create\" class=\"btn btn-outline-primary\">Düşünür Girişi</a>\n");
#nullable restore
#line 60 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\Testimonial\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
