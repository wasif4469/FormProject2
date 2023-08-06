<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="FormProject2.WebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Form-Table1 {
            width: 66%;
            height: 141px;
            margin-left: auto;
            margin-right: auto;
            font-family: Verdana;
        }

        .Table1-Text {
            height: 20px;
            width: 292px;
            font-family: Verdana;
        }

        .TableHeading {
            width: 500px;
            margin-left: 200px;
            font-size: 14px;
            font-family: Verdana;
        }

        .PageHeader {
            text-align: center;
            font-size: 24px;
            font-weight: bold;
            font-size: 14px;
            font-family: Verdana;
            margin-bottom: 20px;
            color: black; /* Red header color */
        }

        .Table1-Label {
            height: 20px;
            width: 350px;
            font-family: Verdana;
            font-size: 16px;
            background-color: #d8dcdf;
            color: black;
            text-shadow: 4px black;
        }

        .Table1-Input {
            height: 20px;
            width: 292px;
            font-family: Verdana;
        }

        .logo {
            margin-left: 20px;
            margin-top: 20px;
            padding-right: 15px;
            width: 114px;
            height: 56px;
            font-family: Verdana;
        }

        .Form-Table2 {
            width: 47%;
            margin-left: auto;
            margin-right: auto;
            font-family: Verdana;
        }

        .auto-style15 {
            width: 861px;
            font-family: Verdana;
            resize: vertical;
        }

        .Table2-Textarea {
            width: 867px;
            font-family: Verdana;
        }

        .Table2-Question {
            width: 867px;
            height: 24px;
            font-family: Verdana;
            background-color: #d8dcdf;
        }

        .Form-Table10 {
            width: 867px;
            height: 37px;
            font-family: Verdana;
        }

        .Form-Table11 {
            font-family: Verdana;
            font-size: 12px;
            width: 107px;
        }

        .Form-Table12 {
            height: 20px;
            width: 199px;
            font-family: Verdana;
        }

        .Form-Table13 {
            width: 100%;
            height: 29px;
        }

        /* Style for the Submit button */
        .Submit {
            background-color: #BA0C25; /* Submit button color */
            color: #ffffff; /* White text color */
            padding: 12px 20px; /* Add padding to the button */
            font-size: 16px;
            border-radius: 10px; /* Rounded corners */
            margin-left: 75%;
            cursor: pointer; /* Add a pointer cursor on hover */
            transition: background-color 0.2s, box-shadow 0.2s; /* Smooth transition */
        }

            /* Hover effect for the Submit button */
            .Submit:hover {
                background-color: #a70a21; /* Darker shade of the Submit button color on hover */
                box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1); /* Add a subtle box shadow on hover */
            }

            /* Active effect for the Submit button (when it's clicked) */
            .Submit:active {
                background-color: #c0243a; /* Slightly darker shade of the Submit button color on click */
                box-shadow: none; /* Remove box shadow on click */
            }

            /* Optional: Add a slight transition when the button is active */
            .Submit:active {
                transition: background-color 0.1s;
            }

        /* Reset default button styles */
        button {
            border: none;
            outline: none;
        }

        /* Style for the Back button */
        .Back {
            background-color: #4285F4; /* Google Blue color */
            color: #ffffff; /* White text color */
            padding: 12px 20px; /* Add padding to the button */
            font-size: 16px;
            border-radius: 10px; /* Rounded corners */
            margin-left: 3.5%;
            cursor: pointer; /* Add a pointer cursor on hover */
            transition: background-color 0.2s, box-shadow 0.2s; /* Smooth transition */
        }

            /* Hover effect for the Back button */
            .Back:hover {
                background-color: #3c78d8; /* Darker shade of Google Blue on hover */
                box-shadow: 0px 4px 8px rgba(0, 0, 0, 0.1); /* Add a subtle box shadow on hover */
            }

            /* Active effect for the Back button (when it's clicked) */
            .Back:active {
                background-color: #3367c7; /* Slightly darker shade of Google Blue on click */
                box-shadow: none; /* Remove box shadow on click */
            }

            /* Optional: Add a slight transition when the button is active */
            .Back:active {
                transition: background-color 0.1s;
            }


        body {
            justify-content:center;
            align-items:center;
            min-height: 80vh;
            margin: 0;

        }

        .container {
            margin-top: 30px;
            margin-bottom: 30px;
            margin-right: auto;
            margin-left: auto;
            width: 65%; /* Adjust container width as needed */
            background-color: #ffffff; /* White background color */
            padding: 25px;
            box-shadow: 10px 0 13px rgba(0, 0, 0, 0.6); /* Add a subtle box shadow */
            border-radius: 10px;
        }

        .auto-style16 {
            height: 20px;
        }

        .validator {
            display: flex;
            font-family: Verdana;
            font-size: 12px;
        }

        .val-col {
            width: max-content;
            display: flex;
            font-family: Verdana;
            margin-left: 15%;
            font-size: 14px;
        }

        .navbar {
            background-color: #343a40;
            display: flex;
            justify-content: flex-start;
            align-items: center;
            padding: 10px 20px;
        }

        .navbar-brand img {
            max-height: 40px;
        }

        .navbar-brand {
            margin-right: 15px;
        }

        .navbar-list {
            list-style: none;
            display: flex;
            margin: 0;
            padding: 0;
        }

        .navbar-item {
            margin-right: 20px;
        }

        .navbar-link {
            text-decoration: none;
            color: #ffffff;
            font-weight: bold;
            transition: color 0.2s;
        }

            .navbar-link:hover {
                color: #BA0C25;
            }

        /* Responsive Styles */
        @media (max-width: 768px) {
            .navbar {
                flex-direction: column;
                align-items: flex-start;
            }

            .navbar-list {
                margin-top: 10px;
            }

            .navbar-item {
                margin: 0;
            }
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <img alt="" class="logo" src="Images/Jubilee%20Logo.jpg" />
        <p class="PageHeader">Tech Graduate Program 2023</p>
        <p class="PageHeader">Jubilee Life Inusrance - Technology & Project Management</p>
        <p class="PageHeader"><b>Tech Graduate's Performance Evaluation</b></p>
        <p class="TableHeading"><b>To be Filled By Tech Graduate after each rotatation</b></p>
        <table class="Form-Table1">
            <tr>
                <td class="Table1-Label" style="border: thin solid #000000">Name</td>
                <td class="Table1-Input" style="border: thin solid #000000">
                    <asp:TextBox ID="Textname" runat="server" CssClass="Table1-Text"></asp:TextBox>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Textname" Display="Dynamic" ErrorMessage="*" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="Table1-Label" style="border: thin solid #000000">Employee ID</td>
                <td class="Table1-Input" style="border: thin solid #000000">
                    <asp:TextBox ID="Textempid" runat="server" CssClass="Table1-Text"></asp:TextBox>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Textempid" Display="Dynamic" ErrorMessage="*Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td class="Table1-Label" style="border: thin solid #000000">Section Deployed In</td>
                <td class="Table1-Input" style="border: thin solid #000000">
                    <asp:TextBox ID="Textsection" runat="server" CssClass="Table1-Text"></asp:TextBox>
                    <td class="auto-style16">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Textsection" Display="Dynamic" ErrorMessage="*Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td class="Table1-Label" style="border: thin solid #000000">Supervisor Name</td>
                <td class="Table1-Input" style="border: thin solid #000000">
                    <asp:TextBox ID="Textsupervisor" runat="server" CssClass="Table1-Text"></asp:TextBox>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textsupervisor" Display="Dynamic" ErrorMessage="*Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td class="Table1-Label" style="border: thin solid #000000">Tenure( From Date - To Date)</td>
                <td class="Table1-Input" style="border: thin solid #000000">
                    <asp:TextBox ID="Textdate" runat="server" CssClass="Table1-Text"></asp:TextBox>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textdate" Display="Dynamic" ErrorMessage="*Required" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
            </tr>

        </table>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Textempid" Display="Dynamic" ErrorMessage="*" ForeColor="Red" MaximumValue="199999" MinimumValue="100000" SetFocusOnError="True" Type="Integer" CssClass="val-col">*Employee ID Should be of six digits*</asp:RangeValidator>
        <br />
        <p class="TableHeading"><b>General Information of a Tenure by Tech Graduate</b></p>
        <table class="Form-Table2" border="1" style="border: thin solid #000000">
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span font-family: Verdana;font-weight: bold; font-size: 9.0000pt;">How do you feel you have performed in your role as a tech graduate in the last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea1" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">What do you feel you have learned in your role?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea2" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">What do you feel you could have done better in your role?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea3" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">What do you feel was your top achievement in last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea4" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana;font-weight: bold; font-size: 9.0000pt;">What do you think your strengths were specific to last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea5" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">What do you think your weaknesses were specific to last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea6" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">Do you think you would consider last assignment’s area of work for you career?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Form-Table10" style="border: thin solid #000000">
                    <table class="Form-Table13">
                        <tr>
                            <td class="Form-Table11">&nbsp;&nbsp; Yes/No/Maybe:</td>
                            <td>
                                <input id="Text5" class="Form-Table12" type="text" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p class="MsoNormal">
                        <b><span style="font-family: Verdana; font-weight: bold; font-size: 9.0000pt;">Reason:</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <textarea id="TextArea7" class="auto-style15" name="S1" rows="2"></textarea></td>
            </tr>
        </table>
        <br />
        <div>
            <input class="Back" id="Button2" type="button" value="Back" />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="Submit" OnClick="btnSubmit_Click" />

        </div>
    </div>
</asp:Content>




