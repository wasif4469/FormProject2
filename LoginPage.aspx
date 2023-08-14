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
        <form id="loginForm" runat="server" class="login-form">
            <h1>TG-Portal Login</h1>
            <div class="input-container">
                <input type="text" id="username" runat="server" placeholder="Username" />
            </div>
            <div class="input-container">
                <input type="password" id="password" runat="server" placeholder="Password" />
            </div>
            <div class="input-container">
                <select id="category" runat="server">
                    <option value="tech-graduate">Tech Graduate</option>
                    <option value="team-lead">Team Lead</option>
                    <option value="section-head">Section Head</option>
                    <option value="group-head">Group Head</option>
                </select>
            </div>
            <asp:Label ID="Label1" runat="server" ForeColor="#BA0C25" style="margin-bottom: 15px"></asp:Label>
            <div>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" CssClass="submit-button" />
            </div>
            <div class="form-links">
                <a href="RegisterPage.aspx" class="signup-link">Sign Up</a>
                <a href="#" class="forgot-link">Forgot Password?</a>
            </div>
        </form>
    </div>
</body>
</html>
