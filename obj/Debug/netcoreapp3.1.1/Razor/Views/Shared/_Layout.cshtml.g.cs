#pragma checksum "C:\Users\trucc\source\repos\GoldfishClub\GoldfishClub\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e4899fbef5388c005ea2ea13d462a494efae5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\trucc\source\repos\GoldfishClub\GoldfishClub\Views\_ViewImports.cshtml"
using GoldfishClub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01e4899fbef5388c005ea2ea13d462a494efae5e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b3ee239bde56f544652588e6e9b4368b8da25f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>

<html>

<head>
    <meta name=""viewport"" content=""width=device-width"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro"">
    <!-- Font Awesome icons (free version)-->
    <script src=""https://kit.fontawesome.com/804d7da4bf.js"" crossorigin=""anonymous""></script>
    <link href=""~/lib/bootstrap/css/bootstrap.css"" rel=""stylesheet"" />
    <script src=""~/lib/jquery/jquery.js""></script>
    <script src=""~/lib/bootstrap/js/bootstrap.js""></script>
    <link href=""~/content/site.css"" rel=""stylesheet"" />

</head>

<body>

    <header>
        <nav class=""navbar navbar-inverse navbar-fixed-top navbar-expand-sm"" role=""navigation"">
            <div class=""container-fluid"">
                <div class=""navbar-header"">
                    <ul class=""nav navbar-nav mr-auto"">
                        <li class="" nav-link active"">
                            <a asp-controller=""Home"" asp-action=""Index"">Home</a>
                    ");
            WriteLiteral(@"    </li>
                        <li class=""nav-link""><a asp-controller=""News"" asp-action=""Index"">News</a></li>
                        <li class=""nav-link""><a asp-controller=""Contact"" asp-action=""Index"">Contact</a></li>
                        <li class=""nav-link""><a asp-controller=""About"" asp-action=""Index"">About</a></li>


                    </ul>
                </div>
                
               
            </div>
        </nav>
    </header>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                ");
#nullable restore
#line 43 "C:\Users\trucc\source\repos\GoldfishClub\GoldfishClub\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 47 "C:\Users\trucc\source\repos\GoldfishClub\GoldfishClub\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</body>\r\n\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
