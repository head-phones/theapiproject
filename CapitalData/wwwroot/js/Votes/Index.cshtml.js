
var VotesIndexModule = VotesIndexModule || (function () {
    // private
    var _args = {}; 

    var _list = function (chamber) { 
        $('#lbl_heading').html('Recent ' + chamber.charAt(0).toUpperCase() + chamber.slice(1) + ' Votes')
        $('#div_vote_list').html('')
        $('#ph_vote_list').removeClass('d-none')
        $.get('/Votes/List', { chamber: chamber }, function (data) {
            $('#div_vote_list').html(data)
            $('#ph_vote_list').addClass('d-none')
            $('#tbl_votes').DataTable({
                "pageLength": 25,
                order: [[1, 'desc']]
            });
        })
    }

    return {
        //public
        init: function (Args) {
            _args = Args;
            _list(_args.chamber)
        },
        list: function (chamber) {
            _list(chamber)
        },
        initVotesBarChart: function (labels, data) {
            var ctx = $("#votesBarChart");
            var myBarChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: labels,
                    datasets: [
                        {
                            data: data,
                            backgroundColor: "#212529",
                            hoverBackgroundColor: "#6c757d",
                            borderColor: "#212529",
                        }
                    ],
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                    },
                    legend: {
                        display: false
                    },
                }
            });
        },
        onChamberChanged: function (chamber) {
            _list(chamber)
        },
        onCongressChanged: function (chamber) {
            _list(chamber)
        }
    };
}());
