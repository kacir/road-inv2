using RoadInv.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using Z.EntityFramework.Plus;

namespace RoadInv.Models
{
    public class ValidationModel
        //performs all validation of segment models.
    {
        public static void CleanAttr(DB.RoadInv seg)
        {
            if (seg.Access is null)
            {
                seg.Access = "";
            } else
            {
                seg.Access = seg.Access.Trim();
            }

            if (seg.AhBlm is null)
            {
                seg.AhBlm = 0;
            }

            if (seg.AhCounty is null)
            {
                seg.AhCounty = "";
            } else
            {
                seg.AhCounty = seg.AhCounty.Trim();
            }

            if (seg.AhDistrict is null)
            {
                seg.AhDistrict = "";
            } else
            {
                seg.AhDistrict = seg.AhDistrict.Trim();
            }

            if (seg.AhElm is null)
            {
                seg.AhElm = 0;
            } 

            if (seg.AhRoute is null)
            {
                seg.AhRoute = "";
            } else
            {
                seg.AhRoute = seg.AhRoute.Trim();
            }

            if (seg.AhSection is null)
            {
                seg.AhSection = "";
            } else
            {
                seg.AhSection = seg.AhSection.Trim();
            }

            if (seg.AlternativeRouteName is null)
            {
                seg.AlternativeRouteName = "";
            } else
            {
                seg.AlternativeRouteName = seg.AlternativeRouteName.Trim();
            }

            if (seg.Aphn is null)
            {
                seg.Aphn = "";
            } else
            {
                seg.Aphn = seg.Aphn.Trim();
            }

            if (seg.BothDirectionNumLanes is null)
            {
                seg.BothDirectionNumLanes = "";
            } else
            {
                seg.BothDirectionNumLanes = seg.BothDirectionNumLanes.Trim();
            }

            if (seg.Comment1 is null)
            {
                seg.Comment1 = "";
            } else
            {
                seg.Comment1 = seg.Comment1;
            }

            if(seg.ExtraLanes is null)
            {
                seg.ExtraLanes = "";
            } else
            {
                seg.ExtraLanes = seg.ExtraLanes.Trim();
            }

            if (seg.FuncClass is null)
            {
                seg.FuncClass = "";
            } else
            {
                seg.FuncClass = seg.FuncClass.Trim();
            }

            if (seg.GovermentCode is null)
            {
                seg.GovermentCode = "";
            } else
            {
                seg.GovermentCode = seg.GovermentCode.Trim();
            }

            if (seg.LaneWidth is null)
            {
                seg.LaneWidth = 0;
            }

            if (seg.LeftShoulderSurface is null)
            {
                seg.LeftShoulderSurface = "";
            } else
            {
                seg.LeftShoulderSurface = seg.LeftShoulderSurface.Trim();
            }

            if (seg.LeftShoulderWidth is null)
            {
                seg.LeftShoulderWidth = 0;
            }

            if (seg.LogDirect is null)
            {
                seg.LogDirect = "";
            } else
            {
                seg.LogDirect = seg.LogDirect.Trim();
            }

            if (seg.MedianType is null)
            {
                seg.MedianType = "";
            } else
            {
                seg.MedianType = seg.MedianType.Trim();
            }

            if (seg.MedianWidth is null)
            {
                seg.MedianWidth = "";
            } else
            {
                seg.MedianWidth = seg.MedianWidth.Trim();
            }

            if (seg.Nhs is null)
            {
                seg.Nhs = "";
            } else
            {
                seg.Nhs = seg.Nhs.Trim();
            }

            if (seg.OneDirectionNumLanes is null)
            {
                seg.OneDirectionNumLanes = "";
            } else
            {
                seg.OneDirectionNumLanes = seg.OneDirectionNumLanes.Trim();
            }

            if (seg.RightShoulderSurface is null)
            {
                seg.RightShoulderSurface = "";
            } else
            {
                seg.RightShoulderSurface = seg.RightShoulderSurface.Trim();
            }

            if (seg.RightShoulderWidth is null)
            {
                seg.RightShoulderWidth = 0;
            }

            if (seg.RoadwayWidth is null)
            {
                seg.RoadwayWidth = 0;
            }

            if (seg.RouteSign is null)
            {
                seg.RouteSign = "";
            } else
            {
                seg.RouteSign = seg.RouteSign.Trim();
            }

            if (seg.RuralUrbanArea is null)
            {
                seg.RuralUrbanArea = "";
            } else
            {
                seg.RuralUrbanArea = seg.RuralUrbanArea.Trim();
            }

            if (seg.SpecialSystems is null)
            {
                seg.SpecialSystems = "";
            } else
            {
                seg.SpecialSystems = seg.SpecialSystems.Trim();
            }

            if (seg.SurfaceType is null)
            {
                seg.SurfaceType = "";
            } else
            {
                seg.SurfaceType = seg.SurfaceType.Trim();
            }

            if (seg.SurfaceWidth is null)
            {
                seg.SurfaceWidth = 0;
            }
            
            if (seg.SystemStatus is null)
            {
                seg.SystemStatus = "";
            } else
            {
                seg.SystemStatus = seg.SystemStatus.Trim();
            }

            if (seg.TypeOperation is null)
            {
                seg.TypeOperation = "";
            } else
            {
                seg.TypeOperation = seg.TypeOperation.Trim();
            }

            if (seg.TypeRoad is null)
            {
                seg.TypeRoad = "";
            } else
            {
                seg.TypeRoad = seg.TypeRoad.Trim();
            }

            if (seg.UrbanAreaCode is null)
            {
                seg.UrbanAreaCode = "";
            } else
            {
                seg.UrbanAreaCode = seg.UrbanAreaCode.Trim();
            }

            if (seg.YearBuilt is null)
            {
                seg.YearBuilt = "";
            } else
            {
                seg.YearBuilt = seg.YearBuilt.Trim();
            }

            if (seg.YearRecon is null)
            {
                seg.YearRecon = "";
            } else
            {
                seg.YearRecon = seg.YearRecon.Trim();
            }

        }


        public static char[] validCharacters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9', '\0'};

        public roadinvContext _dbContext;
        public List<ConstaintCounty> AH_County;
        public DB.RoadInv details;
        public List<ConstaintDistrict> AH_District;
        public List<ConstraintGeneral> LOG_DIRECT;
        public List<ConstraintGeneral> RouteSign;
        public List<ConstraintGeneral> TypeRoad;
        public List<ConstraintGeneral> RuralUrbanArea;
        public List<ConstaintUrbanAreaCode> UrbanAreaCode;
        public List<ConstraintGeneral> ShoulderSurface;
        public List<ConstraintGeneral> SurfaceType;
        public List<ConstraintGeneral> TypeOperation;
        public List<ConstraintGeneral> Access;
        public List<ConstraintGeneral> ExtraLanes;
        public List<ConstraintGeneral> MedianType;
        public List<ConstraintGeneral> FuncClass;
        public List<ConstraintGeneral> NHS;
        public List<ConstraintGeneral> APHN;
        public List<ConstraintGeneral> GovermentCode;
        public List<ConstraintGeneral> SpecialSystems;
        public List<ConstraintGeneral> SystemStatus;
        public List<ConstraintSectionCode> SectionCode;

        //combo records
        public List<ConstaintCountyDistrict> PairCountyDistrict;
        public List<ConstraintUrbanAreaCounty> PairUrbanAreaCounty;

        public static List<string> checkInvalidCharacters(string focusString)
            //AH_Route and AH_Section can only contain A-Z and 0-9 characters. All others are invalid
        {
            List<string> temp = new();
            foreach (char focusChar in focusString)
            {
                if (!validCharacters.Contains(focusChar) )
                {
                    temp.Add(focusChar.ToString());
                }
            }
            return temp;

        }

        public ValidationModel(roadinvContext dbContext)
        {

            _dbContext = dbContext;

            //copy all the dropdown options into attributes. Do this from cache to avoid the page taking a long time to load every time.
            var countyUnsorted = _dbContext.ConstaintCounties.FromCache().ToList();
            AH_County = countyUnsorted.OrderBy(o => int.Parse(o.CountyNumber)).ToList();
            AH_District = _dbContext.ConstaintDistricts.FromCache().OrderBy(x => int.Parse(x.DistrictNumber)).ToList();
            LOG_DIRECT = _dbContext.ConstraintGenerals.FromCache().Where(s => s.DomainName == "LogDirection").ToList();
            RouteSign = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "RouteSign").ToList();
            TypeRoad = _dbContext.ConstraintGenerals.FromCache().Where(u => u.DomainName == "TypeRoad").ToList();
            RuralUrbanArea = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "RuralUrbanArea").ToList();
            UrbanAreaCode = _dbContext.ConstaintUrbanAreaCodes.FromCache().ToList().OrderBy(x => x.UrbanCode).ToList();
            ShoulderSurface = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "ShoulderSurfaceType").ToList();
            SurfaceType = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "SurfaceType").ToList();
            TypeOperation = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "TypeOperation").ToList();
            Access = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "Access").ToList();
            ExtraLanes = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "ExtraLanes").ToList();
            MedianType = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "MedianType").ToList();
            FuncClass = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "FuncClass").ToList();
            NHS = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "NHS").ToList();
            APHN = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "APHN").ToList();
            GovermentCode = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "GovermentCode").ToList();
            SpecialSystems = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "SpecialSystem").ToList();
            SystemStatus = _dbContext.ConstraintGenerals.FromCache().Where(x => x.DomainName == "SystemStatus").ToList();
            SectionCode = _dbContext.ConstraintSectionCodes.FromCache().ToList();

            //paired validations
            PairCountyDistrict = _dbContext.ConstaintCountyDistricts.FromCache().ToList();
            PairUrbanAreaCounty = _dbContext.ConstraintUrbanAreaCounties.FromCache().ToList();

        }

        public bool ValidAH_District(DB.RoadInv seg)
        {
            bool valid = false;
            foreach (var item in this.AH_District)
            {
                if (item.DistrictNumber == seg.AhDistrict)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool ValidAH_County(DB.RoadInv seg)
        {
            bool valid = false;
            foreach (var item in this.AH_County)
            {
                if (item.CountyNumber == seg.AhCounty)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool ValidCountyDistrictPair(DB.RoadInv seg)
        {
            foreach (var item in this.PairCountyDistrict)
            {
                if (item.CountyNumber.Equals(seg.AhCounty))
                {
                    if (item.DistrictNumber.Equals(seg.AhDistrict))
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }

        public bool ValidGovermentCode(DB.RoadInv seg)
        {
            foreach (var item in this.GovermentCode)
            {
                if (item.Domainvalue == seg.GovermentCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidRouteSign(DB.RoadInv seg)
        {
            foreach (var item in this.RouteSign)
            {
                if (item.Domainvalue == seg.RouteSign)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidRuralUrbanArea(DB.RoadInv seg)
        {
            foreach(var item in this.RuralUrbanArea)
            {
                if (item.Domainvalue == seg.RuralUrbanArea)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidUrbanAreaCode(DB.RoadInv seg)
        {
            foreach(var item in this.UrbanAreaCode)
            {
                if (item.UrbanCode == seg.UrbanAreaCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidUrbanCodeCountyPair(DB.RoadInv seg)
        {
            foreach(var item in this.PairUrbanAreaCounty)
            {
                if (item.CountyNumber == seg.AhCounty & item.UrbanCode == seg.UrbanAreaCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidFuncClass(DB.RoadInv seg)
        {
            foreach(var item in this.FuncClass)
            {
                if (item.Domainvalue == seg.FuncClass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidSystemStatus(DB.RoadInv seg)
        {
            foreach(var item in this.SystemStatus)
            {
                if (item.Domainvalue == seg.SystemStatus)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidTypeRoad(DB.RoadInv seg)
        {
            foreach(var item in this.TypeRoad)
            {
                if (item.Domainvalue == seg.TypeRoad)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidMedianType(DB.RoadInv seg)
        {
            foreach(var item in this.MedianType)
            {
                if (item.Domainvalue == seg.MedianType)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidTypeOperation(DB.RoadInv seg)
        {
            foreach(var item in this.TypeOperation)
            {
                if (item.Domainvalue == seg.TypeOperation)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidAccess(DB.RoadInv seg)
        {
            foreach(var item in this.Access)
            {
                if (item.Domainvalue == seg.Access)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidAPHN(DB.RoadInv seg)
        {
            foreach(var item in this.APHN)
            {
                if (item.Domainvalue == seg.Aphn)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidNHS(DB.RoadInv seg)
        {
            foreach(var item in this.NHS)
            {
                if (item.Domainvalue == seg.Nhs)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidSpecialSystems(DB.RoadInv seg)
        {
            foreach(var item in this.SpecialSystems)
            {
                if (item.Domainvalue == seg.SpecialSystems)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidExtraLanes(DB.RoadInv seg)
        {
            foreach(var item in this.ExtraLanes)
            {
                if (item.Domainvalue == seg.ExtraLanes)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidSurfaceType(DB.RoadInv seg)
        {
            foreach(var item in this.SurfaceType)
            {
                if (item.Domainvalue == seg.SurfaceType)
                {
                    return true;
                }
            }
            return false;
        }


        public List<ErrorItemModel> FindErrors(DB.RoadInv segment)
        {
            List<ErrorItemModel> masterErrorsList = new List<ErrorItemModel>();

            //look for missing properties in first few standard properties
            List<string> missingProperties = new List<string>();

            if (segment.AhCounty is null)
            {
                missingProperties.Add(FieldsListModel.AH_County);
            } 
            else if (segment.AhCounty.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_County);
            }


            if (segment.AhRoute is null)
            {
                missingProperties.Add(FieldsListModel.AH_Route);
            } else  if (segment.AhRoute.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Route);
            }

            if (segment.AhSection is null)
            {
                missingProperties.Add(FieldsListModel.AH_Section);
            } else if (segment.AhSection.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Section);
            }

            if (segment.LogDirect is null)
            {
                missingProperties.Add(FieldsListModel.LOG_DIRECT);
            } else if (segment.LogDirect.Length == 0){
                missingProperties.Add(FieldsListModel.LOG_DIRECT);
            }

            if (segment.AhBlm < 0)
            {
                missingProperties.Add(FieldsListModel.AH_BLM);
            }

            if (segment.AhElm < 0)
            {
                missingProperties.Add(FieldsListModel.AH_ELM);
            }
            //generate first error
            if (missingProperties.Count > 0)
            {
                ErrorItemModel coreMissing = new ErrorItemModel("Core Fields Missing", "Several Core fields are missing values", missingProperties);
                masterErrorsList.Add(coreMissing);
            }

            //check to make sure district is valid $
            if (!(segment.AhDistrict is null) & !(segment.AhDistrict == "") & !this.ValidAH_District(segment))
            {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.AH_District);
                    ErrorItemModel districtError = new ErrorItemModel("AH_District Invalid", "AH_District value is not in list of valid values for field", temp);
            }


            //BLM and ELM validation
            if (segment.AhElm == segment.AhBlm)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is same as ending logmile", temp);
                masterErrorsList.Add(extentError);
            }
            if (segment.AhBlm > segment.AhElm)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is greater than ending logmile", temp);
                masterErrorsList.Add(extentError);
            }

            //BLM or ELM are too big to be valid
            if (segment.AhBlm > 999)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                ErrorItemModel extentError = new ErrorItemModel("BLM > 999", " BLM logmiles should not be larger than 999 miles. Thats longer than the width of the state of arkansas", temp);
                masterErrorsList.Add(extentError);
            }
            if (segment.AhElm > 999)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("ELM > 999", " ELM logmiles should not be larger than 999 miles. Thats longer than the width of the state of arkansas", temp);
                masterErrorsList.Add(extentError);
            }


            //checking other core attributes
            if (segment.AhRoute.Length > 100)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);
                ErrorItemModel routeError = new ErrorItemModel("AH_Route > 100 char", "AH_Route field is greater than 100 characters long", temp);
                masterErrorsList.Add(routeError);
            }

            if (ValidationModel.checkInvalidCharacters(segment.AhRoute).Count > 0)
            {
                segment.AhRoute = segment.AhRoute.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);

                string longError = "";
                foreach (var item in ValidationModel.checkInvalidCharacters(segment.AhRoute))
                {
                    longError = longError + item + ", ";
                }

                if (longError != "")
                {
                    longError = longError.Substring(longError.Length - 2);
                    ErrorItemModel routeError = new ErrorItemModel(@"AH_Route- invalid character(s)", "AH_Route field only allows " +
                        "numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                    masterErrorsList.Add(routeError);
                }

            }
            if (ValidationModel.checkInvalidCharacters(segment.AhSection).Count > 0)
            {
                segment.AhSection = segment.AhSection.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Section);
                string longError = "";

                var invalidChars = ValidationModel.checkInvalidCharacters(segment.AhSection);

                foreach (var item in invalidChars)
                {
                    longError = longError + item + ", ";
                }
                
                if (longError != ", " & longError != "")
                {
                    longError = longError.Substring(longError.Length - 2);
                    ErrorItemModel routeError = new ErrorItemModel(@"AH_Section invalid character(s)", "AH_Section field only allows " +
"numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                    masterErrorsList.Add(routeError);
                }

            }
            //Check if direction is valid
            if (segment.LogDirect is null)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LOG_DIRECT);
                ErrorItemModel error = new ErrorItemModel("LOG_DIRECT not valid", "The LOG_DIRECT/Direction field is null. It must contain a value", temp);
                masterErrorsList.Add(error);
            }
            else if (!(segment.LogDirect.ToUpper() == "A" | segment.LogDirect.ToUpper() == "B"))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LOG_DIRECT);
                ErrorItemModel error = new ErrorItemModel("LOG_DIRECT not valid", "The LOG_DIRECT/Direction field does contain a " +
                    "valid valid. values must be A or B and nothing else", temp);
                masterErrorsList.Add(error);
            }

            //check section field is not too long
            if (!(segment.AhSection is null))
            {
                if (segment.AhSection.Length > 3)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.AH_Section);
                    ErrorItemModel error = new ErrorItemModel("AH_Section > 3 chars", "AH_Section field can only be three characters long according to ARNOLD", temp);
                    masterErrorsList.Add(error);
                }
            }

            //check if section has no value


            //check for valid county value $
            if (!this.ValidAH_County(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_County);
                ErrorItemModel error = new ErrorItemModel("AH_County Invalid", "AH_County is not a valid character set according to database", temp);
                masterErrorsList.Add(error);
            }
            else
            {
                //if the county codes are valid too then check the county district pairing list
                if (this.ValidAH_District(segment))
                {
                    if (!this.ValidCountyDistrictPair(segment))
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.AH_County);
                        temp.Add(FieldsListModel.AH_District);
                        ErrorItemModel error = new ErrorItemModel("invalid AH_District AH_County Pair", "The Choosen AH_District and AH_County values do " +
                            "not make sense together. ArDOT districts contain only certain countys. Some Pairings are not logical. " +
                            "Please refer to a district map.", temp);
                        masterErrorsList.Add(error);
                    }
                }
            }

            //One way cuplet exception, both section and direction must be valid before this becomes active
            if (segment.AhSection.Length <= 3 & segment.AhSection.Length >= 1 & ValidationModel.checkInvalidCharacters(segment.AhSection).Count == 0)
            {
                if (segment.AhSection[segment.AhSection.Length - 1] == 'X' &  segment.LogDirect == "A")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.AH_Section);
                    temp.Add(FieldsListModel.LOG_DIRECT);
                    ErrorItemModel error = new ErrorItemModel("One way couplet" , 
                        @"The section code indicates the segment is a One-way couplet. All one way couplets are must be antilog direction 
and the Type Operation must be one-way couplet. I recommend you change some fields.", temp);
                    masterErrorsList.Add(error);

                }
            }


            if (!(segment.GovermentCode == "") & !(segment.GovermentCode is null) & !this.ValidGovermentCode(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.GovermentCode);
                ErrorItemModel error = new ErrorItemModel("invalid Goverement Code",
                    "Goverment code is not one of the pre-defined codes in the database", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.RouteSign == "" & !(segment.RouteSign is null)) & !this.ValidRouteSign(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RouteSign);

                ErrorItemModel error = new ErrorItemModel("invalid Route Sign", "Routes sign is not a value of 1, 2, or 3", temp);
                masterErrorsList.Add(error);
            }
            else
            {
                if (this.ValidGovermentCode(segment))
                {
                    if ((segment.RouteSign == "1" | segment.RouteSign == "2" | segment.RouteSign == "3") & segment.GovermentCode != "1" | 
                        !(segment.RouteSign == "1" | segment.RouteSign == "2" | segment.RouteSign == "3") & segment.GovermentCode == "1")
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
            if (!(segment.RuralUrbanArea == "") & !(segment.RuralUrbanArea is null) & !this.ValidRuralUrbanArea(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RuralUrbanArea);
                ErrorItemModel error = new ErrorItemModel("Rural Urban Area invalid", "Rural urban area is not valid needs to be one of the sected values in the database.", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.UrbanAreaCode == "") & !(segment.UrbanAreaCode is null) & !this.ValidUrbanAreaCode(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.UrbanAreaCode);
                ErrorItemModel error = new ErrorItemModel("Urban Area Code invalid", "Urban Area code is not one of the valid urban codes according to the database.", temp);
                masterErrorsList.Add(error);
            }
            else if (this.ValidUrbanAreaCode(segment) & this.ValidRuralUrbanArea(segment))
            {
                if ((segment.RuralUrbanArea == "3" | segment.RuralUrbanArea == "4") & segment.UrbanAreaCode == "00000")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RuralUrbanArea);
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    ErrorItemModel error = new ErrorItemModel("Rural Urban Area / Urban Code Pair Invalid", "Small Urganized and Urbanized areas must have Urban Area Code", temp);
                    masterErrorsList.Add(error);
                }

                if ((segment.RuralUrbanArea == "1" | segment.RuralUrbanArea == "2") & !(segment.UrbanAreaCode == "00000"))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RuralUrbanArea);
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    ErrorItemModel error = new ErrorItemModel("Rural Urban Area / Urban Code Pair Invalid", "Rural Areas should not have an Urban Area Code. Urban Area Code should be 00000", temp);
                    masterErrorsList.Add(error);
                }
            }
            else if (this.ValidAH_County(segment) & this.ValidUrbanAreaCode(segment) &  segment.UrbanAreaCode != "00000")
            {
                if (!this.ValidUrbanCodeCountyPair(segment))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.UrbanAreaCode);
                    temp.Add(FieldsListModel.AH_County);
                    ErrorItemModel error = new ErrorItemModel("Invalid County Urban Code Pair", "UrbanArea Code does not match county field. Specific urban areas are only in certain counties", temp);
                    masterErrorsList.Add(error);
                }
            }

            //main functional class checks
            if (!(segment.FuncClass is null) & segment.FuncClass != "" & ! this.ValidFuncClass(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.FuncClass);
                ErrorItemModel error = new ErrorItemModel("Invalid Functional Class", "functional class is not one of the specified classes 1-7", temp);
                masterErrorsList.Add(error);
            }
            else if (this.ValidFuncClass(segment) & this.ValidRouteSign(segment))
            {
                if (segment.RouteSign == "1" & segment.FuncClass != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RouteSign);
                    temp.Add(FieldsListModel.FuncClass);
                    ErrorItemModel error = new ErrorItemModel("Invalid Func and RouteSign Pair", @"If Route Sign is 1 - Interstate, 
the functional class needs to be interstate too.", temp);
                    masterErrorsList.Add(error);
                }
                if (segment.RouteSign != "1" && segment.FuncClass == "1")
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
            if (!(segment.SystemStatus is null) & !(segment.SystemStatus == "") & !this.ValidSystemStatus(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.SystemStatus);
                ErrorItemModel error = new ErrorItemModel("invalid System Status", "System Status does not contain a valid value", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.TypeRoad is null) & !(segment.TypeRoad == "") & !this.ValidTypeRoad(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeRoad);
                ErrorItemModel error = new ErrorItemModel("invalid Type Road", "Type Road value is invalid", temp);
                masterErrorsList.Add(error);
            }

            decimal outMedianWidth;
            if (!(segment.MedianWidth is null) & !(segment.MedianWidth == "") & !decimal.TryParse(segment.MedianWidth, out outMedianWidth))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.MedianWidth);
                ErrorItemModel error = new ErrorItemModel("MedianWidth not number", "Median Width cannot be converted into a number", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.MedianType is null) & !(segment.MedianType == "") & !this.ValidMedianType(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.MedianType);
                ErrorItemModel error = new ErrorItemModel("MedianType Invalid", "Median Type is not a valid coded value", temp);
                masterErrorsList.Add(error);
            }
            else if (this.ValidMedianType(segment) & segment.MedianType != "" & decimal.TryParse(segment.MedianWidth, out outMedianWidth))
            {
                string[] SelectedMedianTypes = { "1", "2", "3", "4", "5" };
                string[] selectedMedianWidths = { null, "", "000" };
                if (SelectedMedianTypes.Contains(segment.MedianType) & selectedMedianWidths.Contains(segment.MedianWidth))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Invalid MedianWidth MedianType Pair", @"Median Type indicates there is 
                        a median but the Median Width is null.", temp);
                    masterErrorsList.Add(error);
                }
                if (segment.MedianType == "0" & !selectedMedianWidths.Contains(segment.MedianWidth))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Invalid MedianWidth MedianType Pair", @"Median Type indicates there is 
                        no median but the Median width is not zero", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(segment.TypeOperation is null) & !(segment.TypeOperation == "") & !this.ValidTypeOperation(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeOperation);
                ErrorItemModel error = new ErrorItemModel("Type Operation not Valid", "Type Operation value is not valid", temp);
                masterErrorsList.Add(error);
            }
            else if (this.ValidTypeOperation(segment))
            {
                var selectedMedianWidth = new List<string>();
                selectedMedianWidth.Add("00000");
                
                if (selectedMedianWidth.Contains(segment.MedianType) & segment.TypeOperation == "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.MedianType);
                    ErrorItemModel error = new ErrorItemModel("Type Operation MedianType Pair invalid", @"Type Operation indicates the 
road is divided so it should have a median but the median type indicates there is no median", temp);
                    masterErrorsList.Add(error);
                }
                
                if (segment.MedianWidth == "0" & segment.TypeOperation == "4")//$
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Type Operation MedianType Pair invalid", @"Type Operation indicates the 
road is divided so it should have a median but the median type indicates there is no median", temp);
                    masterErrorsList.Add(error);
                }

                if (int.TryParse(segment.MedianWidth, out _))
                {
                    int medianWidthInt = int.Parse(segment.MedianWidth);
                    if (medianWidthInt > 0 & segment.TypeOperation != "4")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.TypeOperation);
                        temp.Add(FieldsListModel.MedianWidth);
                        var error = new ErrorItemModel("Type Operation Should be 4.", "You have set the median width to a non-zero value. " +
                            "only multilane divided highway have medians. Please change the type oepration or change the median width to zero.", temp);
                        masterErrorsList.Add(error);
                    }
                    

                }
                
                if (segment.FuncClass == "2" & segment.TypeOperation != "4" )
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.FuncClass);
                    ErrorItemModel error = new ErrorItemModel("Other Freeways and Expressways not mutlilane", @"All functional class 2 roads 
(Other freeways and expressways must be type operation 4 in the majority of cases. Functional class 2 desiganted a multilane highways)", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(segment.Access == "") & !(segment.Access is null) & !this.ValidAccess(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.Access);
                ErrorItemModel error = new ErrorItemModel("invalid Access", "Access is value is not valid", temp);
                masterErrorsList.Add(error);
            } else if (!(segment.Access == "") & !(segment.Access is null) & this.ValidAccess(segment))
            {
                if (this.ValidRouteSign(segment))
                {
                    if ((segment.RouteSign == "1" & segment.Access != "1") | (segment.RouteSign != "1" & segment.Access == "1"))
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.RouteSign);
                        temp.Add(FieldsListModel.Access);
                        ErrorItemModel error = new ErrorItemModel("Route Sign Access Pair invalid", "Route Sign Interstate (1) segmeents must also have accesss be 3 - No Control and vice versa", temp);
                        masterErrorsList.Add(error);
                    }
                }

                if (this.ValidTypeOperation(segment))
                {
                    if (segment.Access == "1" & segment.TypeOperation != "4")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.TypeOperation);
                        temp.Add(FieldsListModel.Access);
                        ErrorItemModel error = new ErrorItemModel("Access/Type Operation Pair invalid", "If access is full control (1) then Type Operation must be divided highway (1)", temp);
                        masterErrorsList.Add(error);
                    }
                }

                if (this.ValidMedianType(segment))
                {
                    if (segment.Access == "3" & segment.MedianType != "0")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.MedianType);
                        temp.Add(FieldsListModel.Access);
                        ErrorItemModel error = new ErrorItemModel("Median Type Access Pair invalid", "If Access is no control (3) then the road has a median so MedianType should not be 0", temp);
                        masterErrorsList.Add(error);
                    }
                }

                if (decimal.TryParse(segment.MedianWidth, out _))
                {
                    if (segment.MedianWidth == "0" & segment.Access == "3")
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.MedianWidth);
                        temp.Add(FieldsListModel.Access);
                        ErrorItemModel error = new ErrorItemModel("Median Width Access Pair invalid", "If Access is no control (3) then the road has no a median so MedianWidth should be greater than 0", temp);
                        masterErrorsList.Add(error);
                    }
                }

            }





            if (!(segment.Aphn is null) & segment.Aphn != "" & ! this.ValidAPHN(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.APHN);
                ErrorItemModel error = new ErrorItemModel("APHN invalid", "APHN value is not valid", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.Nhs is null) & segment.Nhs != "" & !this.ValidNHS(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.NHS);
                ErrorItemModel error = new ErrorItemModel("NHS invalid", "NHS value is not valid", temp);
            }

            //Highy compound check on a few attributes
            if (segment.RouteSign == "1" & segment.TypeRoad == "1")
            {
                if (this.ValidNHS(segment) & segment.Nhs != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    temp.Add(FieldsListModel.RouteSign);
                    ErrorItemModel error = new ErrorItemModel("RouteSign/ NHS pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the NHS (1-Interstate)", temp);
                    masterErrorsList.Add(error);
                    //Yellow All
                }

                if (this.ValidAPHN(segment) & segment.Aphn != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.APHN);
                    temp.Add(FieldsListModel.RouteSign);
                    ErrorItemModel error = new ErrorItemModel("RouteSign APHN pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the APHN (1- Interstate).", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (segment.RouteSign == "2" | segment.RouteSign == "3" & segment.TypeRoad == "1" && segment.Nhs != "0" & this.ValidNHS(segment) & segment.Aphn != "1" & this.ValidAPHN(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RouteSign);
                temp.Add(FieldsListModel.TypeRoad);
                temp.Add(FieldsListModel.NHS);

                ErrorItemModel error = new ErrorItemModel("NHS inconsistancy", "All US Routes and State Highway are are on the NHS are automatically placed on the APHN", temp);
                masterErrorsList.Add(error);
            }

            if (this.ValidAPHN(segment) & segment.Aphn != "" & this.ValidNHS(segment) & segment.Nhs != "")
            {
                if (!(segment.Nhs == "1" & segment.Aphn == "1") & !(segment.Aphn == "2" & segment.Nhs != "0"))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    temp.Add(FieldsListModel.APHN);
                    if (segment.Nhs == "1" & segment.Aphn == "0")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1). 99", temp);
                        masterErrorsList.Add(error);
                    }

                    if (segment.Nhs == "1" & segment.Aphn != "1")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes on the NHS must be placed under AHPN status NHS (1)", temp);
                        masterErrorsList.Add(error);
                    }

                    if (segment.Nhs == "0" & segment.Aphn == "1")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1) 98", temp);
                        masterErrorsList.Add(error);

                    }
                } 
                
                if (segment.Aphn == "2" & segment.Nhs != "0")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    temp.Add(FieldsListModel.APHN);

                    ErrorItemModel Error = new ErrorItemModel("NHS value wrong", "APHN is set to other arterials. " +
                        "This means it must not be on the NHS. if its on the NHS then change the APHN vlaue to 1 NHS", temp);
                    masterErrorsList.Add(Error);
                }



            }

            if (this.ValidFuncClass(segment) & this.ValidAPHN(segment) )
            {
                List<string> selctedFunctionalClass = new List<string>();
                selctedFunctionalClass.Add("1");
                selctedFunctionalClass.Add("5");
                selctedFunctionalClass.Add("6");
                selctedFunctionalClass.Add("7");

                if (segment.Aphn == "2" & selctedFunctionalClass.Contains(segment.FuncClass))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.FuncClass);
                    temp.Add(FieldsListModel.APHN);
                    ErrorItemModel error = new ErrorItemModel("Func and APHN invalid Pair", "APHN is set to Other aerterials. Other arterials status is only given to functional classes 2,3 and 4. Please change the functional class or APHN status", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(segment.SpecialSystems is null) & segment.SpecialSystems != "" & !this.ValidSpecialSystems(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.SpecialSystems);
                ErrorItemModel error = new ErrorItemModel("Special Systems not valid", "SpecialSystems is not valid", temp);
                masterErrorsList.Add(error);
            } else if (ValidNHS(segment) & ValidSpecialSystems(segment))
            {
                if (segment.SpecialSystems == "9" & segment.Nhs != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.SpecialSystems);
                    temp.Add(FieldsListModel.NHS);
                    ErrorItemModel error = new ErrorItemModel("NHS Wrong", @"All Interstates are automatically part of the STRAHNET system. 
It appears you have the value currently at XXX. I recommend you change it to match.", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!int.TryParse(segment.BothDirectionNumLanes, out _) & segment.BothDirectionNumLanes != "")
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.BothDirectionNumLanes);
                ErrorItemModel error = new ErrorItemModel("BothDirectionNum Lanes !#", "Both Directions Number of Lanes is not a integer number", temp);
                masterErrorsList.Add(error);
            }
            else if (segment.BothDirectionNumLanes != "")
            {
                int BothDirectionNumLanes_int = int.Parse(segment.BothDirectionNumLanes);
                if (BothDirectionNumLanes_int <= 0)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.BothDirectionNumLanes);
                    ErrorItemModel error = new ErrorItemModel("Negitive lanes", "Both Directions Number of Lanes should not be negitive or equal to zero", temp);
                    masterErrorsList.Add(error);
                }

                if (this.ValidTypeOperation(segment) )
                {
                    if (segment.BothDirectionNumLanes == "1" & segment.TypeOperation == "4")
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
            if (segment.OneDirectionNumLanes != "" & !(segment.OneDirectionNumLanes is null))
            {
                if (!int.TryParse(segment.OneDirectionNumLanes, out _))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.OneDirectionNumLanes);
                    ErrorItemModel error = new ErrorItemModel("One Direction Num Lanes not #", "One Directions Number of Lanes is not a number", temp);
                    masterErrorsList.Add(error);
                }
                else
                {
                    int OneDirectionNumLanesInt = int.Parse(segment.OneDirectionNumLanes);
                    if (OneDirectionNumLanesInt <= 0)
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.OneDirectionNumLanes);
                        ErrorItemModel error = new ErrorItemModel("invalid One Direction Num Lanes", @"One Directions Number of Lanes should not be 
negitive or equal to zero", temp);
                        masterErrorsList.Add(error);
                    }
                    else if (int.TryParse(segment.BothDirectionNumLanes, out _))
                    {
                        if (int.Parse(segment.BothDirectionNumLanes) < OneDirectionNumLanesInt)
                        {
                            List<string> temp = new List<string>();
                            temp.Add(FieldsListModel.OneDirectionNumLanes);
                            temp.Add(FieldsListModel.BothDirectionNumLanes);
                            ErrorItemModel error = new ErrorItemModel("OneDirectionNumLanes > BothDirectionNumLanes", @"One Directions Number of 
Lanes should not be greater than Both Direction Number of Lanes", temp);
                            masterErrorsList.Add(error);
                        }

                        if (this.ValidTypeOperation(segment) )
                        {
                            if (segment.TypeOperation == "4" && int.Parse(segment.BothDirectionNumLanes) <= OneDirectionNumLanesInt)
                            {
                                List<string> temp = new List<string>();
                                temp.Add(FieldsListModel.OneDirectionNumLanes);
                                temp.Add(FieldsListModel.BothDirectionNumLanes);
                                temp.Add(FieldsListModel.TypeOperation);
                                ErrorItemModel error = new ErrorItemModel("invalid TypeOperation, Lanes combo", @"If a road is Type Operation 4 - Divided highway, 
Both Direction Number of Lanes must be greater than the one direction number of lanes)", temp);
                                masterErrorsList.Add(error);
                            }

                            if (int.Parse(segment.BothDirectionNumLanes) > int.Parse(segment.OneDirectionNumLanes) & segment.TypeOperation != "4")
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

                        if (this.ValidMedianType(segment))
                        {
                            if (segment.MedianType == "0" & int.Parse(segment.BothDirectionNumLanes) > int.Parse(segment.OneDirectionNumLanes))
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
                        if (int.TryParse(segment.MedianWidth, out _))
                        {
                            if (segment.MedianWidth == "0" & int.Parse(segment.BothDirectionNumLanes) > OneDirectionNumLanesInt)
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

            if (segment.YearBuilt != "" & !(segment.YearBuilt is null))
            {
                if (int.TryParse(segment.YearBuilt, out _))
                {
                    int yearBuiltInt = int.Parse(segment.YearBuilt);
                    if (!(yearBuiltInt >= 1800 & yearBuiltInt < 2100))
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.YearBuilt);
                        ErrorItemModel error = new ErrorItemModel("invalid Year Built Range", "Year Built is not between 1800 and 2100", temp);
                        masterErrorsList.Add(error);

                    }
                }
                else
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.YearBuilt);
                    ErrorItemModel error = new ErrorItemModel("Year Built is not a number", "Year Built is not a number", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (segment.YearRecon != "" & !(segment.YearRecon is null))
            {
                if (int.TryParse(segment.YearRecon, out _))
                {
                    int yearReconInt = int.Parse(segment.YearRecon);
                    if (!(yearReconInt > 1800 & yearReconInt < 2100))
                    {
                        List<string> temp = new List<string>();
                        temp.Add(FieldsListModel.yearRecon);
                        ErrorItemModel error = new ErrorItemModel("invalid Year Recon Range", "Year Reconstructed is not between 1800 and 20100", temp);
                        masterErrorsList.Add(error);
                    }
                }
                else
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.yearRecon);
                    ErrorItemModel error = new ErrorItemModel("Year Reconstructed is not a number", "Year Reconstructed is not a number", temp);
                    masterErrorsList.Add(error);

                }
            }

            if (segment.RoadwayWidth != 0 & segment.RoadwayWidth != 999)
            {
                if (segment.RoadwayWidth < 0)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RoadwayWidth);
                    ErrorItemModel error = new ErrorItemModel("Roadway Width is not a number", "Roadway Width is not a number", temp);
                    masterErrorsList.Add(error);

                }
                if (segment.RoadwayWidth > 999)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RoadwayWidth);
                    ErrorItemModel error = new ErrorItemModel("Roadway Width greater than 999", "Roadway Width greater than 999", temp);
                    masterErrorsList.Add(error);
                }
                if (segment.RoadwayWidth > segment.SurfaceWidth)
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.RoadwayWidth);
                    temp.Add(FieldsListModel.SurfaceWidth);
                    var error = new ErrorItemModel("roadway width is too small/big", "Roadway width does not fi inside of surface width", temp);
                    masterErrorsList.Add(error);
                }

            }

            if (segment.ExtraLanes != "" & (ExtraLanes is null))
            {
                if (this.ValidExtraLanes(segment) )
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.ExtraLanes);
                    ErrorItemModel error = new ErrorItemModel("invalid extra lanes", "Extra Lanes is not a valid value", temp);
                    masterErrorsList.Add(error);

                }
            }

            if (!(segment.SurfaceType is null) & segment.SurfaceType != "")
            {
                if (!this.ValidSurfaceType(segment))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.SurfaceType);
                    ErrorItemModel error = new ErrorItemModel("invalid Surface Type", "invalid surface type", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (segment.TypeOperation == "4" & segment.Access == "3")
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeOperation);
                temp.Add(FieldsListModel.Access);
                ErrorItemModel error = new ErrorItemModel("Access Wrong", @"A multilane divided highway must have some amount of control of 
turning. please, change the access to someone other than no control or change the type operation to something toher than multilane divided", temp);
                masterErrorsList.Add(error);
            }

            if (segment.MedianType == "0" & segment.TypeOperation == "4")
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.TypeOperation);
                temp.Add(FieldsListModel.MedianType);
                ErrorItemModel error = new ErrorItemModel("medianwidth or median type wrong", @"All multipalen divided highway have a medain. 
By extension, the mediantpye cant be 0, No Median. please chang ethe tpye operation or select a different median type ", temp);
                masterErrorsList.Add(error);
            }

            if (segment.LaneWidth > 15)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LaneWidth);
                var error = new ErrorItemModel("Lane with > 15 ft", "Lane width of 15 feet or more are very unusual. Would you like to enter this value anyway?", temp);
                masterErrorsList.Add(error);
            }

            if (segment.SurfaceWidth < segment.LaneWidth)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LaneWidth);
                temp.Add(FieldsListModel.SurfaceWidth);
                var error = new ErrorItemModel("lane Width too large ", @"A surface width is made up of a vareity of different characteristics. 
A subset of the surface width is the lane width. The surface width must be larger than the lane width.", temp);
                masterErrorsList.Add(error);
            }

            if (int.TryParse(segment.BothDirectionNumLanes, out _))
            {
                if (int.Parse(segment.BothDirectionNumLanes) * segment.LaneWidth > segment.SurfaceWidth  )
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.LaneWidth);
                    temp.Add(FieldsListModel.SurfaceWidth);
                    temp.Add(FieldsListModel.BothDirectionNumLanes);
                    var error = new ErrorItemModel("Surface width too small", @"A surface width is map up of a variety of differnt characteristics. 
A subset of the sruface width is the lane width. The surface width must be larger than the lane width. See the diagram hyperlink", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (ValidMedianType(segment) & ValidTypeOperation(segment) & segment.TypeOperation != "" & segment.MedianType != "")
            {
                var selectedMedianTypes = new List<string>();
                selectedMedianTypes.Add("1");
                selectedMedianTypes.Add("2");
                selectedMedianTypes.Add("3");
                selectedMedianTypes.Add("4");
                selectedMedianTypes.Add("5");
                if (selectedMedianTypes.Contains(segment.MedianType) & segment.TypeOperation != "4")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.TypeOperation);
                    var error = new ErrorItemModel("Must be divided highway", @"It appears you have selected the median type as XXXX. 
This means the road has a median. Only multilane divided highway have medians. Perhaps you could set the TypeOperation to be 4 (multi-lane divided)", temp);
                    masterErrorsList.Add(error);
                }
            }

            return masterErrorsList;
        }

    }
}
