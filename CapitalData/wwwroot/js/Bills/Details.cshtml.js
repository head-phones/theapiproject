


var BillsDetailsModule = BillsDetailsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {
        $('#tbl_versions').DataTable({
            "pageLength": 10,
            order: [[0, 'asc']]
        });
        $('#tbl_actions').DataTable({
            "pageLength": 10,
            order: [[1, 'desc']],
            "columns": [
                null,
                { "type": "date" },
                null
            ]
        });
        $('#tbl_votes').DataTable({
            "pageLength": 10,
            order: [[1, 'desc']],
            "columns": [
                null,
                { "type": "date" },
                null
            ]
        });
    }

    return {
        init: function (Args) {
            _args = Args;
            _initDataTables();
        }
    };
}());
