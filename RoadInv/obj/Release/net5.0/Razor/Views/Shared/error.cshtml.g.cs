#pragma checksum "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62ed852738b7cade0b73e7b5de67e54a9b02fc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_error), @"mvc.1.0.view", @"/Views/Shared/error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62ed852738b7cade0b73e7b5de67e54a9b02fc7", @"/Views/Shared/error.cshtml")]
    public class Views_Shared_error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\error.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\error.cshtml"
  
    ViewData["Title"] = "Roadway Inventory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<section>
    <h1>Oppsie, Looks like we have encountered some kind of error</h1>
    <br>
    <p>
        Please refresh you the program by going back to the homepage. If problems persist please contact the responsible programmer and database administrator in SIR Division, Traffic Information Section.
    </p>
    <footer>For more Information, please contact Traffic Information Systems at <a href='tel:501-568-2111'>501-568-2111</a></footer>
</section>

");
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
