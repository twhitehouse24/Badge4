$(document).ready(function () {

    loadnew();
})

function loadnew() {

    $('#search-div').empty();

    var searchTerm = $('#searchTerm').val();
    var minPrice = $('#minPrice').val();
    var maxPrice = $('#maxPrice').val();
    var minYear = $('#minYear').val();
    var maxYear = $('#maxYear').val();
    var Type = $('#Type').val();



    $.ajax({
        type: 'GET',
        url: 'http://localhost:60036/search/cars/',
        data: { searchTerm, minPrice, maxPrice, minYear, maxYear, Type },
        dataType: 'json',
        //data: JSON.stringify({ parameter }),
        success: function (searchArray) {
            var searchDiv = $('#search-div');

            $.each(searchArray, function (index, carSearch) {
                var searchInfo = '<br><div class="container"><div style="border-style:solid;border-color:#287Ec7">'

                searchInfo += '<table border="0" style="width: 90%"><tr><td style="padding:  10px 10px 5px 10px; width: 20%">'
                searchInfo += '<center><b>'+ carSearch.CarYr + ' ' + carSearch.Make + ' ' + carSearch.Model
                searchInfo += '<img src="' + carSearch.PhotoPath + '" width="125" height="75" />'
                searchInfo += '</b></center></td>'
                searchInfo += '<td style="padding:  10px 10px 5px 10px; width: 75%">'
                searchInfo += '<table border="0">'
                searchInfo += '<tr>'
                searchInfo += '<td style="padding:  10px 10px 10px 10px; width: 15%"><b>Body Style:</b>' + carSearch.BodyStyle + '</td>'
                searchInfo += '<td style="padding:  10px 10px 10px 10px; width: 35%"><b>Interior Color:</b>' + carSearch.IntColor + '</td>'
                searchInfo += '<td style="padding:  10px 10px 10px 10px; width: 50%; text-align: right"><b>Sale Price:</b> ' + formatMoney(carSearch.SalePrice) + '</td></tr>'
                searchInfo += '<tr><td style="padding:  10px 10px 10px 10px"><b>Trans:</b>' + carSearch.Trans + '</td>'
                searchInfo += '<td style="padding:  10px 10px 10px 10px"><b>Mileage:</b>' + carSearch.CarMileage + '</td>'
                searchInfo += '<td style="padding:  10px 10px 10px 10px; text-align: right"><b>Msrp: </b>' + formatMoney(carSearch.MSRP) + '</td></tr>'
                searchInfo += '<tr><td style="padding:  10px 10px 10px 10px"><b>Color:</b>' + carSearch.ExtColor + '</td>'
                searchInfo += '<td colspan="2" style="padding:  10px 10px 10px 10px"><b>VIN:</b>' + carSearch.VIN + '</td></tr>'
                searchInfo += '<tr><td style="padding:  10px 10px 10px 10px; width: 20%"><b>Description:</b></td>'
                searchInfo += '<td colspan="2" style="padding:  10px 10px 10px 10px; width: 50%"> ' + carSearch.CarDescription + '</td></tr>'
                searchInfo += '</table ></td></tr><tr><td colspan="2" style="padding: 10px 5px 10px 15px; width:70%; text-align:right">'
                searchInfo += '<a href="Details/' + carSearch.CarId + '"><button type="button" >Details</button></a>'
                searchInfo += '</td></tr></table></div></div>'
                searchInfo += '<hr>';

                searchDiv.append(searchInfo);
            })
        },
        error: function () {
            alert('Failure to load search script properly!');
        }
    });


}

function hideSearch() {
    $('#search-div').hide();
}
function showSearch() {
    $('#search-div').show();
}

function formatToCurrency(amount) {
    return "$" + (amount).toFixed(0).replace(/\d(?=(\d{3})+\.)/g, '$&,');
}

function formatMoney(number) {
    return number.toLocaleString('en-US', { style: 'currency', currency: 'USD' });
}
