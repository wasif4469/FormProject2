<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FormProject2.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Register.css" rel="stylesheet" />
</head>
<body>
    <div class="container-right">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-left">
        <form id="signupForm" runat="server" class="signup-form">
            <h1>TG-Portal Registration</h1>
            <div class="input-container">
                <asp:TextBox ID="txtEmployeeID" runat="server" placeholder="Employee Code"></asp:TextBox>
            </div>
            <div class="input-container">
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>

            </div>
            <div class="input-container">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            </div>
            <div class="input-container">
                <asp:TextBox ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
            </div>
            <div class="input-container">
                <asp:DropDownList ID="category" runat="server">
                    <asp:ListItem Value="Tech-Graduate">Tech Graduate</asp:ListItem>
                    <asp:ListItem Value="Team-Lead">Team Lead</asp:ListItem>
                    <asp:ListItem Value="Section-Head">Section Head</asp:ListItem>
                    <asp:ListItem Value="Group-Head">Group Head</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Sign Up" CssClass="submit-button" OnClick="Button1_Click" />
            <div class="form-links">
                <a href="LoginPage.aspx" class="signup-link">Already have an account? Log In</a>
            </div>
        </form>
    </div>
</body>
</html>
