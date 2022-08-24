$(document).ready(function () {
    getItemRem();
    getAllItems();
    getAllOrders();
});

function getItemRem() {


    $.ajax({
        type: 'GET',
        url: "http://localhost:44372/Service.svc/GetLowerItems",
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {
            var ojson = JSON.parse(oResponse.GetLowerItemsResult);
            if (ojson.Success) {

                var dt = ojson.oDataTable;
                var tr = "";
                var alltr = "";
              

                for (var i = 0; i < dt.length; i++) {

                    tr = " <tr>\n" +
                        " <td class=\"f-w-600\">" + dt[i].ItemName + "</td>\n" +
                        "\n" +
                        " <td>\n" +
                        " <div class=\"span badge rounded-pill pill-badge-secondary\">" + dt[i].QTY + "</div>\n" +
                        " </td>\n" +
                        " </tr>"
                    alltr = alltr + tr;

                }

                $("#tbBody").append(alltr);





            } else {

                alert(ojson.Message);
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

function getAllItems() {



        $.ajax({
            type: 'GET',
            url: "http://localhost:44372/Service.svc/LoadAllItem",
            contentType: "application/json; charset=utf-8",
            dataType: 'json',
            success: function (oResponse) {
                var ojson = JSON.parse(oResponse.LoadAllItemResult);
                console.log(ojson)
                if (ojson.Success) {

                    var dt = ojson.oDataTable;

                    var itemCount = dt.length
                    $("#itemStock").text(itemCount);
                    

                } else {

                    alert(ojson.Message);
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

function getAllOrders() {



    $.ajax({
        type: 'GET',
        url: "http://localhost:44372/Service.svc/LoadAllExternalOrders",
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (oResponse) {
            var ojson = JSON.parse(oResponse.LoadAllExternalOrdersResult);
            console.log(ojson)
            if (ojson.Success) {

                var dt = ojson.oDataTable;

                var itemCount = dt.length
                $("#orderCount").text(itemCount);


            } else {

                alert(ojson.Message);
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