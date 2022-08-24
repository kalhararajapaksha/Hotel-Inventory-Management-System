$(document).ready(function () {
    LoadAllItems();
    LoadAllInternalOrders();
});


function LoadAllItems() {
 
    $.ajax({
        type: 'GET',
        url: "http://localhost:44372/Service.svc/LoadAllItem",
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {

            var unitdt = JSON.parse(oResponse.LoadAllItemResult);
            if (unitdt.Success) {
                var dt = unitdt.oDataTable;
                for (var i = 0; i < dt.length; i++) {
                    s += '<option value="' + dt[i].Item_ID + '">' + dt[i].ItemName + '</option>';
                }
                $("#drpItem").html(s);
            }
            var s;

           
        }
        ,
        error: function (xhr, status, error) {
            swal("Something went wrong. Please contact the system administrator." + error.status + ": " + xhr.responseJSON.Message + "", {
                icon: "error",
            });
        }
    });
}


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


function SetInternalOrder() {
    var itemID = $('#drpItem').val();
    var req_Qty = $('#txtRequestQuentity').val();
 

    
        $.ajax({
            type: 'POST',
            url: "http://localhost:44372/Service.svc/InternalOrders",
            "data": JSON.stringify({
                "oREF_InternalOrders": {
                    "OrderID": 0,
                    "ItemID": itemID,
                    "Req_QTY": req_Qty,
                    "OrderBy": 1000,
                    "ApprovedBy": 88,
                    "IssuedBy": 88
                }
            }),
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            success: function (oResponse) {
                console.log(oResponse)
                var ojson = JSON.parse(oResponse.InternalOrdersResult);
                console.log(ojson)
                if (ojson.Success) {
                    LoadAllInternalOrders()
                    swal(ojson.Message, {
                        icon: "success",
                    });

                } else {

                    swal(ojson.Message, {
                        icon: "error",
                    });
                }
            }
            ,
            error: function (xhr, status, error) {
                swal("Something went wrong. Please contact the system administrator." + error.status + ": " + xhr.responseJSON.Message + "", {
                    icon: "error",
                });
            }
        });
    



}