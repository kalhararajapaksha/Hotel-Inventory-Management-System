<%@ Page Title="" Language="C#" MasterPageFile="~/Sidebar.Master" AutoEventWireup="true" CodeBehind="UserAccounts.aspx.cs" Inherits="HIMS_Frontend.UserAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <!-- Container-fluid starts-->
    <div class="container-fluid">
        <!--Page Header Start-->
        <div class="page-header">
            <div class="row">
                <div class="col-sm-6">
                    <h3>User Manager</h3>
                    <%--<ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="frmHome.aspx">Home</a></li>
                    <li class="breadcrumb-item">Master Data</li>
                    <li class="breadcrumb-item active">Category Manager</li>
                  </ol>--%>
                </div>
                <div class="col-sm-6">
                    <!-- Bookmark Start-->
                    <div class="bookmark">

                        <ul>
                            <li><a class="btn btn-primary-light btn-xs" data-container="body" data-placement="top" data-bs-toggle="modal" data-bs-target="#exampleModalfat" data-whatever="@mdo" title="" data-original-title="Tables" onclick="Clearing()"><i data-feather="plus"></i>Add Employee &nbsp;</a></li>

                        </ul>
                    </div>
                    <!-- Bookmark Ends-->
                </div>
            </div>
        </div>
        <!--Page Header End-->
        <div class="row">
            <!-- Zero Configuration  Starts-->
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-header">
                        <h5>User Accounts</h5>
                        <span>Here you can see the User accounts that you created for your Organization.</span>
                    </div>
                    <div class="card-body">
                        <div class="table-responsive">
                            <table class="display" id="basic-1">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Position</th>
                                        <th>Office</th>
                                        <th>Age</th>
                                        <th>Start date</th>
                                        <th>Salary</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                                        <td>2011/04/25</td>
                                        <td>$320,800</td>
                                    </tr>

                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Zero Configuration  Ends-->
        </div>
    </div>

    <!--Modal -->
    <div class="modal fade" id="exampleModalfat" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Create Category</h5>
                    <button class="btn-close" type="button" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <div class="tab">
                        <div class="form-group">
                            <label>Employee:</label><span style="color: red">*</span>
                            <select class="js-example-basic-single col-sm-12 form-control select2-hidden-accessible" style="width: 100%;" id="drpEmployee">
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="lname">User Name</label>
                            <input class="form-control" id="lname" type="text" placeholder="Eg: User123">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Password</label>
                            <input class="form-control" id="exampleInputPassword1" type="password" placeholder="Password">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Confirm Password</label>
                            <input class="form-control" id="exampleInputcPassword2" type="password" placeholder="Confirm Password">
                        </div>
                    </div>
                </div>
                <input class="form-control" id="txtHide" type="password" value="0" hidden>
                <div class="modal-footer text-center" id="btndivcat">
                    <button class="btn btn-secondary" type="button" onclick="btnClose()" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" id="btnSubmit" onclick="SaveUser()" type="button">Save Category</button>
                </div>
            </div>
        </div>
    </div>
    <!--Model end-->

</asp:Content>
