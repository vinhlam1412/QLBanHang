#pragma checksum "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd5b3cbf14aa12810f462869a964ae4d95bab928"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_MyAccount), @"mvc.1.0.view", @"/Views/Accounts/MyAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd5b3cbf14aa12810f462869a964ae4d95bab928", @"/Views/Accounts/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a23462856df2f241b896fcd22ec3e9e80e790dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block btn-sm profile-edit-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-block btn-sm profile-edit-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
  
    ViewData["Title"] = Model.Username + " Profile Page";
    Layout = "~/Views/Layout/_ProfileLayout.cshtml";
    //string url = $"/{Model.CustommerId}.html";
    List<Order> _lstDonHang = ViewBag._lstOrder;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container emp-profile\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5b3cbf14aa12810f462869a964ae4d95bab9286528", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <div class=\"profile-img\" style=\"height:135px; width:235px;\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd5b3cbf14aa12810f462869a964ae4d95bab9286961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 486, "~/images/User/", 486, 14, true);
#nullable restore
#line 14 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
AddHtmlAttributeValue("", 500, Model.Avatar, 500, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
AddHtmlAttributeValue("", 520, Model.FullName, 520, 15, false);

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
                WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-md-7\">\r\n                <div class=\"profile-head\">\r\n                    <h5>\r\n                        ");
