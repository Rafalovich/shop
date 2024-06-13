<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="CategoriesLists.aspx.cs" Inherits="shop.BackAdmin.CategoriesLists" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>רשימת קטגוריות</h1>
     <div class="panel panel-default">
                        <div class="panel-heading">
                            ניהול מוצרים במערכת
                            </div>
         <div class="panel-body">
              <div class="table-responsive">
                                <table class="table table-striped table-bordered table-hover" id="TblCategory">
                                    <thead>
                                        <tr>
                                            <th>קוד קטגוריה</th>
                                            <th>שם קטגוריה</th>
                                            <th>קוד קטגוריית אב</th>
                                            <th>שם תמונת קטגוריה</th>
                                          </tr>
                                        </thead>
                                    <asp:Repeater ID="RptCategory" runat="server" >
                                        <ItemTemplate>
                                            <tr>
                                                <td><a href="CategoryAddEdit.aspx?CategId=<%#Eval("CategId") %>"><%#Eval("CategId") %></a></td>
                                                 <td><%#Eval("CategName") %></td>
                                                 <td><%#Eval("CategFather") %></td>
                                                 <td><%#Eval("CategPicName") %></td>
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
            $('#TblCategory').dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
