var validInputRanges = { 
    validCounty : [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 75],
    validDistrict : [1, 2, 3, 4, 5, 6, 7],
    validDistrictCountyPair : [{"county" : 60, "district" : 6}],
    validGovermentCode : ["01", "02", "04", "60", "63", "64", "66", "70", "72", "73", "74", "80", "21"],
    validRouteSign: ["1", "2", "3", "4", "5", "6"],
    validRuralUrbanArea : ["1", "2", "3", "4"],
    UrbanAreaCode : ["00000", "30925", "43345", "56116", "87193", "29494", "40213", "50392", "69454"],
    validUrbanCountyPair : [{"County" : 5, "UrbanAreaCode" : "29494"}, {"County" : 72, "UrbanAreaCode" : "69454" }, {"County" : 60, "UrbanAreaCode" : "50392" }],
    validFuncClass : ["1", "2", "3", "4", "5", "6", "7"],
    validSystemStatus : ["1", "2", "3"],
    validTypeRoad : ["1", "3", "5", "6", "7", "8"],
    validMedianType : ["0", "1", "2", "3", "4", "5"],
    validTypeOperation : ["1", "2", "3", "4"],
    validAccess : ["1", "2", "3"],
    validAPHN : ["0", "1", "2", "3", "4"],
    validNHS : ["0", "1", "2", "3", "3", "4", "5", "6", "7", "8"],
    validSpecialSystems : ["1" , "3" , "4", "5", "6", "7", "9"],
    validShoulderSurface : ["0", "1", "2", "3", "4", "5", "6"],
    validExtraLanes : ["0", "1", "2", "3", "4", "5", "6", "7"],
    validSurfaceType : ["0", "1", "2", "4", "6"]
};


class Validator {

