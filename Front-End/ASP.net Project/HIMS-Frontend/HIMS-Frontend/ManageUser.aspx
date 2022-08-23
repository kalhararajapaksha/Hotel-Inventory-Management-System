<%@ Page Title="" Language="C#" MasterPageFile="~/Sidebar.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="HIMS_Frontend.ManageUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--page body start-->
   
    <!-- Container-fluid starts-->
    <div class="container-fluid">
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
                      <li ><a class="btn btn-primary-light btn-xs" data-container="body" data-placement="top" data-bs-toggle="modal" data-bs-target="#exampleModalfat" data-whatever="@mdo" title="" data-original-title="Tables" onclick="Clearing()"><i data-feather="plus"></i>Add New User &nbsp;</a></li>

                    </ul>
                  </div>
                  <!-- Bookmark Ends-->
                </div>
              </div>
            </div>

        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-header pb-0">
                        <h5>Manage User</h5>
                        <span>You can Create User accounts of your organization here.</span>
                    </div>

                    <div class="card-body">
                      <div class="row post">
                                          
                      <div class="table-responsive">
                          <table id="tblUsers" class="show-case">
                           <thead>
                          <tr>
                            <th >ID</th>
                            <th >Employee ID</th>
                            <th >User Name</th>
                            <th >Password</th>
                            <th class="text-center py-0 align-middle">Action</th>
                            
                          </tr>
                        </thead>
                        <tbody>
                          
                        </tbody>
                       
                      </table>
                   
                    </div>

          
                
                 
                     </div>
                  </div><!--End card body -->
                </div>
            </div>
        </div>
    </div>
    <!-- Container-fluid Ends-->
      

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
                                    <select class="js-example-basic-single col-sm-12 form-control select2-hidden-accessible" style="width: 100%;" id="drpEmployee" >
                                        
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
    <script src="../script/page/manageUserAccount.js"></script>
    <!--page body start-->
</asp:Content>
