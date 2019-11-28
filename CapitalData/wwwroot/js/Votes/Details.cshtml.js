
var VotesDetailsModule = VotesDetailsModule || (function () {
    var _args = {}; // private

    var _initDataTables = function () {
        $('#tbl_positions').DataTable({
            "pageLength": 25,
            order: [[0, 'asc']]
        });
    }
    var _initVotesBarChart = function (votes) {
        var ctx = $("#votesBarChart");
        var myBarChart = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: ["Yes", "No", "Present", "Not Voting"],
                datasets: [
                    {
                        label: "Republican",
                        backgroundColor: "#dc3545",
                        hoverBackgroundColor: "#dc3545",
                        borderColor: "#dc3545",
                        data: [votes.republican.yes, votes.republican.no, votes.republican.present, votes.republican.not_voting],
                    },
                    {
                        label: "Democrat",
                        backgroundColor: "#007bff",
                        hoverBackgroundColor: "#007bff",
                        borderColor: "#007bff",
                        data: [votes.democratic.yes, votes.democratic.no, votes.democratic.present, votes.democratic.not_voting],
                    },
                    {
                        label: "Independent",
                        backgroundColor: "#6c757d",
                        hoverBackgroundColor: "#6c757d",
                        borderColor: "#6c757d",
                        data: [votes.independent.yes, votes.independent.no, votes.independent.present, votes.independent.not_voting],
                    }],
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
                }
            }
        });
    }
    return {
        init: function (Args) {
            _args = Args;
            _initDataTables();
            _initVotesBarChart(_args.votes);
        }
    };
}());
