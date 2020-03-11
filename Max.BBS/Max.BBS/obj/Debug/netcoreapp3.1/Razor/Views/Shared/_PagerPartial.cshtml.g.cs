#pragma checksum "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c4449f584ad7a7d2eb03b744c17bd0fa96cff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PagerPartial), @"mvc.1.0.view", @"/Views/Shared/_PagerPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c4449f584ad7a7d2eb03b744c17bd0fa96cff9", @"/Views/Shared/_PagerPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf60736b7b948b12018fa8a18459f1116c9909f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PagerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
  
    var pageindex = Convert.ToInt32(ViewBag.PageIndex);
    var pagecount = Convert.ToInt32(ViewBag.PageCount);
    pagecount = pagecount == 0 ? 1 : pagecount;
    pageindex = pageindex > pagecount ? pagecount : pageindex;
    var path = Context.Request.Path.Value;
    var query = string.Empty;
    var querys = Context.Request.Query;
    foreach (var item in querys)
    {
        if (!item.Key.Equals("page"))
        {
            query += $"{item.Key}={item.Value}&";
        }
    }
    query = query == string.Empty ? "?" : "?" + query;
    path += query;
    var pagestart = pageindex - 2 > 0 ? pageindex - 2 : 1;
    var pageend = pagestart + 5 >= pagecount ? pagecount : pagestart + 5;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"pagination\">\r\n    <li");
            BeginWriteAttribute("class", " class=\"", 753, "\"", 815, 3);
            WriteAttributeValue("", 761, "prev", 761, 4, true);
            WriteAttributeValue(" ", 765, "previous_page", 766, 14, true);
#nullable restore
#line 22 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue(" ", 779, pageindex == 1 ? "disabled" : "", 780, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 885, 1);
#nullable restore
#line 23 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 836, pageindex==1?"#":$"{path}page={pageindex - 1}", 836, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">&#8592; 上一页</a>\r\n    </li>\r\n    <li ");
#nullable restore
#line 25 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
    Write(pageindex == 1 ? "class=active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("><a rel=\"start\"");
            BeginWriteAttribute("href", " href=\"", 977, "\"", 997, 2);
#nullable restore
#line 25 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 984, path, 984, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 991, "page=1", 991, 6, true);
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n");
#nullable restore
#line 26 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
     if (pagestart > 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"disabled\"><a href=\"#\">&hellip;</a></li>\r\n");
#nullable restore
#line 29 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
     for (int i = pagestart; i < pageend; i++)
    {
        if (i > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li ");
#nullable restore
#line 34 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
            Write(pageindex == i ? "class=active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("><a rel=\"next\"");
            BeginWriteAttribute("href", " href=\"", 1265, "\"", 1286, 3);
#nullable restore
#line 34 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 1272, path, 1272, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1279, "page=", 1279, 5, true);
#nullable restore
#line 34 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 1284, i, 1284, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 35 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
     if (pageend < pagecount)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"disabled\"><a href=\"#\">&hellip;</a></li>\r\n");
#nullable restore
#line 40 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
     if (pagecount > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li ");
#nullable restore
#line 43 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
        Write(pageindex == pagecount ? "class=active" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("><a rel=\"end\"");
            BeginWriteAttribute("href", " href=\"", 1528, "\"", 1557, 3);
#nullable restore
#line 43 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 1535, path, 1535, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1542, "page=", 1542, 5, true);
#nullable restore
#line 43 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 1547, pagecount, 1547, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
                                                                                                  Write(pagecount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 44 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 1594, "\"", 1654, 3);
            WriteAttributeValue("", 1602, "next", 1602, 4, true);
            WriteAttributeValue(" ", 1606, "next_page", 1607, 10, true);
#nullable restore
#line 45 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue(" ", 1616, pageindex==pagecount?"disabled":"", 1617, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a rel=\"next\"");
            BeginWriteAttribute("href", " href=\"", 1679, "\"", 1743, 1);
#nullable restore
#line 46 "D:\max\core\Max.BBS\Max.BBS\Views\Shared\_PagerPartial.cshtml"
WriteAttributeValue("", 1686, pageindex==pagecount?"#":$"{path}page={pageindex + 1}", 1686, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">下一页 &#8594;</a>\r\n    </li>\r\n</ul>");
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