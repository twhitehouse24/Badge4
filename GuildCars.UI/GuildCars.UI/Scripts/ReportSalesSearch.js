$(document).ready(function () {

    loadnew();
})

function loadnew() {

    $('#search-div').empty();

    var searchUser = $('#UserName').val();
    var fromDate = $('#fromDate').val();
    var toDate = $('#toDate').val();

    $.ajax({
        type: 'GET',
        url: 'http://localhost:60036/search/sales/',
        data: { searchUser, fromDate, toDate },
        dataType: 'json',
        success: function (searchArray) {
            var searchDiv = $('#search-div');

            var searchInfo = '<h4>Search Results<h4>'
            searchInfo += '<br><table border="1" class="table table-striped" style="width: 95%">'
            searchInfo += '<tr><th>User</th><th>Total Sales</th><th>Total Vehicles</th></tr>'

            $.each(searchArray, function (index, salesSearch) {

                searchInfo += '<tr><td>' + salesSearch.UserName + '</td>'
                searchInfo += '<td>' + formatMoney(salesSearch.TotalSales) + '</td>'
                searchInfo += '<td>' + salesSearch.CountOfCarsSold + '</td></tr>'

            })
                searchInfo += '</table>'
                searchInfo += '<hr>';
                searchDiv.append(searchInfo);
            
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
