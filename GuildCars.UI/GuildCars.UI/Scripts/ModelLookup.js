$(document).ready(function () {


})

function ModelLookup(choice) {

    $.ajax({
        type: 'GET',
        url: 'http://localhost:60036/search/model/' + choice,
        success: function (data) {
            $("#ModelId").empty();
            $.each(data, function (index, row) {
                $("model.options").append(
                    $("#ModelId").append("<option value='" + row.ModelId + "'>" + row.ModelName + "</option>"))
            });
        },
        error: function () {
            alert('Error performing Model search, try again later!')
        }
    });
 }

