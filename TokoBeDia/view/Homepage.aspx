<%@ Page Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="TokoBeDia.view.Homepage" %>


<asp:Content runat="server" ContentPlaceHolderID="container">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="dgvRandProd" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Name" DataField="Name" />
            <asp:BoundField HeaderText="Stock" DataField="Stock" />
            <asp:BoundField HeaderText="ProductTypeName" DataField="ProductTypeName" />
            <asp:BoundField HeaderText="Price" DataField="Price" />

            
        </Columns>

    </asp:GridView>
    <asp:Button ID="btn_ViewPaymentType"  runat="server" Text="Payment Type" OnClick="btn_ViewPaymentType_Click" />

</asp:Content>
