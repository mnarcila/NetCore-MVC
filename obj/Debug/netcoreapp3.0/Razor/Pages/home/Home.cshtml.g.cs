#pragma checksum "D:\Proyectos\netcore\Pages\home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e082c0e678292e7cbc855ab81b3f6a0427658ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(netcore.Pages.home.Pages_home_Home), @"mvc.1.0.razor-page", @"/Pages/home/Home.cshtml")]
namespace netcore.Pages.home
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
#line 1 "D:\Proyectos\netcore\Pages\_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\netcore\Pages\home\Home.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e082c0e678292e7cbc855ab81b3f6a0427658ae", @"/Pages/home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9cf59cd5cc28b282e1537dd1b478e19ddc6698", @"/Pages/_ViewImports.cshtml")]
    public class Pages_home_Home : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Proyectos\netcore\Pages\home\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bienvenido </h1>\r\n   <h2>    ");
#nullable restore
#line 11 "D:\Proyectos\netcore\Pages\home\Home.cshtml"
      Write(HttpContext.Session.GetString(Home.SessionKeyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n     </h2> \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Home> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Home> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Home>)PageContext?.ViewData;
        public Home Model => ViewData.Model;
    }
}
#pragma warning restore 1591
