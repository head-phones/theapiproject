

var BillsIndexModule = BillsIndexModule || (function () {
    // private
    var _args = {};
    var _list = function (chamber) {
        $('#lbl_heading').html('Upcoming ' + chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Bills')
        $('#div_bill_list').html('')
        $('#ph_bill_list').removeClass('d-none')
        $.get('/Bills/List', { chamber: chamber }, function (data) {
            $('#div_bill_list').html(data)
            $('#ph_bill_list').addClass('d-none')
            $('#tbl_bills').DataTable({
                "pageLength": 25,
                order: [[1, 'desc']],
                "columns": [
                    null,
                    { "type": "date" },
                    null,
                    null
                ]
            });
        })
    }
    return {
        init: function (Args) {
            _args = Args;
            _list( _args.chamber);
        },
        list: function (congress, chamber) {
            _list(congress, chamber)
        },
        onChamberChanged: function (sender, chamber) {
            _list(chamber)
        },
        onCongressChanged: function (sender, chamber) {
            _list(chamber)
        }
    };
}());
