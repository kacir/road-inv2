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
        public static char[] validCharacters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9', '\0'};

        public roadinvContext _dbContext;
        public List<ConstaintCounty> AH_County;
        public SegmentModel details;
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
            List<string> temp = new List<string>();
            foreach (char focusChar in focusString)
            {
                var yellow = focusChar;
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

        public bool ValidAH_District(SegmentModel seg)
        {
            bool valid = false;
            foreach (var item in this.AH_District)
            {
                if (item.DistrictNumber == seg.AH_District)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool ValidAH_County(SegmentModel seg)
        {
            bool valid = false;
            foreach (var item in this.AH_County)
            {
                if (item.CountyNumber == seg.AH_County)
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool ValidCountyDistrictPair(SegmentModel seg)
        {
            foreach (var item in this.PairCountyDistrict)
            {
                if (item.CountyNumber.Equals(seg.AH_County))
                {
                    if (item.DistrictNumber.Equals(seg.AH_District))
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }

        public bool ValidGovermentCode(SegmentModel seg)
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

        public bool ValidRouteSign(SegmentModel seg)
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

        public bool ValidRuralUrbanArea(SegmentModel seg)
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

        public bool ValidUrbanAreaCode(SegmentModel seg)
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

        public bool ValidUrbanCodeCountyPair(SegmentModel seg)
        {
            foreach(var item in this.PairUrbanAreaCounty)
            {
                if (item.CountyNumber == seg.AH_County & item.UrbanCode == seg.UrbanAreaCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidFuncClass(SegmentModel seg)
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

        public bool ValidSystemStatus(SegmentModel seg)
        {
            foreach(var item in this.SystemStatus)
            {
                if (item.Domainvalue == seg.FuncClass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidTypeRoad(SegmentModel seg)
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

        public bool ValidMedianType(SegmentModel seg)
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

        public bool ValidTypeOperation(SegmentModel seg)
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

        public bool ValidAccess(SegmentModel seg)
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

        public bool ValidAPHN(SegmentModel seg)
        {
            foreach(var item in this.APHN)
            {
                if (item.Domainvalue == seg.APHN)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidNHS(SegmentModel seg)
        {
            foreach(var item in this.NHS)
            {
                if (item.Domainvalue == seg.NHS)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ValidSpecialSystems(SegmentModel seg)
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

        public bool ValidExtraLanes(SegmentModel seg)
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

        public bool ValidSurfaceType(SegmentModel seg)
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


        public List<ErrorItemModel> FindErrors(SegmentModel segment)
        {
            List<ErrorItemModel> masterErrorsList = new List<ErrorItemModel>();

            //look for missing properties in first few standard properties
            List<string> missingProperties = new List<string>();

            if (segment.AH_County is null | segment.AH_County.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_County);
            }

            if (segment.AH_Route is null | segment.AH_Route.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Route);
            }

            if (segment.AH_Section is null | segment.AH_Section.Length == 0)
            {
                missingProperties.Add(FieldsListModel.AH_Section);
            }

            if (segment.LOG_DIRECT is null | segment.LOG_DIRECT.Length == 0)
            {
                missingProperties.Add(FieldsListModel.LOG_DIRECT);
            }

            if (segment.AH_BLM < 0)
            {
                missingProperties.Add(FieldsListModel.AH_BLM);
            }

            if (segment.AH_ELM < 0)
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
            if (!(segment.AH_District is null) & !(segment.AH_District == "") & !this.ValidAH_District(segment))
            {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.AH_District);
                    ErrorItemModel districtError = new ErrorItemModel("AH_District Invalid", "AH_District value is not in list of valid values for field", temp);
            }


            //BLM and ELM validation
            if (segment.AH_ELM == segment.AH_BLM)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is same as ending logmile", temp);
                masterErrorsList.Add(extentError);
            }
            if (segment.AH_BLM > segment.AH_ELM)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_BLM);
                temp.Add(FieldsListModel.AH_ELM);
                ErrorItemModel extentError = new ErrorItemModel("BLM = ELM", "Begining log mile is greater than ending logmile", temp);
                masterErrorsList.Add(extentError);
            }

            //checking other core attributes
            if (segment.AH_Route.Length > 100)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);
                ErrorItemModel routeError = new ErrorItemModel("AH_Route > 100 char", "AH_Route field is greater than 100 characters long", temp);
                masterErrorsList.Add(routeError);
            }

            if (ValidationModel.checkInvalidCharacters(segment.AH_Route).Count > 0)
            {
                segment.AH_Route = segment.AH_Route.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Route);

                string longError = "";
                foreach (var item in ErrorItemModel.checkInvalidCharacters(segment.AH_Route))
                {
                    longError = longError + item + ", ";
                }
                longError = longError.Substring(longError.Length - 2);
                ErrorItemModel routeError = new ErrorItemModel(@"AH_Route- invalid character(s)", "AH_Route field only allows " +
                    "numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                masterErrorsList.Add(routeError);

            }
            if (ErrorItemModel.checkInvalidCharacters(segment.AH_Section).Count > 0)
            {
                segment.AH_Section = segment.AH_Section.ToUpper();
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Section);
                string longError = "";

                var invalidChars = ErrorItemModel.checkInvalidCharacters(segment.AH_Section);

                foreach (var item in invalidChars)
                {
                    longError = longError + item + ", ";
                }
                longError = longError.Substring(longError.Length - 2);
                if (longError != ", ")
                {
                    ErrorItemModel routeError = new ErrorItemModel(@"AH_Section invalid character(s)", "AH_Section field only allows " +
"numeric (1-9) and aphabet letters (A-Z). The following invalid characters were found it the AH_Route field" + longError, temp);
                    masterErrorsList.Add(routeError);
                }

            }
            //Check if direction is valid
            if (!(segment.LOG_DIRECT.ToUpper() == "A" | segment.LOG_DIRECT.ToUpper() == "B"))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.LOG_DIRECT);
                ErrorItemModel error = new ErrorItemModel("LOG_DIRECT not valid", "The LOG_DIRECT/Direction field does contain a " +
                    "valid valid. values must be A or B and nothing else", temp);
                masterErrorsList.Add(error);
            }

            //check section field is not too long
            if (segment.AH_Section.Length > 3)
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.AH_Section);
                ErrorItemModel error = new ErrorItemModel("AH_Section > 3 chars", "AH_Section field can only be three characters long according to ARNOLD", temp);
                masterErrorsList.Add(error);
            }

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
                    if ((segment.RouteSign == "1" | segment.RouteSign == "2" | segment.RouteSign == "3") & segment.GovermentCode != "1" | !(segment.RouteSign == "1" | segment.RouteSign == "2" | segment.RouteSign == "3") & segment.GovermentCode == "1")
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
            if (!(segment.FuncClass is null) & (segment.FuncClass == "") & ! this.ValidFuncClass(segment))
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
                if (segment.RouteSign == "1" && segment.FuncClass != "1")
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
            else if (this.ValidMedianType(segment) & decimal.TryParse(segment.MedianWidth, out outMedianWidth))
            {
                string[] SelectedMedianTypes = { "1", "2", "3", "4", "5" };
                string[] selectedMedianWidths = { null, "", "00000" };
                if (SelectedMedianTypes.Contains(segment.MedianType) & selectedMedianWidths.Contains(segment.MedianWidth))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.MedianType);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Invalid MedianWidth MedianType Pair", @"Median Type indicates there is 
                        a median but the Median Width is null.", temp);
                    masterErrorsList.Add(error);
                }
                if (segment.MedianType == "1" & !selectedMedianWidths.Contains(segment.MedianWidth))
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
                selectedMedianWidth.Add(null);
                selectedMedianWidth.Add("");
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

                if (segment.MedianWidth == "0" & segment.TypeOperation == "4")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.TypeOperation);
                    temp.Add(FieldsListModel.MedianWidth);
                    ErrorItemModel error = new ErrorItemModel("Type Operation MedianType Pair invalid", @"Type Operation indicates the 
road is divided so it should have a median but the median type indicates there is no median", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (!(segment.Access == "") & (segment.Access is null) & !this.ValidAccess(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.Access);
                ErrorItemModel error = new ErrorItemModel("invalid Access", "Access is value is not valid", temp);
                masterErrorsList.Add(error);
            }
            else if (this.ValidRouteSign(segment))
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
            else if (this.ValidTypeOperation(segment))
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
            else if (this.ValidMedianType(segment))
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
            else if (decimal.TryParse(segment.MedianWidth, out _))
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

            if (!(segment.APHN is null) & segment.APHN != "" & ! this.ValidAPHN(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.APHN);
                ErrorItemModel error = new ErrorItemModel("APHN invalid", "APHN value is not valid", temp);
                masterErrorsList.Add(error);
            }

            if (!(segment.NHS is null) & segment.NHS != "" & !this.ValidNHS(segment))
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.NHS);
                ErrorItemModel error = new ErrorItemModel("NHS invalid", "NHS value is not valid", temp);
            }

            //Highy compound check on a few attributes
            if (segment.RouteSign == "1" & segment.TypeRoad == "1")
            {
                if (this.ValidNHS(segment) & segment.NHS != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    ErrorItemModel error = new ErrorItemModel("RouteSign/ NHS pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the NHS (1-Interstate)", temp);
                    masterErrorsList.Add(error);
                }

                if (this.ValidAPHN(segment) & segment.APHN != "1")
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.APHN);
                    ErrorItemModel error = new ErrorItemModel("RouteSign APHN pair invalid", "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the APHN (1- Interstate).", temp);
                    masterErrorsList.Add(error);
                }
            }

            if (segment.RouteSign == "2" | segment.RouteSign == "3" & segment.TypeRoad == "1" && segment.NHS != "0")
            {
                List<string> temp = new List<string>();
                temp.Add(FieldsListModel.RouteSign);
                temp.Add(FieldsListModel.TypeRoad);
                temp.Add(FieldsListModel.NHS);

                ErrorItemModel error = new ErrorItemModel("NHS inconsistancy", "All US Routes and State Highway are are on the NHS are automatically placed on the APHN", temp);
                masterErrorsList.Add(error);
            }

            if (this.ValidRouteSign(segment) & this.ValidTypeRoad(segment) )
            {
                if (!(segment.NHS == "1" & segment.APHN == "1"))
                {
                    List<string> temp = new List<string>();
                    temp.Add(FieldsListModel.NHS);
                    temp.Add(FieldsListModel.APHN);
                    if (segment.NHS == "1" & segment.APHN == "0")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1). 99", temp);
                        masterErrorsList.Add(error);
                    }

                    if (segment.NHS == "1" & segment.APHN != "1")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes on the NHS must be placed under AHPN status NHS (1)", temp);
                        masterErrorsList.Add(error);
                    }

                    if (segment.NHS == "0" & segment.APHN == "1")
                    {
                        ErrorItemModel error = new ErrorItemModel("NHS/APHN invalid", "Routes not on the NHS can't be placed under AHPN status NHS (1) 98", temp);
                        masterErrorsList.Add(error);

                    }
                }



            }

            if (this.ValidFuncClass(segment) & this.ValidAPHN(segment) )
            {
                List<string> selctedFunctionalClass = new List<string>();
                selctedFunctionalClass.Add("2");
                selctedFunctionalClass.Add("3");
                selctedFunctionalClass.Add("4");

                if (segment.APHN == "2" & selctedFunctionalClass.Contains(segment.FuncClass))
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
                    if ((yearBuiltInt >= 1800) && yearBuiltInt < 2100)
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

            if (segment.yearRecon != "" & !(segment.yearRecon is null))
            {
                if (int.TryParse(segment.yearRecon, out _))
                {
                    int yearReconInt = int.Parse(segment.yearRecon);
                    if (yearReconInt > 1800 & yearReconInt < 2100)
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

            if (segment.RoadwayWidth != 0 & segment.RoadwayWidth == 999)
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
                    ErrorItemModel error = new ErrorItemModel("invalid Surface Type", "invalid surface type", temp);
                    masterErrorsList.Add(error);
                }
            }


            return masterErrorsList;
        }

    }
}
