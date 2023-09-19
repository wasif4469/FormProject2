<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FormProject2.RegisterPage" EnableViewState="true" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
    <link href="Content/Register.css" rel="stylesheet" />
    <link rel="icon" href="/Images/Jubilee%20Logo%202.jpg" type="image/x-icon" />

</head>
<body>
    <div class="container-right">
        <div class="image">
            <img src="Images/Jubilee_Logo_2-bgr.png" />
        </div>
    </div>
    <div class="container-left">
        <form id="signupForm" runat="server" class="signup-form">
            <h1>Employee Details</h1>
            <p>*Note:&nbsp;Please press tab after entering employee ID</p>
            <p>*Note:&nbsp;Employee ID Should be of 6-8 digits</p>
            <div class="input-container">
                <asp:TextBox ID="txtEmployeeID" runat="server" placeholder="Employee Code" OnTextChanged="txtEmployeeID_TextChanged" AutoPostBack="true"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="EmployeeIdValidator" runat="server" ForeColor="#BA0C25" ControlToValidate="txtEmployeeID" Display="Dynamic" SetFocusOnError="True" ValidationGroup="ValEmpid">*Required</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtEmployeeID" Display="Dynamic" ForeColor="#BA0C25" MaximumValue="99999999" MinimumValue="100000" SetFocusOnError="True" Type="Integer" ValidationGroup="ValEmpid">Employee ID Should be of Six digits</asp:RangeValidator>
            <div class="input-container">
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="UsernameValidator" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <asp:TextBox ID="txtFullName" runat="server" placeholder="Full Name"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="FullNameValidator" runat="server" ControlToValidate="txtFullName" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div class="input-container">
                <asp:TextBox ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="txtEmail" ValidationExpression="^[a-zA-Z0-9._%+-]+@jubileelife\.com$"
                ForeColor="#BA0C25" Display="Dynamic" SetFocusOnError="True">Invalid email format or domain.</asp:RegularExpressionValidator>
            <div class="input-container">
                <asp:TextBox ID="txtRole" runat="server" placeholder="Role"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RoleValidator" runat="server" ControlToValidate="txtRole" Display="Dynamic" ForeColor="#BA0C25" SetFocusOnError="True">*Required</asp:RequiredFieldValidator>
            <div>
                <div class="form-links">
                    <a href="LoginPage.aspx" class="signup-link">Already have an account? Log In</a>
                </div>
                <div class="form-links">
                    <a href="AdminLogin.aspx" class="signup-link" style="margin-right: 70px;">Want to edit your details?</a>
                    <br />
                </div>
                <asp:Label ID="RegisterLabel" runat="server" ForeColor="#BA0C25"></asp:Label>
            </div>
        </form>

    </div>
</body>
</html>

