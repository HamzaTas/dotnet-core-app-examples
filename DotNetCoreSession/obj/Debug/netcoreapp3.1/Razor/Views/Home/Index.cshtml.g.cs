#pragma checksum "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "294db169868ba827596a920b0395bb40663a6d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
using DotnetCoreSession.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294db169868ba827596a920b0395bb40663a6d5a", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
  
    List<User> users = (List<User>)ViewBag.UserList;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Hello World :)</h1>\r\n\r\n<b> String Session Value</b>\r\n<br />\r\n");
#nullable restore
#line 13 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
Write(ViewBag.sessionKeyStr);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b> int Session Value</b>\r\n<br />\r\n");
#nullable restore
#line 17 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
Write(ViewBag.sessionKeyInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<b>User List</b>\r\n<br />\r\n");
#nullable restore
#line 21 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
 foreach (var item in users)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
      Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n    <br />\r\n");
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
      Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n    <br />\r\n");
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
      Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n    <br />\r\n");
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
      Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 31 "C:\Users\hamza.tas\source\repos\DotnetCoreSession\DotnetCoreSession\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
