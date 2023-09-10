var dataTable;

$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {


    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/sugarcanedb",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "truckoil", "width": "20%" },
            { "data": "vehicle_code", "width": "20%" },
            { "data": "transdate", "width": "20%" },
            { "data": "oilamoun", "width": "20%" },
            { "data": "approvestatus", "width": "20%" },
            { "data": "approver", "width": "20%" },
            {
                "data": "uid",
                "render": function (data) {
                    return `<div class="text-center">
                      
                        &nbsp;
                      
                        </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}
