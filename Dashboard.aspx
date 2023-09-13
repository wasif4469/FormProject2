<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FormProject2.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Content/Dashboard.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3>Pending Approvals</h3>
    <br />
    <div class="PendingTable">
        <asp:GridView ID="GridView1" runat="server" CssClass="custom-gridview" AutoGenerateColumns="False">
            <HeaderStyle CssClass="grid-header" />
            <RowStyle CssClass="grid-row" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Trainee_Name" HeaderText="Trainee_Name" />
                <asp:BoundField DataField="Section_Name" HeaderText="Section_Name" />
                <asp:HyperLinkField  DataTextField="Activity_Form" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="form2/{0}" HeaderText="Activities Evaluation" ControlStyle-CssClass="custom-link" />
                <asp:HyperLinkField DataTextField="Indicator_Form" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="form3/{0}" HeaderText="Indicator Rating" ControlStyle-CssClass="custom-link"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
