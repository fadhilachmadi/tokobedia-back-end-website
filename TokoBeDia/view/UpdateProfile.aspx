<%@ Page  MasterPageFile="~/Master.Master"  Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="TokoBeDia.view.UpdateProfile" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>Update Profile</h1>
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
        <label>Gender </label>
        <asp:RadioButtonList ID="txtGender" runat="server">
            <asp:ListItem>male</asp:ListItem>
            <asp:ListItem>female</asp:ListItem>
        </asp:RadioButtonList>
    </div>

    <asp:Button ID="btnUpdateProfile" OnClick="btnUpdateProfile_Click" CssClass="btn btn-primary" Text="Update Profile" runat="server" />
</asp:Content>
