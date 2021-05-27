#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef507f416958a2f6620ea81b266fbd69813cdc1b"
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
#line 1 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
using RoadInv.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
using RoadInv.DB;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef507f416958a2f6620ea81b266fbd69813cdc1b", @"/Views/Shared/SearchTable.cshtml")]
    public class Views_Shared_SearchTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchPageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
  Layout = "_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("nav_Segments", async() => {
                WriteLiteral("\r\n    active\r\n");
            }
            );
#nullable restore
#line 9 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
  
    ViewData["Title"] = "Segments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #AH_BLM, #AH_Route, #AH_Section {
        width: 100%;
    }
</style>

<div id=""Segment-search-main-content master-grid"">
    <div id=""side-panel"" class='split left'>
        <h3>Search</h3>
        <div >
            <div class=""form-group"">
                <label for='form-district'>District Number</label>
                <select class=""form-control""");
            BeginWriteAttribute("id", " id=\'", 563, "\'", 596, 1);
#nullable restore
#line 25 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 568, FieldsListModel.AH_District, 568, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 627, "\"", 635, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 27 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var x in Model.con.AH_District)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 29 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (Model.filterDistrict == x.DistrictNumber.Trim()) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 29 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 29 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                   Write(x.DistrictNumber.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 29 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                             Write(x.DistrictNumber.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 30 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>County</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 1086, "\"", 1117, 1);
#nullable restore
#line 35 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1091, FieldsListModel.AH_County, 1091, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 1169, "\"", 1177, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 37 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach (var u in Model.con.AH_County)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option ");
#nullable restore
#line 39 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                 if (Model.filterCounty == u.CountyNumber) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 39 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 39 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                        Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 39 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                         Write(u.CountyNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 39 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                           Write(u.County);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 40 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Route</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1608, "\"", 1638, 1);
#nullable restore
#line 46 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1613, FieldsListModel.AH_Route, 1613, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1672, "\"", 1698, 1);
#nullable restore
#line 46 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1680, Model.filterRoute, 1680, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Section</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1824, "\"", 1856, 1);
#nullable restore
#line 50 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1829, FieldsListModel.AH_Section, 1829, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 1890, "\"", 1918, 1);
#nullable restore
#line 50 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 1898, Model.filterSection, 1898, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Direction</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 2047, "\"", 2079, 1);
#nullable restore
#line 54 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 2052, FieldsListModel.LOG_DIRECT, 2052, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" >\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 2132, "\"", 2140, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 56 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach(var u in Model.con.LOG_DIRECT)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option ");
#nullable restore
#line 58 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         if (Model.filterDirection == u.Domainvalue) {

#line default
#line hidden
#nullable disable
            WriteLiteral("selected");
#nullable restore
#line 58 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 58 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                               Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                               Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 58 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                Write(u.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 59 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div>\r\n                <label>Road Type</label>\r\n                <select");
            BeginWriteAttribute("id", " id=\"", 2528, "\"", 2558, 1);
#nullable restore
#line 64 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 2533, FieldsListModel.TypeRoad, 2533, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 2610, "\"", 2618, 0);
            EndWriteAttribute();
            WriteLiteral("></option>\r\n");
#nullable restore
#line 66 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                     foreach(var u in Model.con.TypeRoad)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <option ");
#nullable restore
#line 68 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         if (Model.filterTypeRoad == u.Domainvalue) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(" selected");
#nullable restore
#line 68 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(" value=\"");
#nullable restore
#line 68 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                 Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 68 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                 Write(u.Domainvalue);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 68 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                  Write(u.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </option>\r\n");
#nullable restore
#line 69 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\'form-group\'>\r\n                <label>Logmile</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 3022, "\"", 3050, 1);
#nullable restore
#line 74 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 3027, FieldsListModel.AH_BLM, 3027, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" type=\'text\'");
            BeginWriteAttribute("value", " value=\"", 3084, "\"", 3161, 2);
            WriteAttributeValue("", 3092, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 74 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                             if (Model.filterLogmile != -1) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                               Write(Model.filterLogmile);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                                                                                                                                                               }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 3092, 68, false);
            WriteAttributeValue(" ", 3160, "", 3161, 1, true);
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
            <div><h1>Roadway Inventory Segments</h1></div>
            <div><a target=""_blank"" href=""new_Segment.html""><button id=""new-seg-button"">New Segment</button></a></div>
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
            WriteLiteral("       <th>Functional Class</th>\r\n                <th>NHS</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 108 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
             foreach (var u in Model.details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> <a style=\"transform: rotate(90deg)\"");
            BeginWriteAttribute("href", " href=\'", 4415, "\'", 4448, 2);
            WriteAttributeValue("", 4422, "edit_Segment.html?id=", 4422, 21, true);
#nullable restore
#line 111 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
WriteAttributeValue("", 4443, u.Id, 4443, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a> </td>\r\n                    <td>");
#nullable restore
#line 112 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.SystemStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 113 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhDistrict);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 114 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhCounty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 115 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhRoute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 116 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhSection);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 117 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.LogDirect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 118 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhBlm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 119 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhElm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 120 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.AhLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 121 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.RouteSign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 122 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 123 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.FuncClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 124 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                   Write(u.Nhs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 127 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n\r\n    function submitEventLoop() {\r\n        console.log(\"hello world!\");\r\n        var inputDistrict = $(\'#");
#nullable restore
#line 138 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                           Write(FieldsListModel.AH_District);

#line default
#line hidden
#nullable disable
            WriteLiteral(" option:selected\').text();\r\n        var inputCounty = $(\'#");
#nullable restore
#line 139 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                         Write(FieldsListModel.AH_County);

#line default
#line hidden
#nullable disable
            WriteLiteral(" option:selected\').attr(\'value\');\r\n        var inputRoute = $(\'#");
#nullable restore
#line 140 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                        Write(FieldsListModel.AH_Route);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n        var inputSection = $(\'#");
#nullable restore
#line 141 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                          Write(FieldsListModel.AH_Section);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n        var inputLogmile = $(\'#");
#nullable restore
#line 142 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                          Write(FieldsListModel.AH_BLM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val();\r\n\r\n        var inputRoadtype = $(\"#");
#nullable restore
#line 144 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
                           Write(FieldsListModel.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val();\r\n        var inputDirection = $(\"#");
#nullable restore
#line 145 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
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
#line 207 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_District);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\"#");
#nullable restore
#line 208 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_County);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\'#");
#nullable restore
#line 209 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_Route);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\'#");
#nullable restore
#line 210 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_Section);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\'#");
#nullable restore
#line 211 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.AH_BLM);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(\"\");\r\n        $(\"#");
#nullable restore
#line 212 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
       Write(FieldsListModel.TypeRoad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").val(\"\");\r\n        $(\"#");
#nullable restore
#line 213 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\SearchTable.cshtml"
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
