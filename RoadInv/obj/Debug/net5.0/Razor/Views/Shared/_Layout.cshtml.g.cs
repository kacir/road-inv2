#pragma checksum "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb064e06ec9e7be67dc8777398adcebea66a9ca8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb064e06ec9e7be67dc8777398adcebea66a9ca8", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb064e06ec9e7be67dc8777398adcebea66a9ca82741", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""icon"" href=""https://www.ardot.gov/wp-content/uploads/2020/07/cropped-android-chrome-512x512-1-300x300.png"" />

    <!-- Jquery and associated pre-dependences -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>

    <!-- Bootstrap core library -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PV");
                WriteLiteral("CmYl\" crossorigin=\"anonymous\"></script>\r\n\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 1136, "\"", 1174, 2);
#nullable restore
#line 17 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1143, ViewData["slash"], 1143, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1161, "css/style.css", 1161, 13, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>");
#nullable restore
#line 19 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb064e06ec9e7be67dc8777398adcebea66a9ca85605", async() => {
                WriteLiteral("\r\n  \r\n<nav class=\"navbar navbar-expand-lg\">\r\n\r\n  <a class=\"navbar-brand\" href=\"index.html\">\r\n          <img");
                BeginWriteAttribute("src", " src=\"", 1345, "\"", 1387, 2);
#nullable restore
#line 28 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1351, ViewData["slash"], 1351, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1369, "img/ARDOT_Logo.png", 1369, 18, true);
                EndWriteAttribute();
                WriteLiteral(@" width=""100"">
      
      Roadway Inventory Database</a>
  <button class=""navbar-toggler custom-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
    <ul class=""navbar-nav mr-auto"">
      <li");
                BeginWriteAttribute("class", " class=\"", 1844, "\"", 1909, 2);
                WriteAttributeValue("", 1852, "nav-item", 1852, 8, true);
#nullable restore
#line 37 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 1860, RenderSection("nav_segements", required: false), 1861, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 1940, "\"", 1978, 2);
#nullable restore
#line 38 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1947, ViewData["slash"], 1947, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1965, "segments.html", 1965, 13, true);
                EndWriteAttribute();
                WriteLiteral(@">Segements <span class=""sr-only"">(current)</span></a>
      </li>
      <li class=""nav-item dropdown"">
        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
          System Changes
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
          <a");
                BeginWriteAttribute("class", "  class=\"", 2362, "\"", 2428, 2);
                WriteAttributeValue("", 2371, "dropdown-item", 2371, 13, true);
#nullable restore
#line 45 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2384, RenderSection("nav_nhs", required: false), 2386, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2429, "\"", 2477, 2);
#nullable restore
#line 45 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2436, ViewData["slash"], 2436, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2454, "system_changes/nhs.html", 2454, 23, true);
                EndWriteAttribute();
                WriteLiteral(">NHS</a>\r\n          <a");
                BeginWriteAttribute("class", " class=\"", 2500, "\"", 2566, 2);
                WriteAttributeValue("", 2508, "dropdown-item", 2508, 13, true);
#nullable restore
#line 46 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2521, RenderSection("nav_func", required: false), 2523, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2567, "\"", 2616, 2);
#nullable restore
#line 46 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2574, ViewData["slash"], 2574, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2592, "system_changes/func.html", 2592, 24, true);
                EndWriteAttribute();
                WriteLiteral(">Functional Class</a>\r\n          <a");
                BeginWriteAttribute("class", " class=\"", 2652, "\"", 2718, 2);
                WriteAttributeValue("", 2660, "dropdown-item", 2660, 13, true);
#nullable restore
#line 47 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2673, RenderSection("nav_apnh", required: false), 2675, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2719, "\"", 2768, 2);
#nullable restore
#line 47 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2726, ViewData["slash"], 2726, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2744, "system_changes/aphn.html", 2744, 24, true);
                EndWriteAttribute();
                WriteLiteral(">APHN</a>\r\n        </div>\r\n      </li>\r\n      <li");
                BeginWriteAttribute("class", " class=\"", 2818, "\"", 2881, 2);
                WriteAttributeValue("", 2826, "nav-item", 2826, 8, true);
#nullable restore
#line 50 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2834, RenderSection("nav_quality", required: false), 2835, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2912, "\"", 2957, 2);
#nullable restore
#line 51 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2919, ViewData["slash"], 2919, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2937, "quality_control.html", 2937, 20, true);
                EndWriteAttribute();
                WriteLiteral(">Quality Control</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 3065, "\"", 3108, 2);
#nullable restore
#line 54 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3072, ViewData["slash"], 3072, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3090, "RI_Cheat_Sheet.pdf", 3090, 18, true);
                EndWriteAttribute();
                WriteLiteral(">RI Cheatsheet</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 3214, "\"", 3247, 2);
#nullable restore
#line 57 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3221, ViewData["slash"], 3221, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3239, "help.pdf", 3239, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Help</a>\r\n      </li>\r\n        \r\n    </ul>\r\n  </div>\r\n</nav>\r\n    ");
#nullable restore
#line 63 "E:\scratch\RoadInv_Overhaul\WebServer\RoadInv\RoadInv\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
