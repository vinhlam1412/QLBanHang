#pragma checksum "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa6051790d9fcbf5dd35ff82390b01d5d13fe3f7", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a23462856df2f241b896fcd22ec3e9e80e790dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_UserAssets/img/product01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_UserAssets/img/product02.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_UserAssets/img/product03.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/_UserAssets/img/product04.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
  
    ViewData["Title"] = Model.ProductName;
    Layout = "~/Views/Layout/_ProductLayout.cshtml";
    string url1 = $"{Model.Cate.CategoryName}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- SECTION -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <!-- Product main img -->
            <div class=""col-md-5 col-md-push-2"">
                <div id=""product-main-img"">
                    <div class=""product-preview"" style=""height :458px; width:458px;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f76079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 590, "~/images/products/", 590, 18, true);
#nullable restore
#line 19 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 608, Model.ThumbImg, 608, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 630, Model.Title, 630, 12, false);

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
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!-- /Product main img -->
            <!-- Product thumb imgs -->
            <div class=""col-md-2  col-md-pull-5"">
                <div id=""product-imgs"">
                    <div class=""product-preview"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f78341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 976, "~/images/products/", 976, 18, true);
#nullable restore
#line 28 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 994, Model.ThumbImg, 994, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 1016, Model.Title, 1016, 12, false);

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
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <!-- /Product thumb imgs -->
            <!-- Product details -->
            <div class=""col-md-5"">
                <div class=""product-details"">
                    <h2 class=""product-name"">");
#nullable restore
#line 36 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                                        Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <div>
                        <div class=""product-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <a class=""review-link"" href=""#"">10 Review(s) | Add your review</a>
                    </div>
                    <div>
                        <h3 class=""product-price"">");
#nullable restore
#line 48 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                                             Write(Model.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</h3>\r\n\r\n");
#nullable restore
#line 50 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                         if (Model.IsActived && Model.UnitInStock > 0)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">In Stock</span>\r\n");
#nullable restore
#line 55 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"product-available\">Out Stock</span>\r\n");
#nullable restore
#line 59 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <p>");
#nullable restore
#line 61 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                  Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""add-to-cart"">
                        <div class=""qty-label"">
                            Qty
                            <div class=""input-number"">
                                <input id=""txtsoluong"" name=""txtsoluong"" type=""number"" value=""1"">
                                <span class=""qty-up"">+</span>
                                <span class=""qty-down"">-</span>
                            </div>
                        </div>
                        <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f713599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 72 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n");
            WriteLiteral("\r\n                    <ul class=\"product-links\">\r\n                        <li>Category:</li>\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 3508, "\"", 3520, 1);
#nullable restore
#line 82 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
WriteAttributeValue("", 3515, url1, 3515, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                                       Write(Model.Cate.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                    </ul>

                    <ul class=""product-links"">
                        <li>Share:</li>
                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""#""><i class=""fa fa-envelope""></i></a></li>
                    </ul>

                </div>
            </div>
            <!-- /Product details -->
            <!-- Product tab -->
            <div class=""col-md-12"">
                <div id=""product-tab"">
                    <!-- product tab nav -->
                    <ul class=""tab-nav"">
                        <li class=""active""><a data-toggle=""tab"" href=""#tab1"">Description</a></li>
                    </ul>
                    <!-- /product tab nav -->
                    <!-- product tab content -->
                    <div class=""tab");
            WriteLiteral(@"-content"">
                        <!-- tab1  -->
                        <div id=""tab1"" class=""tab-pane fade in active"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <p>");
#nullable restore
#line 110 "C:\Users\Administrator\Downloads\EShop\EShop\Views\Products\Details.cshtml"
                                  Write(Html.Raw(Model.Descriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <!-- /tab1  -->
                    </div>
                    <!-- /product tab content  -->
                </div>
            </div>
            <!-- /product tab -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /SECTION -->
<!-- RelateProduct Section -->
<div class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">

            <div class=""col-md-12"">
                <div class=""section-title text-center"">
                    <h3 class=""title"">Related Products</h3>
                </div>
            </div>

            <!-- product -->
            <div class=""col-md-3 col-xs-6"">
                <div class=""product"">
                    <div class=""product-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f718648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""product-label"">
                            <span class=""sale"">-30%</span>
                        </div>
                    </div>
                    <div class=""product-body"">
                        <p class=""product-category"">Category</p>
                        <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                        <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
                        <div class=""product-rating"">
                        </div>
                        <div class=""product-btns"">
                            <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                            <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                            <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">qu");
            WriteLiteral(@"ick view</span></button>
                        </div>
                    </div>
                    <div class=""add-to-cart"">
                        <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                    </div>
                </div>
            </div>
            <!-- /product -->
            <!-- product -->
            <div class=""col-md-3 col-xs-6"">
                <div class=""product"">
                    <div class=""product-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f721401", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""product-label"">
                            <span class=""new"">NEW</span>
                        </div>
                    </div>
                    <div class=""product-body"">
                        <p class=""product-category"">Category</p>
                        <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                        <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
                        <div class=""product-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                        </div>
                        <div class=""product-btns"">
                            <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add ");
            WriteLiteral(@"to wishlist</span></button>
                            <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                            <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
                        </div>
                    </div>
                    <div class=""add-to-cart"">
                        <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                    </div>
                </div>
            </div>
            <!-- /product -->

            <div class=""clearfix visible-sm visible-xs""></div>

            <!-- product -->
            <div class=""col-md-3 col-xs-6"">
                <div class=""product"">
                    <div class=""product-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f724512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""product-body"">
                        <p class=""product-category"">Category</p>
                        <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                        <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
                        <div class=""product-rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-o""></i>
                        </div>
                        <div class=""product-btns"">
                            <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                            <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">");
            WriteLiteral(@"add to compare</span></button>
                            <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
                        </div>
                    </div>
                    <div class=""add-to-cart"">
                        <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                    </div>
                </div>
            </div>
            <!-- /product -->
            <!-- product -->
            <div class=""col-md-3 col-xs-6"">
                <div class=""product"">
                    <div class=""product-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa6051790d9fcbf5dd35ff82390b01d5d13fe3f727408", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""product-body"">
                        <p class=""product-category"">Category</p>
                        <h3 class=""product-name""><a href=""#"">product name goes here</a></h3>
                        <h4 class=""product-price"">$980.00 <del class=""product-old-price"">$990.00</del></h4>
                        <div class=""product-rating"">
                        </div>
                        <div class=""product-btns"">
                            <button class=""add-to-wishlist""><i class=""fa fa-heart-o""></i><span class=""tooltipp"">add to wishlist</span></button>
                            <button class=""add-to-compare""><i class=""fa fa-exchange""></i><span class=""tooltipp"">add to compare</span></button>
                            <button class=""quick-view""><i class=""fa fa-eye""></i><span class=""tooltipp"">quick view</span></button>
                        </div>
                    </div>
                    <div class=""add-to-cart"">
            ");
            WriteLiteral(@"            <button class=""add-to-cart-btn""><i class=""fa fa-shopping-cart""></i> add to cart</button>
                    </div>
                </div>
            </div>
            <!-- /product -->

        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- End RelateProduct Section -->
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(function () {
                $("".add-to-cart-btn"").click(function () {
                    var productID = $('#ProductId').val();
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
                WriteLiteral(@"           var productID = $(this).attr(""data-mahh"");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
