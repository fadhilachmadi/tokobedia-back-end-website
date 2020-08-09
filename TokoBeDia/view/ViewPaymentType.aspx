<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="TokoBeDia.view.ViewPaymentType" %>

<asp:Content ID="Content2" ContentPlaceHolderID="container" runat="server">
    <h1>View Payment Type</h1>
    <asp:GridView runat="server" EmptyDataText="No data can be shown" ID="dgvPaymentType" AutoGenerateColumns="false">
<%--     OnSelectedIndexChanged="dgvPaymentType_SelectedIndexChanged">--%>
       <Columns>
           <asp:BoundField DataField="Name" HeaderText="Name"/>
           <asp:TemplateField HeaderText="Update Button" Visible="false">
               <ItemTemplate>
                   <asp:LinkButton runat="server" Text="Update Payment Type" ID="btnUpdatePaymentType" CssClass="btn btn-primary" CommandArgument='<% #Eval("Id") %>' OnClick="btnUpdatePaymentType_Click"></asp:LinkButton>
               </ItemTemplate>
           </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete Button" Visible="false">
               <ItemTemplate>
                   <asp:LinkButton runat="server" Text="Delete Payment Type" ID="btnDeletePaymentType" CommandArgument='<% #Eval("Id") %>' CssClass ="btn btn-primary" OnClick="btnDeletePaymentType_Click"></asp:LinkButton>
               </ItemTemplate>
           </asp:TemplateField>
       </Columns>
   </asp:GridView>
   <asp:Button runat="server" Text="Insert Payment Type" ID="btnInsertPaymentType" CssClass="btn btn-primary" OnClick="btnInsertPaymentType_Click"/>
</asp:Content>
