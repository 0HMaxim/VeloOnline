#pragma checksum "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7ffb234a72357d9b9b49186dd274da387cbce7e"
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
#line 1 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\_ViewImports.cshtml"
using VeloOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\_ViewImports.cshtml"
using VeloOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ffb234a72357d9b9b49186dd274da387cbce7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8681544e29c5b761e9a6b0a9b9240a153c10d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeloOnline.Models.ViewModels.BikeListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Index.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <input type=\"hidden\" id=\"indexViewModel\"");
            BeginWriteAttribute("value", " value=\"", 191, "\"", 250, 1);
#nullable restore
#line 9 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Index.cshtml"
WriteAttributeValue("", 199, Newtonsoft.Json.JsonConvert.SerializeObject(Model), 199, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group\">\r\n        <input id=\"searchText\" type=\"text\" class=\"form-control\" />\r\n        <button id=\"searchBtn\" class=\"form-control btn btn-primary\">Search</button>\r\n    </div>\r\n\r\n\r\n    <div class=\"d-flex\">\r\n\r\n\r\n");
            WriteLiteral(@"


        <div id=""bike-list""></div>
    </div>

    <div class=""paggination"">

        <div id=""bike-list""></div>
    </div>



    <button id=""selectFilter"" class=""float-right btn btn-secondary form-control w-25 h-25"">Filter</button>



</div>");
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
