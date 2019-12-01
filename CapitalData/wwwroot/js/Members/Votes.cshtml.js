


var MembersVotesModule = MembersVotesModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {

        $('#tbl_votes').DataTable({
            "pageLength": 25,
            order: [[1, 'desc']],
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
