#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc7b67673836a31bd8fcbc2428769a9f4f6339f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc7b67673836a31bd8fcbc2428769a9f4f6339f", @"/Views/Shared/_Layout.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc7b67673836a31bd8fcbc2428769a9f4f6339f2735", async() => {
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
                WriteLiteral(@"CmYl"" crossorigin=""anonymous""></script>

    <!-- modal dialog boxes -->
    <link rel=""stylesheet"" href=""css/micromodal.css"">
    <script src=""https://unpkg.com/micromodal/dist/micromodal.min.js""></script>
    
    <!-- custom css -->
    <link rel=""stylesheet""");
                BeginWriteAttribute("href", " href=\"", 1336, "\"", 1374, 2);
#nullable restore
#line 22 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1343, ViewData["slash"], 1343, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1361, "css/style.css", 1361, 13, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>");
#nullable restore
#line 24 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc7b67673836a31bd8fcbc2428769a9f4f6339f5790", async() => {
                WriteLiteral("\r\n  \r\n<nav class=\"navbar navbar-expand-lg\">\r\n\r\n  <a class=\"navbar-brand\" href=\"index.html\">\r\n          <img");
                BeginWriteAttribute("src", " src=\"", 1545, "\"", 1589, 2);
#nullable restore
#line 33 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1551, ViewData["slash"], 1551, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1569, "img/ArDOT_Logo_1.png", 1569, 20, true);
                EndWriteAttribute();
                WriteLiteral(@" width=""100"">
      
      Roadway Inventory Database</a>
  <button class=""navbar-toggler custom-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
      <ul class=""navbar-nav mr-auto"">
          <li");
                BeginWriteAttribute("class", " class=\"", 2052, "\"", 2116, 2);
                WriteAttributeValue("", 2060, "nav-item", 2060, 8, true);
#nullable restore
#line 42 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 2068, RenderSection("nav_Segments", required: false), 2069, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n              <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 2153, "\"", 2191, 2);
#nullable restore
#line 43 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2160, ViewData["slash"], 2160, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2178, "segments.html", 2178, 13, true);
                EndWriteAttribute();
                WriteLiteral(@">Segments <span class=""sr-only"">(current)</span></a>
          </li>
          <li class=""nav-item dropdown"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                  System Changes
              </a>
              <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                  <a");
                BeginWriteAttribute("class", " class=\"", 2616, "\"", 2681, 2);
                WriteAttributeValue("", 2624, "dropdown-item", 2624, 13, true);
#nullable restore
#line 50 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2637, RenderSection("nav_nhs", required: false), 2639, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2682, "\"", 2730, 2);
#nullable restore
#line 50 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2689, ViewData["slash"], 2689, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2707, "system_changes/nhs.html", 2707, 23, true);
                EndWriteAttribute();
                WriteLiteral(">NHS</a>\r\n                  <a");
                BeginWriteAttribute("class", " class=\"", 2761, "\"", 2827, 2);
                WriteAttributeValue("", 2769, "dropdown-item", 2769, 13, true);
#nullable restore
#line 51 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2782, RenderSection("nav_func", required: false), 2784, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2828, "\"", 2877, 2);
#nullable restore
#line 51 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2835, ViewData["slash"], 2835, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2853, "system_changes/func.html", 2853, 24, true);
                EndWriteAttribute();
                WriteLiteral(">Functional Class</a>\r\n                  <a");
                BeginWriteAttribute("class", " class=\"", 2921, "\"", 2987, 2);
                WriteAttributeValue("", 2929, "dropdown-item", 2929, 13, true);
#nullable restore
#line 52 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 2942, RenderSection("nav_apnh", required: false), 2944, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 2988, "\"", 3037, 2);
#nullable restore
#line 52 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2995, ViewData["slash"], 2995, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3013, "system_changes/aphn.html", 3013, 24, true);
                EndWriteAttribute();
                WriteLiteral(">APHN</a>\r\n                  <a");
                BeginWriteAttribute("class", " class=\"", 3069, "\"", 3138, 2);
                WriteAttributeValue("", 3077, "dropdown-item", 3077, 13, true);
#nullable restore
#line 53 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 3090, RenderSection("nav_special", required: false), 3092, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 3139, "\"", 3191, 2);
#nullable restore
#line 53 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3146, ViewData["slash"], 3146, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3164, "system_changes/special.html", 3164, 27, true);
                EndWriteAttribute();
                WriteLiteral(@">Special Systems</a>
              </div>
          </li>
          <li class=""nav-item dropdown"">
              <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                  Quality Control
              </a>
              <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                  <a");
                BeginWriteAttribute("class", " class=\"", 3607, "\"", 3676, 2);
                WriteAttributeValue("", 3615, "dropdown-item", 3615, 13, true);
#nullable restore
#line 61 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 3628, RenderSection("nav_quality", required: false), 3630, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 3677, "\"", 3717, 2);
#nullable restore
#line 61 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3684, ViewData["slash"], 3684, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3702, "quality_control", 3702, 15, true);
                EndWriteAttribute();
                WriteLiteral(">General Quality Control</a>\r\n                  <a");
                BeginWriteAttribute("class", " class=\"", 3768, "\"", 3842, 2);
                WriteAttributeValue("", 3776, "dropdown-item", 3776, 13, true);
#nullable restore
#line 62 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("  ", 3789, RenderSection("nav_quality_bulk", required: false), 3791, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 3843, "\"", 3881, 2);
#nullable restore
#line 62 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3850, ViewData["slash"], 3850, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3868, "bulk_validate", 3868, 13, true);
                EndWriteAttribute();
                WriteLiteral(">Bulk Validation</a>\r\n              </div>\r\n          </li>\r\n          <li class=\"nav-item\">\r\n              <a class=\"nav-link\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 4025, "\"", 4068, 2);
#nullable restore
#line 66 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4032, ViewData["slash"], 4032, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4050, "RI_Cheat_Sheet.pdf", 4050, 18, true);
                EndWriteAttribute();
                WriteLiteral(">RI Cheatsheet</a>\r\n          </li>\r\n          <li class=\"nav-item\">\r\n              <a class=\"nav-link\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 4188, "\"", 4221, 2);
#nullable restore
#line 69 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4195, ViewData["slash"], 4195, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4213, "help.pdf", 4213, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Help</a>\r\n          </li>\r\n\r\n      </ul>\r\n  </div>\r\n</nav>\r\n    ");
#nullable restore
#line 75 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\_Layout.cshtml"
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
