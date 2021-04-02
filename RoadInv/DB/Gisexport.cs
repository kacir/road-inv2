using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class Gisexport
    {
        public int Objectid { get; set; }
        public string AhRoadId { get; set; }
        public string AhCounty { get; set; }
        public string AhRoute { get; set; }
        public string AhSection { get; set; }
        public decimal? AhBlm { get; set; }
        public decimal? AhElm { get; set; }
        public short? Nhs { get; set; }
        public short? NhsSummary { get; set; }
        public short? Aphn { get; set; }
        public short? FunctionalClass { get; set; }
        public short? SpecialSystems { get; set; }
        public short? SystemStatus { get; set; }
        public short? TypeRoad { get; set; }
        public short? RouteSign { get; set; }
        public short? Access { get; set; }
        public short? TypeOperation { get; set; }
        public short? MedianType { get; set; }
        public short? MedianWidth { get; set; }
        public short? SurfaceType { get; set; }
        public int? LaneWidth { get; set; }
        public int? SurfaceWidth { get; set; }
        public short? RightShoulderSurface { get; set; }
        public short? LeftShoulderSurface { get; set; }
        public int? RightShoulderWidth { get; set; }
        public int? LeftShoulderWidth { get; set; }
        public int? RoadwayWidth { get; set; }
        public short? ExtraLanes { get; set; }
        public string Psr { get; set; }
        public string CrewNumber { get; set; }
        public string SampleId { get; set; }
        public short? HpmsSection { get; set; }
        public string RoadId { get; set; }
        public int? IsStructure { get; set; }
        public int? HovType { get; set; }
        public int? HovLanes { get; set; }
        public int? PeakLanes { get; set; }
        public int? CounterPeakLanes { get; set; }
        public int? TurnLanesR { get; set; }
        public int? TurnLanesL { get; set; }
        public int? Speedlimit { get; set; }
        public int? TollCharged { get; set; }
        public int? SignalType { get; set; }
        public int? PctGreenTime { get; set; }
        public int? NumberSignals { get; set; }
        public int? StopSigns { get; set; }
        public int? AtGradeOther { get; set; }
        public int? MedianWidth1 { get; set; }
        public int? PeakParking { get; set; }
        public int? WideningPotential { get; set; }
        public int? PctPassSight { get; set; }
        public string YearLastConstruction { get; set; }
        public decimal? LastOverlayThickness { get; set; }
        public decimal? ThicknessRigid { get; set; }
        public decimal? ThicknessFlexible { get; set; }
        public int? BaseType { get; set; }
        public int? BaseThickness { get; set; }
        public string LogDirection { get; set; }
        public string YearIri { get; set; }
        public string YearBuilt { get; set; }
        public string YearRecon { get; set; }
        public string RoughCode { get; set; }
        public string WideningObstacle { get; set; }
        public string Terrain { get; set; }
        public string UrbanAreaCode { get; set; }
        public int? UniqueId { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastEditedUser { get; set; }
        public DateTime? LastEditedDate { get; set; }
        public decimal ShapeStlength { get; set; }
        public string Comment { get; set; }
        public string ArnoldConv { get; set; }
        public decimal? LegacyLogMile { get; set; }
        public decimal? LegacyEndLogmile { get; set; }
        public string AhDistrict { get; set; }
        public string LocError { get; set; }
        public decimal? AhLength { get; set; }
        public string GlobalId { get; set; }
        public short? AdtYear { get; set; }
        public int? Adt { get; set; }
        public string RdClass { get; set; }
        public string RdDesign { get; set; }
        public string RdSurftyp { get; set; }
        public short? GovernmentCode { get; set; }
        public short? RuralUrbanArea { get; set; }
        public short? TotalLanes { get; set; }
        public short? TravelLanes { get; set; }
        public string Temp { get; set; }
    }
}
