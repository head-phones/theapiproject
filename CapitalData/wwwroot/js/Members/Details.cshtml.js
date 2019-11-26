
$(function () {
    $('#tbl_terms').DataTable({
        "pageLength": 10,
        order: [[0, 'desc']]
    });
    $('#tbl_votes').DataTable({
        "pageLength": 10,
        order: [[1, 'desc']]
    });
    $('#tbl_sponsored_bills').DataTable({
        "pageLength": 10,
        order: [[1, 'desc']]
    });
    $('#tbl_co_sponsored_bills').DataTable({
        "pageLength": 10,
        order: [[1, 'desc']]
    });
})