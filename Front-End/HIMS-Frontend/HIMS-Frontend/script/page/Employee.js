$(document).ready(function () {
    LoadAllEmployee();

});

function LoadAllEmployee() {
    var settings = {
        url: "http://localhost:44372/ServiceUser.svc/LoadAllEmployee",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {

        var ojson = JSON.parse(response.LoadAllEmployeeResult);


        $('#tblEmployee').dataTable({
            destroy: true,
            data: ojson,
            ordering: false,
            columns: [
                { data: 'EmployeeID', width: '10%' },
                { data: 'DepatmentID', width: '10%' },
                { data: 'EmployeeName', width: '10%' },
                { data: 'Address', width: '10%' },
                { data: 'ContactNumber', width: '10%' },
                { data: 'Email', width: '10%' },
                { data: 'Dob', width: '10%' },
                {
                    width: '30%',
                    'render': function (data, type, row, meta) {

                        return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                            row.Item_ID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.Item_ID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

                    }
                },
            ]
        });

        //if (ojson.Success) {
        //    var dt = ojson.oDataTable

        //    $('#tblEmployee').dataTable({
        //        destroy: true,
        //        data: dt,
        //        ordering: false,
        //        columns: [
        //            { data: 'EmployeeID', width: '10%' },
        //            { data: 'DepatmentID', width: '10%' },
        //            { data: 'EmployeeName', width: '10%' },
        //            { data: 'Address', width: '10%' },
        //            { data: 'ContactNumber', width: '10%' },
        //            { data: 'Email', width: '10%' },
        //            { data: 'Dob', width: '10%' },
        //            {
        //                width: '30%',
        //                'render': function (data, type, row, meta) {

        //                    return '<div class="btn-group " role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
        //                        row.Item_ID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.Item_ID + '")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

        //                }
        //            },
        //        ]
        //    });


        //} else {
        //    swal(ojson.Message, {
        //        icon: "error",
        //    });
        //}


    });
}