#pragma checksum "D:\max\core\Max.BBS\Max.BBS\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26fc700e5dad67c9e28549df452fec658f34afbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26fc700e5dad67c9e28549df452fec658f34afbc", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf60736b7b948b12018fa8a18459f1116c9909f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\core\Max.BBS\Max.BBS\Views\Home\About.cshtml"
  
    ViewData["Title"] = ".NET Core 跨平台论坛介绍";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "D:\max\core\Max.BBS\Max.BBS\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<h3>");
#nullable restore
#line 5 "D:\max\core\Max.BBS\Max.BBS\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

<p>
    .NET Core 开发<br />
    VS Code 或者 VS 2017<br />
    更多详细：<a href=""http://dot.net"" target=""_blank"">dot.net</a><br />
    <h3>论坛系统介绍：</h3>
    系统开发：<br />
    ASP.NET Core + EF Core Sqlite + Bootstrap <br />
    运行环境：<br />
    Ubuntu 14.04 + Kestrel <br /><br />
    博客介绍：
    <a href=""http://www.cnblogs.com/linezero/"" target=""_blank"">
        LineZero's Blog
    </a><br />
    服务器时间：");
#nullable restore
#line 20 "D:\max\core\Max.BBS\Max.BBS\Views\Home\About.cshtml"
     Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
