#pragma checksum "D:\.Net\Eng.Rahim-Ghasemi\Exercise\S19\Flight\Views\Home\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840cebb05dbc5990c9c9f15faf926477082ebf7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payment), @"mvc.1.0.view", @"/Views/Home/Payment.cshtml")]
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
#line 1 "D:\.Net\Eng.Rahim-Ghasemi\Exercise\S19\Flight\Views\_ViewImports.cshtml"
using Flight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net\Eng.Rahim-Ghasemi\Exercise\S19\Flight\Views\_ViewImports.cshtml"
using Flight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840cebb05dbc5990c9c9f15faf926477082ebf7c", @"/Views/Home/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33cc5e31a71d7e1870d9a722a1dca6b3aec3ff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n\r\n\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840cebb05dbc5990c9c9f15faf926477082ebf7c5015", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
    <link href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.0.3/css/font-awesome.css"">
    <!--Bootsrap 4 CDN-->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css""
        integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">

    <!--Fontawesome CDN-->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css""
        integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/");
                WriteLiteral("3.2.1/jquery.min.js\"></script>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "840cebb05dbc5990c9c9f15faf926477082ebf7c6407", async() => {
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
                WriteLiteral("\r\n    <title>Document</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840cebb05dbc5990c9c9f15faf926477082ebf7c8325", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840cebb05dbc5990c9c9f15faf926477082ebf7c8587", async() => {
                    WriteLiteral(@"
        <div class=""container-fluid"">
            <div class=""row justify-content-center"">
                <div class=""col-12 col-lg-11"">
                    <div class=""card card0 rounded-0"">
                        <div class=""row"">
                            <div class=""col-md-5 d-md-block d-none p-0 box"">
                                <div class=""card rounded-0 border-0 card1"" id=""bill"">
                                    <h3 id=""heading1"">Flight Info</h3>
                                    <div class=""row"">
                                        <div class=""col-lg-7 col-8 mt-4 line pl-4"">
                                            <small class=""bill-date"">AirLine :
                                                </small>
                                            <h2 class=""bill-head"">???</h2> 
                                        </div>
                                        <div class=""col-lg-5 col-4 mt-4"">
                                            <h2 class=""bill-head px");
                    WriteLiteral(@"-xl-5 px-lg-4"">CAF</h2>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                       <div class=""col-lg-7 col-8 mt-4 line pl-4"">
                                            <small class=""bill-date"">From :
                                                </small>
                                            <h2 class=""bill-head"">???</h2> 
                                        </div>
                                        <div class=""col-lg-5 col-4 mt-4"">
                                            <h2 class=""bill-head px-xl-5 px-lg-4"">JFK</h2>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-7 col-8 mt-4 line pl-4"">
                                            <small class=""bill-date"">To :
                                  ");
                    WriteLiteral(@"              </small>
                                            <h2 class=""bill-head"">???</h2> 
                                        </div>
                                        <div class=""col-lg-5 col-4 mt-4"">
                                            <h2 class=""bill-head px-xl-5 px-lg-4"">LHR</h2>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-7 col-8 mt-4 line pl-4"">
                                            <small class=""bill-date"">DateTime :
                                                </small>
                                            <h2 class=""bill-head"">???</h2> 
                                        </div>
                                        <div class=""col-lg-5 col-4 mt-4"">
                                            <h2 class=""bill-head px-xl-5 px-lg-4"">JFK</h2>
                                        </div");
                    WriteLiteral(@">
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-12 red-bg"">
                                            <p class=""bill-date"" id=""total-label"">Total Price</p>
                                            <h2 class=""bill-head"" id=""total"">$ 523.65</h2> <small class=""bill-date""
                                                id=""total-label"">Price includes all taxes</small>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-7 col-sm-12 p-0 box"">
                                <div class=""card rounded-0 border-0 card2"" id=""paypage"">
                                    <div class=""form-card"">
                                        <h2 id=""heading2"" class=""text-danger"">Payment Method</h2>
                                        <div cl");
                    WriteLiteral(@"ass=""radio-group"">
                                            <div class='radio' data-value=""credit""><img
                                                    src=""https://i.imgur.com/28akQFX.jpg"" width=""200px"" height=""60px"">
                                            </div>
                                            <div class='radio' data-value=""paypal""><img
                                                    src=""https://i.imgur.com/5QFsx7K.jpg"" width=""200px"" height=""60px"">
                                            </div>
                                            <br>
                                        </div> <label class=""pay"">Name on Card</label> <input type=""text""
                                            name=""holdername"" placeholder=""John Smith"">
                                        <div class=""row"">
                                            <div class=""col-8 col-md-6""> <label class=""pay"">Card Number</label> <input
                                                    type=");
                    WriteLiteral(@"""text"" name=""cardno"" id=""cr_no""
                                                    placeholder=""0000-0000-0000-0000"" minlength=""19"" maxlength=""19"">
                                            </div>
                                            <div class=""col-4 col-md-6""> <label class=""pay"">CVV</label> <input
                                                    type=""password"" name=""cvcpwd"" placeholder=""&#9679;&#9679;&#9679;""
                                                    class=""placeicon"" minlength=""3"" maxlength=""3""> </div>
                                        </div>
                                        <div class=""row"">
                                            <div class=""col-md-12""> <label class=""pay"">Expiration Date</label> </div>
                                            <div class=""col-md-12""> <input type=""text"" name=""exp"" id=""exp""
                                                    placeholder=""MM/YY"" minlength=""5"" maxlength=""5""> </div>
                                        ");
                    WriteLiteral(@"</div>
                                        <div class=""row"">
                                            <div class=""col-md-6""> <input type=""submit""
                                                    value=""MAKE A PAYMENT &nbsp; &#xf178;""
                                                    class=""btn btn-info placeicon"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
