<%@ Page MasterPageFile="~/Master.Master" Language="C#" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="TokoBeDia.view.UpdateProductType" %>
<asp:Content runat="server" ContentPlaceHolderID="container">
       <h1>Update Product Type</h1>
     <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Description</label>
        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:Button ID="btnUpdateProductType" OnClick="btnUpdateProductType_Click" CssClass="btn btn-primary" Text="Update product type" runat="server" />
</asp:Content>