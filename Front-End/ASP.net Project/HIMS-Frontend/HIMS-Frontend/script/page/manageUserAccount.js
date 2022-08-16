$(document).ready(function () {
    LoadAllEmployee();
    LoadTable();
});

function LoadAllEmployee() {
    $.ajax({
        type: 'GET',
        url: "http://localhost:44372/ServiceUser.svc/LoadAllEmployee",
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {

            var unitdt = JSON.parse(oResponse.LoadAllEmployeeResult);

            var s;

            for (var i = 0; i < unitdt.length; i++) {
                s += '<option value="' + unitdt[i].EmployeeID + '">' + unitdt[i].EmployeeName + '</option>';
            }
            $("#drpEmployee").html(s);
        }
        ,
        error: function (xhr, status, error) {
            swal("Something went wrong. Please contact the system administrator." + error.status + ": " + xhr.responseJSON.Message + "", {
                icon: "error",
            });
        }
    });
}

function SaveUser() {
    var empID = $('#drpEmployee').val();
    var userName = $('#lname').val();
    var password1 = $('#exampleInputPassword1').val();
    var password2 = $('#exampleInputcPassword2').val();

    $.ajax({
        type: 'POST',
        url: "http://localhost:44372/ServiceUser.svc/SaveUser",
        "data": JSON.stringify({"oREF_User":{
            "UserID": 0,
            "EmployeeID": empID,
            "UserName": userName,
            "Password": password1,
            "CreateBy":1000,
            "ModifyDate":"",
            "ModifyBy":0,
            "Satus":1}}),
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {
            console.log(oResponse)
            var ojson = JSON.parse(oResponse.SaveUserResult);
            console.log(ojson)
            if (ojson.Success) {

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

function LoadTable() {

    var settings = {
        url:"http://localhost:44372/ServiceUser.svc/LoadAllUsers",
        "method": "GET",
        "dataType": "json",
    };

    $.ajax(settings).done(function (response) {
 
        var dt = JSON.parse(response.LoadAllUsersResult);
        console.log(dt);
        $('#tblUsers').dataTable({
            destroy: true,
            data: dt,
            ordering: false,
            columns: [
                { data: 'UserID', width: '20%' },
                { data: 'EmployeeID', width: '20%' },
                { data: 'UserName', width: '60%' },
                { data: 'Password', width: '10%' },
                {
                    width: '10%',
                    'render': function (data, type, row, meta) {

                        return '<div class="btn-group" role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=userActionHandle("' +
                            row.UserID + '",90) ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=userActionHandle("' + row.UserID +
                            '",99)><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

                    }
                },
            ]
        });
    });
}

function userActionHandle(userID,actionID) {

    if (actionID == 0) {
        //Insert Category 
        SaveUser();

    } else if (actionID == 90 ) {
        $('#exampleModalfat').modal('show');
        getUserByID(userID);
    } else if (actionID == 99) {
        $('#exampleModalfat').modal('show');
        DeleteUser(userID);
    }

}

function getUserByID(userID) {

}