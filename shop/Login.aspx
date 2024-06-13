<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="shop.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" lang="he">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>התחברות לאתר</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous" />
    <link rel="stylesheet" href="/css/style.css" />
    <!--- יש לשים את החיבור לתיקיית העיצוב שלי למטה כדי לדרוס דברים מהבוטסטראפ שאני לא מעוניין בהם--->
</head>
<body>

    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">עמוד הבית</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="/ProductInfo.aspx">מוצרים</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Link</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">Dropdown
                        </a>
                        <ul class="dropdown-menu">
                            <li><a class="dropdown-item" href="#">Action</a></li>
                            <li><a class="dropdown-item" href="#">Another action</a></li>
                            <li>
                                <hr class="dropdown-divider" />
                            </li>
                            <li><a class="dropdown-item" href="#">Something else here</a></li>
                        </ul>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link disabled" aria-disabled="true">Disabled</a>
                    </li>
                </ul>
                <form class="d-flex" role="search">
                    <input class="form-control me-2" type="search" placeholder="חיפוש" aria-label="Search" />
                    <button class="btn btn-outline-success" type="submit">חיפוש</button>
                </form>
            </div>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div class="container text-center">
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    מייל
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextEmail" runat="server" class="form-control" placeholder="נא הזן כתובת מייל " />
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    סיסמה
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextPassord" TextMode="Password" runat="server" class="form-control" placeholder="נא הזן סיסמה" />
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    <asp:Button ID="BtnLogin" runat="server" Text="התחברות" CssClass="btn btn-success" OnClick="BtnLogin_Click"/>
                </div>
            </div>
             <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                   <asp:Literal ID="LtMsg2" runat="server" /> 
        </div>
             </div>
        </div>
        
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
