

$(function () {
    var congress = $('.congress').val()
    var chamber = $('.chamber').val()
    List(congress, chamber)
})
function List(congress, chamber) {
    $('#lbl_heading').html(chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Members')
    $('#div_member_list').html('')
    $('#ph_member_list').removeClass('d-none')
    $.get('/Members/List', { congress: congress, chamber: chamber }, function (data) {
        $('#div_member_list').html(data)
        $('#ph_member_list').addClass('d-none')
        $('#tbl_members').DataTable({
            "pageLength": 25,
             order: [[1, 'asc']]
        });
    })
}
function OnChamberChanged(sender, congress, chamber) {
    List(congress, chamber)
}
function OnCongressChanged(sender, congress, chamber) {
    List(congress, chamber)
}