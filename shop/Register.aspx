<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="shop.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" lang="he">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>הרשמה לאתר</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" integrity="sha384-nU14brUcp6StFntEOOEBvcJm4huWjB0OcIeQ3fltAfSmuZFrkAif0T+UtNGlKKQv" crossorigin="anonymous" />
    <link rel="stylesheet" href="/css/style.css" />
    <!--- יש לשים את החיבור לתיקיית העיצוב שלי למטה כדי לדרוס דברים מהבוטסטראפ שאני לא מעוניין בהם--->
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
                    שם מלא
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TxtFullName" runat="server" class="form-control" placeholder="נא הזן שם מלא" />
                    <asp:RequiredFieldValidator ID="RqFullName" runat="server" ErrorMessage="שדה זה הינו חובה" ControlToValidate="TxtFullName" ForeColor="Red"/>
                    </div>
                </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    כתובת
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextAddres" runat="server" class="form-control" placeholder="נא הזן כתובת" />

                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    גיל
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextAge" runat="server" class="form-control" placeholder="נא הזן גיל" />
                    <asp:RangeValidator ID="RgAge" runat="server" ErrorMessage="הרשמה מגיל 18 ומעלה" ControlToValidate="TextAge" MinimumValue="18" MaximumValue="120" Type="Integer" ForeColor="Red"/>
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    עיר
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextCity" runat="server" class="form-control" placeholder="נא הזן עיר" />
                </div>
            </div>
            <div>
          <asp:DropDownList ID="DDLCity" runat="server" >
        
               </asp:DropDownList>
      </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    טלפון
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextPhone" runat="server" class="form-control" placeholder="נא הזן מספר טלפון" />
                    <asp:RegularExpressionValidator ID="RePhone" runat="server" ErrorMessage="טלפון לא תקין" ControlToValidate="TextPhone"  ValidationExpression="05[0-8][-]?[1-9][0-9]{6}" ForeColor="Red"/>
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    מייל
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextEmail" runat="server" class="form-control" placeholder="נא הזן כתובת מייל " />
                   <asp:RegularExpressionValidator ID="ReEmail1" runat="server" ErrorMessage="כתובת מייל אינה תקינה" ControlToValidate="TextEmail" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"  ForeColor="Red"/>
                    <asp:RequiredFieldValidator ID="ReEmail2" runat="server" ErrorMessage="שדה זה הינו חובה" ControlToValidate="TextEmail" ForeColor="Red"/>
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    סיסמה
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextPassord" TextMode="Password" runat="server" class="form-control" placeholder="נא הזן סיסמה" />
                    <asp:RequiredFieldValidator ID="RePass" runat="server" ErrorMessage="שדה זה הינו חובה" ControlToValidate="TextPassord" ForeColor="Red"/>
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    אימות סיסמה
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextConfirmPassword" TextMode="Password" runat="server" class="form-control" placeholder="אימות סיסמא" />
                    <asp:CompareValidator ID="CoPass" runat="server" ErrorMessage="סיסמא ואימות סיסמא אינם תואמים" ControlToValidate="TextConfirmPassword" ControlToCompare="TextPassord" ForeColor="Red" />
                    <asp:RequiredFieldValidator ID="ReConPass" runat="server" ErrorMessage="שדה זה הינו חובה" ControlToValidate="TextConfirmPassword" ForeColor="Red"/>
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    מספר זהות
                </div>
                <div class="col-md-4 col-sm-6">
                    <asp:TextBox ID="TextId" runat="server" class="form-control" placeholder="נא הזן מספר זהות" />
                </div>
            </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    הערות
                    </div>
                 <div class="col-md-4 col-sm-6">
                 <asp:TextBox ID="TextRemarks" runat="server" Class="form-control" placeholder="הערות כלליות" TextMode="MultiLine" Rows="5" Columns="40" />
            </div>
                </div>
                     <div class="row p-2">
                <div class="col-md-4 col-sm-3">
        <asp:CheckBox ID="chkTerm" runat="server" Text="אני מסכים לתנאי השימוש באתר" />
                     </div>
                  </div>
            <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    <asp:Button ID="BtnRegister" runat="server" Text="הרשמה" CssClass="btn btn-success" OnClick="BtnRegister_Click" />
               
                </div>
            </div>
                     <div class="row p-2">
                <div class="col-md-2 col-sm-3">
                    <asp:RadioButton ID="RDMale" runat="server" GroupName="Gender" Text="זכר" />
                    <asp:RadioButton ID="RDFemale" runat="server" GroupName="Gender" Text="נקבה" />
            <div class="row p-2">
                <div class="col-md-6 col-sm-8">
                     <asp:Literal ID="LtMsg" runat="server" />
                         </div>
                  </div>
        </div>
          </div>
              </div>
     </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
</body>
</html>
