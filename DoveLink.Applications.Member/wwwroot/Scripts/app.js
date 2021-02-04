
var now = dayjs();

$(document).ready(function () {
    setInputMasks();
    populateStatesDropdown();

    $(document).on("click", ".navigation-btn", function () {
        $('body').toggleClass('close-sidebar');
    });
});


function setInputMasks() {
    var defaultOptions = { showMaskOnHover: false };

    $("input.date").inputmask("99/99/9999", defaultOptions);
    $("input.phone").inputmask("(999) 999-9999", defaultOptions);
    $("input.pin").inputmask("9999", defaultOptions);
    $("input.zipcode").inputmask("99999[-9999]", defaultOptions);
    $("input.tax-id").inputmask({ regex: "[0-9\-]*", showMaskOnHover: false });

    // Initial placeholder values
    $("input").each(function () {
        setPlaceholderText($(this));
    });

    $("input").on('blur', function () {
        if (!$(this).val()) { // Force blank value to show correct placeholder as input mask does weird things
            $(this).val('');
        }
        setPlaceholderText($(this));
    });
}

function setPlaceholderText(input) {
    var placeholder = "";
    if ($(input).hasClass("date")) {
        placeholder = "mm/dd/yyyy";
    } else if ($(input).hasClass("phone")) {
        placeholder = "ex. (888) 555-1234";
    } else if ($(input).hasClass("zipcode")) {
        placeholder = "10108-____";
    } else if ($(input).hasClass("pin")) {
        placeholder = "ex. 1234";
    }

    if (placeholder) {
        $(input).attr("placeholder", placeholder);
    }
}

// State drop-down
function populateStatesDropdown() {
    var states = [
        {
            "name": "Alabama",
            "abbreviation": "AL"
        },
        {
            "name": "Alaska",
            "abbreviation": "AK"
        },
        {
            "name": "Arizona",
            "abbreviation": "AZ"
        },
        {
            "name": "Arkansas",
            "abbreviation": "AR"
        },
        {
            "name": "California",
            "abbreviation": "CA"
        },
        {
            "name": "Colorado",
            "abbreviation": "CO"
        },
        {
            "name": "Connecticut",
            "abbreviation": "CT"
        },
        {
            "name": "Delaware",
            "abbreviation": "DE"
        },
        {
            "name": "District Of Columbia",
            "abbreviation": "DC"
        },
        {
            "name": "Florida",
            "abbreviation": "FL"
        },
        {
            "name": "Georgia",
            "abbreviation": "GA"
        },
        {
            "name": "Hawaii",
            "abbreviation": "HI"
        },
        {
            "name": "Idaho",
            "abbreviation": "ID"
        },
        {
            "name": "Illinois",
            "abbreviation": "IL"
        },
        {
            "name": "Indiana",
            "abbreviation": "IN"
        },
        {
            "name": "Iowa",
            "abbreviation": "IA"
        },
        {
            "name": "Kansas",
            "abbreviation": "KS"
        },
        {
            "name": "Kentucky",
            "abbreviation": "KY"
        },
        {
            "name": "Louisiana",
            "abbreviation": "LA"
        },
        {
            "name": "Maine",
            "abbreviation": "ME"
        },
        {
            "name": "Maryland",
            "abbreviation": "MD"
        },
        {
            "name": "Massachusetts",
            "abbreviation": "MA"
        },
        {
            "name": "Michigan",
            "abbreviation": "MI"
        },
        {
            "name": "Minnesota",
            "abbreviation": "MN"
        },
        {
            "name": "Mississippi",
            "abbreviation": "MS"
        },
        {
            "name": "Missouri",
            "abbreviation": "MO"
        },
        {
            "name": "Montana",
            "abbreviation": "MT"
        },
        {
            "name": "Nebraska",
            "abbreviation": "NE"
        },
        {
            "name": "Nevada",
            "abbreviation": "NV"
        },
        {
            "name": "New Hampshire",
            "abbreviation": "NH"
        },
        {
            "name": "New Jersey",
            "abbreviation": "NJ"
        },
        {
            "name": "New Mexico",
            "abbreviation": "NM"
        },
        {
            "name": "New York",
            "abbreviation": "NY"
        },
        {
            "name": "North Carolina",
            "abbreviation": "NC"
        },
        {
            "name": "North Dakota",
            "abbreviation": "ND"
        },
        {
            "name": "Ohio",
            "abbreviation": "OH"
        },
        {
            "name": "Oklahoma",
            "abbreviation": "OK"
        },
        {
            "name": "Oregon",
            "abbreviation": "OR"
        },
        {
            "name": "Pennsylvania",
            "abbreviation": "PA"
        },
        {
            "name": "Rhode Island",
            "abbreviation": "RI"
        },
        {
            "name": "South Carolina",
            "abbreviation": "SC"
        },
        {
            "name": "South Dakota",
            "abbreviation": "SD"
        },
        {
            "name": "Tennessee",
            "abbreviation": "TN"
        },
        {
            "name": "Texas",
            "abbreviation": "TX"
        },
        {
            "name": "Utah",
            "abbreviation": "UT"
        },
        {
            "name": "Vermont",
            "abbreviation": "VT"
        },
        {
            "name": "Virginia",
            "abbreviation": "VA"
        },
        {
            "name": "Washington",
            "abbreviation": "WA"
        },
        {
            "name": "West Virginia",
            "abbreviation": "WV"
        },
        {
            "name": "Wisconsin",
            "abbreviation": "WI"
        },
        {
            "name": "Wyoming",
            "abbreviation": "WY"
        }
    ];

    for (var state of states) {
        $("select[name='state']").append("<option value='" + state.abbreviation + "'>" + state.name + "</option>");
    }
}

function showHideEye(e, inputId) {
    if (e && e.className.includes("fa-eye-slash")) {
        e.className = "fa fa-eye";
        document.getElementById(inputId).setAttribute('type', 'text');
    } else {
        e.className = "fa fa-eye-slash";
        document.getElementById(inputId).setAttribute('type', 'password');
    }
}