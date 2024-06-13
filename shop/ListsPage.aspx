<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListsPage.aspx.cs" Inherits="shop.ListsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous" />
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row p-2">
              עיר:  <asp:DropDownList ID="DDLCity" runat="server" ></asp:DropDownList>
                מוצר:<asp:DropDownList ID="DDLProd" runat="server"></asp:DropDownList>
                מספר:<asp:DropDownList ID="DDLNamber" runat="server" ></asp:DropDownList>
            </div>
        </div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

</body>
</html>
