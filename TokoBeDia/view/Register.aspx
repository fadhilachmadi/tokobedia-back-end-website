<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokoBeDia.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../public/css/bootstrap.css" />
</head>
<body>
    <div class="container">
        <h1>Register Kuy</h1>
        <form id="Register" runat="server">
            <div class="form-group">
                <label>
                    Name
                </label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>
                    Email
                </label>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Password </label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Confirm password </label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Gender </label>
                <asp:RadioButtonList ID="txtGender" runat="server">
                    <asp:ListItem>male</asp:ListItem>
                    <asp:ListItem>female</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <asp:Button ID="btnSubmit" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="Submit_Click" />
        </form>
    </div>
</body>
<script type="text/javascript" src="../public/css/bootstrap.css"></script>
<script type="text/javascript" src="../public/js/popper.js"></script>
<script type="text/javascript" src="../public/js/bootstrap.js"></script>
</html>
