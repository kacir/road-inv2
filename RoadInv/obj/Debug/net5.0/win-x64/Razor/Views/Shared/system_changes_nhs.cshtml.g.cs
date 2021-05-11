#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7759bddd7bad31606dbb2d46475502dc26c027c1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7759bddd7bad31606dbb2d46475502dc26c027c1", @"/Views/Shared/system_changes_nhs.cshtml")]
    public class Views_Shared_system_changes_nhs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadInv.Models.SystemChangesPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("nav_nhs", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
  
    ViewData["Title"] = "NHS";
    ViewData["slash"] = "/";
    ViewBag.Title = "NHS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"http://localhost:65424/css/micromodal.css\">");
            WriteLiteral(@"
<script src=""https://unpkg.com/micromodal/dist/micromodal.min.js""></script>

<script>
    MicroModal.init();
    console.log('modal inititalized')
</script>

<div class=""modal micromodal-slide"" id=""modal-1"" aria-hidden=""true"">
    <div class=""modal__overlay"" tabindex=""-1"" data-micromodal-close>
        <div class=""modal__container"" role=""dialog"" aria-modal=""true"" aria-labelledby=""modal-1-title"">
            <header class=""modal__header"">
                <h2 class=""modal__title"" id=""modal-1-title"">
                    NHS Bulk Redesignation
                </h2>
                <button class=""modal__close"" aria-label=""Close modal"" data-micromodal-close></button>
            </header>
            <main class=""modal__content"" id=""modal-1-content"">
");
#nullable restore
#line 33 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 using (Html.BeginForm("nhs_update", "system_changes", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\'form-group\'>\r\n                            <label>County</label>\r\n                            ");
#nullable restore
#line 37 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\'form-group\'>\r\n                            <label>Route</label>\r\n                            ");
#nullable restore
#line 41 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\'form-group\'>\r\n                            <label>Direction</label>\r\n                            ");
#nullable restore
#line 45 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\'form-group\'>\r\n                            <label>BLM</label>\r\n                            ");
#nullable restore
#line 49 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.TextBox("BLM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\'form-group\'>\r\n                            <label>ELM</label>\r\n                            ");
#nullable restore
#line 53 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.TextBox("ELM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\'form-district\'>NHS</label>\r\n                            ");
#nullable restore
#line 57 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DropDownListFor(m => m.NHS, Model.NHS_vals, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    <footer class=\"modal__footer\">\r\n                        <button class=\"modal__btn modal__btn-primary\" type=\"submit\" value=\"Update\">Submit for Validation</button>\r\n");
            WriteLiteral("                        <button class=\"modal__btn\" data-micromodal-close aria-label=\"Close this dialog window\">Close</button>\r\n                    </footer>\r\n");
#nullable restore
#line 64 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </main>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"segement-search-main-content master-grid\">\r\n    <div id=\"side-panel\" class=\'split left\'>\r\n        <h3>Search</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7759bddd7bad31606dbb2d46475502dc26c027c18944", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\'form-dissolve-method\'>Dissolve</label>\r\n                ");
#nullable restore
#line 78 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(model => model.Dissolve, Enum.GetNames(typeof(RoadInv.Models.SystemChangesPageModel.DissolveSelect)).Select(e => new SelectListItem { Text = e }), " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\'form-district\'>District Number</label>\r\n                ");
#nullable restore
#line 82 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(m => m.District, Model.Districts, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                ");
#nullable restore
#line 86 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                ");
#nullable restore
#line 90 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                ");
#nullable restore
#line 94 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                ");
#nullable restore
#line 98 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Logmile", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div id=""form-button-holder"" class='form-group'>
                <button type=""submit"" id=""submit-search"">Submit </button>
                <button type =""reset"" value=""clear"" id=""clear-all"">Clear All</button>
            </div>


        ");
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
            <div><button id=""new-seg-button"" data-micromodal-trigger=""modal-1"" href='javascript:void(0);'>Apply Bulk Redesignation</button></div>
        </div>
        <section>
            <h5>NHS Designation Summarized by: <span>ARNOLD ID</span> </h5>
            <table>

");
#nullable restore
#line 118 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 if (Model.Dissolve == "Segment")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>ID</th>\r\n                        <th>Road ID</th>\r\n                        <th>BLM</th>\r\n                        <th>ELM</th>\r\n                        <th>NHS Summary</th>\r\n                    </tr>\r\n");
#nullable restore
#line 127 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    foreach (var item in Model.DissolveNhsViews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 130 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 131 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 132 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 133 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 134 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NhsSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 136 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
               Write(Html.PagedListPager(Model.DissolveNhsViews, page => Url.Action("system_changes_nhs",
                    new
                    {
                        page,
                        sortOrder = ViewBag.CurrentSort,
                        district = Model.District,
                        county = Model.County,
                        route = Model.Route,
                        section = Model.Section,
                        logmile = Model.Logmile,
                        direction = Model.Direction,
                        blm = Model.BLM,
                        elm = Model.ELM,
                        nhs = Model.NHS,
                        dissolve = Model.Dissolve
                    }), new X.PagedList.Web.Common.PagedListRenderOptionsBase
                    {
                        DisplayItemSliceAndTotal = false,
                        ContainerDivClasses = new[] { "navigation" },
                        LiElementClasses = new[] { "page-item" },
                        PageClasses = new[] { "page-link" }
                    }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                      

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
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
#line 174 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                     foreach (var item in Model.roadInvs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 177 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 178 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 179 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 180 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 181 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 182 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 183 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 184 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nhs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 8951, "\'", 8991, 2);
            WriteAttributeValue("", 8958, "../edit_segement.html?id=", 8958, 25, true);
#nullable restore
#line 185 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
WriteAttributeValue("", 8983, item.Id, 8983, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n                            <td>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7759bddd7bad31606dbb2d46475502dc26c027c121893", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 188 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 191 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </table>\r\n            <br />\r\n            Page ");
#nullable restore
#line 197 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
             Write(Model.roadInvs.PageCount < Model.roadInvs.PageNumber ? 0 : Model.roadInvs.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 197 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                                                                                                       Write(Model.roadInvs.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 198 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
       Write(Html.PagedListPager(Model.roadInvs, page => Url.Action("system_changes_nhs",
            new
            {
                page,
                sortOrder = ViewBag.CurrentSort,
                district = Model.District,
                county = Model.County,
                route = Model.Route,
                section = Model.Section,
                logmile = Model.Logmile,
                direction = Model.Direction,
                blm = Model.BLM,
                elm = Model.ELM,
                nhs = Model.NHS,
                dissolve = Model.Dissolve
            }), new X.PagedList.Web.Common.PagedListRenderOptionsBase
            {
                DisplayItemSliceAndTotal = false,
                ContainerDivClasses = new[] { "navigation" },
                LiElementClasses = new[] { "page-item" },
                PageClasses = new[] { "page-link" }
            }));

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
                    <th>BLM</th>
                    <th>ELM</th>
                </tr>
");
#nullable restore
#line 230 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 foreach (var item in Model.ExcludeNhs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 233 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 234 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 235 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 238 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </section>
    </div>
</div>

<script>
    document.addEventListener(""DOMContentLoaded"", function () {
        try {
            MicroModal.init({
                awaitCloseAnimation: true, // set to false, to remove close animation
                onShow: function (modal) {
                    console.log(""micromodal open"");
                    addModalContentHeight('short');
                    /**************************
                      For full screen scrolling modal,
                      uncomment line below & comment line above
                     **************************/
                    //addModalContentHeight('tall');
                },
                onClose: function (modal) {
                    console.log(""micromodal close"");
                }
            });
        } catch (e) {
            console.log(""micromodal error: "", e);
        }
    });

    function addModalContentHeight(type) {
        var type = (arguments[0] ");
            WriteLiteral(@"!= null) ? arguments[0] : 'short';
        var modalContainer = $(""#modal-container"");
        var modalHeader = $(""#modal-header"");
        var modalContentContent = $(""#modal-content-content"");
        var modalContent = $(""#modal-content"");
        var modalFooter = $(""#modal-footer"");

        var modalIsDefined =
            modalContainer.length &&
            modalHeader.length &&
            modalContent.length &&
            modalFooter.length;

        if (modalIsDefined) {
            var modalContainerHeight = modalContainer.outerHeight();
            var modalHeaderHeight = modalHeader.outerHeight();
            var modalFooterHeight = modalFooter.outerHeight();

            console.log(""modalContainerHeight: "", modalContainerHeight);
            console.log(""modalHeaderHeight: "", modalHeaderHeight);
            console.log(""modalFooterHeight: "", modalFooterHeight);

            var offset = 80;

            var height = modalContainerHeight - (modalHeaderHeight + modalFoo");
            WriteLiteral(@"terHeight + offset);

            console.log('height: ', height);

            if (!isNaN(height)) {
                height = height > 0 ? height : 20;
                if (type == 'short') {
                    modalContent.css({ 'height': height + 'px' });
                }
                else {
                    modalContainer.css({ 'height': '100%', 'overflow-y': 'hidden', 'margin-top': '40px' });
                    modalContentContent.css({ 'height': '100%', 'overflow-y': 'auto' });
                    modalContent.css({ 'overflow-y': 'visible' });
                    modalFooter.css({ 'margin-bottom': '120px' });
                }
                setTimeout(function () {
                    modalContent.css({ 'display': 'block' });
                    var modalContentDOM = document.querySelector('#modal-content');
                    modalContentDOM.scrollTop = 0;
                });
            }

        }

    }


</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoadInv.Models.SystemChangesPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
