<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FormProject2.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Content/Dashboard.css" rel="stylesheet" />
    <style>
        .Label-Style {
            width: 400px;
            height: 70px;
            font-size: 14px;
            color: #BA0C25;
            text-align: justify;
            display: flex;
            flex-direction: row-reverse;
            margin-bottom: 10px;
            margin-top: 12px;
        }

        h3 {
            margin-bottom: 12px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Note" runat="server">
        <div class="Label-Style">
            <asp:Label ID="Label1" runat="server" Text="*Note: For Group Heads, Links on the Pending table is for forms approval and links on the Navigation bar is to see the previous record for any Tech Graduate"></asp:Label>
        </div>
    </asp:Panel>
    <h3>Pending Approvals</h3>
    <div class="PendingTable">
        <asp:GridView ID="GridView1" runat="server" CssClass="custom-gridview" AutoGenerateColumns="False">
            <HeaderStyle CssClass="grid-header" />
            <RowStyle CssClass="grid-row" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Trainee_Name" HeaderText="Trainee_Name" />
                <asp:BoundField DataField="Section_Name" HeaderText="Section_Name" />
                <asp:HyperLinkField DataTextField="Activity_Form" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="form2/{0}" HeaderText="Activities Evaluation" ControlStyle-CssClass="custom-link" />
                <asp:HyperLinkField DataTextField="Indicator_Form" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="form3/{0}" HeaderText="Indicator Rating" ControlStyle-CssClass="custom-link" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
