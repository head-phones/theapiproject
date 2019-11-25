

$(function () {
    List()
})

function List() {
    $('#div_make_list').html('')
    $.get('/Makes/List', function (data) {
        $('#div_make_list').html(data)
        $('#tbl_makes').DataTable({
            "pageLength": 25
        });
    })
}