

$(function () {
    var chamber = $('.chamber').val()
    List(chamber)
})
function List(chamber) {
    $('#lbl_heading').html('Upcoming ' + chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Bills')
    $('#div_bill_list').html('')
    $('#ph_bill_list').removeClass('d-none')
    $.get('/Bills/List', { chamber: chamber }, function (data) {
        $('#div_bill_list').html(data)
        $('#ph_bill_list').addClass('d-none')
        $('#tbl_bills').DataTable({
            "pageLength": 25
        });
    })
}
function OnChamberChanged(sender, chamber) {
    List(chamber)
}
function OnCongressChanged(sender, chamber) {
    List(chamber)
}