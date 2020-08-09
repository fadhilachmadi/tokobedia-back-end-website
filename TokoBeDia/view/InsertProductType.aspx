<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="TokoBeDia.view.InsertProductType" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
   <h1>Insert Product Type</h1>
     <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Description</label>
        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:Button ID="btnInsertProductType" OnClick="btnInsertProductType_Click" CssClass="btn btn-primary" Text="Insert product type" runat="server" />
</asp:Content>
