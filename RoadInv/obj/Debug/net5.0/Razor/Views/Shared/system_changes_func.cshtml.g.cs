#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44709b1ae8eefcf2f6265ff970a4e50c4697c852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_system_changes_func), @"mvc.1.0.view", @"/Views/Shared/system_changes_func.cshtml")]
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
#line 1 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44709b1ae8eefcf2f6265ff970a4e50c4697c852", @"/Views/Shared/system_changes_func.cshtml")]
    public class Views_Shared_system_changes_func : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadInv.Models.SystemChangesPageModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("nav_func", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
  
    ViewData["Title"] = "Functional Class";
    ViewData["slash"] = "/";
    ViewBag.Title = "Functional Class";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"http://localhost:65424/css/micromodal.css\">\r\n");
            WriteLiteral(@"<script src=""https://unpkg.com/micromodal/dist/micromodal.min.js""></script>

<script>
    MicroModal.init();
</script>

<div class=""modal micromodal-slide"" id=""modal-1"" aria-hidden=""true"">
    <div class=""modal__overlay"" tabindex=""-1"" data-micromodal-close>
        <div class=""modal__container"" role=""dialog"" aria-modal=""true"" aria-labelledby=""modal-1-title"">
            <header class=""modal__header"">
                <h2 class=""modal__title"" id=""modal-1-title"">
                    Functional Bulk Redesignation
                </h2>
                <button class=""modal__close"" aria-label=""Close modal"" data-micromodal-close></button>
            </header>
            <main class=""modal__content"" id=""modal-1-content"">
");
#nullable restore
#line 33 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                 using (Html.BeginForm("nhs_update", "system_changes", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\'form-group\'>\r\n                        <label>County</label>\r\n                        ");
#nullable restore
#line 37 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Route</label>\r\n                        ");
#nullable restore
#line 41 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Section</label>\r\n                        ");
#nullable restore
#line 45 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>Direction</label>\r\n                        ");
#nullable restore
#line 49 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.DropDownListFor(m => m.Direction, Model.Directions, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>BLM</label>\r\n                        ");
#nullable restore
#line 53 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.TextBox("BLM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\'form-group\'>\r\n                        <label>ELM</label>\r\n                        ");
#nullable restore
#line 57 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.TextBox("ELM", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\'form-district\'>Functional Class</label>\r\n                        ");
#nullable restore
#line 61 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                   Write(Html.DropDownListFor(m => m.FuncClass, Model.FuncClass_vals, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <footer class=""modal__footer"">
                        <button class=""modal__btn modal__btn-primary"" type=""submit"" value=""Update"">Submit for Validation</button>
                        <button class=""modal__btn"" data-micromodal-close aria-label=""Close this dialog window"">Close</button>
                    </footer>
");
#nullable restore
#line 67 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </main>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"segement-search-main-content master-grid\">\r\n    <div id=\"side-panel\" class=\'split left\'>\r\n        <h3>Search</h3>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44709b1ae8eefcf2f6265ff970a4e50c4697c8528833", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\'form-dissolve-method\'>Dissolve</label>\r\n                ");
#nullable restore
#line 81 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.DropDownListFor(model => model.Dissolve, Enum.GetNames(typeof(RoadInv.Models.SystemChangesPageModel.DissolveSelect)).Select(e => new SelectListItem { Text = e }), " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\'form-district\'>District Number</label>\r\n                ");
#nullable restore
#line 85 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.DropDownListFor(m => m.District, Model.Districts, " ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                ");
#nullable restore
#line 89 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.DropDownListFor(m => m.County, Model.Counties, " ", new { @class = "form-control", }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                ");
#nullable restore
#line 93 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.TextBox("Route", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                ");
#nullable restore
#line 97 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.TextBox("Section", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                ");
#nullable restore
#line 101 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
           Write(Html.TextBox("Logmile", "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
            <div id=""form-button-holder"" class='form-group'>
                <button type=""submit"" id=""submit-search"">Submit </button>
                <button type=""reset"" value=""clear"" id=""clear-all"">Clear All</button>
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
            <div><h1>System Change: Functional</h1> </div>
            <div><button id=""new-seg-button"" data-micromodal-trigger=""modal-1"" href='javascript:void(0);'>Apply Bulk Redesignation</button></div>
        </div>
        <section>
            <h5>Functional Class Designation (1-6) Summarized by: <span>ARNOLD ID</span> </h5>
            <table>

");
#nullable restore
#line 120 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                 if (Model.Dissolve == "Segment")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <th></th>
                        <th>Arnold ID</th>
                        <th>County</th>
                        <th>Section</th>
                        <th>Direction</th>
                        <th>BLM</th>
                        <th>ELM</th>
                        
                    </tr>
");
#nullable restore
#line 132 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                    foreach (var item in Model.DissolveFuncViews)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 6130, "\'", 6170, 2);
            WriteAttributeValue("", 6137, "../edit_segement.html?id=", 6137, 25, true);
#nullable restore
#line 135 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
WriteAttributeValue("", 6162, item.Id, 6162, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                            <td>");
#nullable restore
#line 136 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 137 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 138 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 139 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 140 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 141 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 143 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                    }

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.PagedListPager(Model.DissolveFuncViews, page => Url.Action("system_changes_func",
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
#line 169 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                      

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
                        <th>Functional Class</th>
                    </tr>
");
#nullable restore
#line 185 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                     foreach (var item in Model.roadInvs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\'", 8631, "\'", 8671, 2);
            WriteAttributeValue("", 8638, "../edit_segement.html?id=", 8638, 25, true);
#nullable restore
#line 188 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
WriteAttributeValue("", 8663, item.Id, 8663, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a></td>\r\n                <td>");
#nullable restore
#line 189 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhRoadId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 190 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhCounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 191 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhSection));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 192 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.LogDirect));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 193 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhBlm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 194 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhElm));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 195 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.AhLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 196 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
               Write(Html.DisplayFor(modelItem => item.FuncClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 198 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 198 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </table>\r\n            <br />\r\n            Page ");
#nullable restore
#line 204 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
             Write(Model.roadInvs.PageCount < Model.roadInvs.PageNumber ? 0 : Model.roadInvs.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 204 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
                                                                                                       Write(Model.roadInvs.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 205 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\system_changes_func.cshtml"
       Write(Html.PagedListPager(Model.roadInvs, page => Url.Action("system_changes_func",
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
        var type = (arguments[0] != null) ? argumen");
            WriteLiteral(@"ts[0] : 'short';
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

            var height = modalContainerHeight - (modalHeaderHeight + modalFooterHeight + offset");
            WriteLiteral(@");

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
