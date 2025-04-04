﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductEtid.aspx.cs" Inherits="shop.BackAdmin.ProductEtid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
    <title>הוספת מוצר</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous" />
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
     <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">דף הבית</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="/ProductInfo.aspx">מוצרים</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/login.aspx">התחברות</a>
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
                    <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search" />
                    <button class="btn btn-outline-success" type="submit">Search</button>
                </form>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container text-center">
             <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                     שם מוצר
                 </div>
                 <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TxtProductName" runat="server" Class="form-control" placeOlder="נא הזן שם מוצר" />
            </div>
        </div>
                  <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                     מחיר
                 </div>
                 <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TextBox2" runat="server" Class="form-control" placeOlder="נא הזן שם מוצר" />
            </div>
        </div>
                  <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                     תיאור קצר
                 </div>
                 <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TextShortDesc" runat="server" Class="form-control" placeOlder="נא הזן תיאור קצר" />
            </div>
        </div>
             <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                     תיאור נרחב
                 </div>
                 <div class="col-md-4 col-sm-6">
        <asp:TextBox ID="TextExtensiveDesc" runat="server" TextMode="MultiLine" Rows="5" Columns="40" Class="form-control" placeOlder="נא הזן תיאור נרחב" />
            </div>
        </div>
             <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
           תמונת המוצר 
                      </div>
                     <div class="col-md-4 col-sm-6">
                     <asp:FileUpload ID="FlD" runat="server" Class="form-control"/>
                      </div>
        </div>
        <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                   קטגוריה
                 </div>
                 <div class="col-md-4 col-sm-6">
                     <asp:DropDownList ID="DDLCategory" runat="server" Class="form-control" >
                     <asp:ListItem Text="בחר קטגוריה" Value="-1" />
                          <asp:ListItem Text="הנעלה" Value="10" />
                          <asp:ListItem Text="בגדי ילדים" Value="12" />
                          <asp:ListItem Text="בגדי גברים" Value="14" />
                     </asp:DropDownList>
            </div>
        </div>
             <div class="row p-2">
                 <div class="col-md-2 col-sm-3">
                     <asp:Button ID="BtnAddProd" runat="server" CssClass="btn btn-success" Text="שמור נתונים" OnClick="BtnAddProd_Click" />
                     </div>
                 </div>
        </div>
    </form>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

</body>
</html>
