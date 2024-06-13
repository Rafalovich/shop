<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginCube.ascx.cs" Inherits="shop.BackAdmin.User_Control.LoginCube" %>
<div class="container">
    <div class="row p-2">
<div id="LoginContainer" runat="server">
    <div class="col-md-2 col-sm-3">
    שם משתמש
      </div>
    <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TxtUser" runat="server" />
    </div>
    <div class="col-md-2 col-sm-3">
    סיסמא
        </div>
    <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TxtPass" runat="server" />
        </div>
    <asp:Button ID="BtnLogin" runat="server" Text="התחברות" OnClick="BtnLogin_Click" />
</div>
        </div>
</div>