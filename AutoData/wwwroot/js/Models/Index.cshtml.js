

$(function () {
    var make = $('.make').val()
    List(make)
})

function List(make) {
    $('#div_model_list').html('')
    $.get('/Models/List', { make: make },  function (data) {
        $('#div_model_list').html(data)
        $('#tbl_models').DataTable({
            "pageLength": 25
        });
    })
}