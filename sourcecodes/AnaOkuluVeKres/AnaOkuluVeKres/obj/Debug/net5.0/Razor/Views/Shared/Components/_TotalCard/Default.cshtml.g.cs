#pragma checksum "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_TotalCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89b0af779992aa56868aa828f7d8f5e3facce717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TotalCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TotalCard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b0af779992aa56868aa828f7d8f5e3facce717", @"/Views/Shared/Components/_TotalCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a8db95ec65cf8e484db0d4a453bad5f5dd155c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TotalCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-lg-8 order-2 order-md-3 order-lg-2 mb-4"">
    <div class=""card"">
        <div class=""row row-bordered g-0"">
            <div class=""col-md-8"">
                <h5 class=""card-header m-0 me-2 pb-3"">Son Yılda Kayıt Olan Öğrencilerimiz</h5>
                <canvas id=""studentGraph""></canvas>
            </div>
        </div>
    </div>
</div>

<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
<script>
    var months = ");
#nullable restore
#line 14 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_TotalCard\Default.cshtml"
            Write(Html.Raw(Json.Serialize(ViewBag.Months)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    var enrollments = ");
#nullable restore
#line 15 "C:\Users\Fatih\OneDrive\Masaüstü\AnaOkuluVeKres\AnaOkuluVeKres\Views\Shared\Components\_TotalCard\Default.cshtml"
                 Write(Html.Raw(Json.Serialize(ViewBag.Enrollments)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function createStudentGraph(months, enrollments) {
        var ctx = document.getElementById('studentGraph').getContext('2d');
        var chart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: months,
                datasets: [{
                    label: 'Öğrenci Sayısı',
                    data: enrollments,
                    backgroundColor: 'rgba(75, 192, 192, 0.2)',
                    borderColor: 'rgba(75, 192, 192, 1)',
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true,
                scales: {
                    y: {
                        beginAtZero: true,
                        stepSize: 1
                    }
                }
            }
        });
    }

    createStudentGraph(months, enrollments);
</script>


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
