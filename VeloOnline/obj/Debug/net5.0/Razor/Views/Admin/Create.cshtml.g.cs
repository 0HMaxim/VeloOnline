#pragma checksum "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd54f26c00c6298a48377a1dd177038fab4fcb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Create), @"mvc.1.0.view", @"/Views/Admin/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd54f26c00c6298a48377a1dd177038fab4fcb4", @"/Views/Admin/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935a1f42cb13bf111caf0e270afa7a5b11bf3e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeloOnline.Models.ViewModels.EditBikeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml"; 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd54f26c00c6298a48377a1dd177038fab4fcb44174", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
Write(Html.HiddenFor(x => x.Bike.BikeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
Write(Html.HiddenFor(x => x.ReturnUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <div class=\"card mb-3 justify-content-center\" style=\"box-shadow: 10px 5px 5px black;\">\r\n        <div class=\"d-flex\">\r\n            <div>\r\n");
#nullable restore
#line 14 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                 if (@Model.Bike != null && @Model.Bike.ImageUrl != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <img");
                BeginWriteAttribute("src", " src=\"", 499, "\"", 525, 1);
#nullable restore
#line 16 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
WriteAttributeValue("", 505, Model.Bike.ImageUrl, 505, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"400\" alt=\"...\">\r\n");
#nullable restore
#line 17 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("               \r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.LabelFor(x => x.Bike.Title, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 24 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Bike.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.ValidationMessage("Bike.Title", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                    <p class=\"card-text\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.LabelFor(x => x.Bike.Description, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 29 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.TextAreaFor(x => x.Bike.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 30 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                   Write(Html.ValidationMessage("Bike.Description", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </p>\r\n                    <ul class=\"list-group list-group-flush\">\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.Manufacturer, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 35 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.Manufacturer, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 36 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.Manufacturer", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.NumberOfSpeeds, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 40 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.NumberOfSpeeds, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 41 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.NumberOfSpeeds", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.WheelSize, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 45 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.WheelSize, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 46 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.WheelSize", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.Weight, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.Weight, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 51 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.Weight", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.Price, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 55 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.Price", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n\r\n                        <li class=\"list-group-item\">\r\n                            ");
#nullable restore
#line 60 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.LabelFor(x => x.Bike.ImageUrl, null, new { @class = "form-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 61 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.TextBoxFor(x => x.Bike.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 62 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Admin\Create.cshtml"
                       Write(Html.ValidationMessage("Bike.ImageUrl", null, new { @class = "text-danger m-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <button type=\"submit\" class=\"btn btn-primary col-12\">Save</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeloOnline.Models.ViewModels.EditBikeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591