<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="ListCity.aspx.cs" Inherits="shop.BackAdmin.ListCity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container">
        <div class="col-lg-6">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            טבלת ערים
                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="table-responsive">
                                <table class="table">
                                    <thead>
                                        <tr>
                                            <th>קוד עיר</th>
                                            <th>שם עיר</th>
                                            
                                        </tr>
                                    </thead>
                                    <tbody>
                                <asp:Repeater runat="server" ID="rptCity">
                                    <ItemTemplate>
                                        <tr>
                                          <td><%#Eval("_id") %></td>
                                          <td><%#Eval("שם_ישוב") %></td>
                                       </tr>
                                   </ItemTemplate> 
                               </asp:Repeater>
                                   </tbody>
                                </table>
                            </div>
                            <!-- /.table-responsive -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->
                </div>
         
   </div>
          
              <%-- <tr>
                   <%#Eval("שם_ישוב")%>
               </tr>--%>
          
      
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
      <script src="js/jquery/jquery.dataTables.min.js"></script>
    <script src="js/bootstrap/dataTables.bootstrap.min.js"></script>
    <script>

    </script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
