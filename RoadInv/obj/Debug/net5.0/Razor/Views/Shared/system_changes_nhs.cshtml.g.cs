#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "550333393e15e6cc91ec495b596021a8c5b10a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_system_changes_nhs), @"mvc.1.0.view", @"/Views/Shared/system_changes_nhs.cshtml")]
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
#line 1 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"550333393e15e6cc91ec495b596021a8c5b10a12", @"/Views/Shared/system_changes_nhs.cshtml")]
    public class Views_Shared_system_changes_nhs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadInv.Models.SystemChangesPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("nav_nhs", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
  
    ViewData["Title"] = "NHS";
    ViewData["slash"] = "/";
    ViewBag.Title = "NHS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"segement-search-main-content master-grid\"> \r\n    <div id=\"side-panel\" class=\'split left\'>\r\n        <h3>Search</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550333393e15e6cc91ec495b596021a8c5b10a124973", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\'form-dissolve-method\'>Dissolve</label>\r\n                <select class=\"form-control\" id=\'form-dissolve-method\'>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550333393e15e6cc91ec495b596021a8c5b10a125444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550333393e15e6cc91ec495b596021a8c5b10a126433", async() => {
                    WriteLiteral("Segement");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550333393e15e6cc91ec495b596021a8c5b10a127678", async() => {
                    WriteLiteral("ARNOLD ID");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\'form-district\'>Distict Number</label>\r\n                ");
#nullable restore
#line 33 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownList("District", new List<SelectListItem>
                {
                    new SelectListItem{Text = "", Value = "" },
                    new SelectListItem{Text = "1", Value = "1" },
                    new SelectListItem{Text = "2", Value = "2" },
                    new SelectListItem{Text = "3", Value = "3" },
                    new SelectListItem{Text = "4", Value = "4" },
                    new SelectListItem{Text = "5", Value = "5" },
                    new SelectListItem{Text = "6", Value = "6" }
                }, "Select District", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                \r\n\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                ");
#nullable restore
#line 48 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("County", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                ");
#nullable restore
#line 52 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                ");
#nullable restore
#line 56 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                ");
#nullable restore
#line 60 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Logmile", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div id=\"form-button-holder\" class=\'form-group\'>\r\n                <input type=\"submit\" value=\"Search\" />\r\n            </div>\r\n\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class='split-right'>
        <div class=""master-grid grid-container"" style=""align-content: center; text-align: center;"">
            <div><h1>System Change: NHS</h1> </div>
            <div><a target=""_blank"" href=""../new_segement""><button id=""new-seg-button"">New NHS Segement</button></a></div>
        </div>
        <section>
            <h5>NHS Designation Summarized by: <span>ARNOLD ID</span> </h5>
            <table>
                <tr>
                    <th>ARNOLD ID</th>
                    <th>County</th>
                    <th>Section</th>
                    <th>Direction</th>
                    <th>BLM</th>
                    <th>ELM</th>
                    <th>Length</th>
                    <th>NHS</th>
                </tr>
");
#nullable restore
#line 87 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 foreach (var item in Model.roadInvs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>N/A</td>\r\n                <td>");
#nullable restore
#line 91 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 93 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 94 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 95 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 97 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nhs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 3935, "\'", 3975, 2);
            WriteAttributeValue("", 3942, "../edit_segement.html?id=", 3942, 25, true);
#nullable restore
#line 98 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
WriteAttributeValue("", 3967, item.Id, 3967, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n                <td>\r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "550333393e15e6cc91ec495b596021a8c5b10a1216513", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 104 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n            <br />\r\n            Page ");
#nullable restore
#line 108 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
             Write(Model.roadInvs.PageCount < Model.roadInvs.PageNumber ? 0 : Model.roadInvs.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 108 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                                                                                                       Write(Model.roadInvs.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 109 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
       Write(Html.PagedListPager(Model.roadInvs, page => Url.Action("system_changes_nhs",
            new
            {
                page,
                sortOrder = ViewBag.CurrentSort,
                district = Model.District,
                county = Model.County,
                route = Model.Route,
                section = Model.Section,
                logmile = Model.Logmile
            }), new X.PagedList.Web.Common.PagedListRenderOptionsBase { ActiveLiElementClass = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </section>
        <section>
            <h5>Non-NHS Segements on NHS Routes</h5>
            <table>
                <tr>
                    <th>ARNOLD ID</th>
                    <th>RoadID</th>
                    <th>BLM</th>
                    <th>ELM</th>
                </tr>
");
#nullable restore
#line 131 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 foreach (var item in Model.ExcludeNhs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>N/A</td>\r\n                        <td>");
#nullable restore
#line 135 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 136 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 137 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 140 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </section>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoadInv.Models.SystemChangesPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
