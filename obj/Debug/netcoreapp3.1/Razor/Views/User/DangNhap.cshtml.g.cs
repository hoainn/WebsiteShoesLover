#pragma checksum "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24cace2ef566f2bdf5118ad65b4dc0358916e058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DangNhap), @"mvc.1.0.view", @"/Views/User/DangNhap.cshtml")]
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
#line 1 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24cace2ef566f2bdf5118ad65b4dc0358916e058", @"/Views/User/DangNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DangNhap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:blue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DangKy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/User/LogIn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
  
    ViewData["Title"] = "DangNhap";
    /*Layout = "~/Views/User/DangNhap.cshtml";*/


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html>


<style>
    * {
        box-sizing: border-box;
    }



    .login h1 {
        font-weight: bold;
        margin: 1px;
        text-align: center;
    }



    .login .btn {
        border-radius: 20px;
        border: 2px solid green;
        background-color: green;
        color: #FFFFFF;
        font-size: 12px;
        font-weight: bold;
        padding: 12px 45px;
        letter-spacing: 2px;
        text-transform: uppercase;
    }

    .login .btn:active {
        transform: scale(0.9);
    }

    .login form {
        background-color: #FFFFFF;
        padding: 20px 50px 50px;
        text-align: center;
        margin-top: 100px;
    }

    .container {
        background-color: #fff;
        border-radius: 20px;
        box-shadow: 0 15px 28px rgba(0, 0, 0, 0.25), 0 10px 10px rgba(0, 0, 0, 0.22);
        overflow: hidden;
        width: 600px;
        max-width: 100%;
        min-height: 480px;
        padding: 15px 90px 10px 100p");
            WriteLiteral("x;\r\n        align-content: center;\r\n        margin: 100px auto;\r\n    }\r\n    .alert{\r\n        color:red;\r\n        font-size: 10px;\r\n    }\r\n</style>\r\n\r\n\r\n<div class=\"container login\" id=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24cace2ef566f2bdf5118ad65b4dc0358916e0586481", async() => {
                WriteLiteral(@"
        <h1>Đăng nhập</h1>
        <input type=""text"" name=""email"" placeholder=""Email đăng nhập"" style=""background-color: #eee; border: none; padding: 15px 15px; margin: 10px; width: 100%;"" />
        <input type=""password"" name=""password"" placeholder=""Nhập password"" style=""background-color: #eee; border: none; padding: 15px 15px; margin: 10px; width: 100%;"" />
");
#nullable restore
#line 76 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
         if (ViewData["redirectOption"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"hidden\" name=\"redirectOption\" value=\"payment\"/>\r\n");
#nullable restore
#line 79 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button class=\"btn\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1972, "\"", 2026, 3);
                WriteAttributeValue("", 1982, "location.href=\'", 1982, 15, true);
#nullable restore
#line 80 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
WriteAttributeValue("", 1997, Url.Action("LogIn", "User"), 1997, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2025, "\'", 2025, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Đăng nhập</button>\r\n\r\n        <p style=\"margin-top: 10px\">Bạn chưa có tài khoản? ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24cace2ef566f2bdf5118ad65b4dc0358916e0588400", async() => {
                    WriteLiteral("Đăng kí tại đây");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n        <p class=\"alert\">");
#nullable restore
#line 83 "C:\Users\Administrator\OneDrive\Desktop\C#\ShoesLoverFinal\ShoesLoverFinal\Views\User\DangNhap.cshtml"
                    Write(TempData["message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
