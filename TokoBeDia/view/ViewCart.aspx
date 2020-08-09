<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="TokoBeDia.view.ViewCart" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
   <h1>View Cart</h1>
    <asp:GridView runat="server" ID="dgvCart" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Product Id" DataField="ProductId"/>
            <asp:BoundField HeaderText="Product Name" DataField="ProductName"/>
            <asp:BoundField HeaderText="Product Price" DataField="ProductPrice"/>
            <asp:BoundField HeaderText="Quantity" DataField="Quantity"/>
            <asp:BoundField HeaderText="Subtotal" DataField="Subtotal"/>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton CssClass="btn btn-primary" runat="server" ID="DeleteCart" OnClick="DeleteCart_Click" CommandArgument='<%# Eval("ProductId") %>'>Delete Cart</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton CssClass="btn btn-primary" runat="server" ID="UpdateCart" OnClick="UpdateCart_Click" CommandArgument='<%# Eval("ProductId") %>'>Update Cart</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <asp:Label runat="server" ID="txtGrandtotal" Text=""></asp:Label>
</asp:Content>