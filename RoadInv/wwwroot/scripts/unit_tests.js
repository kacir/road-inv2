

unitTest = {};
//empty Test
unitTest.emptyInput = function () {
    var test = new Validator({});

    try {
        test.check();
        console.log("failed");
    } catch (error) {
        console.log("passed");
        console.log(test.check());
    }

};

unitTest.minAttributes = function () {
    var test = new Validator(
        {"County" : 2, "Route" : "ARNOLDDRIVE1", "Section" : "123", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.logmilesFlipped = function (){
    var test = new Validator(
        {"County" : 2, "Route" : "ARNOLDDRIVE1", "Section" : "123", "Direction" : "A", "BLM" : 0.3, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidCharRoute = function (){
    var test = new Validator(
        {"County" : 2, "Route" : "ARNOLDDRIVE1*", "Section" : "123", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidCharDirection = function (){
    var test = new Validator(
        {"County" : 2, "Route" : "ARNOLDDRIVE1", "Section" : "123", "Direction" : "Z", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidCharSection = function (){
    var test = new Validator(
        {"County" : 2, "Route" : "ARNOLDDRIVE1", "Section" : "12^", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidCharCounty =  function (){
    var test = new Validator(
        {"County" : 80, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidDistrictCountyPair =  function (){
    var test = new Validator(
        {"District" : 3, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}
unitTest.invalidDistrictCountyPair2 =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2 }
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidGoverementCode =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, GovermentCode : "05" }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validRouteSignGoverementCodePair =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, GovermentCode : "01", RouteSign : "1" }
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidRouteSignGoverementCodePair =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, GovermentCode : "01", RouteSign : "5" }
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validUrbanRuralArea =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, UrbanRuralArea : "1", UrbanAreaCode : "00000" }
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidUrbanRuralArea =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, RuralUrbanArea : "5"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validUrbanRuralArea =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, RuralUrbanArea : "1"}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validUrbanRuralArea =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, RuralUrbanArea : "1", UrbanAreaCode : "00000"}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidUrbanRuralAreaPair =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, RuralUrbanArea : "4", UrbanAreaCode : "00000"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validUrbanAreaCode =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, UrbanAreaCode : "50392"}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidUrabnCodeCountyPair =  function (){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, UrbanAreaCode : "40925"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

//on page 33 of validation checks
unitTest.inValidFunctionalClass = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "FuncClass" : '10'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.inValidFuncRouteSignPair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "FuncClass" : '1', "RouteSign" : "2"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.inValidFuncRouteSignPair2 = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "FuncClass" : '2', "RouteSign" : "1"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

//page 34 of validation checks
unitTest.invalidNHSPair1 = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "RouteSign" : "1", "TypeRoad" : "1", "NHS" : '0'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAPHNPair1 = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "RouteSign" : "1", "TypeRoad" : "1", "APHN" : '0'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidNHSPair2 = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "RouteSign" : "2", "TypeRoad" : "1", "NHS" : '3', "APHN" : '0'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidNHSAPHNpair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "NHS" : '0', "APHN" : '1'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

// page 37
unitTest.validSystemStatus = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "SystemStatus" : '2'}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidSystemStatus = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "SystemStatus" : '7'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validSpecialSystems = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "SystemStatus" : '1'}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAPHNFunctionalPair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "FuncClass" : '1', "APHN" : "2"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validAccess = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '1'}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAccess = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '50'}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAccessTypeOperationPair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '1', "TypeOperation" : "2"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validAccessTypeOperationPair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '1', "TypeOperation" : "4"}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.validAccessMedianTypePair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '3', "MedianType" : "0"}
    );

    if (test.check().length === 0){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAccessMedianTypePair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '3', "MedianType" : "3"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidAccessMedianWidthPair = function(){
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "Access" : '3', "MedianWidth" : "0"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}

unitTest.invalidTypeOperationMedianTypePair = function() {
    var test = new Validator(
        {"District" : 6, "County" : 60, "Route" : "ARNOLDDRIVE1", "Section" : "12", "Direction" : "A", "BLM" : 0, "ELM" : 0.2, "TypeOperation" : '4', "MedianWidth" : "0000"}
    );

    if (test.check().length === 1){
        console.log("passed");
    } else {
        console.log("failed");
        console.log(test.check());
    }
}


unitTest.master = function () {
    unitTest.minAttributes();
    unitTest.logmilesFlipped();
    unitTest.invalidCharRoute();
    unitTest.invalidCharDirection();
    unitTest.invalidCharSection();
    unitTest.invalidCharCounty();
    unitTest.invalidDistrictCountyPair();
    unitTest.invalidDistrictCountyPair2();
    unitTest.invalidGoverementCode();
    unitTest.validRouteSignGoverementCodePair();
    unitTest.invalidRouteSignGoverementCodePair();
    unitTest.validUrbanRuralArea();
    unitTest.invalidUrbanRuralArea();
    unitTest.validUrbanRuralArea();
    unitTest.validUrbanRuralArea();
    unitTest.invalidUrbanRuralAreaPair();
    unitTest.validUrbanAreaCode();
    unitTest.invalidUrabnCodeCountyPair();
    unitTest.inValidFunctionalClass();
    unitTest.inValidFuncRouteSignPair();
    unitTest.inValidFuncRouteSignPair2();
    unitTest.invalidNHSPair1();
    unitTest.invalidAPHNPair1();
    unitTest.invalidNHSPair2();
    unitTest.invalidNHSAPHNpair();
    unitTest.validSystemStatus();
    unitTest.invalidSystemStatus();
    unitTest.validSpecialSystems();
    unitTest.invalidAPHNFunctionalPair();
    unitTest.validAccess();
    unitTest.invalidAccess();
    unitTest.validAccessTypeOperationPair();
    unitTest.validAccessMedianTypePair();
    unitTest.invalidAccessMedianTypePair();
    unitTest.invalidAccessMedianWidthPair();
    
    unitTest.invalidTypeOperationMedianTypePair();

}

unitTest.master();