#pragma checksum "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "606174e3f10635acfe9b847a1be3e8a0afdf5b90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PostedTweets_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PostedTweets/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/PostedTweets/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_PostedTweets_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"606174e3f10635acfe9b847a1be3e8a0afdf5b90", @"/Views/Shared/Components/PostedTweets/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9a8a8dccf8856e72cfe1a5c4ff4824f3adc942", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PostedTweets_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TwitterClone.Core.Models.ViewModels.TweetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            BeginContext(111, 169, true);
            WriteLiteral("    <div class=\"Grid-cell panel panel-primary\" style=\"margin-top:5px; width:720px\">\r\n        <div class=\"card\">\r\n            <h4 class=\"card-header\">Posted&nbsp;by&nbsp;");
            EndContext();
            BeginContext(281, 13, false);
#line 9 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
                                                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(294, 14, true);
            WriteLiteral("&nbsp;on&nbsp;");
            EndContext();
            BeginContext(309, 22, false);
#line 9 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
                                                                               Write(item.DisplayCreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(331, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 10 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
             if (item.DisplayModifedDate != null)
            {

#line default
#line hidden
            BeginContext(404, 61, true);
            WriteLiteral("                <h5 class=\"card-header\">Modifed&nbsp;at&nbsp;");
            EndContext();
            BeginContext(466, 23, false);
#line 12 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
                                                        Write(item.DisplayModifedDate);

#line default
#line hidden
            EndContext();
            BeginContext(489, 7, true);
            WriteLiteral("</h5>\r\n");
            EndContext();
#line 13 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(511, 76, true);
            WriteLiteral("            <div class=\"card-body\">\r\n\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(588, 12, false);
#line 16 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
                                Write(item.Content);

#line default
#line hidden
            EndContext();
            BeginContext(600, 266, true);
            WriteLiteral(@"</p>

                <div style=""margin-top:10px;text-align:right"">
                    <a href=""#"" class=""card-link"">Edit</a>
                    <a href=""#"" class=""card-link"">Delete</a>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 25 "C:\Users\sbhatia\Desktop\desktop items\1.FSE\Assignment 20-Twitter\TwitterClone.Core\Views\Shared\Components\PostedTweets\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TwitterClone.Core.Models.ViewModels.TweetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
