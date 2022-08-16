function login() {
    var username = $("#UserName").val();
    var password = $("#Password").val();

    $.ajax({
        type: 'POST',
        url: "http://localhost:44372/ServiceUser.svc/UserLogin",
        "data": JSON.stringify({
            "oREF_User": {
                "UserName": username,
                "Password": password
            }
        }),
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {
            console.log(oResponse)
            var ojson = JSON.parse(oResponse.GetUserByUserNameResult);
            console.log(ojson.length);
            console.log(ojson);
            if (ojson.length > 0) {
                swal("Login successfully", {
                    icon: "success",
                });

                window.location.href = "Dashboard.aspx";

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

