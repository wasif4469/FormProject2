<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="FormProject2.WebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Form1.css" rel="stylesheet" />
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
                    <p>
                        <b><span>How do you feel you have performed in your role as a tech graduate in the last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>What do you feel you have learned in your role?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>What do you feel you could have done better in your role?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>What do you feel was your top achievement in last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>What do you think your strengths were specific to last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>What do you think your weaknesses were specific to last assignment?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>Do you think you would consider last assignment’s area of work for you career?</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Form-Table10" style="border: thin solid #000000">
                    <table class="Form-Table13">
                        <tr>
                            <td class="Form-Table11">&nbsp;&nbsp; Yes/No/Maybe:</td>
                            <td>
                               <asp:TextBox ID="TextBox8" runat="server" CssClass="Form-Table12"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="Table2-Question" style="border: thin solid #000000">
                    <p>
                        <b><span>Reason:</span></b>
                    </p>
                </td>
            </tr>
            <tr>
                <td class="Table2-Textarea" style="border: thin solid #000000">
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style15" TextMode="MultiLine" Rows="10"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <div>
            <input class="Back" id="Button2" type="button" value="Back" />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="Submit" OnClick="btnSubmit_Click" />

        </div>
    </div>
</asp:Content>




