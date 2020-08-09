<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TokoBeDia.view.ViewProduct" %>



<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>View Product</h1>
    <asp:GridView runat="server" EmptyDataText="No data available." ID="dgvProduct" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Stock" HeaderText="Stock" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <asp:BoundField DataField="ProductTypeName" HeaderText="ProductType" />
            <asp:TemplateField HeaderText="Update button" Visible="false">
                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="btnUpdateProduct" Text="Update Button" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="UpdateProduct_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete button" Visible="false">
                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="btnDeleteProduct" Text="Delete Button" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="DeleteProduct_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Add to cart" Visible="false">
                <ItemTemplate>
                    <asp:LinkButton runat="server" ID="btnAddToCart" Text="Add To Cart" CommandArgument='<%# Eval("Id") %>' CssClass="btn btn-primary" OnClick="btnAddToCart_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <% if ((String)Session["role"] == "admin")
        {%>
    <asp:Button ID="btnInsertProduct" OnClick="btnInsertProduct_Click" Text="Insert Product" runat="server" CssClass="btn btn-primary" />
    <%} %>
</asp:Content>
