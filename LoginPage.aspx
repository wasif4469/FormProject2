<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FormProject2.LoginPage" Title="LOGIN PAGE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/LoginPage.css" rel="stylesheet" />
    <link rel="icon" href="/Images/Jubilee%20Logo%202.jpg" type="image/x-icon" />

</head>
<body>
    <div class="container-left">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-right">
        <form id="loginForm" runat="server" class="login-form">
            <h1>TG-Portal Login</h1>
            <div class="input-container">
                <input type="text" id="username" runat="server" placeholder="Username" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <input type="password" id="password" runat="server" placeholder="Password" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Tech Graduate" Value="Tech Graduate"></asp:ListItem>
                    <asp:ListItem Text="Team Lead" Value="Team Lead"></asp:ListItem>
                    <asp:ListItem Text="Section Head" Value="Section Head"></asp:ListItem>
                    <asp:ListItem Text="Group Head" Value="Group Head"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <asp:Label ID="Label1" runat="server" ForeColor="#BA0C25" Style="margin-bottom: 15px"></asp:Label>
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" CssClass="submit-button" />
            </div>
            <div class="form-links">
                <a href="RegisterPage.aspx" class="signup-link">Employee Details</a>
                <a href="/Forgot2.aspx" class="forgot-link">Forgot Password?</a>
            </div>
        </form>
    </div>
</body>
</html>
