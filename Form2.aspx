<%@ Page Title="" Language="C#" MasterPageFile="/Site.Master" AutoEventWireup="true" CodeBehind="form2.aspx.cs" Inherits="FormProject2.form2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Content/Form2.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style46 {
            width: 50px;
            height: 36px;
        }

        .auto-style47 {
            width: 543px;
            height: 36px;
        }

        .auto-style48 {
            width: 185px;
            height: 36px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Image ID="Image2" runat="server" Height="45px" src="/Images/Jubilee%20Logo.jpg" Width="130px" />
        <asp:Panel ID="header" runat="server">
            <div class="Container-header">
                <p>Tech Graduate Program</p>
                <p>Jubilee Life Insurance - Technology & Project Management</p>
                <p>Tech Graduate Performance Evaluation </p>
                <div class="Select">
                    <asp:DropDownList ID="trainee" runat="server" CssClass="Trainee-Select" OnSelectedIndexChanged="fetch" AutoPostBack="True"></asp:DropDownList>
                    <asp:DropDownList ID="Depart" runat="server" CssClass="Depart-Select" OnSelectedIndexChanged="fetch" AutoPostBack="True"></asp:DropDownList>
                </div>
            </div>
        </asp:Panel>
        <asp:Panel ID="Trainee_details" runat="server">
            <table class="container-table" border="1">
                <tr>
                    <td style="height: 20px;">
                        <asp:Label ID="Name" runat="server" Text="Name" Font-Bold="True"></asp:Label></td>
                    <td style="height: 20px;">
                        <asp:TextBox ID="Name1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="Name1" runat="server" ErrorMessage="Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td style="height: 20px;">
                        <asp:Label ID="Team_name" runat="server" Text="Team Name" Font-Bold="True"></asp:Label></td>
                    <td style="height: 20px;">
                        <asp:TextBox ID="Team_name1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="Team_name1" runat="server" ErrorMessage="Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px;">
                        <asp:Label ID="Employ_ID" runat="server" Text="Employee ID" Font-Bold="True"></asp:Label>
                    </td>
                    <td style="height: 20px;">
                        <asp:TextBox ID="Employ_ID1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Employ_ID1" runat="server" ErrorMessage="Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Employ_ID1" ErrorMessage="6 digit number" ValidationExpression="\d{6}" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*Incorrect</asp:RegularExpressionValidator>
                    </td>
                    <td style="height: 20px;">
                        <asp:Label ID="program" runat="server" Text="Program Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="program1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="program1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px;">
                        <asp:Label ID="section_name" runat="server" Text="Section Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td style="height: 20px;">
                        <asp:TextBox ID="section_name1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="section_name1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td style="height: 20px;">
                        <asp:Label ID="Section_head_name" runat="server" Text="Section Head Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="Section_head_name1" runat="server" Width="180px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="Section_head_name1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <br />
        </asp:Panel>
        <asp:Panel ID="Static_table" runat="server">
            <table class="container-table" border="1">
                <tr>
                    <th class="auto-style34">Activity Score Criteria (activity is not more than 5 rating)</th>
                    <th class="auto-style45">Rating  </th>
                </tr>
                <tr>
                    <td class="auto-style34">Activity Not Attempted</td>
                    <td class="auto-style45">0</td>
                </tr>
                <tr>
                    <td class="auto-style34">Tried but not able to complete the activity</td>
                    <td class="auto-style45">1-2</td>
                </tr>
                <tr>
                    <td class="auto-style34">Activity Completed under high assistance</td>
                    <td class="auto-style45">3</td>
                </tr>
                <tr>
                    <td class="auto-style34">Activity Completed with some assistance</td>
                    <td class="auto-style45">4</td>
                </tr>
                <tr>
                    <td class="auto-style34">Activity Completed without assistance</td>
                    <td class="auto-style45">5</td>
                </tr>
            </table>
            <br />
        </asp:Panel>
        <asp:Panel ID="Activity_table" runat="server">
            <table class="container-table" border="1">
                <tr>
                    <th class="auto-style37">S.no</th>
                    <th class="auto-style38">Activity Code /Activity Description (Example Entries)</th>
                    <th class="auto-style44">Rating</th>
                </tr>
                <tr>
                    <td class="auto-style37">1</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act1" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="act1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="drop1" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" ControlToValidate="drop1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">2</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act2" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="act2" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop2" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" ControlToValidate="Drop2" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">3</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act3" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" ControlToValidate="act3" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop3" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" ControlToValidate="Drop3" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">4</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act4" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="act4" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop4" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" ControlToValidate="Drop4" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">5</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act5" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" ControlToValidate="act5" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop5" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" ControlToValidate="Drop5" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">6</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act6" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" ControlToValidate="act6" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop6" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" ControlToValidate="Drop6" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">7</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act7" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" ControlToValidate="act7" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop7" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator23" ControlToValidate="Drop7" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">8</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act8" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" ControlToValidate="act8" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop8" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator24" ControlToValidate="Drop8" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37">9</td>
                    <td class="auto-style38">
                        <asp:TextBox ID="act9" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" ControlToValidate="act9" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style44">
                        <asp:DropDownList ID="Drop9" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" ControlToValidate="Drop9" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style46">10</td>
                    <td class="auto-style47">
                        <asp:TextBox ID="act10" runat="server" Width="511px" ValidationGroup="val"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" ControlToValidate="act10" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style48">
                        <asp:DropDownList ID="Drop10" runat="server" CssClass="auto-style21" Width="162px" ValidationGroup="val">
                            <asp:ListItem Value="0">0</asp:ListItem>
                            <asp:ListItem Value="1">1</asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator26" ControlToValidate="Drop10" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style37"></td>
                    <td class="auto-style38">Total Activity rating score out of 50  
                    </td>
                    <td class="auto-style44">
                        <asp:TextBox ID="Txtsum" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Panel ID="Remarks" runat="server">
            <asp:Label ID="Label8" runat="server" Text="Recommendation(s) for the further growth." Style="margin-left: 10%"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator28" ControlToValidate="TextArea1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
            <textarea id="TextArea1" class="auto-style41" runat="server" name="S1"></textarea>
        </asp:Panel>
        <asp:Panel ID="button" runat="server">
            <asp:Button ID="Submit" runat="server" ValidationGroup="val" CssClass="Submit-Pro" Text="Submit" OnClick="Submit_Click1" />
            <asp:Button ID="Review" runat="server" ValidationGroup="val" Text="Reviewed" OnClick="review" CssClass="Submit" />
        </asp:Panel>
        <asp:Panel ID="ApprovalPanel" runat="server">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Reason for rejection." Style="margin-left: 10%"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator27" ControlToValidate="TextArea2" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="rej" ClientIDMode="Static">*</asp:RequiredFieldValidator>
            <br />
            <textarea id="TextArea2" class="auto-style41" runat="server" name="S1"></textarea>
            <br />
            <br />
            <asp:Button ID="approve" runat="server" BackColor="#BA0C25" BorderColor="#BA0C25" CssClass="Approve" ValidationGroup="val" Text="Approve" OnClick="process" />
            <asp:Button ID="Reject" runat="server" BackColor="#BA0C25" BorderColor="#BA0C25" CssClass="Reject" ValidationGroup="rej" Text="Reject" OnClick="reject" />
        </asp:Panel>
    </div>
</asp:Content>