    static propertyList = ["County", "Route", "Section", "Direction", "BLM", "ELM"];

static validCharacters = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9"];


constructor(inputs){

    var missingProperties = [];

    Validator.propertyList.forEach(function (i) {
        if (!inputs.hasOwnProperty(i)) {
            missingProperties.push(i);
        }
    });
    this.missingProperties = missingProperties;

    //populate the core attributes inside of the object
    if (inputs.hasOwnProperty("County")){
        if (typeof inputs.County === "string" ){
            this.County = parseInt(inputs.County.trim());
        } else {
            this.County = inputs.County;
        }
    }

    if (inputs.hasOwnProperty("Route")){
        this.Route = inputs.Route.trim();
    }
    if (inputs.hasOwnProperty("Section")){
        this.Section = inputs.Section.trim();
    }
    if (inputs.hasOwnProperty("Direction")){
        this.Direction = inputs.Direction.trim();
    }
    if (inputs.hasOwnProperty("BLM")){
        this.BLM = inputs.BLM;
    }
    if (inputs.hasOwnProperty("ELM")){
        this.ELM = inputs.ELM;
    }


    //poplate optional attributes
    if (inputs.hasOwnProperty("District")){
        if (typeof inputs.District === "string"){
            this.District = parseInt(inputs.District.trim());
        } else {
            this.District = inputs.District;
        }
    }
    //populate goverment code
    if (inputs.hasOwnProperty("GovermentCode")){
        this.GovermentCode = inputs.GovermentCode;
    }

    if (inputs.hasOwnProperty("RouteSign")){
        this.RouteSign = inputs.RouteSign;
    }

    if (inputs.hasOwnProperty("RuralUrbanArea")){
        this.RuralUrbanArea = inputs.RuralUrbanArea;
    }

    if (inputs.hasOwnProperty("UrbanAreaCode")){
        this.UrbanAreaCode = inputs.UrbanAreaCode;
    }

    if (inputs.hasOwnProperty("FuncClass")){
        this.FuncClass = inputs.FuncClass;
    }

    if (inputs.hasOwnProperty("SystemStatus")){
        this.SystemStatus = inputs.SystemStatus;
    }

    if (inputs.hasOwnProperty("Comment")){
        this.Comment = inputs.Comment;
    }

    if (inputs.hasOwnProperty("TypeRoad")){
        this.TypeRoad = inputs.TypeRoad;
    }

    if (inputs.hasOwnProperty("MedianWidth")){
        this.MedianWidth = inputs.MedianWidth;
    }

    if (inputs.hasOwnProperty("MedianType")){
        this.MedianType = inputs.MedianType;
    }

    if (inputs.hasOwnProperty("TypeOperation")){
        this.TypeOperation = inputs.TypeOperation;
    }

    if (inputs.hasOwnProperty("Access")){
        this.Access = inputs.Access;
    }

    if (inputs.hasOwnProperty("APHN")){
        this.APHN = inputs.APHN;
    }

    if (inputs.hasOwnProperty("NHS")) {
        this.NHS = inputs.NHS;
    }

    if (inputs.hasOwnProperty("SpecialSystems")) {
        this.SpecialSystems = inputs.SpecialSystems;
    }

    if (inputs.hasOwnProperty("BothDirectionNumLanes")) {
        this.BothDirectionNumLanes = inputs.BothDirectionNumLanes;
    }

    if (inputs.hasOwnProperty("OneDirectionNumLanes")) {
        this.OneDirectionNumLanes = inputs.OneDirectionNumLanes;
    }

    if (inputs.hasOwnProperty("Comment")) {
        this.Comment = inputs.Comment;
    }

    if (inputs.hasOwnProperty("YearBuilt")) {
        this.YearBuilt = inputs.YearBuilt;
    }

    if (inputs.hasOwnProperty("YearRecon")) {
        this.YearBuilt = inputs.YearBuilt;
    }

    if (inputs.hasOwnProperty("LaneWidth")) {
        this.YearBuilt = inputs.YearBuilt;
    }

    if (inputs.hasOwnProperty("SurfaceWidth")) {
        this.SurfaceWidth = inputs.SurfaceWidth;
    }

    if (inputs.hasOwnProperty("RightShoulderSurface")){
        this.RightShoulderSurface = inputs.RightShoulderSurface;
    }

    if (inputs.hasOwnProperty("LeftShoulderSurface")){
        this.LeftShoulderSurface = inputs.LeftShoulderSurface;
    }

    if (inputs.hasOwnProperty("RightShoulderWidth")){
        this.RightShoulderWidth = inputs.RightShoulderWidth;
    }

    if (inputs.hasOwnProperty("LeftShoulderWidth")){
        this.LeftShoulderWidth = inputs.LeftShoulderWidth;
    }

    if (inputs.hasOwnProperty("RoadwayWidth")){
        this.RoadwayWidth = inputs.RoadwayWidth;
    }

    if (inputs.hasOwnProperty("ExtraLanes")){
        this.ExtraLanes = inputs.ExtraLanes;
    }

    if (inputs.hasOwnProperty("SurfaceType")){
        this.SurfaceType = inputs.SurfaceType;
    }

    if (inputs.hasOwnProperty("Alternative_Route_Name")){
        this.Alternative_Route_Name = inputs.Alternative_Route_Name;
    }


}

findInvalidCharacters(testString){
    var invaidCharactersList = [];
    var characterList = testString.split("");
    characterList.forEach(function(x){
        if (!Validator.validCharacters.includes(x)) {
            invaidCharactersList.push(x);
        }
    });
    return invaidCharactersList;
}

AH_RoadID(){
    if (this.hasOwnProperty("County")){
        var County = this.County;
    } else {
        var County = "";
    }
    
    if (this.hasOwnProperty("Route")){
        var Route = this.Route;
    } else {
        var Route = this.Route;
    }
    
    if (this.hasOwnProperty("Section")){
        var Section = this.Section;
    } else {
        var Section = "";
    }
    
    if (this.hasOwnProperty("Direction")){
        var Direction = this.Direction;
    } else {
        var Direction = "";
    }
    
    return County + "x" + Route + "x" + Section + "x" + Direction; 
}

//provides the section code for the current segment assuming it has a special case in the section number
sectionCode(){
    var result = "";
    
    if (!this.hasOwnProperty("Section")){
        return "";
    }

    switch (this.Section.slice(-1)){
        case "A":
            result = "A - Alternate Route";
            break;
        case "B":
            result = "B - Business Route";
            break;
        case "C":
            result = "C - City Route";
            break;
        case "E":
            result = "E - East";
            break;
        case "N":
            result = "N - North";
            break;
        case "P":
            result = "P - Projected";
            break;
        case "S":
            result = "S - Spur or South";
            break;
        case "T":
            result = "T - Truck Route";
            break;
        case "W":
            result = "W - West";
            break;
        case "X":
            result = "X - One-way Couplet";
            break;
        case "Y":
            result = "Y - Y leg of a route";
            break;
        case "L":
            result = "L - Loop";
            break;
    }

    return result;
}

//provides the length of the segement in miles
length(){
    return this.ELM - this.BLM;
}

check(){
    var errorList = [];

    if (this.missingProperties.length > 0) {
        errorList.push({"level" : "error-error", "message" : "following input fields are missing " +  this.missingProperties, effectedFields : this.missingProperties});
    }


    //BLM and ELM validation
    if (this.ELM === undefined || this.ELM === "" || this.ELM === " "){
        errorList.push({"level" : "error-error", "message" : "ELM is empty" , effectedFields : ["ELM"]}); 
    }
    if (this.BLM === undefined || this.BLM === "" || this.BLM === " "){
        errorList.push({"level" : "error-error", "message" : "BLM is empty" , effectedFields : ["BLM"]}); 
    }
    if (this.ELM < this.BLM){
        errorList.push({"level" : "core-error", "message" : "BLM is greater than ELM" , effectedFields : ["BLM", "ELM"]});
    }
    if (this.ELM === this.BLM){
        errorList.push({"level" : "core-error",  "message" : "BLM is same as ELM" , effectedFields : ["BLM", "ELM"]});
    }

    //Other core attributes check if populated
    if (this.County === undefined || this.County.length === 0 || this.County === " "){
        errorList.push({"level" : "core-error",  "message" : "County is empty" , effectedFields : ["County"]});
    }
    if (this.Route === undefined || this.Route.length === 0 || this.Route === " "){
        errorList.push({"level" : "core-error",  "message" : "Route is empty" , effectedFields : ["Route"]});
    } else {
        if (this.Route.length > 150){
            errorList.push({"level" : "core-error", "message" : "Route is more than 150 characters long", effectedFields : ["Route"]})
        }

        var invaidRouteCharactersList = this.findInvalidCharacters(this.Route.toUpperCase());
        if (invaidRouteCharactersList.length > 0){
            errorList.push({"level" : "core", "message" : "Route contains non-aphanumeric characters listed here: " + invaidRouteCharactersList, effectedFields : ["Route"]});
        }
    }



    if (this.Section === undefined || this.Section.length === 0 || this.Section === " "){
        errorList.push({"level" : "core-error",  "message" : "Section is empty" , effectedFields : ["Section"]});
    } else {
        var invaidSectionCharactersList = this.findInvalidCharacters(this.Section.toUpperCase());
        if (invaidSectionCharactersList.length > 0){
            errorList.push({"level" : "core", "message" : "Section contains non-aphanumeric characters listed here: " + invaidSectionCharactersList, effectedFields : ["Route"]});
        }
    }


    if (this.Direction === undefined || this.Direction.length === 0 || this.Direction === " "){
        errorList.push({"level" : "core-error",  "message" : "Direction is empty" , effectedFields : ["Direction"]});
    } else {
        //check direction for valid value
        if (!(this.Direction === "B" || this.Direction === "A")){
            errorList.push({"level" : "core-error", "message" : "Direction is not a valid value of A or B", effectedFields : ["Direction"]})
        }
    }

    //check the section of route fields for input lengths
    if (this.hasOwnProperty("Section")){
        if (this.Section.length > 3){
            errorList.push({"level" : "core-error", "message" : "Section is more than 3 characters long", effectedFields : ["Section"]})
        }
    }


    //check for valid county value
    if (!validInputRanges.validCounty.includes(this.County)){
        errorList.push({"level" : "core-error", "message" : "county number is not valid", effectedFields : ["County"]})
    }

    if (this.hasOwnProperty("District")){
        if (!validInputRanges.validDistrict.includes(this.District)){
            errorList.push({"level" : "error", "message" : "ArDot District number is not valid", effectedFields : ["District"]})

        } else {
            //if the county codes are valid too then check the county district pairing list
            if (validInputRanges.validCounty.includes(this.County)) {
                var validDistrict = false;
                var self = this;
                validInputRanges.validDistrictCountyPair.forEach(function(x){
                    if (x.county === self.County && x.district === self.District){
                        validDistrict = true;
                    }
                });

                if (!validDistrict){
                    errorList.push({"level" : "error", "message" : "County and District do not match", effectedFields : ["District", "County"]});
                }

            }
        }
    }

    if (this.hasOwnProperty("GovermentCode")){
        //if populated check to see if its a number
        if (!validInputRanges.validGovermentCode.includes(this.GovermentCode)){
            errorList.push({"level" : "error", "message" : "Invalid Goverment Code", effectedFields : ["GovermentCode"]});
        }

    }

    //Needs work on goverment code logic
    if (this.hasOwnProperty("RouteSign")){
        if (!validInputRanges.validRouteSign.includes(this.RouteSign)){
            errorList.push({"level" : "error", "message" : "Invalid RouteSign Code", effectedFields : ["RouteSign"]});
        } else {
            //if the goverement code is valid too then check this attribute
            if (validInputRanges.validGovermentCode.includes(this.GovermentCode)){
                if (( ["1", "2", "3"].includes(this.RouteSign) && this.GovermentCode != "01") || ( !["1", "2", "3"].includes(this.RouteSign) && this.GovermentCode === "01")){
                    errorList.push({"level" : "error", "message" : "Interstates, US routes, and state highway much be managed have a goverment code for ArDOT managment", effectedFields : ["RouteSign", "GovermentCode"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("RuralUrbanArea")){
        if (!validInputRanges.validRuralUrbanArea.includes(this.RuralUrbanArea)){
            errorList.push({"level" : "error", "message" : "Rural Urban Area value is not valid", effectedFields : ["RuralUrbanArea"]});
        } else {

        }

    }

    if (this.hasOwnProperty("UrbanAreaCode")){
        if (!validInputRanges.UrbanAreaCode.includes(this.UrbanAreaCode)){
            errorList.push({"level" : "error", "message" : "Urban Area value is not valid", effectedFields : ["UrbanArea"]});
        } else {
            if (validInputRanges.validRuralUrbanArea.includes(this.RuralUrbanArea)){
                //multiple error messages according to the RuralUrbanArea vs the UrbanAreaCode
                if (["3", "4"].includes(this.RuralUrbanArea) && this.UrbanAreaCode === "00000"){
                    errorList.push({"level" : "error", "message" : "Small Urganized and Urbanized areas must have Urban Area Code", effectedFields : ["RuralUrbanArea", "UrbanArea"]});
                }
                if (["1", "2"].includes(this.RuralUrbanArea) && !(this.UrbanAreaCode === "00000")){
                    errorList.push({"level" : "error", "message" : "Rural and Urban Areas should not have an Urban Area Code. Urban Area Code should be 00000", effectedFields : ["RuralUrbanArea", "UrbanArea"]});
                }
            }

            //check to see if county is valid for the urban code
            if ((this.UrbanAreaCode != "00000") && validInputRanges.validCounty.includes(this.County)){
                var self = this;
                var validUrbanCountyPair = false;
                validInputRanges.validUrbanCountyPair.forEach(function(x){
                    if (x.County == self.County && x.UrbanAreaCode === self.UrbanAreaCode){
                        validUrbanCountyPair = true;
                    }
                });

                if (!validUrbanCountyPair) {
                    errorList.push({"level" : "error", "message" : "UrbanArea Code does not match county field", effectedFields : ["County", "UrbanArea"]});
                }
            }

        }
    }

    if (this.hasOwnProperty("FuncClass")) {
        if (!validInputRanges.validFuncClass.includes(this.FuncClass)){
            errorList.push({"level" : "error", "message" : "Functional Class does not have a valid input value", effectedFields : ["FuncClass"]});
        } else {
            //if the route sign value field is valid
            if (validInputRanges.validRouteSign.includes(this.RouteSign)){
                if (this.RouteSign === "1" && this.FuncClass != "1"){
                    errorList.push({"level" : "error", "message" : "If Route Sign is 1 - Interstate, the functional class needs to be interstate too.", effectedFields : ["FuncClass", "RouteSign"]});
                }

                if (this.RouteSign != "1" && this.FuncClass === "1"){
                    errorList.push({"level" : "error", "message" : "If Functional Class is is 1 (Interstate), the Route Sign needs to be interstate too.", effectedFields : ["FuncClass", "RouteSign"]});
                }
            }

            //check against type operation
        }
    }

    if (this.hasOwnProperty("SystemStatus")){
        if (!validInputRanges.validSystemStatus.includes(this.SystemStatus)){
            errorList.push({"level" : "error", "message" : "System Status does not contain a valid value", effectedFields : ["SystemStatus"]});
        }
    }

    if (this.hasOwnProperty("TypeRoad")){
        if (!validInputRanges.validTypeRoad.includes(this.TypeRoad)){
            errorList.push({"level" : "error", "message" : "Type Road value is invalid", effectedFields : ["TypeRoad"]});
        }
    }

    if (this.hasOwnProperty("MedianWidth")){
        //check to see if it is numeric
        if (!/^\d+$/.test(this.MedianWidth)){
            errorList.push({"level" : "error", "message" : "Median Width cannot be converted into a number", effectedFields : ["MedianWidth"]});
        }
    }

    if (this.hasOwnProperty("MedianType")){
        if (!validInputRanges.validMedianType.includes(this.MedianType)){
            errorList.push({"level" : "error", "message" : "Median Type is not a valid coded value", effectedFields : ["MedianWidth"]});
        } else {
            if (/^\d+$/.test(this.MedianWidth)){
                if (["1", "2", "3", "4", "5"].includes(this.MedianType) && ([null, undefined, "", "00000"].includes(this.MedianWidth))) {
                    errorList.push({"level" : "error", "message" : "Median Type indicates there is a median but the Median Width is null.", effectedFields : ["MedianWidth", "MedianType"]});
                }
                if (this.MedianType === "1" &&  !([null, undefined, "", "00000"].includes(this.MedianWidth))) {
                    errorList.push({"level" : "error", "message" : "Median Type indicates there is no median but the Median width is not zero", effectedFields : ["MedianWidth", "MedianType"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("TypeOperation")) {
        if (!validInputRanges.validTypeOperation.includes(this.TypeOperation)){
            errorList.push({"level" : "error", "message" : "Type Operation value is not valid", effectedFields : ["TypeOperation"]});
        } else {
            //if the median type is valid
            if (validInputRanges.validMedianType.includes(this.MedianType)){
                if ([null, undefined, "", "00000"].includes(this.MedianWidth) && this.TypeOperation === "1") {
                    errorList.push({"level" : "error", "message" : "Type Operation indicates the road is divided so it should have a median but the median type indicates there is no median", effectedFields : ["MedianType", "TypeOperation"]});
                }
            }

            //if the median width is valid
            if (/^\d+$/.test(this.MedianWidth)){
                if ( parseInt(this.MedianWidth) === 0 && this.TypeOperation === "4"){
                    errorList.push({"level" : "error", "message" : "Type Operation indicates the road is divided so it should have a median but the median width indicates there is no median", effectedFields : ["MedianWidth", "TypeOperation"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("Access")){
        if (!validInputRanges.validAccess.includes(this.Access)){
            errorList.push({"level" : "error", "message" : "Access is value is not valid", effectedFields : ["Access"]});
        } else {
            //if the RouteSign is 
            if (validInputRanges.validRouteSign.includes(this.RouteSign)) {
                if ((this.RouteSign === "1" && this.Access != "1") || (this.RouteSign != "1" && this.Access === "1")){
                    errorList.push({"level" : "error", "message" : "Route Sign Interstate (1) segmeents must also have accesss be 3 - No Control and vice versa", effectedFields : ["RouteSign", "Access"]});
                }
            }

            //type operation
            if (validInputRanges.validTypeOperation.includes(this.TypeOperation)){
                if (this.Access === "1" && this.TypeOperation != "4") {
                    errorList.push({"level" : "error", "message" : "If access is full control (1) then Type Operation must be divided highway (1)", effectedFields : ["Access", "TypeOperation"]});
                }
            }

            //MedianType
            if (validInputRanges.validMedianType.includes(this.MedianType)) {
                if (this.Access === "3" && this.MedianType != "0") {
                    errorList.push({"level" : "error", "message" : "If Access is no control (3) then the road has a median so MedianType should not be 0", effectedFields : ["Access", "MedianType"]});
                }
            }

            //Median Width
            if (/^\d+$/.test(this.MedianWidth)){
                if (parseInt(this.MedianWidth) === 0 && this.Access === "3"){
                    errorList.push({"level" : "error", "message" : "If Access is no control (3) then the road has no a median so MedianWidth should be greater than 0", effectedFields : ["Access", "MedianWidth"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("AHPN")){
        if (!validInputRanges.validAPHN.includes(this.APHN)){
            errorList.push({"level" : "error", "message" : "APHN value is not valid", effectedFields : ["APHN"]});
        }
    }

    if (this.hasOwnProperty("NHS")){
        if (!validInputRanges.validNHS.includes(this.NHS)){
            errorList.push({"level" : "error", "message" : "NHS value is not valid", effectedFields : ["NHS"]});
        } 
    }



    //highly compound check on a few attributes
    if (this.RouteSign === "1" && this.TypeRoad === "1"){
        if(validInputRanges.validNHS.includes(this.NHS)){
            if (this.NHS != "1"){
                errorList.push({"level" : "error", "message" : "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the NHS (1-Interstate).", effectedFields : ["NHS", "RouteSign", "TypeRoad"]});
            }
        }
        if (validInputRanges.validAPHN.includes(this.APHN)){
            if (this.APHN != "1"){
                errorList.push({"level" : "error", "message" : "All RouteSign Interstate (1) roads that are Type Road mainlane (1) must be part of the APHN (1- Interstate).", effectedFields : ["NHS", "RouteSign", "TypeRoad"]});
            }
        }

    }

    if (["2", "3"].includes(this.RouteSign) && this.TypeRoad === "1" && this.NHS != "0"){
        errorList.push({"level" : "error", "message" : "All US Routes and State Highway are are on the NHS are automatically placed on the APHN", effectedFields : ["NHS", "RouteSign", "TypeRoad", "NHS"]});
    }

    if (validInputRanges.validAPHN.includes(this.APHN) && validInputRanges.validNHS.includes(this.NHS)){
        if (this.NHS != "0" && this.AHPN === "1"){
            errorList.push({"level" : "error", "message" : "Routes not on the NHS can't be placed under AHPN status NHS (1)", effectedFields : ["NHS", "APHN"]});
        }

        if (this.NHS === "1" && this.APHN != "1"){
            errorList.push({"level" : "error", "message" : "Routes on the NHS must be placed under AHPN status NHS (1)", effectedFields : ["NHS", "APHN"]});
        }

        if (this.NHS === "0" && this.APHN === "1"){
            errorList.push({"level" : "error", "message" : "Routes not on the NHS can't be placed under AHPN status NHS (1)", effectedFields : ["NHS", "APHN"]});
        }
    }

    if (validInputRanges.validFuncClass.includes(this.FuncClass) && validInputRanges.validAPHN.includes(this.APHN)){
        if (this.APHN === "2" && !(["2", "3", "4"].includes(this.FuncClass))){
            errorList.push({"level" : "error", "message" : "APHN is set to Other aerterials. Other arterials status is only given to functional classes 2,3 and 4. Please change the functional class or APHN status", effectedFields : ["FuncClass", "APHN"]});
        }
    }



    if (this.hasOwnProperty("SpecialSystems")){
        if (!validInputRanges.validSpecialSystems.includes(this.SpecialSystems)){
            errorList.push({"level" : "error", "message" : "SpecialSystems is not valid", effectedFields : ["SpecialSystems"]});
        }
    }

    if (this.hasOwnProperty("BothDirectionNumLanes")){
        if (!/^\d+$/.test(this.BothDirectionNumLanes)){
            errorList.push({"level" : "error", "message" : "Both Directions Number of Lanes is not a number", effectedFields : ["BothDirectionNumLanes"]});
        } else {

            if (parseInt(this.BothDirectionNumLanes) <= 0){
                errorList.push({"level" : "error", "message" : "Both Directions Number of Lanes should not be negitive", effectedFields : ["BothDirectionNumLanes"]});
            }

            if (validInputRanges.validTypeOperation.includes(this.TypeOperation)){
                if (this.BothDirectionNumLanes === "1" && this.TypeOperation === "4") {
                    errorList.push({"level" : "error", "message" : "A one lane road can't be Type Operation 4 - Divided highway. Needs to be 2 or greater", effectedFields : ["TypeOperation", "BothDirectionNumLanes" ]});
                }
            }
        }
    }

    if (this.hasOwnProperty("OneDirectionNumLanes")){
        if (!/^\d+$/.test(this.OneDirectionNumLanes)){
            errorList.push({"level" : "error", "message" : "One Directions Number of Lanes is not a number", effectedFields : ["OneDirectionNumLanes"]});
        } else {
            if (parseInt(this.OneDirectionNumLanes) <= 0){
                errorList.push({"level" : "error", "message" : "One Directions Number of Lanes should not be negitive", effectedFields : ["OneDirectionNumLanes"]});
            }

            //check with both lane fields
            if (/^\d+$/.test(this.BothDirectionNumLanes)) {
                if (this.BothDirectionNumLanes < this.OneDirectionNumLanes){
                    errorList.push({"level" : "error", "message" : "One Directions Number of Lanes should not be greater than Both Direction Number of Lanes", effectedFields : ["OneDirectionNumLanes", "BothDirectionNumLanes"]});
                }

                if (validInputRanges.validTypeOperation.includes(this.TypeOperation)){
                    if (this.TypeOperation === "4" && this.BothDirectionNumLanes <= this.OneDirectionNumLanes){
                        errorList.push({"level" : "error", "message" : "If a road is Type Operation 4 - Divided highway, Both Direction Number of Lanes must be greater than the one direction number of lanes", effectedFields : ["OneDirectionNumLanes", "BothDirectionNumLanes", "TypeOperation"]});
                    }

                    if (this.BothDirectionNumLanes > this.OneDirectionNumLanes && this.TypeOperation != "4"){
                        errorList.push({"level" : "error", "message" : "If both direction Number of Lanes is greater than one direction number of lanes, then type Operation must be 4 - divided highway", effectedFields : ["OneDirectionNumLanes", "BothDirectionNumLanes", "TypeOperation"]});
                    }
                }

            }
            if (validInputRanges.validMedianType.includes(this.MedianType)){
                if (this.MedianType === "0" && this.BothDirectionNumLanes > this.OneDirectionNumLanes){
                    errorList.push({"level" : "error", "message" : "If both direction Number of Lanes is greater than one direction number of lanes, then the road must have a median and MedianType must not be 0 - no median", effectedFields : ["OneDirectionNumLanes", "BothDirectionNumLanes", "MedianType"]});
                }
            }

            if (/^\d+$/.test(this.MedianWidth)){
                if (this.MedianWidth === "0"  && parseInt(this.BothDirectionNumLanes) > parseInt(this.OneDirectionNumLanes)){
                    errorList.push({"level" : "error", "message" : "If both direction Number of Lanes is greater than one direction number of lanes, then the road must have a median and Median Width must not be 0 - no median", effectedFields : ["OneDirectionNumLanes", "BothDirectionNumLanes", "MedianWidth"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("YearBuilt")){
        if (/^\d+$/.test(this.YearBuilt)){
            if (!(parseInt(this.YearBuilt) >= 1800 && parseInt(this.YearBuilt) < 20100)){
                errorList.push({"level" : "error", "message" : "Year Built is not between 1800 and 20100", effectedFields : ["YearBuilt"]});
            }
        } else {
            errorList.push({"level" : "error", "message" : "Year Built is not a number", effectedFields : ["YearBuilt"]});
        }
    }

    if (this.hasOwnProperty("YearRecon")){
        if (/^\d+$/.test(this.YearRecon)){
            if (!(parseInt(this.YearRecon) >= 1800 && parseInt(this.YearRecon) < 20100)){
                errorList.push({"level" : "error", "message" : "Year Reconstructed is not between 1800 and 20100", effectedFields : ["YearRecon"]});
            }
        } else {
            errorList.push({"level" : "error", "message" : "Year Reconstructed is not a number", effectedFields : ["YearRecon"]});
        }
    }

    if (this.hasOwnProperty("LaneWidth")){
        if (/^\d+$/.test(this.LaneWidth)){
            if (parseInt(this.LaneWidth) > 15){
                errorList.push({"level" : "error", "message" : "LaneWidth is Greater than 15 feet", effectedFields : ["LaneWidth"]});
            }
        } else {
            errorList.push({"level" : "error", "message" : "LaneWidth is not a number", effectedFields : ["LaneWidth"]});
        }
    }

    if (this.hasOwnProperty("SurfaceWidth")){
        if (!/^\d+$/.test(this.LaneWidth)){
            errorList.push({"level" : "error", "message" : "LaneWidth is not a number", effectedFields : ["LaneWidth"]});
        } else {
            if (this.hasOwnProperty("LaneWidth") && /^\d+$/.test(this.LaneWidth)){
                if (this.SurfaceWidth < this.LaneWidth){
                    errorList.push({"level" : "error", "message" : "Lane Width can't be larger than Surface Width", effectedFields : ["LaneWidth", "SurfaceWidth"]});
                }
            }
        }
    }

    if (this.hasOwnProperty("RightShoulderSurface")){
        if (!validInputRanges.validShoulderSurface.includes(this.RightShoulderSurface)){
            errorList.push({"level" : "error", "message" : "invalid Right Shoulder Surface Type", effectedFields : ["RightShoulderSurface"]});
        }
    }

    if (this.hasOwnProperty("LeftShoulderSurface")){
        if (!validInputRanges.validShoulderSurface.includes(this.LeftShoulderSurface)){
            errorList.push({"level" : "error", "message" : "invalid Left Shoulder Surface Type", effectedFields : ["LeftShoulderSurface"]});
        }
    }

    if (this.hasOwnProperty("LeftShoulderWidth")){
        if (!/^\d+$/.test(this.LeftShoulderWidth)){
            errorList.push({"level" : "error", "message" : "Left Shoulder Width is not a number", effectedFields : ["LeftShoulderWidth"]});
        } else {
            if (parseInt(this.LeftShoulderWidth) <0){
                errorList.push({"level" : "error", "message" : "Left Shoulder Width can't be negitive", effectedFields : ["LeftShoulderWidth"]});
            }
            if (parseInt(this.LeftShoulderWidth) > 99 ){
                errorList.push({"level" : "error", "message" : "Left Shoulder Width can't be greater than 99", effectedFields : ["LeftShoulderWidth"]});
            }
        }
    }

    if (this.hasOwnProperty("RightShoulderWidth")){
        if (!/^\d+$/.test(this.RightShoulderWidth)){
            errorList.push({"level" : "error", "message" : "Right Shoulder Width is not a number", effectedFields : ["RightShoulderWidth"]});
        } else {
            if (parseInt(this.RightShoulderWidth) <0){
                errorList.push({"level" : "error", "message" : "Right Shoulder Width can't be negitive", effectedFields : ["RightShoulderWidth"]});
            }
            if (parseInt(this.RightShoulderWidth) > 99 ){
                errorList.push({"level" : "error", "message" : "Right Shoulder Width can't be greater than 99", effectedFields : ["RightShoulderWidth"]});
            }
        }
    }

    if (this.hasOwnProperty("RoadwayWidth")){
        if (!/^\d+$/.test(this.RoadwayWidth)){
            errorList.push({"level" : "error", "message" : "Roadway Width is not a number", effectedFields : ["RoadwayWidth"]});
        } else {
            if (parseInt(this.RoadwayWidth) < 0){
                errorList.push({"level" : "error", "message" : "Roadway Width can't be negitive", effectedFields : ["RoadwayWidth"]});
            }

            if (parseInt(this.RoadwayWidth) > 999){
                errorList.push({"level" : "error", "message" : "Roadway Width greater than 999", effectedFields : ["RoadwayWidth"]});
            }
        }
    }

    if (this.hasOwnProperty("validExtraLanes")){
        if (!validInputRanges.validExtraLanes.includes(this.ExtraLanes)){
            errorList.push({"level" : "error", "message" : "Extra Lanes is not a valid value", effectedFields : ["ExtraLanes"]});
        }
    }

    if (this.hasOwnProperty("SurfaceType")){
        if (!validInputRanges.validSurfaceType.includes(this.SurfaceType)){
            errorList.push({"level" : "error", "message" : "Surface Type is not valid", effectedFields : ["SurfaceType"]});
        }
    }


    //currently on page 61 of guide (68 pages total)

    return errorList;
}


}




/*
var test = new Validator({"County" : 2, "Route" : "ARNOLDDRIVE1" , "Section" : "1234?", "Direction" : "A", "BLM" : 2.15, "ELM" : 0, "District" : "2", "GovermentCode" : "01", "RouteSign" : "3", "RuralUrbanArea" : "4", "UrbanAreaCode" : "29494" });
console.log(test);
console.log(test.check());
*/