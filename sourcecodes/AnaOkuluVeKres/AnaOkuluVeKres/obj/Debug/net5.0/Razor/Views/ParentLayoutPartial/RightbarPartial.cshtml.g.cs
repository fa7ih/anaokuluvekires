#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\ProjectAnaOkuluVeKres\AnaOkuluVeKres\AnaOkuluVeKres\Views\ParentLayoutPartial\RightbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0daa4e4f5ef55f4b57cdeb209bdc271d831a2bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ParentLayoutPartial_RightbarPartial), @"mvc.1.0.view", @"/Views/ParentLayoutPartial/RightbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daa4e4f5ef55f4b57cdeb209bdc271d831a2bcf", @"/Views/ParentLayoutPartial/RightbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c23065a41780938ce83fd8b0cfcc9a92a22ece", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ParentLayoutPartial_RightbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""fixed-plugin"">
    <a class=""fixed-plugin-button text-dark position-fixed px-3 py-2"">
        <i class=""fa fa-cog py-2""> </i>
    </a>
    <div class=""card shadow-lg "">
        <div class=""card-header pb-0 pt-3 "">
            <div class=""float-start"">
                <h5 class=""mt-3 mb-0"">Soft UI Configurator</h5>
                <p>See our dashboard options.</p>
            </div>
            <div class=""float-end mt-4"">
                <button class=""btn btn-link text-dark p-0 fixed-plugin-close-button"">
                    <i class=""fa fa-close""></i>
                </button>
            </div>
            <!-- End Toggle Button -->
        </div>
        <hr class=""horizontal dark my-1"">
        <div class=""card-body pt-sm-3 pt-0"">
            <!-- Sidebar Backgrounds -->
            <div>
                <h6 class=""mb-0"">Sidebar Colors</h6>
            </div>
            <a href=""javascript:void(0)"" class=""switch-trigger background-color"">
                <div class=""b");
            WriteLiteral(@"adge-colors my-2 text-start"">
                    <span class=""badge filter bg-gradient-primary active"" data-color=""primary"" onclick=""sidebarColor(this)""></span>
                    <span class=""badge filter bg-gradient-dark"" data-color=""dark"" onclick=""sidebarColor(this)""></span>
                    <span class=""badge filter bg-gradient-info"" data-color=""info"" onclick=""sidebarColor(this)""></span>
                    <span class=""badge filter bg-gradient-success"" data-color=""success"" onclick=""sidebarColor(this)""></span>
                    <span class=""badge filter bg-gradient-warning"" data-color=""warning"" onclick=""sidebarColor(this)""></span>
                    <span class=""badge filter bg-gradient-danger"" data-color=""danger"" onclick=""sidebarColor(this)""></span>
                </div>
            </a>
            <!-- Sidenav Type -->
            <div class=""mt-3"">
                <h6 class=""mb-0"">Sidenav Type</h6>
                <p class=""text-sm"">Choose between 2 different sidenav types.</p>
 ");
            WriteLiteral(@"           </div>
            <div class=""d-flex"">
                <button class=""btn bg-gradient-primary w-100 px-3 mb-2 active"" data-class=""bg-transparent"" onclick=""sidebarType(this)"">Transparent</button>
                <button class=""btn bg-gradient-primary w-100 px-3 mb-2 ms-2"" data-class=""bg-white"" onclick=""sidebarType(this)"">White</button>
            </div>
            <p class=""text-sm d-xl-none d-block mt-2"">You can change the sidenav type just on desktop view.</p>
            <!-- Navbar Fixed -->
            <div class=""mt-3"">
                <h6 class=""mb-0"">Navbar Fixed</h6>
            </div>
            <div class=""form-check form-switch ps-0"">
                <input class=""form-check-input mt-1 ms-auto"" type=""checkbox"" id=""navbarFixed"" onclick=""navbarFixed(this)"">
            </div>

        </div>
    </div>
</div>
");
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