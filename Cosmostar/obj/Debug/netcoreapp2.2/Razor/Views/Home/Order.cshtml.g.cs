#pragma checksum "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a165c2d8bd42079a017e8e45f5bbbfaf34cb05a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Order.cshtml", typeof(AspNetCore.Views_Home_Order))]
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
#line 1 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/_ViewImports.cshtml"
using Cosmostar;

#line default
#line hidden
#line 2 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/_ViewImports.cshtml"
using Cosmostar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a165c2d8bd42079a017e8e45f5bbbfaf34cb05a7", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb18cf028df2511fe524b68bf29d05710014b1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
  
    ViewData["Title"] = "Заказ";

#line default
#line hidden
            BeginContext(38, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(43, 17, false);
#line 4 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(60, 20, true);
            WriteLiteral("</h1>\n\n<p>Заказ</p>\n");
            EndContext();
            BeginContext(81, 19, false);
#line 7 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
Write(ViewBag.Description);

#line default
#line hidden
            EndContext();
            BeginContext(100, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(102, 16, false);
#line 8 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
Write(ViewBag.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(118, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(120, 17, false);
#line 9 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
Write(ViewBag.OrderTime);

#line default
#line hidden
            EndContext();
            BeginContext(137, 39, true);
            WriteLiteral("\n\n<div>\n    <h3>Сумма заказа</h3>\n     ");
            EndContext();
            BeginContext(177, 11, false);
#line 13 "/Users/ufocombat/Projects/Cosmostar/Cosmostar/Views/Home/Order.cshtml"
Write(ViewBag.Sum);

#line default
#line hidden
            EndContext();
            BeginContext(188, 10, true);
            WriteLiteral(";\n</div>\n\n");
            EndContext();
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
