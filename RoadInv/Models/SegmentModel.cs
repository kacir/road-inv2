using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SegmentModel : Object
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
            //generates a mirror image segement of 
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

        public List<ErrorItemModel> FindErrors ()
        {
            List <ErrorItemModel> masterErrorsList = new List<ErrorItemModel>();

            //look for missing properties in first few standard properties
            List<string> missingProperties = new List<string>();

            if (this.AH_County is null | this.AH_County.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_County);
            }

            if (this.AH_Route is null | this.AH_Route.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Route);
            }

            if (this.AH_Section is null | this.AH_Section.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Section);
            }

            if (this.LOG_DIRECT is null | this.LOG_DIRECT.Length == 0)
            {
                missingProperties.Add(FieldsListModel.LOG_DIRECT);
            }

            if (this.AH_BLM < 0)
            {
                missingProperties.Add(FieldsListModel.AH_BLM);
            }

            if (this.AH_ELM < 0)
            {
                missingProperties.Add(FieldsListModel.AH_ELM);
            }
            //generate first error
            if (missingProperties.Count > 0)
            {
                ErrorItemModel coreMissing = new ErrorItemModel("Core Fields Missing", "Several Core fields are missing values", missingProperties);
                masterErrorsList.Add(coreMissing);
            }

            //check to make sure district is valid
            if (!(AH_District is null) & !(AH_District == "") & !ErrorItemModel.validDistrict.Contains(AH_District))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_District);
                ErrorItemModel districtError = new ErrorItemModel("AH_District Invalid", "AH_District value is not in list of valid values for field", temp);
            }
            
            
            //BLM and ELM validation
            if (this.AH_ELM == this.AH_BLM)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is same as ending logmile", temp);
                masterErrorsList.Add(extentError);
            }
            if (this.AH_BLM > this.AH_ELM)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is greater than ending logmile", temp);
                masterErrorsList.Add(extentError);
            }

            //checking other core attributes
            if (this.AH_Route.Length > 100)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);
                ErrorItemModel routeError = new ErrorItemModel("AH_Route > 100 char", "AH_Route field is greater than 100 characters long", temp);
                masterErrorsList.Add(routeError);
            }
            if (ErrorItemModel.checkInvalidCharacters( this.AH_Route).Count > 0)
            {
                AH_Route = AH_Route.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);

                string longError = "";
                foreach(char item in ErrorItemModel.checkInvalidCharacters(AH_Route).ToString())
                {
                    longError = longError + item.ToString() + ", ";
                }
                longError = longError.Substring(longError.Length - 2);
                ErrorItemModel routeError = new ErrorItemModel(@"AH_Route- invalid character(s)", "AH_Route field only allows " +
                    "numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                masterErrorsList.Add(routeError);

            }
            if (ErrorItemModel.checkInvalidCharacters(this.AH_Section).Count > 0)
            {
                this.AH_Section = this.AH_Section.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Section);
                string longError = "";

                foreach (char item in ErrorItemModel.checkInvalidCharacters(AH_Section).ToString())
                {
                    longError = longError + item.ToString() + ", ";
                }
                longError = longError.Substring(longError.Length - 2);
                ErrorItemModel routeError = new ErrorItemModel(@"AH_Section invalid character(s)", "AH_Section field only allows " +
    "numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                masterErrorsList.Add(routeError);
            }
            //Check if direction is valid
            if (!(this.LOG_DIRECT.ToUpper() == "A" | this.LOG_DIRECT.ToUpper() == "B"))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LOG_DIRECT);
                ErrorItemModel error = new ErrorItemModel("LOG_DIRECT not valid", "The LOG_DIRECT/Direction field does contain a " +
                    "valid valid. values must be A or B and nothing else", temp);
                masterErrorsList.Add(error);
            }

            //check section field is not too long
            if (this.AH_Section.Length > 3)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Section);
                ErrorItemModel error = new ErrorItemModel("AH_Section > 3 chars", "AH_Section field can only be three characters long according to ARNOLD", temp);
                masterErrorsList.Add(error);
            }

            //check for valid county value
            if (!ErrorItemModel.validCounty.Contains(this.AH_County))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_County);
                ErrorItemModel error = new ErrorItemModel("AH_County Invalid", "AH_County is not a valid character set according to database", temp);
                masterErrorsList.Add(error);
            }
            else {
                //if the county codes are valid too then check the county district pairing list
                if (ErrorItemModel.validDistrict.Contains(AH_District))
                {
                    bool validPair = false;
                    foreach(KeyValuePair<string, string> x in ErrorItemModel.validDistrictCountyPair)
                    {
                        if (x.Key == AH_County & x.Value == AH_District)
                        {
                            validPair = true;
                        }
                        
                    }
                    if (!validPair)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.AH_County);
                        temp.Add(FieldsListModel.AH_District);
                        ErrorItemModel error = new ErrorItemModel("invalid AH_District AH_County Pair", "The Choosen AH_District @and AH_County values do " +
                            "not make sense together. ArDOT districts contain only certain countys. Some Pairings are not logical. " +
                            "Please refer to a district map.", temp);
                        masterErrorsList.Add(error);
                    }
                }
            }

            if (!(GovermentCode == "") & !(GovermentCode is null)  & !ErrorItemModel.validGovermentCode.Contains(this.GovermentCode))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.GovermentCode);
                ErrorItemModel error = new ErrorItemModel("invalid Goverement Code", 
                    "Goverment code is not one of the pre-defined codes in the database", temp);
                masterErrorsList.Add(error);
            }

            if (!(RouteSign == "" & !(RouteSign is null)) & !ErrorItemModel.validRouteSign.Contains(this.RouteSign))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RouteSign);

                ErrorItemModel error = new ErrorItemModel("invalid Route Sign", "Routes sign is not a value of 1, 2, or 3", temp);
                masterErrorsList.Add(error);
            } else
            {
                if (ErrorItemModel.validGovermentCode.Contains(this.GovermentCode))
                {
                    if ((RouteSign == "1" | RouteSign == "2" | RouteSign == "3") & GovermentCode != "01" | !(RouteSign == "1" | RouteSign == "2" | RouteSign == "3") & this.GovermentCode == "01")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.RouteSign);
                        temp.Add(FieldsListModel.GovermentCode);
                        ErrorItemModel error = new ErrorItemModel("Invalid RouteSign Goverement Code Pair", "Interstates, US routes, and state highway must be managed have a goverment code for ArDOT managment", temp);
                        masterErrorsList.Add(error);
                    }
                }
            }

            //RuralUrbanArea -Code Line 413
            if (!(RuralUrbanArea == "") & !(RuralUrbanArea is null) &  !ErrorItemModel.validRuralUrbanArea.Contains(RuralUrbanArea))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RuralUrbanArea);
                ErrorItemModel error = new ErrorItemModel("Rural Urban Area invalid", "Rural urban area is not valid needs to be one of the sected values in the database.", temp);
                masterErrorsList.Add(error);
            }

            if (!(UrbanAreaCode == "") & !(UrbanAreaCode is null) & !ErrorItemModel.validUrbanAreaCode.Contains(UrbanAreaCode))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.UrbanAreaCode);
                ErrorItemModel error = new ErrorItemModel("Urban Area Code invalid", "Urban Area code is not one of the valid urban codes according to the database.", temp);
                masterErrorsList.Add(error);
            } else if (ErrorItemModel.validUrbanAreaCode.Contains(UrbanAreaCode) & ErrorItemModel.validRuralUrbanArea.Contains(RuralUrbanArea))
            {
                if ((RuralUrbanArea == "3" | RuralUrbanArea == "4") & UrbanAreaCode == "00000")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RuralUrbanArea);
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    ErrorItemModel error = new ErrorItemModel("Rural Urban Area / Urban Code Pair Invalid", "Small Urganized and Urbanized areas must have Urban Area Code", temp);
                    masterErrorsList.Add(error);
                }

                if ((RuralUrbanArea == "1" | RuralUrbanArea == "2") & !(UrbanAreaCode == "00000"))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RuralUrbanArea);
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    ErrorItemModel error = new ErrorItemModel("Rural Urban Area / Urban Code Pair Invalid", "Rural Areas should not have an Urban Area Code. Urban Area Code should be 00000", temp);
                    masterErrorsList.Add(error);
                }
            } else if (ErrorItemModel.validCounty.Contains(AH_County) & ErrorItemModel.validUrbanAreaCode.Contains(UrbanAreaCode) & UrbanAreaCode != "00000")
            {
                bool validPair = false;
                foreach (KeyValuePair<string, string> x in ErrorItemModel.validUrbanCountyPair)
                {
                    if (x.Key == AH_County & x.Value == UrbanAreaCode)
                    {
                        validPair = true;
                    }

                }
                if (!validPair)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    temp.Add(FieldsListModel.AH_County);
                    ErrorItemModel error = new ErrorItemModel("Invalid County Urban Code Pair", "UrbanArea Code does not match county field. Specific urban areas are only in certain counties", temp);
                    masterErrorsList.Add(error);
                }
            }

            //main functional class checks
            if ( !(FuncClass is null) & (FuncClass == "") & !ErrorItemModel.validFuncClass.Contains(FuncClass))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.FuncClass);
                ErrorItemModel error = new ErrorItemModel("Invalid Functional Class", "functional class is not one of the specified classes 1-7", temp);
                masterErrorsList.Add(error);
            } else if (ErrorItemModel.validFuncClass.Contains(FuncClass) & ErrorItemModel.validRouteSign.Contains(RouteSign))
            {
                if (RouteSign == "1" & FuncClass != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RouteSign);
                    temp.Add(FieldsListModel.FuncClass);
                    ErrorItemModel error = new ErrorItemModel("Invalid Func and RouteSign Pair", @"If Route Sign is 1 - Interstate, 
the functional class needs to be interstate too.", temp);
                    masterErrorsList.Add(error);
                }
                if (RouteSign == "1" && FuncClass != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RouteSign);
                    temp.Add(FieldsListModel.FuncClass);
                    ErrorItemModel error = new ErrorItemModel("Invalid Func and RouteSign Pair", @"If Functional Class is is 1 
(Interstate), the Route Sign needs to be interstate too.", temp);
                    masterErrorsList.Add(error);
                }
            }

            //line 473
            if (!(SystemStatus is null) & !(SystemStatus == "") &  !ErrorItemModel.validSystemStatus.Contains(SystemStatus))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.SystemStatus);
                ErrorItemModel error = new ErrorItemModel("invalid System Status", "System Status does not contain a valid value", temp);
                masterErrorsList.Add(error);
            }

            if (!(TypeRoad is null) & !(TypeRoad == "") & !ErrorItemModel.validTypeRoad.Contains(TypeRoad))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeRoad);
                ErrorItemModel error = new ErrorItemModel("invalid Type Road", "Type Road value is invalid", temp);
                masterErrorsList.Add(error);
            }

            decimal outMedianWidth;
            if (!(MedianWidth is null) & !(MedianWidth == "") & !decimal.TryParse(MedianWidth, out outMedianWidth))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.MedianWidth);
                ErrorItemModel error = new ErrorItemModel("MedianWidth not number", "Median Width cannot be converted into a number", temp);
                masterErrorsList.Add(error);
            }

            if (!(MedianType is null) & !(MedianType == "") & !ErrorItemModel.validMedianType.Contains(MedianType))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.MedianType);
                ErrorItemModel error = new ErrorItemModel("MedianType Invalid", "Median Type is not a valid coded value", temp);
                masterErrorsList.Add(error);
            } else if (ErrorItemModel.validMedianType.Contains(MedianType) & decimal.TryParse(MedianWidth, out outMedianWidth))
            {
                string[] SelectedMedianTypes = { "1", "2", "3", "4", "5" };
                string[] selectedMedianWidths = {null, "", "00000" };
                if (SelectedMedianTypes.Contains(MedianType) & selectedMedianWidths.Contains(MedianWidth))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Invalid MedianWidth MedianType Pair", @"Median Type indicates there is 
                        a median but the Median Width is null.", temp);
                    masterErrorsList.Add(error);
                }
                if (MedianType == "1" & !selectedMedianWidths.Contains(MedianWidth))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Invalid MedianWidth MedianType Pair", @"Median Type indicates there is 
                        no median but the Median width is not zero", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(TypeOperation is null) & !(TypeOperation == "") & !ErrorItemModel.validTypeOperation.Contains(TypeOperation))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeOperation);
                ErrorItemModel error = new ErrorItemModel("Type Operation not Valid", "Type Operation value is not valid", temp);
                masterErrorsList.Add(error);
            } 
            else if (ErrorItemModel.validTypeOperation.Contains(TypeOperation))
            {
                string[] selectedMedianWidth = { null, "", "00000" };
                if (selectedMedianWidth.Contains(MedianType) & TypeOperation == "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.MedianType);
                    ErrorItemModel error = new ErrorItemModel("Type Operation MedianType Pair invalid", @"Type Operation indicates the 
road is divided so it should have a median but the median type indicates there is no median", temp);
                    masterErrorsList.Add(error);
                }

                if (MedianWidth == "0" & TypeOperation == "4")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Type Operation MedianType Pair invalid", @"Type Operation indicates the 
road is divided so it should have a median but the median type indicates there is no median", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(Access == "") & (Access is null ) & !ErrorItemModel.validAccess.Contains(Access))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.Access);
                ErrorItemModel error = new ErrorItemModel("invalid Access", "Access is value is not valid", temp);
                masterErrorsList.Add(error);
            } 
            else if (ErrorItemModel.validRouteSign.Contains(RouteSign))
            {
                if ((RouteSign == "1" & Access != "1") | (RouteSign != "1" & Access == "1"))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RouteSign);
                    temp.Add(FieldsListModel.Access);
                    ErrorItemModel error = new ErrorItemModel("Route Sign Access Pair invalid", "Route Sign Interstate (1) segmeents must also have accesss be 3 - No Control and vice versa", temp);
                    masterErrorsList.Add(error);
                }
            } 
            else if (ErrorItemModel.validTypeOperation.Contains(TypeOperation))
            {
                if (Access == "1" & TypeOperation != "4")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.Access);
                    ErrorItemModel error = new ErrorItemModel("Access/Type Operation Pair invalid", "If access is full control (1) then Type Operation must be divided highway (1)", temp);
                    masterErrorsList.Add(error);
                }
            } 
            else if (ErrorItemModel.validMedianType.Contains(MedianType))
            {
                if (Access == "3" & MedianType != "0"){
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.Access);
                    ErrorItemModel error = new ErrorItemModel("Median Type Access Pair invalid", "If Access is no control (3) then the road has a median so MedianType should not be 0", temp);
                    masterErrorsList.Add(error);
                }
            } 
            else if (decimal.TryParse(MedianWidth ,out _))
            {
                if (MedianWidth == "0" & Access == "3")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianWidth);
                    temp.Add(FieldsListModel.Access);
                    ErrorItemModel error = new ErrorItemModel("Median Width Access Pair invalid", "If Access is no control (3) then the road has no a median so MedianWidth should be greater than 0", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(APHN is null) & APHN != "" & !ErrorItemModel.validAPHN.Contains(APHN))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.APHN);
                ErrorItemModel error = new ErrorItemModel("APHN invalid", "APHN value is not valid", temp);
                masterErrorsList.Add(error);
            }

            if (!(NHS is null) & NHS != "" & !ErrorItemModel.validNHS.Contains(NHS))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.NHS);
                ErrorItemModel error = new ErrorItemModel("NHS invalid", "NHS value is not valid", temp);
            }

            //Highy compound check on a few attributes
            if (RouteSign == "1" & TypeRoad == "1")
            {
                if (ErrorItemModel.validNHS.Contains(NHS) & NHS != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    ErrorItemModel error = new ErrorItemModel("RouteSign/ NHS pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the NHS (1-Interstate)", temp);
                    masterErrorsList.Add(error);
                }

                if (ErrorItemModel.validAPHN.Contains(APHN) & APHN != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.APHN);
                    ErrorItemModel error = new ErrorItemModel("RouteSign APHN pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the APHN (1- Interstate).", temp);
                    masterErrorsList.Add(error);
                }
            }
            
            if (RouteSign == "2" | RouteSign == "3" & TypeRoad == "1" && NHS != "0")
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RouteSign);
                temp.Add(FieldsListModel.TypeRoad);
                temp.Add(FieldsListModel.NHS);

                ErrorItemModel error = new ErrorItemModel("NHS inconsistancy", "All US Routes and State Highway are are on the NHS are automatically placed on the APHN", temp);
                masterErrorsList.Add(error);
            }
            
            if(ErrorItemModel.validRouteSign.Contains(RouteSign) & ErrorItemModel.validTypeRoad.Contains(TypeRoad))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.NHS);
                temp.Add(FieldsListModel.APHN);
                if (NHS != "0" & APHN == "1")
                {
                    ErrorItemModel error = new ErrorItemModel( "NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1)", temp);
                    masterErrorsList.Add(error);
                }

                if (NHS == "1" & APHN != "1")
                {
                    ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes on the NHS must be placed under AHPN status NHS (1)", temp);
                    masterErrorsList.Add(error);
                }

                if (NHS == "0" & APHN == "1")
                {
                    ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1)", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (ErrorItemModel.validFuncClass.Contains(FuncClass) & ErrorItemModel.validAPHN.Contains(APHN))
            {
                string[] selctedFunctionalClass = { "2", "3", "4" };
                if (APHN == "2" & selctedFunctionalClass.Contains(FuncClass))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.FuncClass);
                    temp.Add(FieldsListModel.APHN);
                    ErrorItemModel error = new ErrorItemModel("Func and APHN invalid Pair", "APHN is set to Other aerterials. Other arterials status is only given to functional classes 2,3 and 4. Please change the functional class or APHN status", temp);
                    masterErrorsList.Add(error);
                }
            }
            
            if (!(SpecialSystems is null) & SpecialSystems != "" & ErrorItemModel.validSpecialSystems.Contains(SpecialSystems))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.SpecialSystems);
                ErrorItemModel error = new ErrorItemModel("Special Systems not valid", "SpecialSystems is not valid", temp);
                masterErrorsList.Add(error);
            }

            if (!int.TryParse(BothDirectionNumLanes, out _)){
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.BothDirectionNumLanes);
                ErrorItemModel error = new ErrorItemModel("BothDirectionNum Lanes !#", "Both Directions Number of Lanes is not a integer number", temp);
                masterErrorsList.Add(error);
            } else
            {
                int BothDirectionNumLanes_int = int.Parse(BothDirectionNumLanes);
                if (BothDirectionNumLanes_int <= 0)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.BothDirectionNumLanes);
                    ErrorItemModel error = new ErrorItemModel("Negitive lanes", "Both Directions Number of Lanes should not be negitive or equal to zero", temp);
                    masterErrorsList.Add(error);
                }

                if (ErrorItemModel.validTypeOperation.Contains(TypeOperation))
                {
                    if (BothDirectionNumLanes == "1" & TypeOperation == "4")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.BothDirectionNumLanes);
                        temp.Add(FieldsListModel.TypeOperation);
                        ErrorItemModel error = new ErrorItemModel("Lanes error", "A one lane road can't be Type Operation 4 - Divided highway. Needs to be 2 or greater", temp);
                        masterErrorsList.Add(error);
                    }
                }
            }
            
            //Line 639
            if (OneDirectionNumLanes != "" & !( OneDirectionNumLanes is null))
            {
                if (!int.TryParse(OneDirectionNumLanes, out _))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.OneDirectionNumLanes);
                    ErrorItemModel error = new ErrorItemModel("One Direction Num Lanes not #", "One Directions Number of Lanes is not a number", temp);
                    masterErrorsList.Add(error);
                } 
                else
                {
                    int OneDirectionNumLanesInt =  int.Parse(OneDirectionNumLanes);
                    if (OneDirectionNumLanesInt <= 0)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.OneDirectionNumLanes);
                        ErrorItemModel error = new ErrorItemModel("invalid One Direction Num Lanes", @"One Directions Number of Lanes should not be 
negitive or equal to zero", temp);
                        masterErrorsList.Add(error);
                    } 
                    else if (int.TryParse(BothDirectionNumLanes, out _))
                    {
                        if (int.Parse(BothDirectionNumLanes) < OneDirectionNumLanesInt)
                        {
                            List<string> temp = new List<string>();
                            temp.Add(FieldsListModel.OneDirectionNumLanes);
                            temp.Add(FieldsListModel.BothDirectionNumLanes);
                            ErrorItemModel error = new ErrorItemModel("OneDirectionNumLanes > BothDirectionNumLanes", @"One Directions Number of 
Lanes should not be greater than Both Direction Number of Lanes", temp);
                            masterErrorsList.Add(error);
                        }

                        if (ErrorItemModel.validTypeOperation.Contains(TypeOperation))
                        {
                            if (TypeOperation == "4" && int.Parse(BothDirectionNumLanes) <= OneDirectionNumLanesInt)
                            {
                                List<string> temp = new List<string>();
                                temp.Add(FieldsListModel.OneDirectionNumLanes);
                                temp.Add(FieldsListModel.BothDirectionNumLanes);
                                temp.Add(FieldsListModel.TypeOperation);
                                ErrorItemModel error = new ErrorItemModel("invalid TypeOperation, Lanes combo", @"If a road is Type Operation 4 - Divided highway, 
Both Direction Number of Lanes must be greater than the one direction number of lanes)", temp);
                                masterErrorsList.Add(error);
                            }
                            
                            if (int.Parse(BothDirectionNumLanes) > int.Parse(OneDirectionNumLanes) & TypeOperation != "4")
                            {
                                List<string> temp = new List<string>();
                                temp.Add(FieldsListModel.OneDirectionNumLanes);
                                temp.Add(FieldsListModel.BothDirectionNumLanes);
                                temp.Add(FieldsListModel.TypeOperation);
                                ErrorItemModel error = new ErrorItemModel("invalid TypeOperation, Lanes combo", @"If both direction Number of Lanes is greater 
                                    than one direction number of lanes, then type Operation must be 4 - divided highway", temp);
                                masterErrorsList.Add(error);

                            }
                        }

                        if (ErrorItemModel.validMedianType.Contains(MedianType))
                        {
                            if (MedianType == "0" & int.Parse(BothDirectionNumLanes) > int.Parse(OneDirectionNumLanes))
                            {
                                List<string> temp = new List<string>();
                                temp.Add(FieldsListModel.OneDirectionNumLanes);
                                temp.Add(FieldsListModel.BothDirectionNumLanes);
                                temp.Add(FieldsListModel.MedianType);
                                ErrorItemModel error = new ErrorItemModel("invalid median lanes pairing", @"If both direction Number of Lanes is greater 
than one direction number of lanes, then the road must have a median and MedianType must not be 0 - no median", temp);
                                masterErrorsList.Add(error);
                            }

                        }
                        if (int.TryParse(MedianWidth, out _))
                        {
                            if (MedianWidth == "0" & int.Parse(BothDirectionNumLanes) > OneDirectionNumLanesInt)
                            {
                                List<string> temp = new List<string>();
                                temp.Add(FieldsListModel.OneDirectionNumLanes);
                                temp.Add(FieldsListModel.BothDirectionNumLanes);
                                temp.Add(FieldsListModel.MedianWidth);
                                ErrorItemModel error = new ErrorItemModel("invalid lane and MedianWidth Pairing", @"If both direction Number of Lanes is 
greater than one direction number of lanes, then the road must have a median and Median Width must not be 0 - no median", temp);
                                masterErrorsList.Add(error);
                            }
                        }

                    }



                }
            }

            if (YearBuilt != "" & !(YearBuilt is null))
            {
                if (int.TryParse(YearBuilt, out _))
                {
                    int yearBuiltInt = int.Parse(YearBuilt);
                    if ((yearBuiltInt >= 1800) && yearBuiltInt < 2100)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.YearBuilt);
                        ErrorItemModel error = new ErrorItemModel("invalid Year Built Range", "Year Built is not between 1800 and 2100", temp);
                        masterErrorsList.Add(error);

                    }
                } else
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.YearBuilt);
                    ErrorItemModel error = new ErrorItemModel("Year Built is not a number", "Year Built is not a number", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (yearRecon != "" & !(yearRecon is null))
            {
                if (int.TryParse(yearRecon, out _))
                {
                    int yearReconInt = int.Parse(yearRecon);
                    if (yearReconInt > 1800 & yearReconInt < 2100)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.yearRecon);
                        ErrorItemModel error = new ErrorItemModel("invalid Year Recon Range", "Year Reconstructed is not between 1800 and 20100", temp);
                        masterErrorsList.Add(error);
                    }
                } else
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.yearRecon);
                    ErrorItemModel error = new ErrorItemModel("Year Reconstructed is not a number", "Year Reconstructed is not a number", temp);
                    masterErrorsList.Add(error);

                }
            }

            if (RoadwayWidth != 0)
            {
                if (RoadwayWidth < 0)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RoadwayWidth);
                    ErrorItemModel error = new ErrorItemModel("Roadway Width is not a number", "Roadway Width is not a number", temp);
                    masterErrorsList.Add(error);

                }
                if (RoadwayWidth > 999)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RoadwayWidth);
                    ErrorItemModel error = new ErrorItemModel("Roadway Width greater than 999", "Roadway Width greater than 999", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (ExtraLanes != "" & (ExtraLanes is null))
            {
                if (!ErrorItemModel.validExtraLanes.Contains(ExtraLanes))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.ExtraLanes);
                    ErrorItemModel error = new ErrorItemModel("invalid extra lanes", "Extra Lanes is not a valid value", temp);
                    masterErrorsList.Add(error);

                }
            }

            if (!(SurfaceType is null) & SurfaceType != "" )
            {
                if (!ErrorItemModel.validSurfaceType.Contains(SurfaceType))
                {
                    List<string> temp = new List<string>();
                    ErrorItemModel error = new ErrorItemModel("invalid Surface Type", "invalid surface type", temp);
                    masterErrorsList.Add(error);
                }
            }


            return masterErrorsList;
        }

    }


}
