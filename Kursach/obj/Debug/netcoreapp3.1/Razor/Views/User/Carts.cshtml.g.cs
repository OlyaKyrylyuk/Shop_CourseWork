#pragma checksum "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e514e28b117690fc6b3dc3c8691e82a4ea3187"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Carts), @"mvc.1.0.view", @"/Views/User/Carts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e514e28b117690fc6b3dc3c8691e82a4ea3187", @"/Views/User/Carts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25e4126cf7b940ec7a958fe707d1fe1887186ff", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Carts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kursach.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
  
    ViewData["Title"] = "User Page";
    Layout = "~/Views/Shared/User.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
 if (ViewBag.Carts == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>List of products is empty</h1>\r\n");
#nullable restore
#line 10 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-5 mb-2\">\r\n");
#nullable restore
#line 14 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
          
            foreach (var t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4\">\r\n                    <div class=\"proto_border\"><img class=\"img\"");
            BeginWriteAttribute("src", " src=\"", 416, "\"", 438, 1);
#nullable restore
#line 18 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
WriteAttributeValue("", 422, t.Product.Photo, 422, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 439, "\"", 460, 1);
#nullable restore
#line 18 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
WriteAttributeValue("", 445, t.Product.Name, 445, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></div>\r\n                    <h2> ");
#nullable restore
#line 19 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
                    Write(t.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                    <h2>Price: ");
#nullable restore
#line 20 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
                          Write(t.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <h2>Count ");
#nullable restore
#line 21 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
                         Write(t.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4e514e28b117690fc6b3dc3c8691e82a4ea31876352", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" class=\"butn\" value=\"Buy\" />\r\n                        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 828, "\"", 841, 1);
#nullable restore
#line 24 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"
WriteAttributeValue("", 836, t.Id, 836, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 27 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 31 "E:\A_University\2курс\ПВІ\Kursach\Kursach\Views\User\Carts.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kursach.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591