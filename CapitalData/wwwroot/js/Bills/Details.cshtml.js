


var BillsDetailsModule = BillsDetailsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {
        $('#tbl_versions').DataTable({
            "pageLength": 10,
            order: []
        });
        $('#tbl_actions').DataTable({
            "pageLength": 10,
            order: [],
            "columns": [
                null,
                { "type": "date" },
                null
            ]
        });
        $('#tbl_votes').DataTable({
            "pageLength": 10,
            order: [],
            "columns": [
                null,
                { "type": "date" },
                null
            ]
        });
        $('#tbl_statments').DataTable({
            "pageLength": 10,
            order: [],
            "columns": [
                null,
                { "type": "date" },
                null,
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
