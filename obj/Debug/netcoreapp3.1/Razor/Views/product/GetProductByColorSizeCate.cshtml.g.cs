#pragma checksum "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09765530105080b6e0a9b94ed8c69e3f6719ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_product_GetProductByColorSizeCate), @"mvc.1.0.view", @"/Views/product/GetProductByColorSizeCate.cshtml")]
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
#line 1 "F:\New\WebSecurityFinal\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\New\WebSecurityFinal\Views\_ViewImports.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09765530105080b6e0a9b94ed8c69e3f6719ae0", @"/Views/product/GetProductByColorSizeCate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Views/_ViewImports.cshtml")]
    public class Views_product_GetProductByColorSizeCate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/rating_review.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-color-small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/rating_review.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c09765530105080b6e0a9b94ed8c69e3f6719ae05706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"products\">\r\n    <div class=\"row \">\r\n");
#nullable restore
#line 7 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
         foreach (var item in ViewBag.ShowProducts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col l-4 m-4 c-6\">\r\n");
#nullable restore
#line 10 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
               Color a = new Color();
                a = item.productcolorMaster[0];

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"li-product-id\"");
            BeginWriteAttribute("value", " value=\"", 449, "\"", 465, 1);
#nullable restore
#line 12 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 457, item.Id, 457, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"list-style:none;\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 516, "\"", 581, 4);
            WriteAttributeValue("", 523, "ShowProductDetailObject?color_id=", 523, 33, true);
#nullable restore
#line 13 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 556, a.Id, 556, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 561, "&product_id=", 561, 12, true);
#nullable restore
#line 13 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 573, item.Id, 573, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c09765530105080b6e0a9b94ed8c69e3f6719ae08645", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 634, "product-img-", 634, 12, true);
#nullable restore
#line 14 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
AddHtmlAttributeValue("", 646, item.Id, 646, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 683, "~/image/", 683, 8, true);
#nullable restore
#line 14 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
AddHtmlAttributeValue("", 691, item.DefaultImage, 691, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4 class=\"product-name\">");
#nullable restore
#line 15 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                            Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    </a>\r\n                    <p class=\"sale-label\">\r\n                        <span>SALE</span>\r\n                    </p>\r\n                </li>\r\n");
#nullable restore
#line 21 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                double regular = item.RegularPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Đặt dấu . vào tiền-->\r\n");
#nullable restore
#line 22 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                double sale = item.SalePrice;
                string regular_price = regular.ToString("N0",
                System.Globalization.CultureInfo.GetCultureInfo("de"));
                string sale_price = sale.ToString("N0",
               System.Globalization.CultureInfo.GetCultureInfo("de"));
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"p-money\" style=\"text-align:center;\"><span class=\"span-money\" style=\"text-decoration:line-through; color:rgb(153,153,153);\">");
#nullable restore
#line 28 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                                                                            Write(regular_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>đ</sup></span><span></span><span style=\"color: red;\">");
#nullable restore
#line 28 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                                                                                                                                                    Write(sale_price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>đ</sup></span></p>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1630, "\"", 1691, 3);
            WriteAttributeValue("", 1638, "rating-product-interface-", 1638, 25, true);
#nullable restore
#line 29 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 1663, item.Id, 1663, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1671, "rating-product-temp", 1672, 20, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div style=\" font-size: 25px; cursor: default; \"");
            BeginWriteAttribute("id", " id=\"", 1759, "\"", 1772, 1);
