$(document).ready(function () {
    LoadAllCategory();

});

function LoadAllCategory() {
    var settings = {
        url: "http://localhost:44372/Service.svc/LoadAllCategory",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {

        var ojson = JSON.parse(response.LoadAllCategoryResult);

        if (ojson.Success) {
            var dt = ojson.oDataTable

            $('#tblCategory').dataTable({
                destroy: true,
                data: dt,
                ordering: false,
                columns: [
                    { data: 'CategoryID', width: '30%' },
                    { data: 'CategoryName', width: '30%' },
                    //{ data: 'QTY', width: '10%' },
                    //{ data: 'ItemName', width: '40%' },
                    {
                        width: '40%',
                        'render': function (data, type, row, meta) {

                            return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                                row.CategoryID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.CategoryID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

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