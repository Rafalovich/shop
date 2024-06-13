<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" AutoEventWireup="true" CodeBehind="UserAddEdit.aspx.cs" Inherits="shop.BackAdmin.UserAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <!-- DataTables CSS -->
    <link href="css/plugins/dataTables.bootstrap.css" rel="stylesheet">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">הוספת / עריכת משתמש</h1>
    <div class="container">
        <asp:HiddenField ID="HidUserId" runat="server" value="-1" />
        <div class="row">
            <div class="col-md-2">שם פרטי</div>
            <div class="col-md-4"><asp:TextBox ID="TxtFName" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">שם משפחה</div>
            <div class="col-md-4"><asp:TextBox ID="TextLName" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">קוד עיר</div>
            <div class="col-md-4"><asp:TextBox ID="TextCityId" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">כתובת</div>
            <div class="col-md-4"><asp:TextBox ID="TextAddres" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">מייל</div>
            <div class="col-md-4"><asp:TextBox ID="TextMail" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">סיסמא</div>
            <div class="col-md-4"><asp:TextBox ID="TextPass" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">תאריך לידה</div>
            <div class="col-md-4"><asp:TextBox ID="TextBirth" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">מספר טלפון</div>
            <div class="col-md-4"><asp:TextBox ID="TextPhone" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">תאריך רישום</div>
            <div class="col-md-4"><asp:TextBox ID="TextReg" runat="server" CssClass="form-control" /></div><br /><br />
            <asp:Button runat="server" ID="BtnSave" Text="שמור" CssClass="btn btn-success" OnClick="BtnSave_Click" />
        </div>
        </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
</asp:Content>
