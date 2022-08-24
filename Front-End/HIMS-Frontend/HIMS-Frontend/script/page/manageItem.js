$(document).ready(function () {
    LoadAllItems();

});

function LoadAllItems() {
    var settings = {
        url: "http://localhost:44372/Service.svc/LoadAllItem",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {

        var ojson = JSON.parse(response.LoadAllItemResult);
   
        if (ojson.Success) {
            var dt = ojson.oDataTable

            $('#tblItem').dataTable({
                destroy: true,
                data: dt,
                ordering: false,
                columns: [
                    { data: 'Item_ID', width: '10%' },
                    { data: 'Sub_CategoryID', width: '10%' },
                    { data: 'QTY', width: '10%' },
                    { data: 'ItemName', width: '40%' },
                    {
                        width: '30%',
                        'render': function (data, type, row, meta) {

                            return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                                row.Item_ID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.Item_ID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

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