#pragma checksum "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c935f96062017ff9ed7f2199f03a38923c2c708f"
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
#nullable restore
#line 2 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
using RoadInv.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c935f96062017ff9ed7f2199f03a38923c2c708f", @"/Views/Shared/SearchTable.cshtml")]
    public class Views_Shared_SearchTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchPageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
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
#line 9 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
  
    ViewData["Title"] = "Segements";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #AH_BLM, #AH_Route, #AH_Section {
        width: 100%;
    }
</style>

<div id=""segement-search-main-content master-grid"">
    <div id=""side-panel"" class='split left'>
        <h3>Search</h3>
        <div >
            <div class=""form-group"">
                <label for='form-district'>District Number</label>
                <select class=""form-control""");
            BeginWriteAttribute("id", " id=\'", 566, "\'", 599, 1);
#nullable restore
#line 25 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 571, FieldsListModel.AH_District, 571, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 630, "\"", 638, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 27 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var x in Model.con.AH_District)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 29 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (Model.filterDistrict == x.DistrictNumber.Trim()) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 29 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 29 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                   Write(x.DistrictNumber.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 29 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                             Write(x.DistrictNumber.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 30 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 1089, "\"", 1120, 1);
#nullable restore
#line 35 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1094, FieldsListModel.AH_County, 1094, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 1172, "\"", 1180, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 37 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var u in Model.con.AH_County)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (Model.filterCounty == u.CountyNumber) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                        Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                         Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                           Write(u.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 40 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1611, "\"", 1641, 1);
#nullable restore
#line 46 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1616, FieldsListModel.AH_Route, 1616, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1675, "\"", 1701, 1);
#nullable restore
#line 46 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1683, Model.filterRoute, 1683, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1827, "\"", 1859, 1);
#nullable restore
#line 50 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1832, FieldsListModel.AH_Section, 1832, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1893, "\"", 1921, 1);
#nullable restore
#line 50 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1901, Model.filterSection, 1901, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Direction</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 2050, "\"", 2082, 1);
#nullable restore
#line 54 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 2055, FieldsListModel.LOG_DIRECT, 2055, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" >\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 2135, "\"", 2143, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 56 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach(var u in Model.con.LOG_DIRECT)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option ");
#nullable restore
#line 58 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         if (Model.filterDirection == u.Domainvalue) {

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 58 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 58 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                               Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                               Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 58 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                Write(u.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 59 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div>\r\n                <label>Road Type</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 2531, "\"", 2561, 1);
#nullable restore
#line 64 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 2536, FieldsListModel.TypeRoad, 2536, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 2613, "\"", 2621, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 66 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach(var u in Model.con.TypeRoad)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option ");
#nullable restore
#line 68 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         if (Model.filterTypeRoad == u.Domainvalue) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 68 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 68 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                 Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 68 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                 Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 68 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                  Write(u.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 69 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 3025, "\"", 3053, 1);
#nullable restore
#line 74 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 3030, FieldsListModel.AH_BLM, 3030, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 3087, "\"", 3164, 2);
            WriteAttributeValue("", 3095, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 74 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                             if (Model.filterLogmile != -1) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                               Write(Model.filterLogmile);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                                               }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 3095, 68, false);
            WriteAttributeValue(" ", 3163, "", 3164, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>
            <div id=""form-button-holder"" class='form-group'>
                <button type=""submit"" id=""submit-search"" onclick=""submitEventLoop()"">Submit </button>
                <button id=""clear-all"">Clear All</button>
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
                <th>Link</th>
                <th>Status</th>
                <th>District</th>
                <th>County</th>
                <th>Route</th>
                <th>Section</th>
                <th>Direction</th>
                <th>BLM</th>
                <th>ELM</th>
                <th>Length</th>
                <th>Route Sign</th>
                <th>Type Road</th>
      ");
            WriteLiteral("          <th>Functional Class</th>\r\n                <th>NHS</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 108 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
             foreach (var u in Model.details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> <a style=\"transform: rotate(90deg)\"");
            BeginWriteAttribute("href", " href=\'", 4421, "\'", 4455, 2);
            WriteAttributeValue("", 4428, "edit_segement.html?id=", 4428, 22, true);
#nullable restore
#line 111 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 4450, u.Id, 4450, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a> </td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 4539, "\"", 4782, 1);
            WriteAttributeValue("", 4547, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 112 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.SystemStatus){
                        if (item.Domainvalue == u.SystemStatus){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.Domainvalue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 114 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                 Write(item.Label);

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                        
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 4547, 235, false);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 116 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                  Write(u.SystemStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 4872, "\"", 4908, 3);
            WriteAttributeValue("", 4880, "ArDOT", 4880, 5, true);
            WriteAttributeValue(" ", 4885, "District", 4886, 9, true);
#nullable restore
#line 117 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue(" ", 4894, u.AhDistrict, 4895, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 117 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                   Write(u.AhDistrict);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 4996, "\"", 5235, 1);
            WriteAttributeValue("", 5004, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 118 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.AH_County){
                        if (item.CountyNumber == u.AhCounty){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.CountyNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 120 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                  Write(item.County);

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                          
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5004, 231, false);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 122 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                  Write(u.AhCounty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 123 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhRoute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 124 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhSection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 125 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.LogDirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 126 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhBlm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 127 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhElm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 128 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 5568, "\"", 5805, 1);
            WriteAttributeValue("", 5576, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 129 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.RouteSign){
                        if (item.Domainvalue == u.RouteSign){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.Domainvalue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 131 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                 Write(item.Label);

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                        
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5576, 229, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 134 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
               Write(u.RouteSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 5914, "\"", 6149, 1);
            WriteAttributeValue("", 5922, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 135 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.TypeRoad){
                        if (item.Domainvalue == u.TypeRoad){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.Domainvalue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 137 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                 Write(item.Label);

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                        
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 5922, 227, false);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                  Write(u.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 6235, "\"", 6472, 1);
            WriteAttributeValue("", 6243, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 140 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.FuncClass){
                        if (item.Domainvalue == u.FuncClass){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.Domainvalue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 142 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                 Write(item.Label);

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                        
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 6243, 229, false);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 144 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                  Write(u.FuncClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td data-toggle=\"tooltip\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 6559, "\"", 6784, 1);
            WriteAttributeValue("", 6567, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 145 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                           foreach(var item in Model.con.NHS){
                        if (item.Domainvalue == u.Nhs){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                             Write(item.Domainvalue);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 147 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                 Write(item.Label);

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                        
                        }
                    }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 6567, 217, false);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 149 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                  Write(u.Nhs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 152 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </table>
    </div>
</div>
<script>
    $(document).ready(function () {
        $('[data-toggle=""tooltip""]').tooltip();
            });
</script>
<script>

    function submitEventLoop() {
        console.log(""hello world!"");
        var inputDistrict = $('#");
#nullable restore
#line 167 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                           Write(FieldsListModel.AH_District);

#line default
#line hidden
#nullable disable
            WriteLiteral(" option:selected\').text();\r\n        var inputCounty = $(\'#");
#nullable restore
#line 168 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         Write(FieldsListModel.AH_County);

#line default
#line hidden
#nullable disable
            WriteLiteral(" option:selected\').attr(\'value\');\r\n        var inputRoute = $(\'#");
#nullable restore
#line 169 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                        Write(FieldsListModel.AH_Route);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n        var inputSection = $(\'#");
#nullable restore
#line 170 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                          Write(FieldsListModel.AH_Section);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n        var inputLogmile = $(\'#");
#nullable restore
#line 171 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                          Write(FieldsListModel.AH_BLM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n\r\n        var inputRoadtype = $(\"#");
#nullable restore
#line 173 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                           Write(FieldsListModel.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val();\r\n        var inputDirection = $(\"#");
#nullable restore
#line 174 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                            Write(FieldsListModel.LOG_DIRECT);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""").val();

        if (inputDistrict === undefined) {
            inputDistrict = """";
        }

        if (inputCounty === undefined) {
            inputCounty = """";
        }

        if (inputRoute === undefined) {
            inputRoute = """";
        }

        if (inputSection === undefined) {
            inputSection = """";
        }

        if (inputLogmile === undefined) {
            inputLogmile = -1;
        }

        if (inputRoadtype === undefined) {
            inputRoadtype = """";
        }

        if (inputDirection === undefined) {
            inputDirection = """";
        }


        console.log(inputDistrict);
        console.log(inputCounty);
        console.log(inputRoute);
        console.log(inputSection);
        console.log(inputLogmile);
        console.log(inputRoadtype);
        console.log(inputDirection);

        inputDistrict = 'district=' + inputDistrict.trim() + '&';
        inputCounty = 'county=' + inputCounty.trim() + '&';
        ");
            WriteLiteral(@"inputRoute = 'route=' + inputRoute.trim() + '&';
        inputSection = 'section=' + inputSection.trim() + '&';
        inputLogmile = 'logmile=' + inputLogmile.trim() + '&';
        inputRoadType = ""typeroad="" + inputRoadtype.trim() + '&';
        inputDirection = ""direction="" + inputDirection.trim();

        var searchString = ""/segments?"" + inputDistrict + inputCounty + inputRoute + inputSection + inputLogmile + inputRoadType + inputDirection;
        window.location.href = searchString;
        console.log(searchString);
        //$('#submit-search-link').attr(""href"", searchString);
    }

    $("".form-group"").keypress(function (e) {
        if (e.which == 13) {
            submitEventLoop();
            return false;
        }
    });

    // Re-add clear attributes option
    $(""#clear-all"").click(function () {
        $(""#");
#nullable restore
#line 236 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_District);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\"#");
#nullable restore
#line 237 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_County);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\'#");
#nullable restore
#line 238 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_Route);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\'#");
#nullable restore
#line 239 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_Section);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\'#");
#nullable restore
#line 240 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_BLM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\"#");
#nullable restore
#line 241 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\"#");
#nullable restore
#line 242 "E:\scratch\RoadInv_Overhaul\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.LOG_DIRECT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n    });\r\n</script>");
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
