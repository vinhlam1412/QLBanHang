#pragma checksum "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "592cbb7546934c425281f15ab694d789e1996269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LaptopColection), @"mvc.1.0.view", @"/Views/Home/LaptopColection.cshtml")]
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
#line 1 "C:\Users\Administrator\Downloads\EShop\EShop\Views\_ViewImports.cshtml"
using EShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\EShop\EShop\Views\_ViewImports.cshtml"
using EShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"592cbb7546934c425281f15ab694d789e1996269", @"/Views/Home/LaptopColection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a23462856df2f241b896fcd22ec3e9e80e790dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LaptopColection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<EShop.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:263px; width:360px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("paper-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LaptopColection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
  
    int _current = ViewBag.CurrentPage;
    int _next = _current + 1;
    ViewData["Title"] = "LaptopColection";
    Layout = "~/Views/Layout/_StoreLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- STORE -->
            <div id=""store"" class=""col-md-12"">
                <!-- store products -->
                <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {
                        foreach (var item in Model)
                        {
                            string url = $"/{item.Alias}-{item.ProductId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- product -->
                            <div class=""col-md-4 col-xs-6"">
                                <div class=""product"">
                                    <div class=""product-img"" style=""height:263px; width:360px;"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "592cbb7546934c425281f15ab694d789e19962696454", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1098, "~/images/products/", 1098, 18, true);
#nullable restore
#line 30 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
AddHtmlAttributeValue("", 1116, item.ThumbImg, 1116, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(";", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
AddHtmlAttributeValue("", 1174, item.Title, 1174, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                         if (item.Discount.Value > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"product-label\">\r\n                                                <span class=\"sale\">-");
#nullable restore
#line 34 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                               Write(item.Discount.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"product-body\">\r\n                                        <p class=\"product-category\">");
#nullable restore
#line 39 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                               Write(item.Cate.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <h3 class=\"product-name\"><a");
            BeginWriteAttribute("href", " href=\"", 1841, "\"", 1852, 1);
#nullable restore
#line 40 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
WriteAttributeValue("", 1848, url, 1848, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n");
#nullable restore
#line 41 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                         if (item.Discount.Value > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">");
#nullable restore
#line 43 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                                 Write(item.SalesPrice.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ<del class=\"product-old-price\" style=\"margin-left:5px;\">");
#nullable restore
#line 43 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                                                                                                                                     Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</del></h4>\r\n");
#nullable restore
#line 44 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4 class=\"product-price\">");
#nullable restore
#line 47 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                                 Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h4>\r\n");
#nullable restore
#line 48 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""product-rating"">
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                            <i class=""fa fa-star""></i>
                                        </div>
                                    </div>
                                    <div class=""add-to-cart"">
                                        <input id=""txtsoluong"" name=""txtsoluong"" type=""hidden"" value=""1"">
                                        <button class=""add-to-cart-btn"" data-mahh=""");
#nullable restore
#line 59 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                                                                              Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                                    </div>
                                </div>
                            </div>
                            <!-- /product -->
                            <div class=""clearfix visible-sm visible-xs""></div>
");
#nullable restore
#line 65 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!-- /store products -->\r\n                <!-- store bottom filter -->\r\n");
            WriteLiteral("                <hr />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "592cbb7546934c425281f15ab694d789e199626914977", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 75 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Home\LaptopColection.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspArea = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <!-- /store bottom filter -->\r\n            </div>\r\n            <!-- /STORE -->\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <!-- /container -->\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(function () {
                $("".add-to-cart-btn"").click(function () {
                    var productID = $(this).attr(""data-mahh"");
                    var qty1 = $('#txtsoluong').val();
                    $.ajax({
                        url: '/api/cart/add',
                        type: ""POST"",
                        dataType: ""JSON"",
                        data: {
                            productId: productID,
                            qty: qty1
                        },
                        success: function (response) {
                            loadHeaderCart();
                            location.reload();
                        },
                        error: function (error) {
                            alert(""Lỗi khi post data: "" + error.responseText);
                        }
                    });
                });
            });

            $("".delete"").click(function () {
 ");
                WriteLiteral(@"               var productID = $(this).attr(""data-mahh"");
                $.ajax({
                    url: ""api/cart/remove"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productId: productID,
                    },
                    success: function (result) {
                        location.reload();
                    },
                    error: function (rs) {
                        alert(""Lỗi khi Xóa !!!"");
                    }
                });
            });

            function loadHeaderCart() {
                $(""#miniCart"").load(""/AjaxContent/HeaderCart"")
                $(""#miniCart"").load(""/AjaxContent/NumberCart"")
            }
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<EShop.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