#nullable restore
#line 24 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                    <h6>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                   Write(Model.Mail);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h6>\r\n                    <p class=\"proile-rating\">Tỉnh/Thành Phố : <span>");
#nullable restore
#line 29 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                               Write(Model.Province);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Thông tin</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Địa Chỉ</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#lstOrder"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Danh sách đơn hàng</a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-2"">
");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5b3cbf14aa12810f462869a964ae4d95bab92811182", async() => {
                    WriteLiteral("\r\n                    <i class=\"fas fa-edit\" style=\"margin-right:5px;\"></i>Edit Profile\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                 WriteLiteral(Model.CustommerId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5b3cbf14aa12810f462869a964ae4d95bab92813885", async() => {
                    WriteLiteral("\r\n                    <i class=\"fas fa-arrow-circle-left\" style=\"margin-right:5px;\"></i>Đổi mật khẩu\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd5b3cbf14aa12810f462869a964ae4d95bab92815542", async() => {
                    WriteLiteral("\r\n                    <i class=\"fas fa-arrow-circle-left\" style=\"margin-right:5px;\"></i>Back to list\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3"">
            </div>
            <div class=""col-md-9"">
                <div class=""tab-content profile-tab"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Username</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 69 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Ngày sinh nhật</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 77 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.BirthDay);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Số điện thoại</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 85 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Tỉnh/Thành phố</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 95 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.Province);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Quận/Huyện</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 103 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.District);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Phường/Xã</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 111 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.Ward);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Địa chỉ</label>
                            </div>
                            <div class=""col-md-6"">
                                <p>");
#nullable restore
#line 119 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                              Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 123 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                     if (_lstDonHang != null && _lstDonHang.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""tab-pane fade"" id=""lstOrder"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                            <div class=""table-responsive"">
                                <table class=""table align-items-center mb-0"">
                                    <thead>
                                        <tr>
                                            <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Mã Đơn Hàng</th>
                                            <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">
                                                Ngày mua
                                            </th>
                                            <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">
                                                Trạng thái giao dịch
                                            </th>
                                            <th");
                WriteLiteral(@" class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">
                                                Trạng thái
                                            </th>
                                            <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">
                                                Tổng tiền
                                            </th>
                                            <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">
                                                Đã xóa?
                                            </th>
                                            <th></th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 150 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                         foreach (var item in _lstDonHang)
                                        {
                                            string url = $"/chi-tiet-don-hang-{item.OrderId}.html";

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <tr>
                                                <td>
                                                    <div class=""d-flex px-2"">
                                                        <div class=""my-auto"">
                                                            <h6 class=""mb-0 text-xs"">");
#nullable restore
#line 157 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                Write(item.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td>
                                                    <p class=""text-xs font-weight-normal mb-0"">");
#nullable restore
#line 162 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                          Write(item.OrderDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <p class=\"text-xs font-weight-normal mb-0\">");
#nullable restore
#line 165 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                          Write(item.TransactionStatus.Descriptions);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                </td>\r\n                                                <td>\r\n");
#nullable restore
#line 168 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                     if (item.IsPaid == true)
                                                    {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <span class=\"badge bg-success\">Đã thanh toán</span>\r\n");
#nullable restore
#line 173 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <span class=\"badge bg-secondary\">Chưa thanh toán</span>\r\n");
#nullable restore
#line 177 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </td>\r\n                                                <td>\r\n                                                    <p class=\"text-xs font-weight-normal mb-0\">");
#nullable restore
#line 180 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                          Write(item.TotalMoney.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</p>\r\n                                                </td>\r\n                                                <td>\r\n");
#nullable restore
#line 183 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                     if (item.IsDeleted == true)
                                                    {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <span class=\"badge bg-danger\">Đã xóa</span>\r\n");
#nullable restore
#line 188 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <span class=\"badge bg-info\">Chưa xóa</span>\r\n");
#nullable restore
#line 192 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </td>\r\n                                                <td>\r\n                                                    <a class=\"btn btn-secondary btn-primary-hover\"");
                BeginWriteAttribute("href", " href=\"", 11160, "\"", 11171, 1);
#nullable restore
#line 195 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
WriteAttributeValue("", 11167, url, 11167, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"xemdonhang\" data-madonhang=\"");
#nullable restore
#line 195 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                                                                          Write(item.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Xem chi tiết</a>\r\n");
#nullable restore
#line 196 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                     if (item.IsDeleted == false && item.TransactionStatusId < 3 && item.IsPaid == false)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <a class=\"btn btn-warning btn-danger-hover\" id=\"huydonhang\" data-madonhang=\"");
#nullable restore
#line 198 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                                                                                               Write(item.OrderId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Hủy đơn hàng</a>\r\n");
#nullable restore
#line 199 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 202 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                                <br />
                                <br />
                                <br />
                                <hr />
                                <div id=""record_table"">

                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 214 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"tab-pane fade\" id=\"lstOrder\" role=\"tabpanel\" aria-labelledby=\"profile-tab\">\r\n                            <p>Danh sách đơn hàng rỗng</p>\r\n                        </div>\r\n");
#nullable restore
#line 220 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Accounts\MyAccount.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <style>
        body {
            background: -webkit-linear-gradient(left, #3931af, #00c6ff);
        }

        .emp-profile {
            padding: 3%;
            margin-top: 3%;
            margin-bottom: 3%;
            border-radius: 0.5rem;
            background: #fff;
        }

        .profile-img {
            text-align: center;
        }

            .profile-img img {
                max-height: 188px;
                max-width: 125px;
                border-radius: 10px;
            }

            .profile-img .file {
                position: relative;
                overflow: hidden;
                margin-top: -20%;
                width: 70%;
                border: none;
                border-radius: 10px;
                font-size: 15px;
                background: #212529b8;
            }

                .profile-img .file inp");
                WriteLiteral(@"ut {
                    position: absolute;
                    opacity: 0;
                    right: 0;
                    top: 0;
                }

        .profile-head h5 {
            color: #333;
        }

        .profile-head h6 {
            color: #0062cc;
        }

        .profile-edit-btn {
            border: none;
            border-radius: 1.5rem;
            width: 70%;
            padding: 2%;
            font-weight: 600;
            color: #6c757d;
            cursor: pointer;
        }

        .proile-rating {
            font-size: 12px;
            color: #818182;
            margin-top: 5%;
        }

            .proile-rating span {
                color: #495057;
                font-size: 15px;
                font-weight: 600;
            }

        .profile-head .nav-tabs {
            margin-bottom: 5%;
        }

            .profile-head .nav-tabs .nav-link {
                font-weight: 600;
                border: none;
    ");
                WriteLiteral(@"        }

                .profile-head .nav-tabs .nav-link.active {
                    border: none;
                    border-bottom: 2px solid #0062cc;
                }

        .profile-work {
            padding: 14%;
            margin-top: -15%;
        }

            .profile-work p {
                font-size: 12px;
                color: #818182;
                font-weight: 600;
                margin-top: 10%;
            }

            .profile-work a {
                text-decoration: none;
                color: #495057;
                font-weight: 600;
                font-size: 14px;
            }

            .profile-work ul {
                list-style: none;
            }

        .profile-tab label {
            font-weight: 600;
        }

        .profile-tab p {
            font-weight: 600;
            color: #0062cc;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

    <script>
        $(document).ready(function () {
            $(function () {
                $(""#huydonhang"").click(function () {
                    var madonhang = $(this).attr(""data-madonhang"")
                    $.ajax({
                        url: 'api/donhang/cancel',
                        dataType: ""JSON"",
                        type: ""POST"",
                        data: { id: madonhang },
                        async: true,
                        success: function (results) {
                            location.reload();
                        },
                        error: function (xhr) {
                            alert(""Lỗi"");
                        }
                    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591