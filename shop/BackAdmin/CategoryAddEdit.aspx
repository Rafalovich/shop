
<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="CategoryAddEdit.aspx.cs" Inherits="shop.BackAdmin.CategoryAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
  </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">עריכת/ הוספת קטגוריה</h1>
    <div class="container">
         <asp:HiddenField ID="HidCategId" runat="server" Value="-1" />
        <div class="row">
            <div class="col-md-2">שם הקטגוריה </div>
                 <div class="col-md-4"><asp:TextBox ID="TxtPnameC" runat="server" CssClass="form-control" /></div><br />
                <br />
                 <div class="col-md-2">הערות </div>
                      <div class="col-md-4"><asp:TextBox ID="TxtDescC" runat="server" CssClass="form-control" /></div><br />
                      <br />
            <div class="col-md-2">שם תמונה</div>
            <div class="col-md-4"><asp:TextBox ID="TxtPicC" runat="server" CssClass="form-control" /></div><br />
                     <br />
         <div class="col-md-2">קוד קטגוריית אב</div>
            <div class="col-md-4"><asp:TextBox ID="TxtCatFa" runat="server" CssClass="form-control" /></div><br />
                         <br />
            <asp:Button ID="BtnSave" runat="server" Text="שמור" CssClass="btn btn-success" OnClick="BtnSave_Click" />
            <br />
                 
                 </div>
                 </div>
           
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
