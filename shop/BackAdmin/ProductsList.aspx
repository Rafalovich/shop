<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="ProductsList.aspx.cs" Inherits="shop.BackAdmin.ProductsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>מאגר מוצרים</h1>
       <div class="panel panel-default">
                        <div class="panel-heading">
                           ניהול מוצרים במערכת
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="table-responsive">
                                <table class="table table-striped table-bordered table-hover" id="TblProducts">
                                    <thead>
                                        <tr>
                                            <th>קוד מוצר</th>
                                            <th>שם</th>
                                            <th>מחיר</th>
                                            <th>תמונה</th>
                                        </tr>
                                    </thead>
                                   <asp:Repeater ID="RptProducts" runat="server">
                                       <ItemTemplate>
                                           <tr>
                                               <td><a href="ProductAddEdit.aspx?pid=<%#Eval("Pid") %>"><%#Eval("Pid") %></a></td>
                                                <td><%# Eval("Pname") %></td>
                                                <td><%#Eval("Price") %></td>
                                                <td><img src="/upload/products/<%# Eval("PicName") %>" width="30" /></td>

                                           </tr>
                                       </ItemTemplate>
                                   </asp:Repeater>
                                </table>
                            </div>
                            <!-- /.table-responsive -->
                         
                        </div>
                        <!-- /.panel-body -->
                    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
     <!-- DataTables JavaScript -->
    <script src="js/jquery/jquery.dataTables.min.js"></script>
    <script src="js/bootstrap/dataTables.bootstrap.min.js"></script>

   

    <!-- Page-Level Demo Scripts - Tables - Use for reference -->
    <script>
        $(document).ready(function() {
            $('#TblProducts').dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
