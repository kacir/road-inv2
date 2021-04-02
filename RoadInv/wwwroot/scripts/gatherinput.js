function gatherInput (){
    inputs = {};

    subjectAttributes = ["District", "County", "Route", "Section", "Direction", "BLM", "ELM", "RouteSign", "TypeRoad", "RuralUrbanArea", "UrbanCode", "LeftShoulderWidth", "LeftShoulderSurface", "RightShoulderWidth", "RightShoulderSurface", "SurfaceType", "TypeOperation", "LaneWidth", "ExtraLanes", "SurfaceWidth", "Access", "MedianType", "MedianWidth", "OneDirectionNumLanes", "BothDirectionNumLanes", "FuncClass", "NHS", "APHN", "GovermentCode", "SpecialSystems", "SystemStatus", "Alternative_Route_Names"];

    subjectAttributes.forEach(function(x){
        var raw = $("#gather-" + x).val();
        if (raw != "") {
            inputs[x] = raw;
        }
    });

    var altNames = $("#box-alternate div input").map((_,el) => el.value).get();
    var altNamesFilter = [];

    altNames.forEach(function(x){
        if (x != ""){altNamesFilter.push(x)}
    })

    return inputs;
}

function parameterCheckEventLoop(){
    console.log(gatherInput());
    var inputParameters = gatherInput();
    var checker = new Validator(inputParameters);
    var errors = checker.check();

    var itemIDs = [];

    errors.forEach(function(x){
        itemIDs = itemIDs.concat(x.effectedFields);
    });

    itemIDs = Array.from(new Set(itemIDs));//remove duplicates
    refinedItem = []

    itemIDs.forEach(function(x){
        refinedItem.push("gather-" + x);
    });

    console.log(errors);
    console.log(refinedItem);


    $(".error-flag").removeClass("error-flag");
    //change color of effected items by changing the item class
    refinedItem.forEach(function(x){
        $("#" + x).addClass("error-flag");
    });

    //populate section code, road length and
    checker.length();
    $("#post-SectionCode").html(checker.sectionCode());
    $("#post-RoadLength").html(checker.length().toFixed(3));
    $("#post-AH_RoadID").html(checker.AH_RoadID());
}


//contrain these corrections to Manual Override mode off
//make sure BLM and ELM always have 3 digit 
$("#gather-BLM").focusout(function(){
    //force BLM and ELM to be zero decimal places
    var BLM = $("#gather-BLM").val();
    if (!isNaN(BLM) && BLM != "" && BLM != null && BLM != undefined){
        console.log(BLM);
        BLM = parseFloat(BLM).toFixed(3);
        $("#gather-BLM").val(BLM);
    }
});

$("#gather-ELM").focusout(function(){
    //force BLM and ELM to be zero decimal places
    var ELM = $("#gather-ELM").val();
    if (!isNaN(ELM) && ELM != "" && ELM != null && ELM != undefined){
        console.log(ELM);
        ELM = parseFloat(ELM).toFixed(3);
        $("#gather-ELM").val(ELM);
    }
});

//make Shoulder widths, Lane widths, lanes, surface width and median width integers when entered




$(document).ready(function(){
    $("input").keyup(parameterCheckEventLoop);
    $("select").change(parameterCheckEventLoop);
    //$("#button-save").click(parameterCheckEventLoop);
})