#pragma checksum "C:\Users\vaishnavi\source\repos\PIA_Public\PIA.DotNet.Interview\src\PIA.DotNet.Interview.WebUI\Pages\Readme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5e9e36ce36314fba6d460ab759c203627db58c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PIA.DotNet.Interview.WebUI.Pages.Pages_Readme), @"mvc.1.0.razor-page", @"/Pages/Readme.cshtml")]
namespace PIA.DotNet.Interview.WebUI.Pages
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
#line 1 "C:\Users\vaishnavi\source\repos\PIA_Public\PIA.DotNet.Interview\src\PIA.DotNet.Interview.WebUI\Pages\_ViewImports.cshtml"
using PIA.DotNet.Interview.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vaishnavi\source\repos\PIA_Public\PIA.DotNet.Interview\src\PIA.DotNet.Interview.WebUI\Pages\Readme.cshtml"
using UI_BL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5e9e36ce36314fba6d460ab759c203627db58c", @"/Pages/Readme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0538e88b0328b54a789b8df2243b30dbac8f12", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Readme : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\vaishnavi\source\repos\PIA_Public\PIA.DotNet.Interview\src\PIA.DotNet.Interview.WebUI\Pages\Readme.cshtml"
  
    ViewData["Title"] = "Readme page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 10 "C:\Users\vaishnavi\source\repos\PIA_Public\PIA.DotNet.Interview\src\PIA.DotNet.Interview.WebUI\Pages\Readme.cshtml"
Write(Html.Raw(@_markdownService.Parse(@"../../../PIA.DotNet.Interview/README.md")));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MarkdownService _markdownService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PIA.DotNet.Interview.WebUI.Pages.ReadmeModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIA.DotNet.Interview.WebUI.Pages.ReadmeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PIA.DotNet.Interview.WebUI.Pages.ReadmeModel>)PageContext?.ViewData;
        public PIA.DotNet.Interview.WebUI.Pages.ReadmeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
