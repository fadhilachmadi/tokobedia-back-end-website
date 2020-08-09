<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokoBeDia.view.Profile" %>


<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>Profile</h1>
    <asp:GridView ID="dgvProfile" runat="server"
        EmptyDataText="No data available." AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" ID="btnGoToProfile" CssClass="btn btn-dark" OnClick="btnGoToProfile_Click" Text="Update Profile"/>
</asp:Content>
