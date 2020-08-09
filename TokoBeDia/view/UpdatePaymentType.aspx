<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UpdatePaymentType.aspx.cs" Inherits="TokoBeDia.view.UpdatePaymentType" %>

<asp:Content ID="Content2" ContentPlaceHolderID="container" runat="server">
     <h1>Update Payment Type</h1>
     <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
    </div>
   
    <asp:Button ID="btnUpdatePaymentType" CssClass="btn btn-primary" Text="Update payment type" runat="server" OnClick="btnUpdatePaymentType_Click" />

</asp:Content>
