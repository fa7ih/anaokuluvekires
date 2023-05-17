#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f96e1c3c0827fd215e1c9fa509c922c48970758"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TeacherAdmin_ActiveTeacher), @"mvc.1.0.view", @"/Areas/Admin/Views/TeacherAdmin/ActiveTeacher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f96e1c3c0827fd215e1c9fa509c922c48970758", @"/Areas/Admin/Views/TeacherAdmin/ActiveTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_TeacherAdmin_ActiveTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
  
    ViewData["Title"] = "ActiveTeacher";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aktif Öğretmen Listesi</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Aktif Öğretmeniniz Bulunmamaktadır.</h4>\r\n");
#nullable restore
#line 13 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>TC</th>
            <th>Kullanıcı Adı</th>
            <th>Adı Soyadı</th>
            <th>Branşı</th>
            <th>Doğum Tarihi</th>
            <th>Detay</th>
        </tr>
");
#nullable restore
#line 26 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 29 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
                  sayac++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
               Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
               Write(item.TeacherTC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
               Write(item.TeacherUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
               Write(item.TeacherNameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
               Write(item.TeacherBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
                Write(((DateTime)item.TeacherBirth).ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a href=\"#\" class=\"btn btn-outline-info\">Detay</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 40 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\TeacherAdmin\ActiveTeacher.cshtml"
}

#line default
#line hidden
#nullable disable
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
