#pragma checksum "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494c31ff518670d46e3db8a23d2f51a4087383d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SearchTable), @"mvc.1.0.view", @"/Views/Shared/SearchTable.cshtml")]
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
#line 1 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
using RoadInv.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494c31ff518670d46e3db8a23d2f51a4087383d4", @"/Views/Shared/SearchTable.cshtml")]
    public class Views_Shared_SearchTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchPageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("nav_segements", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
#nullable restore
#line 8 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
  
    ViewData["Title"] = "Segements";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""segement-search-main-content master-grid"">
    <div id=""side-panel"" class='split left'>
        <h3>Search</h3>
        <div action=""/search"" method=""get"">
            <div class=""form-group"">
                <label for='form-district'>Distict Number</label>
                <select class=""form-control"" id='district'>
                    <option></option>
");
#nullable restore
#line 20 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var x in Model.con.AH_District)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 22 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (ViewBag.district == x.DistrictNumber) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 22 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 22 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                        Write(x.DistrictNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" >");
#nullable restore
#line 22 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                            Write(x.DistrictNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 23 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                <select id=\"county\" class=\"form-control\">\r\n                    <option></option>\r\n");
#nullable restore
#line 30 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var u in Model.con.AH_County)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 32 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (ViewBag.county == u.CountyNumber) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 32 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 32 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                    Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 32 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                     Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                       Write(u.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 33 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                <input id=\"route\" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1489, "\"", 1511, 1);
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1497, ViewBag.route, 1497, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                <input id=\"section\" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1683, "\"", 1707, 1);
#nullable restore
#line 43 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1691, ViewBag.section, 1691, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                <input id=\"logmile\" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1879, "\"", 1948, 2);
            WriteAttributeValue("", 1887, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 47 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                             if (ViewBag.logmile != -1) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                           Write(ViewBag.logmile);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                       }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 1887, 60, false);
            WriteAttributeValue(" ", 1947, "", 1948, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <div id=""form-button-holder"" class='form-group'>
                <a id=""submit-search-link"" href=""/search""><button type=""submit"" id=""submit-search"">Submit </button></a>
                <a href=""/search""><button id=""clear-all"">Clear All</button></a>
            </div>


        </div>
    </div>
    <div class='split-right'>
        <div class=""master-grid grid-container"">
            <div><h1>Roadway Inventory Segements</h1></div>
            <div><a target=""_blank"" href=""new_segement.html""><button id=""new-seg-button"">New Segement</button></a></div>
        </div>

        <table>
            <tr>
                <th>Status</th>
                <th>Distict</th>
                <th>County</th>
                <th>Route</th>
                <th>Section</th>
                <th>Direction</th>
                <th>BLM</th>
                <th>ELM</th>
                <th>Length</th>
                <th>Route Sign</th>
                <th>Type Road</th>");
            WriteLiteral("\r\n                <th>Functional Class</th>\r\n                <th>NHS</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 80 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
             foreach (var u in Model.details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\'", 3179, "\'", 3213, 2);
            WriteAttributeValue("", 3186, "edit_segement.html?id=", 3186, 22, true);
#nullable restore
#line 83 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 3208, u.Id, 3208, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                         Write(u.SystemStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 84 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhDistrict);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhCounty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhRoute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhSection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 88 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.LogDirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 89 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhBlm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhElm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.RouteSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 94 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.FuncClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 95 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.Nhs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 98 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n<script src=\"scripts/set_submit_search.js\"></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