#nullable restore
#line 30 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 1764, item.Id, 1764, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button_wishlist heart-color\" onclick=\"add_wishlist(this.id)\">&#10084;</div>\r\n\r\n\r\n");
#nullable restore
#line 33 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                  
                    double rating_d = item.ratingProduct;
                    int rating;
                    var color = "";
                    if (rating_d == 0)
                    {
                        rating = 0;
                        color = "";
                    }
                    else
                    {
                        rating = Convert.ToInt32(Math.Ceiling(rating_d));
                        color = "";
                    }



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul class=\"list-rating\">\r\n\r\n");
#nullable restore
#line 51 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                         for (int i = 1; i <= 5; i++)
                        {
                            if (i <= rating)
                            {
                                color = "color:#ffcc00;";
                            }
                            else
                            {
                                color = "color:#ccc;";
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"rating\" title=\"Star rating\"");
            BeginWriteAttribute("id", " id=\"", 2876, "\"", 2881, 0);
            EndWriteAttribute();
            WriteLiteral(" data-index=\"");
#nullable restore
#line 62 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-rating=\"");
#nullable restore
#line 62 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                                 Write(rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                data-product_id=\"\" data-color_id=\"\"");
            BeginWriteAttribute("style", " style=\"", 2989, "\"", 3043, 3);
            WriteAttributeValue("", 2997, "color:#ccc;cursor:text;", 2997, 23, true);
            WriteAttributeValue(" ", 3020, "font-size:30px;", 3021, 16, true);
#nullable restore
#line 63 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue(" ", 3036, color, 3037, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#9733;</li>\r\n");
#nullable restore
#line 64 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n");
            WriteLiteral("            </div>\r\n\r\n            <div class=\"watcher-product\">\r\n                <ul>\r\n");
#nullable restore
#line 73 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                     foreach (var index in item.productcolorMaster)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("value", " value=\"", 3342, "\"", 3359, 1);
#nullable restore
#line 75 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 3350, index.Id, 3350, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3360, "\"", 3385, 2);
            WriteAttributeValue("", 3368, "li-color-", 3368, 9, true);
#nullable restore
#line 75 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 3377, item.Id, 3377, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c09765530105080b6e0a9b94ed8c69e3f6719ae018349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3463, "color_small_", 3463, 12, true);
#nullable restore
#line 77 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
AddHtmlAttributeValue("", 3475, index.Id, 3475, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3515, "~/image/", 3515, 8, true);
#nullable restore
#line 77 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
AddHtmlAttributeValue("", 3523, index.ColorImage, 3523, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 80 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 84 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 88 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
  
    double page_all = Convert.ToDouble(ViewBag.GetTotalPage / Convert.ToDouble(9));
    int page_total = Convert.ToInt32(Math.Ceiling(page_all));
    int page_url = Convert.ToInt32(Context.Request.Query["page"]); //Lấy parameter page trên url
    int page_prev = page_url - 1;
    int page_after = page_url + 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pagination-top\">\r\n    <ul>\r\n");
#nullable restore
#line 98 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
          
            if (page_url > 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"btn prev btn-pagination-prev\"");
            BeginWriteAttribute("value", " value=\"", 4211, "\"", 4228, 1);
#nullable restore
#line 101 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 4219, page_url, 4219, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p class=\"pagination-last\" style=\"width:32px; height:32px; \">\r\n                        <i style=\"width:32px; height:32px;\" class=\"fas fa-angle-left\"></i>\r\n                    </p>\r\n                </li>\r\n");
#nullable restore
#line 106 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
             for (int j = 1; j <= page_total; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"btn-pagination\"");
            BeginWriteAttribute("value", " value=\"", 4580, "\"", 4590, 1);
#nullable restore
#line 109 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 4588, j, 4588, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 110 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                     if (page_url == j)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"width:32px; height:32px; color: white; background: red\">");
#nullable restore
#line 112 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                     Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 113 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"width: 32px; height: 32px;\">");
#nullable restore
#line 116 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                         Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 117 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 119 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
             
            if (page_url < page_total)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"btn next btn-pagination-next\"");
            BeginWriteAttribute("value", " value=\"", 5070, "\"", 5087, 1);
