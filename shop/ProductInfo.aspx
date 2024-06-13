<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="shop.ProductInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" >
<head runat="server">
    <title>מוצרים</title>
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
                        <a class="nav-link active" aria-current="page" href="#">מוצרים</a>
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
        <div>
        <div class="col-md-3 col-sm-6">
           <div class="card mb-5" style="width: 18rem; min-height: 550px; max-height:550px;border-color: rgb(17, 129, 241); border-width: 2px;">
        <img src="" class="card-img-top" alt="..."/>
        <div class="card-body">מספר מק"ט <asp:Literal ID="LtlPrice" runat="server" />
          <h5 class="card-title"> <asp:Literal ID="LtlPname" runat="server" /></h5>
          <p class="card-text"><h3>₪</h3></p>
          <button onclick="addToCart(${arrProd[i].ProdId}, 1)" class="btn btn-primary">הוסף לסל </button>
        </div>
        </div>
           </div>
        </div>
        <asp:Literal  ID="Ltl" runat="server"/>
    </form>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
