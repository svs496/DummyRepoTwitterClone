#pragma checksum "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6613c90549c7212ea24808dd092c23d9f9c929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserFollowers__ManageFollowers), @"mvc.1.0.view", @"/Views/UserFollowers/_ManageFollowers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserFollowers/_ManageFollowers.cshtml", typeof(AspNetCore.Views_UserFollowers__ManageFollowers))]
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
#line 1 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\_ViewImports.cshtml"
using TwitterClone.Core;

#line default
#line hidden
#line 2 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\_ViewImports.cshtml"
using TwitterClone.Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6613c90549c7212ea24808dd092c23d9f9c929", @"/Views/UserFollowers/_ManageFollowers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9a8a8dccf8856e72cfe1a5c4ff4824f3adc942", @"/Views/_ViewImports.cshtml")]
    public class Views_UserFollowers__ManageFollowers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TwitterClone.Core.Models.ViewModels.UserTweetViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ThumbsUp.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;height:50px; float:left;margin-right:1px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ThumbsDown.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ajax-unobtrusive/dist/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(76, 30, true);
            WriteLiteral("\r\n\r\n<div class=\"card-group\">\r\n");
            EndContext();
#line 5 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(147, 284, true);
            WriteLiteral(@"        <div class=""Grid-cell panel panel-primary"" style=""margin-top:5px; margin-left:5px; width:300px"">
            <div class=""card border-success mb-3"">
                <div class=""card-header  border-primary"">
                    <div style=""display:flex;align-items:center"">
");
            EndContext();
#line 11 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                         if (item.FollowFlag)
                        {

#line default
#line hidden
            BeginContext(505, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(533, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e6613c90549c7212ea24808dd092c23d9f9c9296440", async() => {
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
            EndContext();
            BeginContext(629, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(715, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(743, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e6613c90549c7212ea24808dd092c23d9f9c9298075", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(841, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                        }

#line default
#line hidden
            BeginContext(870, 128, true);
            WriteLiteral("                        <h4 style=\"font-size:large; font-family:Calibri;color:indigo;vertical-align:middle; font-weight:bolder\">");
            EndContext();
            BeginContext(999, 17, false);
#line 19 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                                                                           Write(item.UserFullName);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 289, true);
            WriteLiteral(@"</h4>
                    </div>

                </div>
                <div class=""card-body text-danger"">

                    <div class=""memberBioStats"">
                        <div>
                            <strong>Location</strong>   <p class=""card-text memberLineItem"">");
            EndContext();
            BeginContext(1306, 17, false);
#line 27 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                                       Write(item.UserLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1323, 160, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div>\r\n                            <strong>BirthDay</strong>  <p class=\"card-text memberLineItem\">");
            EndContext();
            BeginContext(1484, 17, false);
#line 30 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                                      Write(item.UserBirthDay);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 244, true);
            WriteLiteral("</p>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"memberBioStats\">\r\n                        <div>\r\n                            <strong>Tweet Count</strong>   <p class=\"card-text memberLineItem\">");
            EndContext();
            BeginContext(1746, 20, false);
#line 36 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                                          Write(item.TotalTweetCount);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 162, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div>\r\n                            <strong>Followers</strong>   <p class=\"card-text memberLineItem\">");
            EndContext();
            BeginContext(1929, 19, false);
#line 39 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                                        Write(item.FollowersCount);

#line default
#line hidden
            EndContext();
            BeginContext(1948, 135, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"card-footer\">\r\n");
            EndContext();
#line 45 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                     if (item.FollowFlag)
                    {

#line default
#line hidden
            BeginContext(2149, 159, true);
            WriteLiteral("                        <a class=\"EdgeButton EdgeButton--danger EdgeButton--small\"\r\n                           onclick=\'UnFollowUser(this)\' data-followingusr=\"");
            EndContext();
            BeginContext(2309, 11, false);
#line 48 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                      Write(item.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(2320, 66, true);
            WriteLiteral("\"><i class=\"fas fa-user-minus\"></i>&nbsp;&nbsp;UnFollow User</a>\r\n");
            EndContext();
#line 49 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2458, 192, true);
            WriteLiteral("                        <a class=\"EdgeButton EdgeButton--primary EdgeButton--small\" style=\"background-color:darkcyan\"\r\n                           onclick=\"FollowUser(this)\" data-followingusr=\"");
            EndContext();
            BeginContext(2651, 11, false);
#line 53 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                                                                    Write(item.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(2662, 63, true);
            WriteLiteral("\"><i class=\"fas fa-user-plus\"></i>&nbsp;&nbsp;Follow User</a>\r\n");
            EndContext();
#line 54 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
                    }

#line default
#line hidden
            BeginContext(2748, 60, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 58 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserFollowers\_ManageFollowers.cshtml"
    }

#line default
#line hidden
            BeginContext(2815, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2829, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e6613c90549c7212ea24808dd092c23d9f9c92915862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2918, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2920, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e6613c90549c7212ea24808dd092c23d9f9c92917042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3014, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TwitterClone.Core.Models.ViewModels.UserTweetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
