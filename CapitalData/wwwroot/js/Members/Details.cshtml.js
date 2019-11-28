﻿


var MembersDetailsModule = MembersDetailsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {
        $('#tbl_terms').DataTable({
            "pageLength": 10,
            order: [[0, 'desc']]
        });
        $('#tbl_votes').DataTable({
            "pageLength": 10,
            order: [[1, 'desc']],
            "columns": [
                null,
                { "type": "date" },
                null,
                null
            ]
        });
        $('#tbl_sponsored_bills').DataTable({
            "pageLength": 10,
            order: [[1, 'desc']],
            "columns": [
                null,
                { "type": "date" },
                null
            ]
        });
        $('#tbl_co_sponsored_bills').DataTable({
            "pageLength": 10,
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
