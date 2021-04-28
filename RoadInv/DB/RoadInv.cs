using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RoadInv.DB
{
    public partial class RoadInv
    {
        public int Id { get; set; }
        public string AhDistrict { get; set; }
        public string AhCounty { get; set; }
        public string AhRoute { get; set; }
        public string AhSection { get; set; }
        public string LogDirect { get; set; }
        public string AhRoadId { get; set; }
        public string GovermentCode { get; set; }
        public string RuralUrbanArea { get; set; }
        public string UrbanAreaCode { get; set; }
        public string FuncClass { get; set; }
        public string Nhs { get; set; }
        public string SystemStatus { get; set; }
        public string SpecialSystems { get; set; }
        public string BothDirectionNumLanes { get; set; }
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
        public int? LaneWidth { get; set; }
        public int? SurfaceWidth { get; set; }
        public string RightShoulderSurface { get; set; }
        public string LeftShoulderSurface { get; set; }
        public int? RightShoulderWidth { get; set; }
        public int? LeftShoulderWidth { get; set; }
        public int? RoadwayWidth { get; set; }
        public string ExtraLanes { get; set; }
        public string YearAdt { get; set; }
        public string MedianType { get; set; }
        public string SurfaceType { get; set; }
        public string AlternativeRouteName { get; set; }
        public string LegacyId { get; set; }
        public decimal? LegacyBlm { get; set; }
        public decimal? LegacyElm { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? Gisid { get; set; }
        public DateTime? GiscreateDate { get; set; }
        public string GiscreatedUser { get; set; }
        public string GislastEditedUser { get; set; }
        public DateTime? GislastEditedDate { get; set; }
        public string ArnoldConv { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? AhBlm { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? AhElm { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? AhLength { get; set; }
    }
}
