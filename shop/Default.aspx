<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="shop.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <button type="button" id="Btn1" name="Btn1">כפתור רגיל קלאסי</button>
            <input type="button" id="Btn3" name="Btn3" value="כפתור גירסה נוספת צד לקוח"/>
        <asp:button ID="Btn2" runat="server" Text="הרשמה" />
        שם פרטי<asp:TextBox ID="TexFname" runat="server" placeholder="נא הזן שם פרטי"/>
        </div>
    </form>
    <div id="Yaron" runat="server"></div>
</body>
</html>
