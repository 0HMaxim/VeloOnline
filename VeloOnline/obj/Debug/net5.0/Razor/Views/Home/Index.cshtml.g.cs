#pragma checksum "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdac81542d1bf5d6e3f1791d9080d0d69ce93466"
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
#line 1 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\_ViewImports.cshtml"
using VeloOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\_ViewImports.cshtml"
using VeloOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdac81542d1bf5d6e3f1791d9080d0d69ce93466", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935a1f42cb13bf111caf0e270afa7a5b11bf3e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeloOnline.Models.ViewModels.BikeListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 6 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Home\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div>\n    <input type=\"hidden\" id=\"indexViewModel\"");
            BeginWriteAttribute("value", " value=\"", 183, "\"", 242, 1);
#nullable restore
#line 9 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 191, Newtonsoft.Json.JsonConvert.SerializeObject(Model), 191, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <div class=""form-group"">
        <input id=""searchText"" type=""text"" class=""form-control w-50 offset-3"" />
        <button id=""searchBtn"" class=""form-control btn btn-primary w-50 offset-3"">Search</button>
    </div>


    <div class=""d-flex"">

        <div id=""bike-list""></div>
    </div>

    <div class=""paggination"">

        <div id=""bike-list""></div>
    </div>

</div>

<style>


    html, body {
        background-image: url('https://domfotooboev.com.ua/home/products_images/20241.jpg');
        background-size: cover;
        background-repeat: no-repeat;
        height: 100%;
    }

</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeloOnline.Models.ViewModels.BikeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
