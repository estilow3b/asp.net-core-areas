#pragma checksum "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93214e6372704690580e9618f894d1ac302ca30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\_ViewImports.cshtml"
using Layer.Aplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\_ViewImports.cshtml"
using Layer.Aplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e93214e6372704690580e9618f894d1ac302ca30", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a9ca51cb6c1f4e1ab8196c9b97f2434ac2c78a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n\r\n<h1>Portal Principal</h1>\r\n<!--Enlace Area Ventas-->\r\n");
#nullable restore
#line 13 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\Home\Index.cshtml"
Write(Html.ActionLink("Ventas", "Index", new { area = "Ventas", controller = "Home" }, new { @class = "btn btn-primary text-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Enlace Area Contabilidad-->\r\n");
#nullable restore
#line 16 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\Home\Index.cshtml"
Write(Html.ActionLink("Contabilidad", "Index", new { area = "Contabilidad", controller = "Home" }, new { @class = "btn btn-success text-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Enlace Area Logistica-->\r\n");
#nullable restore
#line 19 "D:\Datos\Proyectos\AVANTISOFT\Estilo Web\Articulos\4. ASP.Net Core y Areas\Fuentes\ASP.Net Core y Areas\Layer.Aplication\Views\Home\Index.cshtml"
Write(Html.ActionLink("Logistica", "Index", new { area = "Logistica", controller = "Home" }, new { @class = "btn btn-danger text-light" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
