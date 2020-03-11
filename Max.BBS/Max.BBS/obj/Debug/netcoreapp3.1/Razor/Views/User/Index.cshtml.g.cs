#pragma checksum "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d33d1e0728904fa02a48c1a26b21546697456fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\max\core\Max.BBS\Max.BBS\Views\_ViewImports.cshtml"
using Max.MBBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\core\Max.BBS\Max.BBS\Views\_ViewImports.cshtml"
using Max.ApplicationCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\core\Max.BBS\Max.BBS\Views\_ViewImports.cshtml"
using Max.MBBS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\core\Max.BBS\Max.BBS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d33d1e0728904fa02a48c1a26b21546697456fa", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf60736b7b948b12018fa8a18459f1116c9909f2", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
  
    ViewData["Title"] = "个人主页";
    var topics = ViewBag.Topics as List<Topic>;
    var replys = ViewBag.Replys as List<TopicReply>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""main"" style=""margin-top:20px;"">
    <div class=""row"">
        <div class=""sidebar col-md-4"" id=""sidebar"">
            <div class=""panel profile panel-default"">
                <div class=""panel-body"">
                    <div class=""media"">
                        <div class=""avatar media-left"">
                            <div class=""image""><img class=""media-object avatar-96""");
            BeginWriteAttribute("src", " src=\"", 553, "\"", 626, 1);
#nullable restore
#line 15 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 559, string.IsNullOrEmpty(Model.Avatar)?"/images/96.png":Model.Avatar, 559, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                        </div>\r\n                        <div class=\"media-body\">\r\n                            <div class=\"item\">\r\n                                ");
#nullable restore
#line 19 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <span class=""opts pull-right"">
                                </span>
                            </div>
                            <div class=""item number"">
                                第 i 位会员 / <span title=""注册日期"">");
#nullable restore
#line 24 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                        Write(Model.CreateOn.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"item counts\">\r\n                                <span>");
#nullable restore
#line 27 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                 Write(Model.TopicCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> 篇帖子 • <span>");
#nullable restore
#line 27 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                                      Write(Model.TopicReplyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> 条回帖
                            </div>
                            <div class=""item social"">

                                <a target=""_blank"" rel=""nofollow"" href=""#""><i class=""glyphicon glyphicon-link""></i></a>


                                <a href=""#""><i class=""fa fa-envelope-o""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class=""panel panel-default"" id=""user_github_repos"">
                <div class=""panel-body"">
                    未设置 GitHub 信息.
                </div>
            </div>

        </div>
        <div class=""col-md-8"">
            <div class=""tabbable"">
                <ul class=""nav nav-tabs"">
                    <li class=""active""><a href=""#topics"" data-toggle=""tab"">热门话题</a></li>
                    <li><a href=""#replies"" data-toggle=""tab"">最近回帖</a></li>
                    <li><a href=""#description"" data-toggle=""tab"">个人介绍</a></li>
");
            WriteLiteral("                </ul>\r\n                <div class=\"tab-content\">\r\n                    <div class=\"tab-pane active recent-topics\" id=\"topics\">\r\n                        <div class=\"panel panel-default\">\r\n                            <ul class=\"list-group\">\r\n");
#nullable restore
#line 60 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                 foreach (var item in topics)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    <div class=\"title\">\r\n                                        <a class=\"node\"");
            BeginWriteAttribute("href", " href=\"", 2858, "\"", 2884, 2);
            WriteAttributeValue("", 2865, "/topic/", 2865, 7, true);
#nullable restore
#line 64 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 2872, item.NodeId, 2872, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                                              Write(item.Node.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <a");
            BeginWriteAttribute("title", " title=\"", 2949, "\"", 2968, 1);
#nullable restore
#line 65 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 2957, item.Title, 2957, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2969, "\"", 2991, 2);
            WriteAttributeValue("", 2976, "/topic/", 2976, 7, true);
#nullable restore
#line 65 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 2983, item.Id, 2983, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </div>\r\n                                    <div class=\"info\">\r\n                                        <span class=\"counter\">");
#nullable restore
#line 68 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                         Write(item.ReplyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 条回复</span>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 71 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                    <div class=""tab-pane recent-replies"" id=""replies"">
                        <div class=""panel panel-default"">
                            <ul class=""list-group"">
");
#nullable restore
#line 78 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                 foreach (var item in replys)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\">\r\n                                        <div class=\"title\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3869, "\"", 3896, 2);
            WriteAttributeValue("", 3876, "/topic/", 3876, 7, true);
#nullable restore
#line 82 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 3883, item.TopicId, 3883, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                                      Write(item.ReplyContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <span class=\"info\">at <abbr class=\"timeago\"");
            BeginWriteAttribute("title", " title=\"", 4009, "\"", 4054, 1);
#nullable restore
#line 83 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
WriteAttributeValue("", 4017, item.CreateOn.ToString("yyyy-MM-dd"), 4017, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                                                                                                                  Write(DateTime.Now.Subtract(item.CreateOn).Days);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 天前</abbr></span>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 86 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"tab-pane\" id=\"description\">\r\n                        <div class=\"panel panel-default\">\r\n                            ");
#nullable restore
#line 92 "D:\max\core\Max.BBS\Max.BBS\Views\User\Index.cshtml"
                       Write(Model.Profile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591