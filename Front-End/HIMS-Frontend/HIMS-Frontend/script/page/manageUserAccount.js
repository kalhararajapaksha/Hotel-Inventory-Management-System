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
    var userID = $('#txtHide').val();
    var empID = $('#drpEmployee').val();
    var userName = $('#lname').val();
    var password1 = $('#exampleInputPassword1').val();
    var password2 = $('#exampleInputcPassword2').val();
    if (password1 == password2 && password1 != "" && userName != "" && empID != 0) {
        $('#reqMsg').text("");
        if (userID == 0) {
            $.ajax({
                type: 'POST',
                url: "http://localhost:44372/ServiceUser.svc/SaveUser",
                "data": JSON.stringify({
                    "oREF_User": {
                        "UserID": 0,
                        "EmployeeID": empID,
                        "UserName": userName,
                        "Password": password1,
                        "CreateBy": 1000,
                        "ModifyDate": "",
                        "ModifyBy": 0,
                        "Satus": 1
                    }
                }),
                contentType: "application/json; charset=utf-8",
                dataType: 'json',
                success: function (oResponse) {
                    console.log(oResponse)
                    var ojson = JSON.parse(oResponse.SaveUserResult);
                    console.log(ojson)
                    if (ojson.Success) {
                        LoadTable();
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
        else {
            $.ajax({
                type: 'POST',
                url: "http://localhost:44372/ServiceUser.svc/UpdateUser",
                "data": JSON.stringify({
                    "oREF_User": {
                        "UserID": userID,
                        "UserName": userName,
                        "Password": password1,
                        "ModifyBy": 1,
                    }
                }),
                contentType: "application/json; charset=utf-8",
                dataType: 'json',
                success: function (oResponse) {
                    console.log(oResponse)
                    var ojson = JSON.parse(oResponse.UpdateUserResult);
                    console.log(ojson)
                    if (ojson.Success) {
                        $('#txtHide').val(userID);
                        LoadTable();
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
    } else {
        $('#reqMsg').text("Please fill required fields");
    }
  
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

                        return '<div class="btn-group" role="group" aria-label="Basic example"><a href="#" class="btn  btn-warning btn-air-warning btn-xs" onclick=getUserByID("' +
                            row.UserID + '") ><ion-icon   class="fa fa-spin fa-cog"></ion-icon ></a> 	&nbsp;<a href="#" class="btn  btn-danger btn-air-danger btn-xs" onclick=DeleteUser("' + row.UserID +'")><ion-icon class="fa fa-trash-o"></ion-icon ></a></div>';

                    }
                },
            ]
        });
    });
}



function DeleteUser(userID) {


        //Insert Category API Call
        try {

            $.ajax({
                url: "http://localhost:44372/ServiceUser.svc/DeleteUser",
                method: "POST",
                "data": JSON.stringify({
                    "oREF_User": {
                        "UserID": userID,
                        "ModifyBy": 1
             
                    }
                }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                   
                    var ojson = JSON.parse(data.DeleteUserResult);
                    console.log(ojson);
                    if (ojson.Success) {

                        
                       
                        $('#exampleModalfat').modal('hide');
                        LoadTable();

                    } else {
                        swal(ojson.Message, {
                            icon: "error",
                        });
                    }
                    


                },
                error: function (xhr, status, error) {
                   
                    swal(error, {
                        icon: "error",
                    });

                }

            });



        } catch (ex) {
            Swal.fire("Error", "", "error");
        }
    

}

function getUserByID(userID) {

    $('#exampleModalfat').modal('show');

    $.ajax({
        type: "POST",
        url: "http://localhost:44372/ServiceUser.svc/UserGetByID",
        data: JSON.stringify({
            "oREF_User": {
                "UserID": userID
            }
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (oResponse) {
            var Astdt = JSON.parse(oResponse.UserGetByIDResult);
            console.log(Astdt.length);
            var tbl = Astdt.oDataTable
            var s = 0;
            $('#txtHide').val(userID);
            $('#drpEmployee').val(tbl[0].EmployeeID);
            $('#lname').val(tbl[0].UserName);
            $('#exampleInputPassword1').val(tbl[0].Password);
            $('#exampleInputcPassword2').val(tbl[0].Password);
            

        }
        ,
        error: function (xhr, status, error) {
            swal("Something went wrong. Please contact the system administrator." + error.status + ": " + xhr.responseJSON.Message + "", {
                icon: "error",
            });
        }
    });

}

