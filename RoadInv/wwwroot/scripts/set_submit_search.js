
function submitEventLoop() {
        console.log("hello world!");
        var inputDistrict = $('#district option:selected').text();
        var inputCounty = $('#county option:selected').attr('value');
        var inputRoute = $('#route').val();
        var inputSection = $('#section').val();
        var inputLogmile = $('#logmile').val();

        if (inputDistrict === undefined) {
            inputDistrict = "";
        }

    if (inputCounty === undefined) {
        inputCounty = "";
    }

    if (inputRoute === undefined) {
        inputRoute = "";
    }

    if (inputSection === undefined) {
        inputSection = "";
    }

    if (inputLogmile === undefined) {
        inputLogmile = -1;
    }

        
        console.log(inputDistrict);
        console.log(inputCounty);
        console.log(inputRoute);
        console.log(inputSection);
        console.log(inputLogmile);

    inputDistrict = 'district=' + inputDistrict + '&';
    inputCounty = 'county=' + inputCounty + '&';
    inputRoute = 'route=' + inputRoute + '&';
    inputSection = 'section=' + inputSection + '&';
    inputLogmile = 'logmile=' + inputLogmile.trim();

    var searchString = "/segments?" + inputDistrict + inputCounty + inputRoute + inputSection + inputLogmile
        $('#submit-search-link').attr("href", searchString);
    }


$("#route, #section, #logmile, #district, #county").change(submitEventLoop);