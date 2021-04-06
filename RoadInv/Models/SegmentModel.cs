using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SegmentModel : Object
        //record details for a single roadway inventory record, either existing or new
    {
        public int ID { set; get; }
        public string AH_District { set; get; }
        public string AH_County { set; get; }
        public string AH_Route { set; get; }
        public string AH_Section { set; get; }
        public string LOG_DIRECT { set; get; }
        public string AH_RoadID { set; get; }
        public string GovermentCode { set; get; }
        public string RuralUrbanArea { set; get; }
        public string UrbanAreaCode { set; get; }
        public string FuncClass { set; get; }
        public string NHS { set; get; }
        public string SystemStatus { set; get; }
        public string SpecialSystems { set; get; }
        public string BothDirectionNumLanes { set; get; }
        public string OneDirectionNumLanes { set; get; }
        public string Comment1 { set; get; }
        public string TypeRoad { set; get; }
        public string RouteSign { set; get; }
        public string APHN { set; get; }
        public string Access { set; get; }
        public string TypeOperation { set; get; }
        public string YearBuilt { set; get; }
        public string yearRecon { set; get; }
        public string MedianWidth { set; get; }
        public string LaneWidth { set; get; }
        public int SurfaceWidth { set; get; }
        public string RightShoulderSurface { set; get; }
        public string LeftShoulderSurface { set; get; }
        public int RightShoulderWidth { set; get; }
        public int LeftShoulderWidth { set; get; }
        public int RoadwayWidth { set; get; }
        public string ExtraLanes { set; get; }
        public string MedianType { set; get; }
        public string SurfaceType { set; get; }
        public string Alternative_Route_Name { set; get; }
        public string LegacyID { set; get; }
        public decimal LegacyBLM { set; get; }
        public decimal legacyELM { set; get; }
        public string UpdateUserID { set; get; }
        public DateTime UpdateDate { set; get; }
        public int GISID { set; get; }
        public DateTime GIScreate_date { set; get; }
        public string GIScreate_user { set; get; }
        public string GISLast_edited_user { set; get; }
        public DateTime GISLast_edited_date { set; get; }
        public string Arnold_conv { set; get; }
        public decimal AH_BLM { set; get; }
        public decimal AH_ELM { set; get; }
        public decimal AH_Length { set; get; }
        public string SectionCode { set; get; }
        public string SectionCodeName { set; get; }

        public int CleanAttr(int id = 0) {
            //trims white space from string attributes and changes them to upper case to match ARNOLD
            if (this.AH_District is not null)
            {
                this.AH_District = this.AH_District.Trim().ToUpper();
            } else
            {
                this.AH_District = "";
            }

            if (this.AH_County is not null)
            {
                this.AH_County = this.AH_County.Trim().ToUpper();
            }

            if (this.AH_Route is not null)
            {
                this.AH_Route = this.AH_Route.Trim().ToUpper();
            } else
            {
                this.AH_Route = "";
            }
            
            if (this.AH_Section is not null)
            {
                this.AH_Section = this.AH_Section.Trim().ToUpper();
            } else
            {
                this.AH_Section = "";
            }
            
            if (LOG_DIRECT is not null)
            {
                LOG_DIRECT = LOG_DIRECT.Trim().ToUpper();
            } else
            {
                LOG_DIRECT = "";
            }

            if (this.AH_RoadID is not null)
            {
                this.AH_RoadID = this.AH_RoadID.Trim().ToUpper();
            } else
            {
                this.AH_RoadID = "";
            }
            
            if (this.GovermentCode is not null)
            {
                this.GovermentCode = this.GovermentCode.Trim().ToUpper();
            } else
            {
                this.GovermentCode = "";
            }

            if (this.RuralUrbanArea is not null)
            {
                this.RuralUrbanArea = RuralUrbanArea.Trim().ToUpper();
            } else
            {
                this.RuralUrbanArea = "";
            }
            
            if (UrbanAreaCode is not null)
            {
                this.UrbanAreaCode = UrbanAreaCode.Trim().ToUpper();
            } else
            {
                this.UrbanAreaCode = "";
            }
            
            if (this.FuncClass is not null)
            {
                this.FuncClass = this.FuncClass.Trim().ToUpper();
            } else
            {
                this.FuncClass = "";
            }
            
            if (this.NHS is not null)
            {
                this.NHS = this.NHS.Trim().ToUpper();
            } else
            {
                this.NHS = "";
            }

            if (this.SpecialSystems is not null)
            {
                this.SpecialSystems = this.SpecialSystems.Trim().ToUpper();
            } else
            {
                this.SpecialSystems = "";
            }
            
            if (this.BothDirectionNumLanes is not null)
            {
                this.BothDirectionNumLanes = this.BothDirectionNumLanes.Trim().ToUpper();
            } else
            {
                this.BothDirectionNumLanes = "";
            }

            if (OneDirectionNumLanes is not null)
            {
                this.OneDirectionNumLanes = this.OneDirectionNumLanes.Trim().ToUpper();
            } else
            {
                this.OneDirectionNumLanes = "";
            }
            
            if (this.Comment1 is not null)
            {
                this.Comment1 = this.Comment1.Trim(); //need to keep upper case in comments field 
            } else
            {
                this.Comment1 = "";
            }

            if (this.TypeRoad is not null)
            {
                this.TypeRoad = this.TypeRoad.Trim().ToUpper();
            } else
            {
                this.TypeRoad = "";
            }
            
            if (this.RouteSign is not null)
            {
                this.RouteSign = this.RouteSign.Trim().ToUpper();
            } else
            {
                this.RouteSign = "";
            }
            
            if (this.APHN is not null)
            {
                this.APHN = this.APHN.Trim().ToUpper();
            } else
            {
                this.APHN = "";
            }
            
            if (this.Access is not null)
            {
                this.Access = this.Access.Trim().ToUpper();
            } else
            {
                this.Access = "";
            }

            if (this.TypeOperation is not null)
            {
                this.TypeOperation = this.TypeOperation.Trim().ToUpper();
            } else
            {
                this.TypeOperation = "";
            }

            if (this.YearBuilt is not null)
            {
                this.YearBuilt = this.YearBuilt.Trim().ToUpper();
            } else
            {
                this.YearBuilt = "";
            }
            
            if (this.yearRecon is not null)
            {
                this.yearRecon = this.yearRecon.Trim().ToUpper();
            } else
            {
                this.yearRecon = "";
            }

            if (this.MedianWidth is not null)
            {
                this.MedianWidth = this.MedianWidth.Trim().ToUpper();
            } else
            {
                this.MedianWidth = "";
            }

            if (this.LaneWidth is not null)
            {
                this.LaneWidth = this.LaneWidth.Trim().ToUpper();
            } else
            {
                this.LaneWidth = "";
            }

            if (this.RightShoulderSurface is not null)
            {
                this.RightShoulderSurface = this.RightShoulderSurface.Trim().ToUpper();
            } else
            {
                this.RightShoulderSurface = "";
            }

            if (this.LeftShoulderSurface is not null)
            {
                this.LeftShoulderSurface = this.LeftShoulderSurface.Trim().ToUpper();
            } else
            {
                this.LeftShoulderSurface = "";
            }
            
            if (this.ExtraLanes is not null)
            {
                this.ExtraLanes = this.ExtraLanes.Trim().ToUpper();
            } else
            {
                this.ExtraLanes = "";
            }
            
            if (this.MedianType is not null)
            {
                this.MedianType = this.MedianType.Trim().ToUpper();
            } else
            {
                this.MedianType = "";
            }

            if (this.SurfaceType is not null)
            {
                this.SurfaceType = this.SurfaceType.Trim().ToUpper();
            } else
            {
                this.SurfaceType = "";
            }
            
            if (this.Alternative_Route_Name is not null)
            {
                this.Alternative_Route_Name = this.Alternative_Route_Name.Trim().ToUpper();
            } else
            {
                this.Alternative_Route_Name = "";
            }

            if (this.UpdateUserID is not null)
            {
                this.UpdateUserID = this.UpdateUserID.Trim().ToUpper();
            } else
            {
                this.UpdateUserID = "";
            }

            if (this.GIScreate_user is not null)
            {
                this.GIScreate_user = this.GIScreate_user.Trim().ToUpper();
            } else
            {
                this.GIScreate_user = "";
            }

            if (this.GISLast_edited_user is not null)
            {
                this.GISLast_edited_user = this.GISLast_edited_user.Trim().ToUpper();
            } else
            {
                this.GISLast_edited_user = "";
            }
            
            if (this.Arnold_conv is not null)
            {
                this.Arnold_conv = this.Arnold_conv.Trim().ToUpper();
            } else
            {
                this.Arnold_conv = "";
            }
            
            

            return 0;
        }


        public SegmentModel Mirror(string section, decimal BLM, decimal ELM)
        {
            //generates a mirror image segement of for use in duel carrageway roads
            SegmentModel mirror = new SegmentModel();

            mirror.ID = -1;
            mirror.AH_District = AH_District;
            mirror.AH_County = AH_County;
            mirror.AH_Route = AH_Route;
            mirror.AH_Section = section;

            //mirror to opposite side of dual carraigeway
            if (LOG_DIRECT == "A")
            {
                mirror.LOG_DIRECT = "B";
            } else if (LOG_DIRECT == "B")
            {
                mirror.LOG_DIRECT = "A";
            }
            //mirror the road id because of the section and direction changed
            mirror.AH_RoadID = AH_County + "x" + AH_Route + "x" + section + "x" + mirror.LOG_DIRECT;

            mirror.GovermentCode = GovermentCode;
            mirror.RuralUrbanArea = RuralUrbanArea;
            mirror.UrbanAreaCode = UrbanAreaCode;
            mirror.FuncClass = GovermentCode;
            mirror.NHS = NHS;
            mirror.SystemStatus = SystemStatus;
            mirror.SpecialSystems = SpecialSystems;
            mirror.BothDirectionNumLanes = BothDirectionNumLanes;
            if (int.TryParse(OneDirectionNumLanes, out _) & int.TryParse(BothDirectionNumLanes, out _))
            {
                mirror.OneDirectionNumLanes =  (int.Parse(BothDirectionNumLanes) - int.Parse(OneDirectionNumLanes)).ToString();
            }
            mirror.Comment1 = Comment1;
            mirror.TypeRoad = TypeRoad;
            mirror.RouteSign = RouteSign;
            mirror.APHN = TypeRoad;
            mirror.Access = Access;
            mirror.TypeOperation = TypeOperation;
            mirror.YearBuilt = YearBuilt;
            mirror.yearRecon = TypeRoad;
            mirror.MedianWidth = MedianWidth;
            mirror.LaneWidth = LaneWidth;
            mirror.SurfaceWidth = SurfaceWidth;

            //mirror shoulder characterstics
            mirror.RightShoulderSurface = LeftShoulderSurface;
            mirror.LeftShoulderSurface = RightShoulderSurface;
            mirror.RightShoulderWidth = RightShoulderWidth;
            mirror.LeftShoulderWidth = LeftShoulderWidth;

            mirror.RoadwayWidth = RoadwayWidth;
            mirror.ExtraLanes = ExtraLanes;
            mirror.MedianType = MedianType;
            mirror.SurfaceType = SurfaceType;
            mirror.Alternative_Route_Name = Alternative_Route_Name;
            mirror.AH_BLM = BLM;
            mirror.AH_ELM = ELM;
            

            return mirror;
        }

    }


}
