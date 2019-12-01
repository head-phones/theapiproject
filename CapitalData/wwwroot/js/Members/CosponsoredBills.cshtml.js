


var MembersCosponsoredBillsModule = MembersCosponsoredBillsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {
        $('#tbl_co_sponsored_bills').DataTable({
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
