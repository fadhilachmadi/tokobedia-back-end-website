<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="TokoBeDia.view.WebForm1" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>Change Password</h1>
    <div class="form-group">
        <label>Old Password</label>
        <asp:TextBox CssClass="form-control" ID="txtOldPassword" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>New Password</label>
        <asp:TextBox CssClass="form-control" ID="txtNewPassword" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Confirm Password</label>
        <asp:TextBox CssClass="form-control" ID="txtConfirmPassword" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="btnChange" runat="server" OnClick="btnChange_Click" Text="change" CssClass="btn btn-primary" />
</asp:Content>
