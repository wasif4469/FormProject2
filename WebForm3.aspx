
<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FormProject2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/Form3.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style9 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <img src="Images/Jubilee%20Logo.jpg" alt="Sample Photo" id="image" /><br /> <br /><br />  
<asp:Label ID="Label1"  style="margin-left:20%; font-family:Verdana;font-weight:bold;" runat="server" 
    Text="To be Filled by Team Lead"></asp:Label>
    <br />   <br />  <br />
    <asp:Panel ID ="Table" runat="server">
    <table border="1" class="evaTable" >
        <tr>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style2">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">Indicators</span></b></p>
            </td>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">&nbsp; Maximum</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Rating</span></b></p>
            </td>
        </tr>
        <tr>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt; " valign="center" class="auto-style2">&nbsp;</td>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">&nbsp;&nbsp;&nbsp; Rating </span></b>
                </p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; By Function</span></b></p>
            </td>
        </tr>

        <tr>
            <td style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="center" class="auto-style2">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">A. KNOWLEDGE</span></b></p>
            </td>
             <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="center">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">20</span></b></p>
            </td>
             <td  style="border: 1pt solid windowtext; padding: 0.00pt 5.400pt;"valign="center">
                 &nbsp;</td>
        </tr>
        <tr>
            <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="top" class="auto-style3">
                <p class="MsoNormal" style="height: 45px; width: 505px;">
                    <span style="font-family:Verdana;font-size:10pt;line-height:1.3;">
                        The Graduate shows willingness to learn new things and<br />to improve competence on the work on hand.</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; vertical-align:central;"class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;10</td>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style1">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL1" runat="server" Width="225px" Height="50px">
                        <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                        <asp:ListItem Value="6">6</asp:ListItem>
                        <asp:ListItem Value="7">7</asp:ListItem>
                        <asp:ListItem Value="8">8</asp:ListItem>
                        <asp:ListItem Value="9">9</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>   
                    </asp:DropDownList>
                    </p>
            </td>
        </tr>

        <tr>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style4" >
                <p class="MsoNormal" style="width: 510px; height: 45px">
                    <span style="font-family:Verdana;font-size:10.0000pt;line-height:1.3;">
                        The Graduate demonstrates clear understanding of duties,
                    responsibilities, and procedures about assigned activities.</span></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; vertical-align: central;"  class="auto-style5">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana; font-size: 16px;">10</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center" class="auto-style5">
                <p align="center" class="MsoNormal" style="height: 38px">
                    <asp:DropDownList ID="DDL2" runat="server"  Width="225px" Height="50px">
                        <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                        <asp:ListItem Value="4"></asp:ListItem>
                        <asp:ListItem Value="5"></asp:ListItem>
                        <asp:ListItem Value="6"></asp:ListItem>
                        <asp:ListItem Value="7"></asp:ListItem>
                        <asp:ListItem Value="8"></asp:ListItem>
                        <asp:ListItem Value="9"></asp:ListItem>
                        <asp:ListItem Value="10"></asp:ListItem>
                    </asp:DropDownList>
                </p>
            </td>
        </tr>
        <tr>
               <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center" class="auto-style2">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">
                        B. SKILLS</span></b></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">20</span></b></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center">
                 &nbsp;</td>
        </tr>
        <tr>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style6">
                <p class="MsoNormal" style="height: 40px">
                    <span style="font-family:Verdana;font-size:10.0000pt; line-height:1.3;">
                        The Graduate works with attention, accuracy, promptness,
                    and efficiency in carrying assign activities.</span></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style7">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:16px;">10</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style7">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL3" runat="server"  Width="225px" Height="50px">
                        <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                        <asp:ListItem Value="4"></asp:ListItem>
                        <asp:ListItem Value="5"></asp:ListItem>
                        <asp:ListItem Value="6"></asp:ListItem>
                        <asp:ListItem Value="7"></asp:ListItem>
                        <asp:ListItem Value="8"></asp:ListItem>
                        <asp:ListItem Value="9"></asp:ListItem>
                        <asp:ListItem Value="10"></asp:ListItem>
                    </asp:DropDownList>
                </p>
            </td>
        </tr>
        <tr>
             <td   style="border: 1.0000pt solid windowtext; " valign="center" class="auto-style2">
                <p>
                    <span style="font-family:Verdana;font-size:10.0000pt;line-height:1.3;">The Graduate works effectively and willingly with others in a positive and supportive relationship and with team spirit</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:16px; vertical-align:central;">10</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL4" runat="server"  Width="225px" Height="50px">
                         <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                        <asp:ListItem Value="4"></asp:ListItem>
                        <asp:ListItem Value="5"></asp:ListItem>
                        <asp:ListItem Value="6"></asp:ListItem>
                        <asp:ListItem Value="7"></asp:ListItem>
                        <asp:ListItem Value="8"></asp:ListItem>
                        <asp:ListItem Value="9"></asp:ListItem>
                        <asp:ListItem Value="10"></asp:ListItem>
                    </asp:DropDownList>
                </p>
            </td>
        </tr>
        <tr>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center" class="auto-style2">
                <p align="center" >
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">C. ATTITUDE </span></b>
                </p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" >
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">10</span></b></p>
            </td>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center">
                  &nbsp;</td>
        </tr>
        <tr>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center" class="auto-style2">
                <p class="MsoNormal" style="height: 46px; width: 506px;">
                    <span style="font-family:Verdana;font-size:10.0000pt;line-height:1.3;">
                        The Graduate reports to work regularly and finish assignments on time</span></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:16px;">5</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL5" runat="server"  Width="225px" Height="38px">
                        <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                        <asp:ListItem Value="4"></asp:ListItem>
                        <asp:ListItem Value="5"></asp:ListItem>
                    </asp:DropDownList>
                </p>
            </td>
        </tr>
        <tr>
                 <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style2">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;line-height:1.3;">The Graduate works hard all the time to accomplish assigned task </span>
                </p>
            </td>
            <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:16px; vertical-align: central;">5</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL6" runat="server"  Width="225px" Height="38px">
                        <asp:ListItem Value="0"></asp:ListItem>
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3"></asp:ListItem>
                        <asp:ListItem Value="4"></asp:ListItem>
                        <asp:ListItem Value="5"></asp:ListItem>
                    </asp:DropDownList>
                </p>
            </td>
        </tr>
        <tr>
             <td "style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center" class="auto-style2">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">D. Technical Section Evaluation (At least 10 Activities)</span></b></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-size:16px;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;50</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="left" class="MsoNormal">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style9" Height="25px"></asp:TextBox>
                </p>
            </td>
        </tr>
        <tr>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style2">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">
                        Total rating from activities section</span></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="center">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
        </tr>
        <tr>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center" class="auto-style2">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">TOTAL RATING</span></b></p>
           <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-size:10.0000pt;">
                        &nbsp;&nbsp;&nbsp;&nbsp; 100</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="center">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
        </asp:Panel>
          
    <br />
    <asp:Button ID="Button5" runat="server" Text="Submit" CssClass="Submit" OnClick="Btn1_Click" />
    &nbsp;
    
    <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
    
    <br />
