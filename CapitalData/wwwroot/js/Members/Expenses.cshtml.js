


var MembersExpensesModule = MembersExpensesModule || (function () {
    // private
    var _args = {};

    var _initDataTables = function () {

        $('#tbl_expenses').DataTable({
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
