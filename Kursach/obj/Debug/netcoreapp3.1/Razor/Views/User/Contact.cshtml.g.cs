#pragma checksum "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b9ab541d8a108cc976a3ade7afa2e9c62a642d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Contact), @"mvc.1.0.view", @"/Views/User/Contact.cshtml")]
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
#line 1 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\_ViewImports.cshtml"
using Kursach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\_ViewImports.cshtml"
using Kursach.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b9ab541d8a108cc976a3ade7afa2e9c62a642d", @"/Views/User/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25e4126cf7b940ec7a958fe707d1fe1887186ff", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml"
  
    ViewData["Title"] = "Contact Form";
    Layout = "~/Views/Shared/User.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Contact Form</h1>\r\n    <a>if you have questions you can call administrator:</a>\r\n</div>\r\n   \r\n    <table class=\"styled-table2\">\r\n\r\n        <tr>\r\n            <th>Surname</th>\r\n            <td>");
#nullable restore
#line 14 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml"
           Write(ViewBag.User.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Name</th>\r\n            <td>");
#nullable restore
#line 18 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml"
           Write(ViewBag.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Email</th>\r\n            <td>");
#nullable restore
#line 22 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml"
           Write(ViewBag.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Phone</th>\r\n            <td>");
#nullable restore
#line 26 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Contact.cshtml"
           Write(ViewBag.User.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n\r\n\r\n    </table>\r\n");
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