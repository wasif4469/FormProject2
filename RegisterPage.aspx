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
                <input type="text" id="username" runat="server" placeholder="Username" />
            </div>
            <div class="input-container">
                <input type="password" id="password" runat="server" placeholder="Password" />
            </div>
            <div class="input-container">
                <input type="email" id="email" runat="server" placeholder="Email" />
            </div>
            <div class="input-container">
                <select id="category" runat="server">
                    <option value="tech-graduate">Tech Graduate</option>
                    <option value="team-lead">Team Lead</option>
                    <option value="section-head">Section Head</option>
                    <option value="group-head">Group Head</option>
                </select>
            </div>
            <button type="submit" class="submit-button">Sign Up</button>
            <div class="form-links">
                <a href="LoginPage.aspx" class="signup-link">Already have an account? Log In</a>
            </div>
        </form>
    </div>
</body>
</html>
