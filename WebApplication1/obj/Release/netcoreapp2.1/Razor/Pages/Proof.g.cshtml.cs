#pragma checksum "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\Proof.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "362324b558c9fe209775db0084da30e20bfa9a74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Proof), @"mvc.1.0.razor-page", @"/Pages/Proof.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Proof.cshtml", typeof(WebApplication1.Pages.Pages_Proof), null)]
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"362324b558c9fe209775db0084da30e20bfa9a74", @"/Pages/Proof.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Proof : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\Proof.cshtml"
  
    ViewData["Title"] = "Proof";

#line default
#line hidden
            BeginContext(67, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(72, 17, false);
#line 6 "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\Proof.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(89, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(101, 13, false);
#line 7 "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\Proof.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(114, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(126, 10, false);
#line 8 "C:\Users\nimda\source\repos\appServiceLabTwo\WebApplication1\Pages\Proof.cshtml"
Write(Model.Loop);

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</h3>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProofModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProofModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProofModel>)PageContext?.ViewData;
        public ProofModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
