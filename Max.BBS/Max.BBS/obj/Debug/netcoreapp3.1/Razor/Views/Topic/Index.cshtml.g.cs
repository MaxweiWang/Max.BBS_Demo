#pragma checksum "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42764c61559f42dd0907d5262fe7e99b7181e7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topic_Index), @"mvc.1.0.view", @"/Views/Topic/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42764c61559f42dd0907d5262fe7e99b7181e7dc", @"/Views/Topic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf60736b7b948b12018fa8a18459f1116c9909f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Topic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Topic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
  
    ViewData["Title"] = Model.Title;
    var list = ViewBag.Replys as List<TopicReply>;
    var user = await services.User;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-9"" style=""margin-top:20px;"">
        <div class=""topic-detail panel panel-default"">
            <div class=""panel-heading media clearfix"">
                <div class=""media-body"">
                    <h1 class=""media-heading"">");
#nullable restore
#line 13 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                          Write(Model.Top == 1 ? "[置顶]" : "");

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                                                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <div class=\"info\">\r\n                        <a class=\"node\"");
            BeginWriteAttribute("href", " href=\"", 580, "\"", 613, 2);
            WriteAttributeValue("", 587, "/topic/node/", 587, 12, true);
#nullable restore
#line 15 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 599, Model.Node.Id, 599, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                                                     Write(Model.Node.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ·\r\n                        <a href=\"#\">");
#nullable restore
#line 17 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                               Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ·\r\n                        于 <abbr class=\"timeago\">");
#nullable restore
#line 19 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                           Write(Model.CreateOn.ToString("MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</abbr>发布\r\n                        ·\r\n                        ");
#nullable restore
#line 21 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                   Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 次阅读\r\n                    </div>\r\n                </div>\r\n                <div class=\"media-right\">\r\n                    <a href=\"#\"><img class=\"media-object avatar-48\"");
            BeginWriteAttribute("src", " src=\"", 1086, "\"", 1170, 1);
#nullable restore
#line 25 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 1092, string.IsNullOrEmpty(Model.User.Avatar)?"/images/96.png": Model.User.Avatar, 1092, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"panel-body markdown\">\r\n                <p id=\"content\">");
#nullable restore
#line 29 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                           Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <p class=\"panel-info\">共收到 ");
#nullable restore
#line 34 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                     Write(list.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 条回复：</p>\r\n            </div>\r\n            <div class=\"items panel-body\">\r\n");
#nullable restore
#line 37 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                 for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"reply\" data-id=\"");
#nullable restore
#line 40 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("id", " id=\"", 1741, "\"", 1757, 2);
            WriteAttributeValue("", 1746, "reply", 1746, 5, true);
#nullable restore
#line 40 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 1751, i+1, 1751, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"avatar\">\r\n                            <a href=\"#\">\r\n                                <img class=\"media-object avatar-48\"");
            BeginWriteAttribute("src", " src=\"", 1916, "\"", 2008, 1);
#nullable restore
#line 43 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 1922, string.IsNullOrEmpty(item.ReplyUser.Avatar)?"/images/96.png": item.ReplyUser.Avatar, 1922, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"infos\">\r\n                            <div class=\"info\">\r\n                                <span class=\"name\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2262, "\"", 2298, 2);
            WriteAttributeValue("", 2269, "#replyuser_", 2269, 11, true);
#nullable restore
#line 49 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 2280, item.ReplyUser.Id, 2280, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                                                       Write(item.ReplyUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </span> ·\r\n                                <span class=\"time\">\r\n                                    <a class=\"reply-floor\"");
            BeginWriteAttribute("href", " href=\"", 2484, "\"", 2503, 2);
            WriteAttributeValue("", 2491, "#reply", 2491, 6, true);
#nullable restore
#line 52 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 2497, i+1, 2497, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 52 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                                                            Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> · <abbr class=\"timeago\">");
#nullable restore
#line 52 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                                                                                                                Write(item.CreateOn.ToString("MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</abbr>
                                </span>
                                <span class=""opts pull-right"">
                                    <a title=""赞"" data-count=""0"" data-state="""" data-type=""Reply"" data-id=""297575"" class=""likeable "" href=""#""><i class=""fa fa-thumbs-up""></i> <span></span></a>
                                    <a data-floor=""1"" data-login=""adamshen"" title=""回复此楼"" class=""btn-reply fa fa-mail-reply"" href=""#""></a>
                                </span>
                            </div>
                            <div class=""markdown"">
                                <p>");
#nullable restore
#line 60 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                              Write(item.ReplyContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 64 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"panel panel-default\" style=\"padding:20px;\">\r\n");
#nullable restore
#line 68 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
             if (user != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42764c61559f42dd0907d5262fe7e99b7181e7dc15764", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"TopicId\"");
                BeginWriteAttribute("value", " value=\"", 3635, "\"", 3652, 1);
#nullable restore
#line 71 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 3643, Model.Id, 3643, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ReplyUserId\"");
                BeginWriteAttribute("value", " value=\"", 3717, "\"", 3735, 1);
#nullable restore
#line 72 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 3725, user.Id, 3725, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ReplyEmail\"");
                BeginWriteAttribute("value", " value=\"", 3799, "\"", 3820, 1);
#nullable restore
#line 73 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
WriteAttributeValue("", 3807, user.Email, 3807, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""form-group"">
                        <label class=""col-sm-2 control-label"">内容</label>
                        <div class=""col-sm-10"">
                            <textarea class=""form-control"" rows=""10"" placeholder=""填写内容"" name=""ReplyContent"" data-provide=""markdown""></textarea>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-sm-offset-2 col-sm-10"">
                            <button type=""submit"" class=""btn btn-default"">回复</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    需要");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42764c61559f42dd0907d5262fe7e99b7181e7dc19858", async() => {
                WriteLiteral("登录");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("发表回复,\r\n                    如果你还没有账号请点击这里 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42764c61559f42dd0907d5262fe7e99b7181e7dc21338", async() => {
                WriteLiteral("注册");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("。\r\n                </p>\r\n");
#nullable restore
#line 93 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 97 "D:\max\core\Max.BBS\Max.BBS\Views\Topic\Index.cshtml"
   Write(await Html.PartialAsync("_SidebarPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\".markdown p\").each(function () {\r\n            var c = $(this).text();\r\n            $(this).html(markdown.toHTML(c));\r\n        })\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserServices services { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591