#nullable restore
#line 122 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
WriteAttributeValue("", 5078, page_url, 5078, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <p class=\"pagination-last\" style=\"width:32px; height:32px;\">\r\n                        <i style=\"width:32px; height:32px;\" class=\"fas fa-angle-right\"></i>\r\n                    </p>\r\n                </li>\r\n");
#nullable restore
#line 127 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c09765530105080b6e0a9b94ed8c69e3f6719ae026112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c09765530105080b6e0a9b94ed8c69e3f6719ae027152", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
   
    //Xử lý khi bấm vào số page
    $("".btn-pagination"").each(function () {
        $(this).on(""click"", function () {
            var page = $(this).val();
               
            if (size_id != undefined && color_id != undefined) {
                $.ajax({
                    url: '");
#nullable restore
#line 144 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                     Write(Url.Action("GetProductByColorSizeCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    type: \"Get\",\r\n                    dataType: \"html\",\r\n                    data: { page: page, color_id:");
#nullable restore
#line 147 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                            Write(ViewBag.GetColor);

#line default
#line hidden
#nullable disable
            WriteLiteral(",size_id: ");
#nullable restore
#line 147 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                       Write(ViewBag.GetSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(", cate_id:");
#nullable restore
#line 147 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                                 Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                    success: function (data) {
                        $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                        $(""#content"").html(data);//load lạ
                    },
                    error: () => alert(""something wrong"")
                });

            }
        });
    });
    //Xử ly nút mũi tên về page sau
    $("".btn-pagination-next"").on(""click"", function () {

        var page = $(this).val() + 1;

        if (size_id != undefined && color_id != undefined) {
            $.ajax({
                url: '");
#nullable restore
#line 165 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                 Write(Url.Action("GetProductByColorSizeCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: page, color_id:");
#nullable restore
#line 168 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                        Write(ViewBag.GetColor);

#line default
#line hidden
#nullable disable
            WriteLiteral(",size_id: ");
#nullable restore
#line 168 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                   Write(ViewBag.GetSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(", cate_id:");
#nullable restore
#line 168 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                             Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lạ
                },
                error: () => alert(""something wrong"")
            });

        }


    });

    //Xử ly nút mũi tên về page trước
     $("".btn-pagination-prev"").on(""click"", function () {

        var page = $(this).val() - 1;

        if (size_id!= undefined && color_id != undefined) {
            $.ajax({
                url: '");
#nullable restore
#line 188 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                 Write(Url.Action("GetProductByColorSizeCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: page, color_id:");
#nullable restore
#line 191 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                        Write(ViewBag.GetColor);

#line default
#line hidden
#nullable disable
            WriteLiteral(",size_id: ");
#nullable restore
#line 191 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                   Write(ViewBag.GetSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(", cate_id:");
#nullable restore
#line 191 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                                             Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lạ
                },
                error: () => alert(""something wrong"")
            });

        }


     });




        var size_id;
        var color_id;
    $("".filter-color-item"").each(function () {
        $(this).on(""click"", function () {
            color_id = $(this).val();
        });
    });
    $("".filter-size-item"").each(function () {
        $(this).on(""click"", function () {
            size_id = $(this).val();
        });
    });
    $(""#btn-cancel-color"").on(""click"", function () {  //Gán lại undefined cho color_id khi mà nhấn nút huỷ
        color_id = undefined;
    })
    $(""#btn-cancel-size"").on(""click"", function () {  //Gán lại undefined cho size_id khi mà nhấn nút huỷ
        size_id = undefined;
    })

    $(""#btn-filter-product"").on(""click"", function () {
        // Lọc theo s");
            WriteLiteral("ize\r\n        console.log(size_id);\r\n        console.log(color_id);\r\n        if (size_id != undefined && color_id == undefined) {\r\n\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 233 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                 Write(Url.Action("GetProductBySizeCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: 1, size_id: size_id, cate_id: ");
#nullable restore
#line 236 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                       Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lại cái mới
                },
                error: () => alert(""something wrong"")
            });
        }
        //Lọc theo color
        else if (size_id == undefined && color_id != undefined) {
            $.ajax({
                url: '");
#nullable restore
#line 247 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                 Write(Url.Action("GetProductByColorCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: 1, color_id: color_id, cate_id: ");
#nullable restore
#line 250 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                         Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lại cái mới
                },
                error: () => alert(""something wrong"")
            });

        }
        else {
            $.ajax({
                url: '");
#nullable restore
#line 261 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                 Write(Url.Action("GetProductByColorSizeCate","product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: 1, color_id: color_id, size_id:size_id, cate_id:  ");
#nullable restore
#line 264 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                                                           Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lại cái mới
                },
                error: () => alert(""something wrong"")
            });
        }



    });

     $(""#btn-select-price"").on(""change"", function () {
         var str = $(this).val();
         var page = ");
#nullable restore
#line 279 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
               Write(page_url);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n         $.ajax({\r\n                url: \"/product/\"+str,\r\n                type: \"Get\",\r\n                dataType: \"html\",\r\n                data: { page: page, cate_id:  ");
#nullable restore
#line 284 "F:\New\WebSecurityFinal\Views\product\GetProductByColorSizeCate.cshtml"
                                         Write(ViewBag.GetCate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  },
                success: function (data) {
                    $(""#content"").empty(); //Xoá tất cả dữ liệu trước đó
                    $(""#content"").html(data);//load lại cái mới
                  //  console.log(page);
                },
                error: () => alert(""something wrong"")
            });
    })



</script>");
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
