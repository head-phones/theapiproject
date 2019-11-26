

$(function () {
    var chamber = $('.chamber').val()
    List(chamber)
})
function List(chamber) {
    $('#lbl_heading').html('Recent ' + chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Votes')
    $('#div_vote_list').html('')
    $('#ph_vote_list').removeClass('d-none')
    $.get('/Votes/List', { chamber: chamber }, function (data) {
        $('#div_vote_list').html(data)
        $('#ph_vote_list').addClass('d-none')
        $('#tbl_votes').DataTable({
            "pageLength": 25,
            order: [[1, 'desc']]
        });
    })
}
function OnChamberChanged(sender, chamber) {
    List(chamber)
}
function OnCongressChanged(sender, chamber) {
    List(chamber)
}