

$(function () {
    List()
})

function List() {
    $('#div_variables_list').html('')
    $.get('/VehicleVariables/List', function (data) {
        $('#div_variables_list').html(data)
        $('#tbl_variables').DataTable({
            "pageLength": 10
        });
    })
}