#pragma checksum "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b093e4ac13ce13ecd1a97db3b345677041fe7d7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserTweet_DisplayTweet), @"mvc.1.0.view", @"/Views/UserTweet/DisplayTweet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserTweet/DisplayTweet.cshtml", typeof(AspNetCore.Views_UserTweet_DisplayTweet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b093e4ac13ce13ecd1a97db3b345677041fe7d7d", @"/Views/UserTweet/DisplayTweet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9a8a8dccf8856e72cfe1a5c4ff4824f3adc942", @"/Views/_ViewImports.cshtml")]
    public class Views_UserTweet_DisplayTweet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwitterClone.Core.Models.ViewModels.UserTweetViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserFollowers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:seagreen"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("EdgeButton EdgeButton--primary EdgeButton--small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tweetMessage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
  
    ViewData["Title"] = "Tweets";

#line default
#line hidden
            BeginContext(107, 2427, true);
            WriteLiteral(@"


<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""deleteModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""deleteModalLabel"">Delete tweet</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are you sure you want to delete this tweet?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""EdgeButton EdgeButton--tertiary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""EdgeButton EdgeButton--danger"" id=""btnContinueDelete""><i class=""fa fa-trash""> Delete</i></button>
            </div>
        </div>
    </div>
</div>


<div c");
            WriteLiteral(@"lass=""modal fade"" id=""EditTweetModal"" role=""dialog"">
    <div class=""modal-dialog "">
        <div class=""modal-content"">
            <div class=""modal-header"">
                
                <h4 class=""modal-title"">Edit tweet</h4>
            </div>
            <div class=""modal-body"" id=""EditTweetModalContent"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>




<div class=""ProfileCanopy-navBar u-boxShadow"" style=""align-items:center"">
    <div class=""Grid Grid--withGutter"">
        <div class=""Grid-cell u-size2of3 u-lg-size3of4"">
            <div class=""ProfileCanopy-nav"">
                <div class=""ProfileNav"" role=""navigation"" data-user-id=""783214"">
                    <ul class=""ProfileNav-list"" style=""text-align:center"">
                        <li class=""ProfileNav-item ProfileNav-item--tweets is-active"">
            ");
            WriteLiteral(@"                <a class=""ProfileNav-stat ProfileNav-stat--link u-borderUserColor u-textCenter js-tooltip js-nav"" data-nav=""tweets""
                               tabindex=0>
                                <span class=""ProfileNav-label"">Tweets</span>
                                <span class=""ProfileNav-value"" id=""TweetCountWrapper"">
                                    ");
            EndContext();
            BeginContext(2536, 57, false);
#line 60 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                Write(ViewBag.OwnTweetCount == null ? 0 : ViewBag.OwnTweetCount);

#line default
#line hidden
            EndContext();
            BeginContext(2594, 620, true);
            WriteLiteral(@"
                                </span>
                            </a>
                        </li>
                        <li class=""ProfileNav-item ProfileNav-item--following"">
                            <a class=""ProfileNav-stat ProfileNav-stat--link u-borderUserColor u-textCenter js-tooltip js-openSignupDialog js-nonNavigable u-textUserColor""
                               title=""162 Following"" data-nav=""following"">
                                <span class=""ProfileNav-label"">Following</span>
                                <span class=""ProfileNav-value"" data-count=162 data-is-compact=""false"">");
            EndContext();
            BeginContext(3215, 46, false);
#line 68 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.FollowingCount));

#line default
#line hidden
            EndContext();
            BeginContext(3261, 597, true);
            WriteLiteral(@"</span>
                            </a>
                        </li>
                        <li class=""ProfileNav-item ProfileNav-item--followers"">
                            <a class=""ProfileNav-stat ProfileNav-stat--link u-borderUserColor u-textCenter js-tooltip js-openSignupDialog js-nonNavigable u-textUserColor""
                               title=""60,604,994 Followers"" data-nav=""followers"">
                                <span class=""ProfileNav-label"">Followers</span>
                                <span class=""ProfileNav-value"" data-count=60604994 data-is-compact=""true"">");
            EndContext();
            BeginContext(3859, 46, false);
#line 75 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.FollowersCount));

#line default
#line hidden
            EndContext();
            BeginContext(3905, 301, true);
            WriteLiteral(@"</span>
                            </a>
                        </li>
                        <li class=""ProfileNav-item ProfileNav-item--userActions u-floatRight u-textRight with-rightCaret "">

                            <span class=""button-text follow-text"">
                                ");
            EndContext();
            BeginContext(4206, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b093e4ac13ce13ecd1a97db3b345677041fe7d7d12288", async() => {
                BeginContext(4399, 47, true);
                WriteLiteral("<i class=\"fas fa-user-plus\"></i>&nbsp;Followers");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4450, 635, true);
            WriteLiteral(@"
                            </span>

                        </li>


                    </ul>

                </div>

            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""column"" style=""width:20%"">
        <div class=""ProfileSidebar ProfileSidebar--withLeftAlignment"">
            <div class=""ProfileHeaderCard"">
                <h1 class=""ProfileHeaderCard-name"">
                    <a href=""/Twitter""
                       class=""ProfileHeaderCard-nameLink u-textInheritColor js-nav"">
                        Welcome&nbsp;
                        <span id=""userFullName"">");
            EndContext();
            BeginContext(5086, 44, false);
#line 105 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                           Write(Html.DisplayFor(model => model.UserFullName));

#line default
#line hidden
            EndContext();
            BeginContext(5130, 637, true);
            WriteLiteral(@"</span>
                    </a>
                    <span class=""ProfileHeaderCard-badges"">
                        <a href=""/help/verified"" class=""js-tooltip"" target=""_blank"" title=""Verified account"" data-placement=""right"" rel=""noopener"">
                            <i class=""fas fa-user-cog""></i>
                        </a>
                    </span>
                </h1>
                <h2 class=""ProfileHeaderCard-screenname u-inlineBlock u-dir"" dir=""ltr"">
                    <a class=""ProfileHeaderCard-screennameLink u-linkComplex js-nav"" href=""/Twitter"">
                        <span class=""username"" dir=""ltr"">");
            EndContext();
            BeginContext(5768, 33, true);
            WriteLiteral("@<b class=\"u-linkComplex-target\">");
            EndContext();
            BeginContext(5802, 45, false);
#line 115 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.TwitterHandle));

#line default
#line hidden
            EndContext();
            BeginContext(5847, 287, true);
            WriteLiteral(@"</b></span>
                    </a>
                </h2>
                <div class=""ProfileHeaderCard-location "">
                    <i class=""fas fa-map-marker-alt""></i>
                    <span class=""ProfileHeaderCard-locationText u-dir"" dir=""ltr"">
                        ");
            EndContext();
            BeginContext(6135, 44, false);
#line 121 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                   Write(Html.DisplayFor(model => model.UserLocation));

#line default
#line hidden
            EndContext();
            BeginContext(6179, 271, true);
            WriteLiteral(@"

                    </span>
                </div>
                <div class=""ProfileHeaderCard-joinDate"">
                    <i class=""far fa-calendar-alt""></i>
                    <span class=""ProfileHeaderCard-joinDateText js-tooltip u-dir"" dir=""ltr"">Joined ");
            EndContext();
            BeginContext(6451, 55, false);
#line 127 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                                                                                              Write(Html.DisplayFor(model => model.UserAccountCreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(6506, 331, true);
            WriteLiteral(@"</span>
                </div>

                <div class=""ProfileHeaderCard-birthdate "">
                    <i class=""fas fa-birthday-cake""></i>
                    <span class=""ProfileHeaderCard-birthdateText u-dir"" dir=""ltr"">
                        <span class=""js-tooltip"" title=""Public"">
                            ");
            EndContext();
            BeginContext(6838, 44, false);
#line 134 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                       Write(Html.DisplayFor(model => model.UserBirthDay));

#line default
#line hidden
            EndContext();
            BeginContext(6882, 357, true);
            WriteLiteral(@"
                        </span>
                    </span>
                </div>
            </div>
        </div>

    </div>
    <div class=""column"" style=""width:55%;margin-top:10px"">
        <span class=""text-danger TweetTextSize--jumbo font-weight-bold font-italic"">Compose new Tweet</span>
        <div id=""ajaxPostNewTweet"">
            ");
            EndContext();
            BeginContext(7240, 54, false);
#line 145 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
       Write(await Html.PartialAsync("_CreateTweet", Model.TweetVM));

#line default
#line hidden
            EndContext();
            BeginContext(7294, 69, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div id=\"divPartialTweets\">\r\n            ");
            EndContext();
            BeginContext(7364, 57, false);
#line 149 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
       Write(await Html.PartialAsync("_PostedTweets", Model.OwnTweets));

#line default
#line hidden
            EndContext();
            BeginContext(7421, 107, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"column\" style=\"width:20%;margin-top:10px; text-align:left\">\r\n");
            EndContext();
            BeginContext(7639, 235, true);
            WriteLiteral("        <ul class=\"list-group\" id=\"messagesList\">\r\n            <li class=\"list-group-item list-group-item-action flex-column align-items-start active list-group-item-info\">Real time updates</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7892, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7898, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b093e4ac13ce13ecd1a97db3b345677041fe7d7d20808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7942, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7948, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b093e4ac13ce13ecd1a97db3b345677041fe7d7d22145", async() => {
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
                EndContext();
                BeginContext(8013, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8019, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b093e4ac13ce13ecd1a97db3b345677041fe7d7d23401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8063, 1153, true);
                WriteLiteral(@"
    <script>

        $('#field').keyup(function () {
            var max = 140;
            var len = $(this).val().length;
            if (len >= max) {
                $('#charNum').text('you have reached the limit');
            } else {
                var char = max - len;
                $('#charNum').text(char + ' characters left');
            }
        });

        $('#field2').keyup(function () {
            debugger;
            var max = 140;
            var len = $(this).val().length;
            if (len >= max) {
                $('#charNum2').text('you have reached the limit');
            } else {
                var char = max - len;
                $('#charNum2').text(char + ' characters left');
            }
        });


        var deleteTweetId;
        $('#deleteModal').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);// Button that triggered the modal
            deleteTweetId = button.data('whatever'); // Extract in");
                WriteLiteral("fo from data-* attributes\r\n        });\r\n\r\n        $(\'#btnContinueDelete\').click(function (event) {\r\n            var targeturl = \'");
                EndContext();
                BeginContext(9217, 33, false);
#line 198 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                        Write(Url.Action("Delete", "UserTweet"));

#line default
#line hidden
                EndContext();
                BeginContext(9250, 1806, true);
                WriteLiteral(@"?id=' + deleteTweetId;
            $.ajax({
                url:  targeturl ,
                type: 'POST',
                contentType: ""application/json; charset=utf-8"",
                //datatype: 'json',
                success: function (response) {
                    if (response.success) {
                        AjaxCallsForPostedTweets();
                        toastr.success('Success ! Delete successful.');
                    }
                    else {
                        toastr.error('Error ! Delete operation failed.');
                    }

                    $(""#deleteModal"").modal(""hide"");
                },
                error: function (response) {
                    toastr.error('Error ! Delete operation failed.');
                }
            });

        });

      
        var onComplete = function ($xhr) {
            if ($xhr.responseJSON.success) {
               
                AjaxCallsForPostedTweets();
                $('#field').val('');");
                WriteLiteral(@"
                $('#charNum').html('*140 characters left');
                toastr.success('Congrats ! You added new tweet.');
               

            }
            else {
                toastr.error('Error during Insert');
            }

        }; // End

        var onCompleteEdit = function ($xhr) {
            if ($xhr.responseJSON.success) {
               
                toastr.success('Congrats ! Tweet is updated successfully..');
                AjaxCallsForPostedTweets();
                $(""#EditTweetModal"").modal(""hide"");
            }
            else {
               toastr.error('Error in update');
            }

        }; // End



        function AjaxCallsForPostedTweets() {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(11057, 26, false);
#line 256 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                 Write(Url.Action("PostedTweets"));

#line default
#line hidden
                EndContext();
                BeginContext(11083, 213, true);
                WriteLiteral("\',\r\n                type: \'GET\',\r\n                cache: false\r\n            }).done(function (result) {\r\n                $(\'#divPartialTweets\').html(result);\r\n\r\n                $.ajax({\r\n                    url: \'");
                EndContext();
                BeginContext(11297, 27, false);
#line 263 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                     Write(Url.Action("GetTweetCount"));

#line default
#line hidden
                EndContext();
                BeginContext(11324, 424, true);
                WriteLiteral(@"',
                    type: 'GET',
                    dataType: ""json"",
                    cache: false
                }).done(function (result) {
                    console.log(result);
                    $('#TweetCountWrapper').html(result);
                });
            });
        }


        var FunctionEditTweet = function (id) {
            window.toastr.clear();
            var targeturl = '");
                EndContext();
                BeginContext(11749, 36, false);
#line 277 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\UserTweet\DisplayTweet.cshtml"
                        Write(Url.Action("ModalEdit", "UserTweet"));

#line default
#line hidden
                EndContext();
                BeginContext(11785, 1676, true);
                WriteLiteral(@"?id=' + id;
            $(""#EditTweetModalContent"").load(targeturl, function () {
                $(""#EditTweetModal"").modal(""show"");
            })
        };
  

        //$(function () {
        //    $(""a[data-modal=editTweets]"").on(""click"", function () {
        //        $(""#EditTweetModalContent"").load(this.href, function () {
        //            $(""#EditTweetModal"").modal({ keyboard: true }, ""show"");

        //            $(""#EditTweetForm"").submit(function () {
        //                if ($(""#EditTweetForm"").valid()) {
        //                    $.ajax({
        //                        url: this.action,
        //                        type: this.method,
        //                        data: $(this).serialize(),
        //                        success: function (result) {
        //                            if (result.success) {
        //                                $(""#EditTweetModal"").modal(""hide"");
        //                                location.reload(");
                WriteLiteral(@"true);
        //                            } else {
        //                               toastr.error(""The data was not updated."");
        //                            }
        //                        },
        //                        error: function () {
        //                            toastr.error(""The web server had an error."");
        //                        }
        //                    });
        //                    return false;
        //                }
        //            });
        //        });
        //        return false;
        //    });
        //});

     

    </script>

");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwitterClone.Core.Models.ViewModels.UserTweetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
