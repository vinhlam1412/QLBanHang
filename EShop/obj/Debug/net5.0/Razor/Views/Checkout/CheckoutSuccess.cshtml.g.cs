#pragma checksum "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c72d388b4e9e888ee50ddf85293f5e28dead7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_CheckoutSuccess), @"mvc.1.0.view", @"/Views/Checkout/CheckoutSuccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c72d388b4e9e888ee50ddf85293f5e28dead7a", @"/Views/Checkout/CheckoutSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a23462856df2f241b896fcd22ec3e9e80e790dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_CheckoutSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop.ViewModel.OrderSuccessViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_AdminAssets/images/logo/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px;width:260px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
  
    ViewData["Title"] = "Thanh toán thành công";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-content"">
    <div class=""container"" style=""border-radius:10px; border:solid crimson;"">
        <div class=""align-content-center justify-content-lg-center"" style=""text-align:center;"">
            <h1 style=""color: green;"">Thanh toán thành công</h1>
        </div>
        <div class=""card"">
            <div class=""card-body"">
                <div id=""invoice"" class=""p-h-30"">
                    <div class=""m-t-15 lh-2"">
                        <div class=""inline-block"">
                            <div class=""row"" style=""margin-top:12px;"">
                                <div class=""col-md-9"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88c72d388b4e9e888ee50ddf85293f5e28dead7a5533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""p-l-10"">
                                        <span class=""font-weight-semibold text-dark"">EShop, Inc.</span><br>
                                        <span>123456, DIENBIENPHU</span><br>
                                        <span>BinhThanh, T</span><br>
                                        <abbr class=""text-dark"" title=""Phone"">Phone:</abbr>
                                        <span>(+84) 968-454-617</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""float-right"" style=""margin-top:10px;"">
                            <h2>HÓA ĐƠN</h2>
                        </div>
                    </div>
                    <div class=""row m-t-20 lh-2"">
                        <div class=""col-sm-9"">
            ");
            WriteLiteral(@"                <h3 class=""p-l-10 m-t-10"">Đặt Hàng Thành Công</h3>
                            <address class=""p-l-10 m-t-10"">
                                <span class=""text-dark"" style=""font: italic;"">Cảm ơn quý khách đã đặt hàng.</span><br>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-md-3"">
                                        <span><a style=""font-weight: 800; margin-right:10px;"">Họ tên khách hàng:</a></span><br>
                                        <span><a style=""font-weight: 800; margin-right: 10px;"">Địa chỉ:</a></span><br>
                                        <span><a style=""font-weight: 800; margin-right: 10px;"">Số điện thoại:</a></span><br>
                                        <span><a style=""font-weight: 800; margin-right: 10px;"">Tỉnh/Thành phố:</a></span><br>
                                        <span><a style=""font-weight: 800; margin-right: 10px;"">Quận huyện:</a></span><br>");
            WriteLiteral(@"
                                        <span><a style=""font-weight: 800; margin-right: 10px; "">Phường xã:</a></span><br>
                                    </div>
                                    <div class=""col-md-4"">
                                        <span>");
#nullable restore
#line 52 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <span>");
#nullable restore
#line 53 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <span>");
#nullable restore
#line 54 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <span>");
#nullable restore
#line 55 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.TinhThanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <span>");
#nullable restore
#line 56 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.QuanHuyen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n                                        <span>");
#nullable restore
#line 57 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                         Write(Model.PhuongXa);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span><br>
                                    </div>
                                </div>
                            </address>
                        </div>
                        <div class=""col-sm-3"">
                            <div class=""m-t-80"">
                                <div class=""text-dark text-uppercase d-inline-block"">
                                    <span class=""font-weight-semibold text-dark"">Mã đơn hàng :</span>
                                </div>
                                <div class=""float-right"">#");
#nullable restore
#line 67 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                                     Write(Model.DonHangID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                            <div class=""text-dark text-uppercase d-inline-block"">
                                <span class=""font-weight-semibold text-dark"">Ngày đặt :</span>
                            </div>
                            <div class=""float-right"">");
#nullable restore
#line 72 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Checkout\CheckoutSuccess.cshtml"
                                                Write(Model.NgayDat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop.ViewModel.OrderSuccessViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
