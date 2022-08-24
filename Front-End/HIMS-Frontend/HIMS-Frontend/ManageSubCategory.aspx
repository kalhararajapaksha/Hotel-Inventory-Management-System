<%@ Page Title="" Language="C#" MasterPageFile="~/Sidebar.Master" AutoEventWireup="true" CodeBehind="ManageSubCategory.aspx.cs" Inherits="HIMS_Frontend.ManageSubCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header">
            <div class="row">
                <div class="col-sm-6">
                    <h3>Manage Sub Category</h3>
                </div>
                <div class="col-sm-6">
                    <!-- Bookmark Start-->
                    <div class="bookmark">

                        <ul>
                            <li><a class="btn btn-primary-light btn-xs" data-container="body" data-placement="top" data-bs-toggle="modal" data-bs-target="#exampleModalfat" data-whatever="@mdo" title="" data-original-title="Tables" onclick=""><i data-feather="plus"></i>Add New Sub Category &nbsp;</a></li>

                        </ul>
                    </div>
                    <!-- Bookmark Ends-->
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <div class="card">
                    <div class="card-header pb-0">
                        <%--  <h5>Category Details</h5>--%>

                        <div id="message" hidden="hidden" class="alert alert-danger inverse alert-dismissible fade show" role="alert">
                            <i class="icon-thumb-up alert-center"></i>
                            <p id="message_content">You successfully read this important alert message.</p>
                            <button class="btn-close" type="button" data-bs-dismiss="alert" aria-label="Close" data-bs-original-title="" title=""></button>
                        </div>
                    </div>


                    <div class="card-body">
                        <div class="row post">

                            <div class="table-responsive">
                                <table id="tblCategory" class="show-case">
                                    <thead>
                                        <tr>
                                            <th style="width: 16.6%">ID</th>
                                            <th style="width: 16.6%">Category</th>
                                            <th style="width: 16.6%">Unit</th>
                                            <th style="width: 16.6%" class="text-center py-0 align-middle">Sub Category Name</th>
                                            <th style="width: 16.6%" >Create Date</th>
                                            <th style="width: 16.6%" >Modify Date</th>

                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>

                                </table>

                            </div>




                        </div>
                    </div>
                    <!--End card body -->
                    <%--              
                  <div class="card-footer">
                  </div><!--End footer ----%>
                </div>
                <!--End Card -->

            </div>
            <!--End Big Col -->
        </div>
        <!--End Row -->
    </div>
    <!--End Fluid -->


    <!--Modal Start-->
    <div class="modal fade" id="exampleModalfat" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Create Sub Category</h5>
                    <button class="btn-close" type="button" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label>Category :</label><span style="color: red">*</span>
                            <select class="js-example-basic-single col-sm-12 form-control select2-hidden-accessible" style="width: 100%;" id="drpCategory"></select>
                        </div>
                        <div class="form-group">
                            <label>Unit :</label><span style="color: red">*</span>
                            <select class="js-example-basic-single col-sm-12 form-control select2-hidden-accessible" style="width: 100%;" id="drpUnit"></select>
                        </div>
                        <div class="mb-3">
                            <input type="hidden" id="txtCatID" name="custId" value="-99">
                            <label class="col-form-label" for="recipient-name">Sub Category Name:</label><span style="color: red">*</span>
                            <input id="txtSubCatName" class="form-control" type="text" value="">
                        </div>
                    </form>
                </div>
                <div class="modal-footer text-center" id="btndivcat">
                    <button class="btn btn-secondary" type="button" onclick="btnClose()" data-bs-dismiss="modal">Close</button>
                    <button class="btn btn-primary" id="btnSubmit" onclick="AddCategory()" type="button">Save Category</button>
                </div>
            </div>
        </div>
    </div>
    <!--Model End-->
</asp:Content>
