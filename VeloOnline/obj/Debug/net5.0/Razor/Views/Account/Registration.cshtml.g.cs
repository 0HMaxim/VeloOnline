#pragma checksum "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95b6bed7ac78a38c782f3e949ffc0507773a783f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Registration), @"mvc.1.0.view", @"/Views/Account/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95b6bed7ac78a38c782f3e949ffc0507773a783f", @"/Views/Account/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935a1f42cb13bf111caf0e270afa7a5b11bf3e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VeloOnline.Models.ViewModels.RegistrationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fw-bold text-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <section class=""vh-100 bg-image"" style=""background-image: url('http://getwallpapers.com/wallpaper/full/a/5/d/544750.jpg'); background-size: cover; background-repeat: no-repeat; height: 100%; "">
        <div class=""mask d-flex align-items-center h-100 gradient-custom-3"">
            <div class=""container h-100"">
                <div class=""row d-flex justify-content-center align-items-center h-100"">
                    <div class=""col-12 col-md-9 col-lg-7 col-xl-6"">
                        <div class=""card"" style=""border-radius: 15px;"">
                            <div class=""card-body p-5"">
                                <h2 class=""text-uppercase text-center mb-5"">Create an account</h2>

                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b6bed7ac78a38c782f3e949ffc0507773a783f6206", async() => {
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b6bed7ac78a38c782f3e949ffc0507773a783f6498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 18 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                                    <div class=""form-outline mb-4"">
                                        <input type=""text""name=""User.UserName"" id=""form3Example1cg"" class=""form-control form-control-lg"" />
                                        <label class=""form-label""  for=""form3Example1cg"">Your Username</label>
                                        ");
#nullable restore
#line 23 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.User.UserName, null, new { @class = "text-danger m-2 col-12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>

                                    <div class=""form-outline mb-4"">
                                        <input type=""email"" name=""User.Email"" id=""form3Example3cg"" class=""form-control form-control-lg"" />
                                        <label class=""form-label"" for=""form3Example3cg"">Your Email</label>
                                        ");
#nullable restore
#line 29 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.User.Email, null, new { @class = "text-danger m-2 col-12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>

                                    <div class=""form-outline mb-4"">
                                        <input type=""password"" name=""Password"" id=""form3Example4cg"" class=""form-control form-control-lg"" />
                                        <label class=""form-label""  for=""form3Example4cg"">Password</label>
                                        ");
#nullable restore
#line 35 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.Password, null, new { @class = "text-danger m-2 col-12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>

                                    <div class=""form-outline mb-4"">
                                        <input type=""password"" name=""ConfirmPassword"" id=""form3Example4cdg"" class=""form-control form-control-lg"" />
                                        <label class=""form-label""  for=""form3Example4cdg"">Repeat your password</label>
                                        ");
#nullable restore
#line 41 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.ConfirmPassword, null, new { @class = "text-danger m-2 col-12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>

                                    <div class=""d-flex justify-content-center"">
                                        <button type=""submit"" class=""btn btn-success btn-block btn-lg gradient-custom-4 text-body"">Register</button>
                                    </div>

                                    <p class=""text-center text-muted mt-5 mb-0"">Have already an account? ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95b6bed7ac78a38c782f3e949ffc0507773a783f11587", async() => {
                    WriteLiteral("<u>Login here</u>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\n\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 17 "C:\Users\student\Desktop\Новая папка\VeloOnline-master\VeloOnline\Views\Account\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VeloOnline.Models.ViewModels.RegistrationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
