<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddToCart.aspx.cs" Inherits="TokoBeDia.view.AddToCart" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>Add to Cart</h1>

   <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName" Enabled="false"></asp:TextBox>
    </div>
    <div class="form-group">
        <label>Stock</label>
        <asp:TextBox ID="txtStock" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Price</label>
        <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
    </div>
    
    <div class="form-group">
        <label>Product Type</label>
         <asp:TextBox ID="txtProductTypeName" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Quantity</label>
        <asp:TextBox ID="txtQty" CssClass="form-control" runat="server"></asp:TextBox>
    </div>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
</asp:Content>