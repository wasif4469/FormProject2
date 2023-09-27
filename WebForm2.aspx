<%@ Page Title="ACTIVITIES FORM" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="FormProject2.WebForm2" EnableViewState="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Content/Form2.css" rel="stylesheet" />
    <link rel="icon" href="/Images/Jubilee%20Logo%202.jpg" type="image/x-icon" />

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
                <br>
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

                    <td class="auto-style43">
                        <asp:DropDownList ID="section_name2" runat="server" CssClass="auto-style21" Width="195px" ValidationGroup="val" OnSelectedIndexChanged="chnge" AutoPostBack="True"></asp:DropDownList>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="section_name2" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>

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
                    <td class="auto-style47">1</td>
                    <td class="auto-style38">
                        <asp:DropDownList ID="acti1" runat="server" CssClass="auto-style21" Width="434px" ValidationGroup="val"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ClientIDMode="Static" ControlToValidate="acti1" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore" runat="server" BorderStyle="Solid" CssClass="auto-style50" BackColor="#BA0C25" ForeColor="White" Height="25px" Width="42px" OnClick="vis1" Text="+" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box" runat="server" CssClass="auto-style51" Width="294px"></asp:TextBox>
                        &nbsp;<asp:Button ID="plus2" runat="server" OnClick="add" Text="Add Activity" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" ForeColor="White" Height="31px" Width="100px" CssClass="auto-style52" />
                    </td>
                    <td class="auto-style49">
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
                        <asp:DropDownList ID="acti2" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" ClientIDMode="Static" ControlToValidate="acti1" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore0" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis2" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box0" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus3" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add1" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti3" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator30" runat="server" ClientIDMode="Static" ControlToValidate="acti3" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore1" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis3" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box1" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus4" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add2" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti4" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" ClientIDMode="Static" ControlToValidate="acti4" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore2" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis4" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box2" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus5" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add3" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti5" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" ClientIDMode="Static" ControlToValidate="acti5" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore3" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis5" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box3" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus6" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add4" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti6" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" ClientIDMode="Static" ControlToValidate="acti6" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore4" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis6" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box4" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus7" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add5" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti7" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" ClientIDMode="Static" ControlToValidate="acti7" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore5" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis7" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box5" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus8" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add6" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti8" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" ClientIDMode="Static" ControlToValidate="acti8" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore6" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis8" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;&nbsp;<asp:TextBox ID="box6" runat="server" CssClass="auto-style51" Width="294px"></asp:TextBox>
                        &nbsp;<asp:Button ID="plus9" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add7" Text="Add Activity" Width="100px" />

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
                        <asp:DropDownList ID="acti9" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator36" runat="server" ClientIDMode="Static" ControlToValidate="acti9" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore7" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis9" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;<asp:TextBox ID="box7" runat="server" Width="294px" CssClass="auto-style51"></asp:TextBox>

                        &nbsp;<asp:Button ID="plus10" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add8" Text="Add Activity" Width="100px" />
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
                    <td class="auto-style37">10</td>
                    <td class="auto-style38">
                        <asp:DropDownList ID="acti10" runat="server" CssClass="auto-style21" ValidationGroup="val" Width="434px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator37" runat="server" ClientIDMode="Static" ControlToValidate="acti10" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val">*</asp:RequiredFieldValidator>
                        &nbsp;&nbsp;<asp:Button ID="addmore8" runat="server" BackColor="#BA0C25" BorderStyle="Solid" CssClass="auto-style50" ForeColor="White" Height="25px" OnClick="vis10" Text="+" Width="42px" />
                        &nbsp;&nbsp;&nbsp;<br />
                        &nbsp;&nbsp;<asp:TextBox ID="box8" runat="server" CssClass="auto-style51" Width="294px"></asp:TextBox>
                        &nbsp;<asp:Button ID="plus11" runat="server" BackColor="#BA0C25" BorderStyle="None" BorderWidth="25px" CssClass="auto-style52" ForeColor="White" Height="31px" OnClick="add9" Text="Add Activity" Width="100px" />
                    </td>
                    <td class="auto-style44">
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
                        <asp:TextBox ID="Txtsum" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <br />
        </asp:Panel>
        <asp:Panel ID="Remarks" runat="server">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label8" runat="server" Text="Recommendation(s) for the further growth." Style="margin-left: 10%"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator28" ControlToValidate="TextArea1" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="val" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                <br />
                <textarea id="TextArea1" class="auto-style41" runat="server" name="S1"></textarea>
            </asp:Panel>
            <asp:Panel ID="button" runat="server">
                <asp:Button ID="Submit" runat="server" ValidationGroup="val" CssClass="Submit-Pro" Text="Submit" OnClick="Submit_Click1" />
                <asp:Button ID="Review" runat="server" ValidationGroup="val" Text="Reviewed" OnClick="review" CssClass="Submit" />
            </asp:Panel>
            <br />
            <asp:Label ID="Label2" runat="server" Text="" Visible="false"></asp:Label>
            <br />
            <asp:Panel ID="ApprovalPanel" runat="server">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Reason for rejection." Style="margin-left: 10%"></asp:Label><asp:RequiredFieldValidator ID="RequiredFieldValidator27" ControlToValidate="TextArea2" runat="server" ErrorMessage="Name Required" ForeColor="#FF3300" ValidationGroup="rej" ClientIDMode="Static">*</asp:RequiredFieldValidator>
                <br />
                <textarea id="TextArea2" class="auto-style41" runat="server" name="S1"></textarea>
                <br />
                <asp:Button ID="approve" runat="server" BackColor="#BA0C25" BorderColor="#BA0C25" CssClass="auto-style26" ValidationGroup="val" Text="Approve" Width="144px" BorderStyle="Double" OnClick="process" ForeColor="White" />
                <asp:Button ID="Reject" runat="server" BackColor="#BA0C25" BorderColor="#BA0C25" CssClass="auto-style26" ValidationGroup="rej" Text="Reject" Width="144px" BorderStyle="Double" OnClick="reject" ForeColor="White" />
            </asp:Panel>
        </asp:Panel>
    </div>
</asp:Content>