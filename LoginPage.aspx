<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FormProject2.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="LoginPage.css" rel="stylesheet" />
</head>
<body>
    <div class="container-left">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-right">
        <form id="loginForm" runat="server" class="login-form">
            <h1>TG-Evaluation Login</h1>
            <div class="input-container">
                <input type="text" id="username" runat="server" placeholder="Username" />
            </div>
            <div class="input-container">
                <input type="password" id="password" runat="server" placeholder="Password" />
            </div>
            <button type="submit" class="submit-button">Sign In</button>
            <div class="form-links">
                <a href="#" class="signup-link">Sign Up</a>
                <a href="#" class="forgot-link">Forgot Password?</a>
            </div>
        </form>
    </div>
</body>
</html>
