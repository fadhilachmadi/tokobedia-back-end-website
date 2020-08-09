<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="TokoBeDia.view.ViewProductType" %>
<asp:Content runat="server" ContentPlaceHolderID="container">
    <h1>View Product Type</h1>
    <asp:GridView runat="server" EmptyDataText="No data can be shown" ID="dgvProductType" AutoGenerateColumns="false">
       <Columns>
           <asp:BoundField DataField="Name" HeaderText="Name"/>
           <asp:BoundField DataField="Description" HeaderText="Description"/>
           <asp:TemplateField HeaderText="Update Button" Visible="false">
               <ItemTemplate>
                   <asp:LinkButton runat="server" Text="Update Product Type" ID="btnUpdateProduct" CssClass="btn btn-primary" CommandArgument='<% #Eval("Id") %>' OnClick="btnUpdateProduct_Click"></asp:LinkButton>
               </ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete Button" Visible="false">
               <ItemTemplate>
                   <asp:LinkButton runat="server" Text="Delete Product Type" ID="btnDeleteProduct" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="btnDeleteProduct_Click"></asp:LinkButton>
               </ItemTemplate>
           </asp:TemplateField>
       </Columns>
   </asp:GridView>
    <asp:Button runat="server" Text="Insert Product Type" ID="btnInsertProduct" OnClick="btnInsertProduct_Click" CssClass="btn btn-primary"/>
</asp:Content>