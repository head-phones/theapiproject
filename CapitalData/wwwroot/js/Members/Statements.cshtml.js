


var MembersStatementsModule = MembersStatementsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {

        $('#tbl_statements').DataTable({
            "pageLength": 25,
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
