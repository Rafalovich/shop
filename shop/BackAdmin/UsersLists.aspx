<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="UsersLists.aspx.cs" Inherits="shop.BackAdmin.UsersLists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>רשימת משתמשים</h1>
    <div class="panel panel-default">
                        <div class="panel-heading">
                            ניהול משתמשים
                                </div>
         <div class="panel-body">
              <div class="table-responsive">
                                <table class="table table-striped table-bordered table-hover" id="TblUsers">
                                    <thead>
                                        <tr>
                                            <th>קוד משתמש</th>
                                            <th>שם פרטי</th>
                                            <th>קוד משפחה</th>
                                            <th>קוד עיר</th>
                                            <th>כתובת</th>
                                            <th>מייל</th>
                                            <th>תאריך לידה</th>
                                            <th>מספר טלפון</th>
                                            <th>תאריך רישום</th>
                                       </tr>
                                    </thead>
                                    <asp:Repeater ID="RptUsers" runat="server" >
                                        <ItemTemplate>
                                            <tr>
                                                <tb><a href="UserAddEdit.aspx?UserId=<%#Eval("UserId") %>"><%#Eval("UserId") %></a></tb>
                                                <tb><%#Eval("FName") %></tb>
                                                <tb><%#Eval("LName") %></tb>
                                                <tb><%#Eval("CityId") %></tb>
                                                <tb><%#Eval("Addres") %></tb>
                                                <tb><%#Eval("Mail") %></tb>
                                                <tb><%#Eval("Password") %></tb>
                                                <tb><%#Eval("BirthDate") %></tb>
                                                <tb><%#Eval("Phone") %></tb>
                                                <tb><%#Eval("RegisDate") %></tb>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                    </div>
               </div>
          </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
     <script src="js/jquery/jquery.dataTables.min.js"></script>
    <script src="js/bootstrap/dataTables.bootstrap.min.js"></script>

   

    <!-- Page-Level Demo Scripts - Tables - Use for reference -->
    <script>
        $(document).ready(function () {
            $('#TblUsere').dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
