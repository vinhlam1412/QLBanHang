#pragma checksum "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5f2d5a3162d9d592e7fc5fdad8a0eb79c47f94c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5f2d5a3162d9d592e7fc5fdad8a0eb79c47f94c", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a23462856df2f241b896fcd22ec3e9e80e790dc", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EShop.ViewModel.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 124px; width:112px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
  
    ViewData["Title"] = "Giỏ Hàng";
    Layout = "~/Views/Layout/_CartLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""cart-area section-space-y-axis-100"">
    <div class=""container"">
        <div class=""row""> <span style=""margin-bottom:10px;""><a href=""/"" style=""border-block:solid;""><i class=""fas fa-long-arrow-alt-left"" style=""margin-right: 10px; margin-bottom: 10px;""></i>Quay về trang chủ</a></span> </div>
        <div class=""row"">
            <div class=""col-12"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5f2d5a3162d9d592e7fc5fdad8a0eb79c47f94c4749", async() => {
                WriteLiteral(@"
                    <div class=""table-content table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""product_remove"">Bỏ sản phẩm</th>
                                    <th class=""product-thumbnail"">Ảnh</th>
                                    <th class=""cart-product-name"">Sản phẩm</th>
                                    <th class=""product-price"">Giá sản phẩm</th>
                                    <th class=""product-quantity"">Số lượng</th>
                                    <th class=""product-subtotal"">Tổng tiền</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <tr>
                                            <td class=""product_remove"">
                                                <input type=""button"" value=""X"" title=""Remove"" class=""removecart btn btn-primary"" data-mahh=""");
#nullable restore
#line 33 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                                                                                                                       Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" />
                                            </td>
                                            <td class=""product-thumbnail"">
                                                <a href=""javascript:void(0)"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5f2d5a3162d9d592e7fc5fdad8a0eb79c47f94c7105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2109, "~/images/products/", 2109, 18, true);
#nullable restore
#line 37 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
AddHtmlAttributeValue("", 2127, item.product.ThumbImg, 2127, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
AddHtmlAttributeValue("", 2156, item.product.Title, 2156, 19, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </a>\r\n                                            </td>\r\n                                            <td class=\"product-name\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 40 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                                                                             Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                            <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 41 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                                                                      Write(item.product.SalesPrice.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                            <td class=\"quantity\">\r\n                                                <div class=\"cart-plus-minus\">\r\n                                                    <input class=\"cart-plus-minus-box\"");
                BeginWriteAttribute("value", " value=\"", 2843, "\"", 2860, 1);
#nullable restore
#line 44 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
WriteAttributeValue("", 2851, item.Qty, 2851, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" data-mahh=\"");
#nullable restore
#line 44 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                                                                                                           Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                                                </div>\r\n                                            </td>\r\n                                            <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 47 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                                                                         Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-5 ml-auto"">
                            <div class=""cart-page-total"">
                                <h2>Tổng cộng</h2>
                                <ul>
                                    <li>Total<span>");
#nullable restore
#line 59 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                              Write(Model.Sum(x => x.TotalMoney.Value).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</span></li>\r\n                                </ul>\r\n");
#nullable restore
#line 61 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                 if (User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a href=\"/checkout.html\">Thanh toán <i class=\"fa fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 64 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a href=\"/login.html?returnUrl=/checkout.html\">Thanh toán <i class=\"fa fa-arrow-circle-right\"></i></a>\r\n");
#nullable restore
#line 68 "C:\Users\Administrator\Downloads\EShop\EShop\Views\ShopCart\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            function loadHeaderCart() {
                $(""#miniCart"").load(""/AjaxContent/HeaderCart"")
                $(""#miniCart"").load(""/AjaxContent/NumberCart"")
            }

            $("".cart-plus-minus-box"").click(function () {
                var productID = $(this).attr(""data-mahh"");
                console.log(productID);
                var qty1 = parseInt($(this).val());
                console.log(productID);
                $.ajax({
                    url: ""api/cart/update"",
                    type: ""POST"",
                    dataType: ""JSON"",
                    data: {
                        productId: productID,
                        qty: qty1
                    },
                    success: function (result) {
                        window.location = 'cartItem.html';
                    },
                    error: function (rs) {
                        alert(""Lỗi cập nhật !!!"");
                    }
          ");
                WriteLiteral(@"      });
            });


            $("".removecart"").click(function () {
                var productID = $(this).attr(""data-mahh"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EShop.ViewModel.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
