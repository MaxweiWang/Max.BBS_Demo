#pragma checksum "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9d28bc3036b0e9ac21a498e208af9cf7ee50f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TopicReplies_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TopicReplies/Index.cshtml")]
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
#line 1 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\_ViewImports.cshtml"
using Max.MBBS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\_ViewImports.cshtml"
using Max.ApplicationCore.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\_ViewImports.cshtml"
using Max.MBBS.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9d28bc3036b0e9ac21a498e208af9cf7ee50f4", @"/Areas/Admin/Views/TopicReplies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf60736b7b948b12018fa8a18459f1116c9909f2", @"/Areas/Admin/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TopicReplies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TopicReply>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
 for (int i = 0; i < Model.Count; i++)
{
    var item = Model[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"reply\" data-id=\"");
#nullable restore
#line 9 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("id", " id=\"", 162, "\"", 181, 2);
            WriteAttributeValue("", 167, "reply_", 167, 6, true);
#nullable restore
#line 9 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
WriteAttributeValue("", 173, item.Id, 173, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"info\">\r\n            <span class=\"name\">\r\n                <a href=\"#\">");
#nullable restore
#line 12 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
                       Write(item.ReplyEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </span> ·\r\n            <span class=\"time\">\r\n                <a class=\"reply-floor\" href=\"#\">#");
#nullable restore
#line 15 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
                                             Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> · <abbr class=\"timeago\">");
#nullable restore
#line 15 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
                                                                                 Write(item.CreateOn.ToString("MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</abbr>\r\n            </span>\r\n            <span class=\"opts pull-right\">\r\n                <a data-id=\"");
#nullable restore
#line 18 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" href=\"#\" class=\"del\">删除</a>\r\n            </span>\r\n        </div>\r\n        <div class=\"markdown\">\r\n            <p>");
#nullable restore
#line 22 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
          Write(item.ReplyContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\max\core\Max.BBS\Max.BBS\Areas\Admin\Views\TopicReplies\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $("".markdown p"").each(function () {
        var c = $(this).html();
        $(this).html(markdown.toHTML(c));
    });
    $("".del"").on(""click"", function () {
        var id = $(this).data('id');
        $.ajax({
            url: ""/Admin/TopicReplies/Delete"",
            data: { id: id },
            success: function (data, status) {
                if (status == ""nocontent"")
                    $(""#reply_"" + id).hide();
            }
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TopicReply>> Html { get; private set; }
    }
}
#pragma warning restore 1591
