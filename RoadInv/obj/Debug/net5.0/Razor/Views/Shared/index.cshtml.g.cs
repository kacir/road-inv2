#pragma checksum "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "399a573b16a9f4315d1a25a092238038eb41aadd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_index), @"mvc.1.0.view", @"/Views/Shared/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"399a573b16a9f4315d1a25a092238038eb41aadd", @"/Views/Shared/index.cshtml")]
    public class Views_Shared_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\index.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\index.cshtml"
  
    ViewData["Title"] = "Roadway Inventory";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<section>
    <h1>Welcome to the Roadway Inventory Database!</h1>
    <br>
    <p>
        This is the roadway inventory which contains segemented data for all public road in the state of Arkansas.
        If you would like to have a direction connection to the database <a href='#'>click</a> here for directions
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
