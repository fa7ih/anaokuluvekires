#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d0297c4850c4e57e50dda4680e6acf6551abdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__BranchStatistic_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_BranchStatistic/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3d0297c4850c4e57e50dda4680e6acf6551abdf", @"/Views/Shared/Components/_BranchStatistic/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__BranchStatistic_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-6 col-lg-4 col-xl-4 order-0 mb-4"">
    <div class=""card h-100"">
        <div class=""card-header d-flex align-items-center justify-content-between pb-0"">
            <div class=""card-title mb-0"">
                <h5 class=""m-0 me-2"">Branş İstatistikleri</h5>
                <small class=""text-muted""></small>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""d-flex justify-content-between align-items-center mb-3"">
                <div class=""d-flex flex-column align-items-center gap-1"">
                    <h2 class=""mb-2"">");
#nullable restore
#line 12 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <span>Toplam Branşlar</span>
                </div>
                <div id=""orderStatisticsChart""></div>
            </div>
            <ul class=""p-0 m-0"">
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-primary"">
                            <i class=""bx bx-mobile-alt""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Okuma Yazma</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 30 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-success""><i class=""bx bx-closet""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Matematik</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 44 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-info""><i class=""bx bx-home-alt""></i></span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Müzik</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 58 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-secondary"">
                            <i class=""bx bx-football""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Spor</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 74 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-info"">
                            <i class=""bx bx-code""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Yazılım</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 90 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v6);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                        </div>
                    </div>
                </li>
                <li class=""d-flex mb-4 pb-1"">
                    <div class=""avatar flex-shrink-0 me-3"">
                        <span class=""avatar-initial rounded bg-label-success"">
                            <i class=""bx bx-play""></i>
                        </span>
                    </div>
                    <div class=""d-flex w-100 flex-wrap align-items-center justify-content-between gap-2"">
                        <div class=""me-2"">
                            <h6 class=""mb-0"">Dans</h6>
                        </div>
                        <div class=""user-progress"">
                            <small class=""text-muted"">Öğretmen Sayımız: </small>
                            <small class=""fw-semibold"">");
#nullable restore
#line 106 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_BranchStatistic\Default.cshtml"
                                                  Write(ViewBag.v7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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