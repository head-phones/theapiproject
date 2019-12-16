

var StatementsIndexModule = StatementsIndexModule || (function () {
    // private
    var _args = {};

    var _list = function () {
        $('#ph_heading').html('Recent Statments')
        $('#div_statments_list').html('')
        $('#ph_statments_list').removeClass('d-none')
        $.get('/Statements/List', _setContent)
    }
    var _setContent = function (data) {
        $('#div_statments_list').html(data)
        $('#ph_statments_list').addClass('d-none')
        $('#tbl_statments').DataTable({
            "pageLength": 25,
            order: [],
            "columns": [
                null,
                { "type": "date" },
                null,
                null
            ]
        });
    }
    var _initSearch = function () {
        $('#form_search').removeClass('d-none')
        $('#nav_search').attr('placeholder', 'Search Statements')
        $('#nav_search').on('keypress', function (e) {
            if (e.which == 13) {
                e.preventDefault()
                var term = $('#nav_search').val();
                $('#ph_heading').html(term + ' Statments')
                $('#div_statments_list').html('')
                $('#ph_statments_list').removeClass('d-none')
                $.get('/Statements/Search', { term: term }, _setContent)
            }
        });
    }
    return {
        init: function (Args) {
            _args = Args;
            _list();
            _initSearch();
        },
        list: function () {
            _list()
        }
    };
}());
