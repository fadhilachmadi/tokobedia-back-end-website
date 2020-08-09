<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="InsertPaymentType.aspx.cs" Inherits="TokoBeDia.view.InsertPaymentType" %>

<asp:Content ID="Content2" ContentPlaceHolderID="container" runat="server">
       <h1>Insert Payment Type</h1>
     <div class="form-group">
        <label>Name</label>
        <asp:TextBox runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
    </div>
   
    <asp:Button ID="btnInsertPaymentType" CssClass="btn btn-primary" Text="Insert payment type" runat="server" OnClick="btnInsertPaymentType_Click" />

</asp:Content>
