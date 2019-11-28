
var MembersIndexModule = MembersIndexModule || (function () {
    // private
    var _args = {};
    var _list = function (congress, chamber) {
        $('#lbl_heading').html(chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Members')
        $('#div_member_list').html('')
        $('#ph_member_list').removeClass('d-none')
        $.get('/Members/List', { congress: congress, chamber: chamber }, function (data) {
            $('#div_member_list').html(data)
            $('#ph_member_list').addClass('d-none')
            $('#tbl_members').DataTable({
                "pageLength": 25,
                order: [[1, 'asc']]
            });
        })
    }
    return {
        init: function (Args) {
            _args = Args;
            _list(_args.congress, _args.chamber);
        },
        list: function (congress, chamber) {
            _list(congress, chamber)
        },
        onChamberChanged: function (sender, congress, chamber) {
            _list(congress, chamber)
        },
        onCongressChanged: function (sender, congress, chamber) {
            _list(congress, chamber)
        }
    };
}());
