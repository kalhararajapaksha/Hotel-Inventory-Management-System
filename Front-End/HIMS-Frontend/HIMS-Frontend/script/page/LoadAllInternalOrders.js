$(document).ready(function () {
    LoadAllInternalOrders();

});

function LoadAllInternalOrders() {
    var settings = {
        url: "http://localhost:44372/Service.svc/LoadAllInternalOrders",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {

        var ojson = JSON.parse(response.LoadAllInternalOrdersResult);

        if (ojson.Success) {
            var dt = ojson.oDataTable

            $('#tblInternalOrders').dataTable({
                destroy: true,
                data: dt,
                ordering: false,
                columns: [
                    { data: 'OrderID', width: '20%' },
                    { data: 'ItemID', width: '20%' },
                    { data: 'AV_QTY', width: '20%' },
                    { data: 'Req_QTY', width: '20%' },
                    {
                        width: '20%',
                        'render': function (data, type, row, meta) {

                            return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                                row.OrderID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.OrderID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

                        }
                    },
                ]
            });


        } else {
            swal(ojson.Message, {
                icon: "error",
            });
        }


    });
}