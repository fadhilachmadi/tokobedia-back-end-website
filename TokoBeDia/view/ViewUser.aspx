<%@ Page MasterPageFile="~/Master.Master" Language="C#" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="TokoBeDia.view.ViewUser" %>

<asp:Content runat="server" ContentPlaceHolderID="container">
    <asp:GridView runat="server" ID="dgvUser" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <%--<asp:BoundField DataField="Status" HeaderText="Status" />--%>
            <asp:TemplateField HeaderText="Role">
                <ItemTemplate>
                    <asp:LinkButton runat="server" Text='<%# (string)Eval("RoleName") == "admin" ? "member" : "admin" %>' ID="toggleRole" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="toggleRole_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:LinkButton runat="server" Text='<%# (String)Eval("Status") == "active" ? "banned" : "active" %>' ID="toggleStatus" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="toggleStatus_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <%--  <asp:BoundField DataField="RoleName" HeaderText="RoleName" />
            <asp:TemplateField HeaderText="Update User">
                <ItemTemplate>
                    <asp:LinkButton runat="server" Text="Update User" ID="btnUpdateUser" CommandArgument='<% #Eval("Id") %>' CssClass="btn btn-primary" OnClick="btnUpdateUser_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>
        </Columns>
    </asp:GridView>
</asp:Content>
