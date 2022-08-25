$(document).ready(function () {
    LoadAllCategory();

});

function LoadAllCategory() {
    var settings = {
        url: "http://localhost:44372/Service.svc/LoadAllSubCategory",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {

        var ojson = JSON.parse(response.LoadAllSubCategoryResult);

        if (ojson.Success) {
            var dt = ojson.oDataTable

            $('#tblSubCategory').dataTable({
                destroy: true,
                data: dt,
                ordering: false,
                columns: [
                    { data: 'SubCategoryID', width: '20%' },
                    { data: 'CategoryID', width: '20%' },
                    { data: 'UnitID', width: '20%' },
                    { data: 'SubCategoryName', width: '20%' },
                    {
                        width: '20%',
                        'render': function (data, type, row, meta) {

                            return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                                row.SubCategoryID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.SubCategoryID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

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