<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="FormProject2.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/AdminLogin.css" rel="stylesheet" />
</head>
<body>
    <div class="container-bg">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="login-form">
        <form id="form1" runat="server">
            <h1>Admin Login</h1>
            <div class="input-container">
                <input type="text" id="userName" runat="server" placeholder="Username" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <input type="password" id="Password" runat="server" placeholder="Password" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <asp:Label ID="Label1" runat="server" ForeColor="#BA0C25" Style="margin-bottom: 15px"></asp:Label>
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" CssClass="submit-button" />
            </div>
            <div class="form-links" style="margin-left: 100px;">
                <a href="RegisterPage.aspx" class="signup-link">Go To Details Page</a>
            </div>
        </form>
    </div>
</body>
</html>
