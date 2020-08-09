<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TokoBeDia.view.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../public/css/bootstrap.css" />
</head>
<body>
    <div class="container">
        <h1>Login Kuy</h1>
        <form runat="server" id="Login">
            <div class="form-group">
                <label>
                    Email
               
                </label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Password
                </label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>

            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn btn-primary" />
            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />

        </form>
        <span>Don't have the account click <a href="Register.aspx">here</a>!</span>
    </div>

</body>
<script type="text/javascript" src="../public/css/bootstrap.css"></script>
<script type="text/javascript" src="../public/js/popper.js"></script>
<script type="text/javascript" src="../public/js/bootstrap.js"></script>
</html>