<asp:Panel ID="SHPanel" runat="server">
    <asp:Label ID="Label2" Style="font-family:Verdana;margin-left:3%;font-weight:bold;" runat="server" Text="To be Submitted by Section Head"></asp:Label>
    <br /><br />
    <div class="auto-style8">
        <asp:Button ID="Button2" CssClass="Submit-Pro" runat="server" Text="Process" OnClick="Button2_Click"  />
        <asp:Button ID="Button3" CssClass="Submit-Pro2" runat="server" Text="Rejected" onClick="Rejbtn1"/>
    </div>
     <asp:Label ID="RejLabel1" runat="server" ForeColor="#BA0C25" Visible="False"></asp:Label>
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br/>
    <asp:Label ID="Label3" Style="font-family:Verdana;margin-left:3%;" runat="server" Text="In case of rejection kindly give the reason"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;
    
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="TextArea1" TextMode="MultiLine" Rows="5"></asp:TextBox>
        <br />
        <br/>
</asp:Panel>

    <asp:Label ID="Label4" Style="font-family:Verdana;margin-left:3%;font-weight:bold;" runat="server" Text="To be Submitted by Group Head"></asp:Label>

    <br/>
        <br/>
    <div>
 <asp:Panel ID="GHPanel" runat="server">
     <asp:Button ID="Button4" runat="server" Text="Approved" CssClass="Submit-Pro" OnClick="Button4_Click"/>
       <asp:Button ID="Rej" runat="server" Text="Rejected" CssClass="Submit-Pro2" OnClick="Rejbtn2"/>
    </div>
        <asp:Label ID="RejLabel2" runat="server" ForeColor="#BA0C25"></asp:Label>
    <br/>
    <br/>
        <asp:Label ID="Label5" Style="font-family:Verdana;margin-left:3%;" runat="server" Text="In case of rejection kindly give the reason"></asp:Label>
    <br />
    <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="TextArea2" TextMode="MultiLine" Rows="5"></asp:TextBox>
&nbsp;&nbsp;
        <br /><br />
    </div>
 </asp:Panel>
</asp:Content>

