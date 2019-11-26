
function List() {
    var vin = $('#txtVIN').val();
    var year = $('#txtYear').val();
    $('#div_results_list').html('')
    $.get('/DecodeVIN/List', { vin: vin, year: year }, function (data) {
        $('#div_results_list').html(data)
        $('#tbl_results').DataTable({
            "pageLength": 25
        });
    })
}