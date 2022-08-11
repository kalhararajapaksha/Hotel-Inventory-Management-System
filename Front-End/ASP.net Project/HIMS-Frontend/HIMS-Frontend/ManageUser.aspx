<%@ Page Title="" Language="C#" MasterPageFile="~/Sidebar.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="HIMS_Frontend.ManageUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--page body start-->
    <div class="page-body">
    <!-- Container-fluid starts-->
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-header pb-0">
                        <h5>Manage User</h5>
                        <span>You can Create | Update | Delete User accounts of your organization here.</span>
                    </div>
                    <div class="card-body">
                        <!--<form class="form-wizard" id="regForm" action="#" method="POST">-->
                            <div class="tab">
                                <div class="form-group">
                                    <label for="name">Employee ID</label>
                                    <input class="form-control" id="name" type="text" placeholder="Eg:123" required="required">
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
                                    <input class="form-control" id="exampleInputcPassword1" type="password" placeholder="Confirm Password">
                                </div>
                            </div>
                            
                            <div>
                                <div class="text-center btn-mb">
                                    <button class="btn btn-success" id="btn_create" type="button" onclick="nextPrev(1)">Create User</button>
                                    <button class="btn btn-outline-warning" id="btn_update" type="button" onclick="nextPrev(-1)">Update User</button>
                                    <button class="btn btn-outline-danger" id="btn_delete" type="button" onclick="nextPrev(-1)">Delete User</button>
                                </div>
                            </div>
                            <!-- Circles which indicates the steps of the form:-->
                            <div class="text-center"><span class="step"></span><span class="step"></span><span class="step"></span><span class="step"></span></div>
                            <!-- Circles which indicates the steps of the form:-->
                        <!--</form>-->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Container-fluid Ends-->
        </div>
    <!--page body start-->
</asp:Content>
