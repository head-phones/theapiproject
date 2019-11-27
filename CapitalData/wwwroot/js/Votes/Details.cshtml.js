
$(function () {
    $('#tbl_vote_totals').DataTable();
    $('#tbl_positions').DataTable({
        "pageLength": 25,
         order: [[0, 'asc']]
    });
})