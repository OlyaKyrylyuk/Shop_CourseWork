#pragma checksum "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa02a7169f5f217c353e596b14313a8a8d33221b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa02a7169f5f217c353e596b14313a8a8d33221b", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25e4126cf7b940ec7a958fe707d1fe1887186ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kursach.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("Search results\r\n<p><a class=\"classA\" href=\"/Home/Index\">Return to main page with all products</a></p>\r\n");
#nullable restore
#line 9 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
 if (ViewBag.Products == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Nothing was found</h1>\r\n");
#nullable restore
#line 12 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 16 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
          
            foreach (var t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <div class=\"proto_border\"><img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 522, "\"", 536, 1);
#nullable restore
#line 20 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
WriteAttributeValue("", 528, t.Photo, 528, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 537, "\"", 550, 1);
#nullable restore
#line 20 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
WriteAttributeValue("", 543, t.Name, 543, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                    <h2> ");
#nullable restore
#line 21 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
                    Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                    <h2>Price: ");
#nullable restore
#line 22 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
                          Write(t.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h2>Category: ");
#nullable restore
#line 23 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
                             Write(t.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p><a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 794, 2);
            WriteAttributeValue("", 775, "/Home/Product/", 775, 14, true);
#nullable restore
#line 24 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
WriteAttributeValue("", 789, t.Id, 789, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">More details...</a></p>\r\n                </div>\r\n");
#nullable restore
#line 26 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 29 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\Home\Search.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kursach.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
