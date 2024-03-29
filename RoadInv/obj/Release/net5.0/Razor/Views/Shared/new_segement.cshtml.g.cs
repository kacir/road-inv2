#pragma checksum "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\new_segement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4b4360046f1c77956211146f8e4999aa305021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_new_segement), @"mvc.1.0.view", @"/Views/Shared/new_segement.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4b4360046f1c77956211146f8e4999aa305021", @"/Views/Shared/new_segement.cshtml")]
    public class Views_Shared_new_segement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\new_segement.cshtml"
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
#line 6 "C:\Users\MW42705\source\repos\road-inv2\RoadInv\Views\Shared\new_segement.cshtml"
  
    ViewData["Title"] = "New Segement";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""segment-title""><h1>New Segment <span id=""post-AH_RoadID""></span></h1></div>
<div class=""main-content"">
    <div class=""master-grid"">
        <div id=""box-coreChar"" class='property-box'>
            <h6>Core Characteristics</h6>
            <div class=grid-container>

                <DIV>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""ArDOT District"">Distict</label>
                    <select id=""gather-District"">
                        <option></option>
                        <option value=""1"">1</option>
                        <option value=""2"">2</option>
                        <option value=""3"">3</option>
                        <option value=""4"">4</option>
                        <option value=""5"">5</option>
                        <option value=""6"">6</option>
                    </select>

                </DIV>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""ArDOT County Number. Not to");
            WriteLiteral(@" be confused with FHWA County Numbers."">County</label>
                    <select id=""gather-County"">
                        <option></option>
                        <option value=""1"">1</option>
                        <option value=""2"">2</option>
                        <option value=""3"">3</option>
                        <option value=""4"">4</option>
                        <option value=""5"">5</option>
                        <option value=""6"">6</option>
                        <option value=""7"">7</option>
                        <option value=""8"">8</option>
                        <option value=""9"">9</option>

                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""ARNOLD compliant Route Name. limited to 150 characters and only be alphnumberic characters"">Route</label>
                    <input id=""gather-Route"" type=""text"" />
                </div>
                <div>
                  ");
            WriteLiteral(@"  <label data-toggle=""tooltip"" data-placement=""top"" title=""ARNOLD section number. 3 digit sections are typically reserved for Y leg segments"">Section</label>
                    <input id='gather-Section' type=""text"" />
                </div>
                <div data-toggle=""tooltip"" data-placement=""top"" title=""A character prefix for the section that identifies a characteristic of the road such as one way cuplet. Rarely used"">
                    Section Code: <br /> <span id=""post-SectionCode"">XXXXX</span>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""The log direction of the road. Most roads are log direction with anti-log roads being part of dual carrageways"">Direction</label>
                    <select id='gather-Direction'>
                        <option value=""A"">A - Log Direction</option>
                        <option value=""B"">B - Anti-Log Direction</option>
                    </select>
                </div>");
            WriteLiteral(@"
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""The Begining Log Mile of the segment"">BLM</label>
                    <input id='gather-BLM' type=""text"" />
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""The ending Log Mile of the segment"">ELM</label>
                    <input id='gather-ELM' type=""text"" />
                </div>
                <div>
                    Road Length <br /> <span id=""post-RoadLength"">XXXXX</span>
                </div>

            </div>
        </div>
        <div id=""box-history"" class='property-box'>
            <h6>History</h6>
            <DIV>
                input
                <input type=""text"" />
            </DIV>
        </div>
    </div>


    <div class=""master-grid"">
        <div id=""box-nest"">
            <div class=""master-grid"">
                <div class=""property-box"">
                    <h6>Classifi");
            WriteLiteral(@"cation Properties</h6>
                    <div class=""grid-container"">
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""The Route Sign designation of the segement. County and City designations are dependent on the municipal boundary rather than the managment or ownership of the road"">Route Sign</label>
                            <select id=""gather-RouteSign"">
                                <option></option>
                                <option value=""1"">1 - Interstate</option>
                                <option value=""2"">2 - US</option>
                                <option value=""3"">3 - State</option>
                                <option value=""4"">4 - City</option>
                                <option value=""5"">5 - County</option>
                                <option value=""6"">6 - Private</option>
                            </select>
                        </div>
                        <div>
            ");
            WriteLiteral(@"                <label data-toggle=""tooltip"" data-placement=""top"" title=""Indicates based on its function in the vacinity"">Type Road</label>
                            <select id=""gather-TypeRoad"">
                                <option></option>
                                <option value=""1"">1 - Mainlane </option>
                                <option value=""3"">3 - Frontage Road </option>
                                <option value=""5"">5 - Cross Connection </option>
                                <option value=""6"">6 - Ramp </option>
                                <option value=""7"">7 - Self-Contained Facility </option>
                                <option value=""8"">7 - Collector Distributor </option>
                            </select>
                        </div>
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""Indicates if the segement in located inside of an ajusted urbanized area boundary"">Rural Urban Area</labe");
            WriteLiteral(@"l>
                            <select id=""gather-RuralUrbanArea"">
                                <option></option>
                                <option value=""1"">1 - Rural Population &lt; 5,000</option>
                                <option value=""2"">2 - Population 5,000 to 49,999</option>
                                <option value=""3"">3 - Small Urbanized - Population 50,000 to 199,999</option>
                                <option value=""4"">4 - Urbanized - Population > 200,000</option>
                            </select>
                        </div>
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""Dicates which census urbanized area of segement is part of. Default is 0000 for not in a designated area"">Urban Code</label>
                            <select id=""gather-UrbanCode"">
                                <option value=""00000"">00000 - N/A</option>
                                <option value=""30925"">30925 - Fo");
            WriteLiteral(@"rt Smith</option>
                                <option value=""43345"">43345 - Jonesboro</option>
                                <option value=""56116"">56116 - West Memphis</option>
                                <option value=""87193"">87193 - Texarkana</option>
                                <option value=""29494"">29494 - Fayetteville/Springdale</option>
                                <option value=""40213"">40213 - Hot Springs</option>
                                <option value=""50392"">50392 - Little Rock</option>
                                <option value=""69454"">69454 - Pine Bluff</option>
                            </select>
                        </div>

                    </div>
                </div>
                <div id=""box-shoulder"" class=""property-box"">
                    <h6>Shoulder Properties</h6>
                    <div class=""grid-container"">
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""width ");
            WriteLiteral(@"of the left road shoulder. Does not include bike lanes or sidewalks"">Left Shoulder <br /> Width</label>
                            <input id=""gather-LeftShoulderWidth"" type=""text"" />
                        </div>
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""The predominant surface type of the road shoulder. Does not include bike lanes or sidewalks"">Left Shoulder <br /> Surface</label>
                            <select id=""gather-LeftShoulderSurface"">
                                <option></option>
                                <option value=""0"">0 - No shoulder</option>
                                <option value=""1"">1 - Asphalt</option>
                                <option value=""2"">2 - Concrete</option>
                                <option value=""3"">3 - Curb</option>
                                <option value=""4"">4 - Gravel</option>
                                <option value=""5"">5 - Earth</option>
       ");
            WriteLiteral(@"                         <option value=""6"">6 - Other</option>
                            </select>
                        </div>
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""width of the right road shoulder. Does not include bike lanes or sidewalks"">Right Shoulder <br /> Width</label>
                            <input id=""gather-RightShoulderWidth"" type=""text"" />
                        </div>
                        <div>
                            <label data-toggle=""tooltip"" data-placement=""top"" title=""The predominant surface type of the road shoulder. Does not include bike lanes or sidewalks"">Right Shoulder <br /> Surface</label>
                            <select id=""gather-RightShoulderSurface"">
                                <option></option>
                                <option value=""0"">0 - No shoulder</option>
                                <option value=""1"">1 - Asphalt</option>
                             ");
            WriteLiteral(@"   <option value=""2"">2 - Concrete</option>
                                <option value=""3"">3 - Curb</option>
                                <option value=""4"">4 - Gravel</option>
                                <option value=""5"">5 - Earth</option>
                                <option value=""6"">6 - Other</option>
                            </select>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id=""box-physical"" class=""property-box"">
            <h6>Physical Properties</h6>
            <div class=""grid-container"">
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""The predominant surface type for the road"">Surface <br /> Type</label>
                    <select id=""gather-SurfaceType"">
                        <option></option>
                        <option value=""0"">0 - unpaved</option>
                        <option value=""1"">1 - Asphalt</option>
      ");
            WriteLiteral(@"                  <option value=""2"">2 - Concrete - JPCP</option>
                        <option value=""4"">4 - Concrete - CRCP</option>
                        <option value=""5"">5 - Asphalt Over Concrete</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""The predominant lane width the road. Must be a whole number"">Lane <br /> Width</label>
                    <input id=""gather-LaneWidth"" type=""text"">
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""non-thu traffic lanes like turn lanes"">Extra <br /> Lanes</label>
                    <select id=""gather-ExtraLanes"">
                        <option></option>
                        <option value=""0"">0 - None</option>
                        <option value=""1"">1 - Center Turn Lane</option>
                        <option value=""2"">2 - Parking</option>
                 ");
            WriteLiteral(@"       <option value=""3"">3 - Passing</option>
                        <option value=""4"">4 - Combination</option>
                        <option value=""5"">5 - Right turn only</option>
                        <option value=""6"">6 - Left turn only</option>
                        <option value=""7"">7 - Auxiliary Lane</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Width of the roadway including shoulders"">Surface <br /> Width</label>
                    <input id=""gather-SurfaceWidth"" type=""text"">
                </div>
            </div>
            <div class=""grid-container"">
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Type Operation describes things like special one way direction roads"">Type <br /> Operation</label>
                    <select id=""gather-TypeOperation"">
                        <option></option>
                ");
            WriteLiteral(@"        <option value=""1"">1 - One way</option>
                        <option value=""2"">2 - Two Way Undivided</option>
                        <option value=""3"">3 - Part of a one-way couplet</option>
                        <option value=""4"">4 - Divided multi-lane</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Describes the amount of control the user has to drive due to constraints like medians and traffic islands"">Access</label>
                    <select id=""gather-Access"">
                        <option></option>
                        <option value=""1"">1 - Full Control</option>
                        <option value=""2"">2 - Partial Control</option>
                        <option value=""3"">3 - No Control</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Describes ma");
            WriteLiteral(@"terials and barriers in the median that help seperate the two lanes of traffic"">Median <br /> Type</label>
                    <select id=""gather-MedianType"">
                        <option></option>
                        <option value=""0"">0 - No median</option>
                        <option value=""1"">1 - Curbed</option>
                        <option value=""2"">2 - Positive Barrier</option>
                        <option value=""3"">3 - Unprotected</option>
                        <option value=""4"">4 - Natural Barrier</option>
                        <option value=""5"">5 - Cable Barrier</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Describes the length accross the median to the other lane of traffic"">Median <br /> Width</label>
                    <input id=""gather-MedianWidth"" type=""text"" />
                </div>

            </div>
        </div>
        <div id=""box-lane");
            WriteLiteral(@"s"" class=""property-box"">
            <h6>Lanes</h6>
            <div class=""grid-container"">
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""In a divided highway, the field describes the number of lanes in a single direction of travel. In non-divided highway segements"">One Direction Number of Lanes</label>
                    <input id=""gather-OneDirectionNumLanes"" type=""text"">
                </div>

            </div>
            <div class=""grid-container"">
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Total includes both directions of travel including in a divided highway"">Both Directions Number of Lanes</label>
                    <input id=""gather-BothDirectionNumLanes"" type=""text"">
                </div>
            </div>
        </div>
    </div>
    <div class=""master-grid"">
        <div id=""box-system"" class='property-box'>
            <h6>System Properties</h6>
            <d");
            WriteLiteral(@"iv class=""grid-container"">
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title='Classification on the FHWA Functional Class System. Please refer to ""Highway functional classification concepts, criteria and proedcures guide"".'>Functional <br /> Class</label>
                    <select id=""gather-FuncClass"">
                        <option></option>
                        <option value=""1"">1 - Interstate</option>
                        <option value=""2"">2 - Principal Arterial</option>
                        <option value=""3"">3 - Principal Arterial (other)</option>
                        <option value=""4"">4 - Minor Arterial</option>
                        <option value=""5"">5 - Major Collector</option>
                        <option value=""6"">6 - Minor Collector</option>
                        <option value=""7"">7 - Local</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""to");
            WriteLiteral(@"oltip"" data-placement=""top"" title=""National Highway System Status including intermodal connectors like major aiports and truck transfer stations"">NHS</label>
                    <select id=""gather-NHS"">
                        <option></option>
                        <option value=""0"">0 - Not on NHS</option>
                        <option value=""1"">1 - On NHS (not intermodal connector)</option>
                        <option value=""2"">2 - Major Airport</option>
                        <option value=""3"">3 - Major Port Facility</option>
                        <option value=""4"">4 - Major Amtrak Station</option>
                        <option value=""5"">5 - Major Rail/Truck Facility</option>
                        <option value=""6"">6 - Major Intercity bus Terminal</option>
                        <option value=""7"">7 - Major Public transit</option>
                        <option value=""8"">8 - Major Pipeline</option>
                        <option value=""9"">9 - Major Ferry Terminal</option>
    ");
            WriteLiteral(@"                </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""catagory on the Arkansas Primary Highway Network. "">APHN<br> </label>
                    <select id=""gather-APHN"">
                        <option></option>
                        <option value=""0"">0 - Not on APHN</option>
                        <option value=""1"">1 - National Highway System</option>
                        <option value=""2"">2 - Other Arterials</option>
                        <option value=""3"">3 - Critical Service Routes</option>
                        <option value=""4"">4 - Other High Traffic Routes</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Goverment agency that has ownership of the road segment"">Goverment <br /> Code</label>
                    <select id=""gather-GovermentCode"">
                        <option");
            WriteLiteral(@"></option>
                        <option value=""1"">01 - State Highway</option>
                        <option value=""02"">02 - County</option>
                        <option value=""04"">04 - City</option>
                        <option value=""60"">60 - Other Fed. Agency</option>
                        <option value=""63"">63 - Fish & Wildlife</option>
                        <option value=""64"">64 - US Forest Service</option>
                        <option value=""66"">66 - National Park Service</option>
                        <option value=""70"">70 - Corps of Engineers</option>
                        <option value=""72"">72 - Air force</option>
                        <option value=""73"">73 - Navy/marines</option>
                        <option value=""74"">74 - Army</option>
                        <option value=""80"">80 - unknown</option>
                        <option value=""21"">21 - Other State Agency</option>
                    </select>
                </div>
                <div>
       ");
            WriteLiteral(@"             <label data-toggle=""tooltip"" data-placement=""top"" title=""Membership in a specialized highway system"">Special <br /> Systems</label>
                    <select id=""gather-SpecialSystems"">
                        <option></option>
                        <option value=""1"">1 - Not a special System</option>
                        <option value=""3"">3 - Airport Road</option>
                        <option value=""4"">4 - Game & Fish Road</option>
                        <option value=""5"">5 - Industrail Access Road</option>
                        <option value=""6"">6 - Institutional Road</option>
                        <option value=""7"">7 - State Park Road</option>
                        <option value=""8"">9 - STRAHNET Route</option>
                    </select>
                </div>
                <div>
                    <label data-toggle=""tooltip"" data-placement=""top"" title=""Indicates if the road is close or open to traffic. Also indicates if its a segement that is not tracked as ");
            WriteLiteral(@"part of the roadway inventory"">System <br /> Status</label>
                    <select id=""gather-SystemStatus"">
                        <option></option>
                        <option value=""1"">1 - Open</option>
                        <option value=""2"">2 - Not Open</option>
                        <option value=""3"">3 - Untracked</option>
                    </select>
                </div>
            </div>
        </div>
        <div id=""box-alternate"" class='property-box'>
            <h6 data-toggle=""tooltip"" data-placement=""top"" title=""Intended to hold additional road names of dual signed roads (Example Road that are designated as both a state highway and US route)"">Alternate Route Names</h6>
            <div>
                <button>-</button><input type=""text"" />
            </div>
            <div>
                <button>-</button><input type=""text"" />
            </div>
            <div>
                <button>-</button><input type=""text"" />
            </div>
            ");
            WriteLiteral(@"<div>
                <button>+</button><input type=""text"" />
            </div>
        </div>
    </div>

    <div class=""master-grid"">
        <div id=""box-comments"">
            <h6>Comments</h6>
            <textarea></textarea>
        </div>
        <div id=""box-dynamic"" class='property-box'>
            <h6>Dynamic Fields</h6>
            <p>These Fields Automatically get added to the interface if new fields are added to the roadway inventory database table</p>
        </div>

    </div>

    <div class=""grid-container"">

        <div>
            <button id=""button-save"" data-toggle=""tooltip"" data-placement=""top"" title=""Save new segement to the backend database"" class=""segment-button"">Save</button>
        </div>
        <div>
            <button data-toggle=""tooltip"" data-placement=""top"" title=""Reset the changes to whatever state it was before you started applying changes"" class=""segment-button"">Reset Changes</button>
        </div>
        <div>
            <button data-t");
            WriteLiteral(@"oggle=""tooltip"" data-placement=""top"" title=""Create a 100% duplicate record from the currently selected record"" class=""segment-button"">Duplicate record</button>
        </div>
        <div>
            <button data-toggle=""tooltip"" data-placement=""top"" title=""copy the currently selected record except flip the attributes so its sitting on the opposite side of a divided highway"" class=""segment-button"">Mirror Record</button>
        </div>
        <div>
            <a href=""#"">View Segment <br> Map</a>
        </div>
        <div>
            <button data-toggle=""tooltip"" data-placement=""top"" title=""Manually Override the error's to submit an exception case"" class=""segment-button"">Manual Override</button>
        </div>
    </div>

</div>



<script>
    $(document).ready(function () {
        $('[data-toggle=""tooltip""]').tooltip();
    });
</script>
<script src=""scripts/validate.js""></script>
<script src=""scripts/gatherinput.js""></script>");
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
