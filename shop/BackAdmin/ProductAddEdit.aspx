<%@ Page Title="" Language="C#" MasterPageFile="~/BackAdmin/Back.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ProductAddEdit.aspx.cs" Inherits="shop.BackAdmin.ProductAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <h1 class="page-header">הוספה / עריכת מוצר</h1>
    <div class="container">
        <asp:HiddenField ID="HidPid" runat="server" Value="-1" />
        <div class="row">
            <div class="col-md-2">שם המוצר</div>
            <div class="col-md-4"><asp:TextBox ID="TxtPname" runat="server" CssClass="form-control" /></div><br />
            <br />
             <div class ="col-md-2">מחיר</div>
            <div class ="col-md-4"><asp:TextBox ID="TxtPrice" runat="server" CssClass="form-control" /></div><br />
            <br />
             
            <br />
             <div class="col-md-2">תמונה</div>
            <div class="col-md-4"><asp:fileupload ID="PicUpload" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">שם תמונה</div>
            <div class="col-md-4"><asp:TextBox ID="TxtPic" runat="server" CssClass="form-control" /></div><br />
            <br />
            <div class="col-md-2">תיאור מוצר</div>
            <div class="col-md-4"><asp:TextBox ID="TextProdDesc" TextMode="MultiLine" Rows="6" Columns="40" runat="server" CssClass="form-control" /></div><br />
            <br />
           
            <asp:Button ID="BtnSave" runat="server" Text="שמור" CssClass="btn btn-success" OnClick="BtnSave_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterCnt" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="UnderCnt" runat="server">
    <script src="https://cdn.ckeditor.com/ckeditor5/41.4.2/classic/ckeditor.js"></script>
<script>
    ClassicEditor
        .create(document.querySelector( '#MainContent_TextProdDesc' ) )
        .catch( error => {
            console.error( error );
        } );
</script>

</asp:Content>
