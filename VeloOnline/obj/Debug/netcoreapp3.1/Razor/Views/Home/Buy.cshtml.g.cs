#pragma checksum "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9f9df2b675eb5cf8f6710e58384085157fa833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Buy), @"mvc.1.0.view", @"/Views/Home/Buy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9f9df2b675eb5cf8f6710e58384085157fa833", @"/Views/Home/Buy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8681544e29c5b761e9a6b0a9b9240a153c10d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Buy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeloOnline.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed9f9df2b675eb5cf8f6710e58384085157fa8334080", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 171, "\"", 194, 1);
#nullable restore
#line 10 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
WriteAttributeValue("", 179, ViewBag.BikeId, 179, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"BikeId\" />\r\n\r\n\r\n    <div class=\"col-6\">\r\n\r\n        ");
#nullable restore
#line 15 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.LabelFor(x => x.Firstname, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.TextBoxFor(x => x.Firstname, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.ValidationMessage("Firstname", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 20 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.LabelFor(x => x.Lastname, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.TextBoxFor(x => x.Lastname, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.ValidationMessage("Lastname", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 26 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.LabelFor(x => x.Email, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.ValidationMessage("Email", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-6\">\r\n        ");
#nullable restore
#line 32 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.LabelFor(x => x.Phone, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.TextBoxFor(x => x.Phone, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Users\123\Desktop\VeloOnline\VeloOnline\Views\Home\Buy.cshtml"
   Write(Html.ValidationMessage("Phone", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n    <div class=\"col-md-6\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">Sign in</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeloOnline.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591