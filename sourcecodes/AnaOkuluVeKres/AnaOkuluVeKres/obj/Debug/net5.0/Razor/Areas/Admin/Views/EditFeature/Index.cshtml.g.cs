#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fff4580a81735c47e1043b2751668266f5a2293"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EditFeature_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/EditFeature/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4580a81735c47e1043b2751668266f5a2293", @"/Areas/Admin/Views/EditFeature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_EditFeature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Feature>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
 using (Html.BeginForm("Index", "EditFeature", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Alan Başlığı: </h4>\r\n");
#nullable restore
#line 11 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureHeadTitle,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>1.Özellik Başlığı: </h4>\r\n");
#nullable restore
#line 14 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureTitle1,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Açıklaması: </h4>\r\n");
#nullable restore
#line 17 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureDescription1,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>2.Özellik Başlığı: </h4>\r\n");
#nullable restore
#line 20 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureTitle2,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Açıklaması: </h4>\r\n");
#nullable restore
#line 23 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureDescription2,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>3.Özellik Başlığı: </h4>\r\n");
#nullable restore
#line 26 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureTitle3,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Açıklaması: </h4>\r\n");
#nullable restore
#line 29 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureDescription3,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>4.Özellik Başlığı: </h4>\r\n");
#nullable restore
#line 32 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureTitle4,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Açıklaması: </h4>\r\n");
#nullable restore
#line 35 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
Write(Html.TextBoxFor(x=>x.FeatureDescription4,new {@class ="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-outline-success\">Güncelle</button>\r\n");
#nullable restore
#line 38 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Areas\Admin\Views\EditFeature\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Feature> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591