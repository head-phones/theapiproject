


var MembersExplanationsModule = MembersExplanationsModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {

        $('#tbl_explanations').DataTable({
            "pageLength": 25,
            "order": []
        });

    }

    return {
        init: function (Args) {
            _args = Args;
            _initDataTables();
        }
    };
}());
