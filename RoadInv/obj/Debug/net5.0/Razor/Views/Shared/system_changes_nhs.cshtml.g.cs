#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1f1d05881c44c4d905e93cd50d9c2413140705"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1f1d05881c44c4d905e93cd50d9c2413140705", @"/Views/Shared/system_changes_nhs.cshtml")]
    public class Views_Shared_system_changes_nhs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadInv.Models.SystemChangesPageModel>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1f1d05881c44c4d905e93cd50d9c24131407054778", async() => {
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
#line 28 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 using (Html.BeginForm("preview_changes", "system_changes", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\'form-group\'>\r\n                        <label>County</label>\r\n                        ");
#nullable restore
#line 32 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Route</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Section</label>\r\n                        ");
#nullable restore
#line 40 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Direction</label>\r\n                        ");
#nullable restore
#line 44 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>BLM</label>\r\n                        ");
#nullable restore
#line 48 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.TextBox("BLM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>ELM</label>\r\n                        ");
#nullable restore
#line 52 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.TextBox("ELM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\'form-district\'>NHS</label>\r\n                        ");
#nullable restore
#line 56 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                   Write(Html.DropDownListFor(m => m.NHS, Model.NHS_vals, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <footer class=""modal__footer"">
                        
                        <button class=""modal__btn modal__btn-primary"" type=""submit"" value=""Update"" onclick=""AlertFunction()"">Submit for Validation</button>
");
            WriteLiteral("                        <button class=\"modal__btn\" data-micromodal-close aria-label=\"Close this dialog window\">Close</button>\r\n                    </footer>\r\n");
#nullable restore
#line 65 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </main>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"Segment-search-main-content master-grid\">\r\n    <div id=\"side-panel\" class=\'split left\'>\r\n        <h3>Search</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d1f1d05881c44c4d905e93cd50d9c241314070511013", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\'form-dissolve-method\'>Dissolve</label>\r\n                ");
#nullable restore
#line 79 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(model => model.Dissolve, Enum.GetNames(typeof(RoadInv.Models.SystemChangesPageModel.DissolveSelect)).Select(e => new SelectListItem { Text = e }), " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\'form-district\'>District Number</label>\r\n                ");
#nullable restore
#line 83 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(m => m.District, Model.Districts, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                ");
#nullable restore
#line 87 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                ");
#nullable restore
#line 91 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                ");
#nullable restore
#line 95 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Direction</label>\r\n                ");
#nullable restore
#line 99 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
           Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                ");
#nullable restore
#line 103 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
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
            <div><h1>System Change: NHS</h1> </div>
            <div><a target=""_blank"" href=""../new_Segment""><button id=""new-seg-button"">New NHS Segment</button></a></div>
            <div><button id=""new-seg-button"" data-micromodal-trigger=""modal-1"" href='javascript:void(0);'>Apply Bulk Redesignation</button></div>
        </div>
        <section>
            <h5>NHS Designation Summarized by: <span>ARNOLD ID</span> </h5>
            <table>

");
#nullable restore
#line 123 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 if (Model.Dissolve == "Segment")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <th></th>
                        <th>ID</th>
                        <th>Road ID</th>
                        <th>County</th>
                        <th>Section</th>
                        <th>Direction</th>
                        <th>BLM</th>
                        <th>ELM</th>
                        <th>NHS Summary</th>
                    </tr>
");
#nullable restore
#line 136 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    foreach (var item in Model.DissolveNhsViews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a href=\"#\" data-toggle=\"modal\" data-target=\"#modal-1\">Link</a></td>\r\n                            <td>");
#nullable restore
#line 140 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 141 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 142 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 143 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 144 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 145 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 146 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 147 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NhsSummary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 149 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
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
#line 172 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                      

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
                        <th>NHS</th>
                    </tr>
");
#nullable restore
#line 188 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                     foreach (var item in Model.roadInvs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 9250, "\'", 9289, 2);
            WriteAttributeValue("", 9257, "../edit_Segment.html?id=", 9257, 24, true);
#nullable restore
#line 191 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
WriteAttributeValue("", 9281, item.Id, 9281, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                            <td>");
#nullable restore
#line 192 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 193 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 194 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 195 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 196 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 197 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 198 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 199 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nhs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                        </tr>\r\n");
#nullable restore
#line 202 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </table>\r\n            <br />\r\n            Page ");
#nullable restore
#line 208 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
             Write(Model.roadInvs.PageCount < Model.roadInvs.PageNumber ? 0 : Model.roadInvs.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 208 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                                                                                                       Write(Model.roadInvs.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 209 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
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
            <h5>Non-NHS Segments on NHS Routes</h5>
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
#line 245 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                 foreach (var item in Model.ExcludeNhs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 11728, "\'", 11773, 2);
            WriteAttributeValue("", 11735, "../edit_Segment.html?id=", 11735, 24, true);
#nullable restore
#line 248 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
WriteAttributeValue("", 11759, item.AhRoadId, 11759, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                        <td>");
#nullable restore
#line 249 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 250 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 251 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 252 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 253 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 254 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n                    </tr>\r\n");
#nullable restore
#line 256 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_nhs.cshtml"
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
            WriteLiteral("   });\r\n            }\r\n\r\n        }\r\n\r\n    }\r\n\r\n\r\n</script>\r\n");
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
