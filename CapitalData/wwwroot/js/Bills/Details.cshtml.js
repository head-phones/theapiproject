
$(function () {
    $('#tbl_versions').DataTable({
        "pageLength": 10
    });
    $('#tbl_actions').DataTable({
        "pageLength": 10,
        order: [[1, 'desc']]
    });
    $('#tbl_votes').DataTable({
        "pageLength": 10,
        order: [[1, 'desc']]
    });
})