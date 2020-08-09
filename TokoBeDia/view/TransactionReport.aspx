<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TransactionReport.aspx.cs" Inherits="TokoBeDia.view.TransactionReport" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content2" ContentPlaceHolderID="container" runat="server">
    <CR:CrystalReportViewer ID="TransactionReportViewer" runat="server" AutoDataBind="true" />
</asp:Content>
