$(document).ready(function () {
    var noitem = "<option value='0'>Seçiniz</option>"
    $('#TownId').html(noitem)
    $("#CityId").on("change", function () {
        var url = "/Disaster/GetCityId";
        var ddlsource = "#CityId";

        $.getJSON(url, {
                    CityId: $(ddlsource).val()
                },
                function (data) {
                    var items = '';
                    $("#TownId").empty();
                    $.each(data, function (i, town) {
                        items += "<option value='" + town.value + "'>" + town.text + "</option>";
                    });
                    $('#TownId').html(items)
                }
            )
            .done(function () {
                $("#TownId").on("change", function () {
                    var url = "/Disaster/GetLatLng";
                    var ddlsource = "#TownId";
                    $.getJSON(url, {
                            TownId: $(ddlsource).val()
                        },
                        function (data) {

                            $("#Latitute").attr('value', data.latitute);
                            $("#Longtitute").attr('value', data.longtitute)
                        }
                    );
                });
            });
    });

});

