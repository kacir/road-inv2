#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "210054cd198c88aad2767d4d91551961af3b8c5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_system_changes_special), @"mvc.1.0.view", @"/Views/Shared/system_changes_special.cshtml")]
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
#line 1 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"210054cd198c88aad2767d4d91551961af3b8c5a", @"/Views/Shared/system_changes_special.cshtml")]
    public class Views_Shared_system_changes_special : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadInv.Models.SystemChangesPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/micromodal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("nav_special", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
  
    ViewData["Title"] = "Special";
    ViewData["slash"] = "/";
    ViewBag.Title = "Special";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "210054cd198c88aad2767d4d91551961af3b8c5a4822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://unpkg.com/micromodal/dist/micromodal.min.js""></script>

<script>
    MicroModal.init();
</script>

<div class=""modal micromodal-slide"" id=""modal-1"" aria-hidden=""true"">
    <div class=""modal__overlay"" tabindex=""-1"" data-micromodal-close>
        <div class=""modal__container"" role=""dialog"" aria-modal=""true"" aria-labelledby=""modal-1-title"">
            <header class=""modal__header"">
                <h2 class=""modal__title"" id=""modal-1-title"">
                    Special System Bulk Redesignation
                </h2>
                <button class=""modal__close"" aria-label=""Close modal"" data-micromodal-close></button>
            </header>
            <main class=""modal__content"" id=""modal-1-content"">
");
#nullable restore
#line 32 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                 using (Html.BeginForm("bulk_update", "system_changes", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\'form-group\'>\r\n                        <label>County</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Route</label>\r\n                        ");
#nullable restore
#line 40 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Section</label>\r\n                        ");
#nullable restore
#line 44 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Direction</label>\r\n                        ");
#nullable restore
#line 48 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>BLM</label>\r\n                        ");
#nullable restore
#line 52 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.TextBox("BLM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>ELM</label>\r\n                        ");
#nullable restore
#line 56 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.TextBox("ELM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\'form-district\'>Special System</label>\r\n                        ");
#nullable restore
#line 60 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                   Write(Html.DropDownListFor(m => m.SpecialSystem, Model.SpecialSystem_vals, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <footer class=""modal__footer"">
                        <button class=""modal__btn modal__btn-primary"" type=""submit"" value=""Update"" onclick=""AlertFunction()"">Submit for Validation</button>
                        <button class=""modal__btn"" data-micromodal-close aria-label=""Close this dialog window"">Close</button>
                    </footer>
");
#nullable restore
#line 66 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </main>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"Segment-search-main-content master-grid\">\r\n    <div id=\"side-panel\" class=\'split left\'>\r\n        <h3>Search</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "210054cd198c88aad2767d4d91551961af3b8c5a11117", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\'form-dissolve-method\'>Dissolve</label>\r\n                ");
#nullable restore
#line 80 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.DropDownListFor(model => model.Dissolve, Enum.GetNames(typeof(RoadInv.Models.SystemChangesPageModel.DissolveSelect)).Select(e => new SelectListItem { Text = e }), " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\'form-district\'>District Number</label>\r\n                ");
#nullable restore
#line 84 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.DropDownListFor(m => m.District, Model.Districts, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                ");
#nullable restore
#line 88 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                ");
#nullable restore
#line 92 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                ");
#nullable restore
#line 96 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Direction</label>\r\n                ");
#nullable restore
#line 100 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                ");
#nullable restore
#line 104 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
           Write(Html.TextBox("Logmile", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div id=""form-button-holder"" class='form-group'>
                <button type=""submit"" id=""submit-search"">Submit </button>
                <button value=""clear"" id=""clear-all"" onclick=""clearall()"">Clear All</button>
            </div>


        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            <div><h1>System Change: Special</h1> </div>
            <div><a target=""_blank"" href=""../new_Segment""><button id=""new-seg-button"">New Segment</button></a></div>
            <div><button id=""new-seg-button"" data-micromodal-trigger=""modal-1"" href='javascript:void(0);'>Apply Bulk Redesignation</button></div>
        </div>
        <section>
            <h5>Special System Designation Summarized by: <span>ARNOLD ID</span> </h5>
            <table>

");
#nullable restore
#line 124 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                 if (Model.Dissolve == "Segment")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <th></th>
                        <th>ID</th>
                        <th>Road ID</th>
                        <th>BLM</th>
                        <th>ELM</th>
                        <th>Special System</th>
                    </tr>
");
#nullable restore
#line 134 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                    foreach (var item in Model.DissolveSpecialSystemsViews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a href=\"#\" data-toggle=\"modal\" data-target=\"#modal-1\">Link</a></td>\r\n                            <td>");
#nullable restore
#line 138 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 139 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 140 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 141 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 142 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 143 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 144 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 145 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SpecialSystems));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 147 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.PagedListPager(Model.DissolveSpecialSystemsViews, page => Url.Action("system_changes_special",
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
                        funcclass = Model.FuncClass,
                        specialsystem = Model.SpecialSystem,
                        aphn = Model.APHN,
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
#line 173 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                      

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <th></th>
                        <th>ARNOLD ID</th>
                        <th>County</th>
                        <th>Section</th>
                        <th>Direction</th>
                        <th>BLM</th>
                        <th>ELM</th>
                        <th>Length</th>
                        <th>Special System</th>
                    </tr>
");
#nullable restore
#line 189 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                     foreach (var item in Model.roadInvs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 9087, "\'", 9126, 2);
            WriteAttributeValue("", 9094, "../edit_Segment.html?id=", 9094, 24, true);
#nullable restore
#line 192 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
WriteAttributeValue("", 9118, item.Id, 9118, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                            <td>");
#nullable restore
#line 193 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 194 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 195 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 196 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 197 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 198 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 199 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 200 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SpecialSystems));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 203 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </table>\r\n            <br />\r\n            Page ");
#nullable restore
#line 209 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
             Write(Model.roadInvs.PageCount < Model.roadInvs.PageNumber ? 0 : Model.roadInvs.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 209 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                                                                                                       Write(Model.roadInvs.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 210 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
       Write(Html.PagedListPager(Model.roadInvs, page => Url.Action("system_changes_special",
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
                funcclass = Model.FuncClass,
                specialsystem = Model.SpecialSystem,
                aphn = Model.APHN,
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
            <h5>Non-Special Segments on Special Routes</h5>
            <table>
                <tr>
                    <th></th>
                    <th>ARNOLD ID</th>
                    <th>County</th>
                    <th>Section</th>
                    <th>Direction</th>
                    <th>BLM</th>
                    <th>ELM</th>
                </tr>
");
#nullable restore
#line 249 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                 foreach (var item in Model.ExcludeSpecials)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 11685, "\'", 11730, 2);
            WriteAttributeValue("", 11692, "../edit_Segment.html?id=", 11692, 24, true);
#nullable restore
#line 252 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
WriteAttributeValue("", 11716, item.AhRoadId, 11716, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                <td>");
#nullable restore
#line 253 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 254 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 255 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 256 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 257 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 258 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 261 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_special.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </table>
        </section>
    </div>
</div>
<script>
    function clearall() {
        document.getElementById(""Search"").reset();
    }
</script>
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
            console.log(""micromodal error: "",");
            WriteLiteral(@" e);
        }
    });

    function addModalContentHeight(type) {
        var type = (arguments[0] != null) ? arguments[0] : 'short';
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

    ");
            WriteLiteral(@"        var offset = 80;

            var height = modalContainerHeight - (modalHeaderHeight + modalFooterHeight + offset);

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
             ");
            WriteLiteral("   });\r\n            }\r\n\r\n        }\r\n\r\n    }\r\n\r\n</script>\r\n");
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
