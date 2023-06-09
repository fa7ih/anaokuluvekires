#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f67c103700906e9dd23117bb20d0a38b2132fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Parents_Views_StudentNotesStatus_Index), @"mvc.1.0.view", @"/Areas/Parents/Views/StudentNotesStatus/Index.cshtml")]
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
#line 1 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\_ViewImports.cshtml"
using AnaOkuluVeKres;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\_ViewImports.cshtml"
using AnaOkuluVeKres.Areas.Parents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f67c103700906e9dd23117bb20d0a38b2132fc", @"/Areas/Parents/Views/StudentNotesStatus/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea090dfc8036a8a400ea4e3605cc00f96532411", @"/Areas/Parents/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Parents_Views_StudentNotesStatus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AnaOkuluVeKres.Areas.Teachers.Models.StudentStatusViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ParentsLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Öğrencinin Durum Bilgisi</h1>
<hr />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>Öğrenci Adı Soyadı</th>
            <th>Öğrenci Numarası</th>
            <th>Sağlık Durumu</th>
            <th>Sınıf İçi Durumu</th>
            <th>Öğretmenin Notu</th>
            <th>Detayları</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
         foreach (var student in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                Write(Model.IndexOf(student) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
               Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
               Write(student.StudentNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 29 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                     if (!string.IsNullOrEmpty(student.StudentStatusHealth))
                    {
                        if (student.StudentStatusHealth.Length > 50)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"truncated-text\">");
#nullable restore
#line 33 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                    Write(student.StudentStatusHealth.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n                            <span class=\"full-text\" style=\"display: none;\">");
#nullable restore
#line 34 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                                      Write(student.StudentStatusHealth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 35 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                       Write(student.StudentStatusHealth);

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                        
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Sağlık durumu mevcut değil.</span>\r\n");
#nullable restore
#line 44 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 47 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                     if (!string.IsNullOrEmpty(student.StudentStatusInClassSituation))
                    {
                        if (student.StudentStatusInClassSituation.Length > 50)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"truncated-text\">");
#nullable restore
#line 51 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                    Write(student.StudentStatusInClassSituation.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n                            <span class=\"full-text\" style=\"display: none;\">");
#nullable restore
#line 52 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                                      Write(student.StudentStatusInClassSituation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 53 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                       Write(student.StudentStatusInClassSituation);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                                  
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Sınıf içi durumu mevcut değil.</span>\r\n");
#nullable restore
#line 62 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 65 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                     if (!string.IsNullOrEmpty(student.StudentStatusTeachNotes))
                    {
                        if (student.StudentStatusTeachNotes.Length > 50)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"truncated-text\">");
#nullable restore
#line 69 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                    Write(student.StudentStatusTeachNotes.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</span>\r\n                            <span class=\"full-text\" style=\"display: none;\">");
#nullable restore
#line 70 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                                      Write(student.StudentStatusTeachNotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 71 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                       Write(student.StudentStatusTeachNotes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                                                            
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Öğretmenin notu mevcut değil.</span>\r\n");
#nullable restore
#line 80 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3297, "\"", 3380, 1);
#nullable restore
#line 83 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
WriteAttributeValue("", 3304, Url.Action("Details", "StudentNotesStatus", new { id = student.StudentId }), 3304, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detayları Görüntüle</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Parents\Views\StudentNotesStatus\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AnaOkuluVeKres.Areas.Teachers.Models.StudentStatusViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
