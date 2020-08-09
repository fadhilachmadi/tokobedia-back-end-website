<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="TokoBeDia.view.InsertProduct" %>

<asp:Content ContentPlaceHolderID="container" runat="server">
    <h1>Insert Product</h1>
    <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Stock</label>
        <asp:TextBox ID="txtStock" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Price</label>
        <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Product Type</label>
        <asp:DropDownList ID="ProductTypeList" runat="server" CssClass="form-control">
        </asp:DropDownList>
    </div>
    <asp:Button ID="btnInsertProduct" OnClick="btnInsertProduct_Click" Text="Insert Button" CssClass="btn btn-primary" runat="server" />
</asp:Content>
