#pragma checksum "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5cf91ce95c9867134eff87f5119a7263559ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Sports), @"mvc.1.0.view", @"/Views/Home/Sports.cshtml")]
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
#line 1 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\_ViewImports.cshtml"
using NewsAnalyzer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\_ViewImports.cshtml"
using NewsAnalyzer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5cf91ce95c9867134eff87f5119a7263559ddf", @"/Views/Home/Sports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881cbe30f84510146b2d092ea8ffa732e8967cac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Sports : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsAPI.Models.ArticlesResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml"
     foreach (var article in Model.Articles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-lg-4 col-sm-2 pb-3\" style=\"width: 18rem;\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 201, "\"", 226, 1);
#nullable restore
#line 7 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml"
WriteAttributeValue("", 207, article.UrlToImage, 207, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml"
                                  Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 10 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml"
                                Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\" class=\"btn btn-primary\">Read more...</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\Windows10\Documents\2021\Development\NewsAnalyzer\Views\Home\Sports.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsAPI.Models.ArticlesResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
