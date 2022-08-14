<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HIMS_Frontend.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js"></script>
    <!--Login Css -->
    <link href="../assets/css/login.css" rel="stylesheet">

    <!-- latest jquery-->
    <script src="../assets/js/jquery-3.5.1.min.js"></script>
</head>
<body>

    <!--webpage content-->
    <!--hero-->
    <div class="container-fluid videodiv">

        <div class="row">
            <div class="my_form">

                <form id="form1">
                    <div class="mb-3 mt-3 form_head">
                        <h5>Hotel Inventory Management System</h5>
                        <p>Here you can Log into inventry Management System</p>
                    </div>
                    <div class="mb-3 mt-3">
                        <label class="form-label">Username</label>
                        <input id="UserName" class="form-control" type="text" placeholder="User Name" required />
                    </div>
                    <div class="mb-3 mt-3">
                        <label class="form-label">Password</label>
                        <input id="Password" class="form-control" type="password" placeholder="*********" required />
                    </div>
                    <div class="forget_pw">
                        <a href="#">Forget Password</a>
                    </div>
                    <div>
                        <input class="btn btn-primary submit_btn" type="button" value="Login" onclick="login()" />
                        <%--<button class="btn btn-primary submit_btn" onclick="login()">Login</button>--%>
                    </div>

                </form>
            </div>
            <div class="w-100">
                <video playsinline="playsinline" autoplay="autoplay" muted="muted" loop="loop">
                    <source src="../Video/bg_video.mp4" type="video/mp4">
                </video>
            </div>
        </div>
    </div>
    <!--Login javascript-->
    <script src="../assets/js/login/login.js"></script>
    <!--sweet alert cdn-->
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</body>

</html>
