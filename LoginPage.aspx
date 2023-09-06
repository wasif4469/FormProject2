<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FormProject2.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/LoginPage.css" rel="stylesheet" />
</head>
<body>
    <div class="container-left">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-right">
        <form id="loginForm" runat="server" class="login-form" >
            <h1>TG-Portal Login</h1>
            <div class="input-container">
                <input type="text" id="username" runat="server" placeholder="Username" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="username" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <input type="password" id="password" runat="server" placeholder="Password" />
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="password" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            
            <asp:Label ID="Label1" runat="server" ForeColor="#BA0C25" style="margin-bottom: 15px"></asp:Label>
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" CssClass="submit-button" />
            </div>
            <div class="form-links">
                <a href="RegisterPage.aspx" class="signup-link">Employee Details</a>
                <a href="#" class="forgot-link">Forgot Password?</a>
            </div>
        </form>
    </div>
</body>
</html>
