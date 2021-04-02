using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class LegacyDatum
    {
        public int AhDistrict { get; set; }
        public string AhCounty { get; set; }
        public string AhRoute { get; set; }
        public string AhSection { get; set; }
        public string LogDirect { get; set; }
        public string AhBlm { get; set; }
        public string AhElm { get; set; }
        public string GovermentCode { get; set; }
        public string RuralUrbanArea { get; set; }
        public string UrbanAreaCode { get; set; }
        public string FuncClass { get; set; }
        public string Nhs { get; set; }
        public string SystemStatus { get; set; }
        public string SpecialSystem { get; set; }
        public string OneDirectionNumLanes { get; set; }
        public string Comment1 { get; set; }
        public string TypeRoad { get; set; }
        public string RouteSign { get; set; }
        public string Aphn { get; set; }
        public string Access { get; set; }
        public string TypeOperation { get; set; }
        public string YearBuilt { get; set; }
        public string YearRecon { get; set; }
        public string MedianWidth { get; set; }
        public int LaneWidth { get; set; }
        public int SurfaceWidth { get; set; }
        public string RightShoulderSurface { get; set; }
        public string LeftShoulderSurface { get; set; }
        public string RightShoulderWidth { get; set; }
        public string LeftShoulderWidth { get; set; }
        public int RoadwayWidth { get; set; }
        public string ExtraLanes { get; set; }
        public string MedianType { get; set; }
        public string SurfaceType { get; set; }
        public string AlternativeRouteName { get; set; }
    }
}
