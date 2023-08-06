
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="FormProject2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img src="Images/Jubilee%20Logo.jpg" alt="Sample Photo" id="image" /><br /> <br /><br />  
<asp:Label ID="Label1"  style="margin-left:20%; font-family:Verdana;font-weight:bold;" runat="server" 
    Text="To be Filled by Section Head"></asp:Label>
    <br />   <br />  <br />
    <asp:Panel ID ="Table" runat="server">
    <table border="1" class="evaTable" >
        <tr>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">Indicators</span></b></p>
            </td>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">&nbsp; Maximum</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Rating</span></b></p>
            </td>
        </tr>
        <tr>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt; " valign="bottom">&nbsp;</td>
            <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">&nbsp;&nbsp;&nbsp; Rating </span></b>
                </p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; By Function</span></b></p>
            </td>
        </tr>

        <tr>
            <td style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">A. KNOWLEDGE</span></b></p>
            </td>
             <td  style="border: 1pt solid windowtext; padding: 0pt 5.4pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">20</span></b></p>
            </td>
             <td  style="border: 1pt solid windowtext; padding: 0.00pt 5.400pt;"valign="bottom">
                 &nbsp;</td>
        </tr>
        <tr>
            <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="top" class="auto-style1">
                <p class="MsoNormal" style="height: 46px">
                    <span style="font-family:Verdana;font-size:10pt;">
                        The Graduate shows willingness to learn new things and<br /> <br />to improve competence on the work on hand.</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom" class="auto-style1">
                <p align="center" class="MsoNormal" style="height: 0px">
                    <span style="font-family:Verdana;font-size:10.0000pt;">10</span></p>
            </td>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom" class="auto-style1">
                <p align="center" class="MsoNormal">
                    <asp:DropDownList ID="DDL1" runat="server" Width="225px" Height="50px">
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
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom" >
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">
                        The Graduate demonstrates clear understanding of duties,<br/>
                    <br/>
                    responsibilities, methods, and procedures about assigned activities.<br/> </span></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">10</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
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
               <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">
                        B. SKILLS</span></b></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">20</span></b></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                 &nbsp;</td>
        </tr>
        <tr>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">
                        The Graduate works with attention, accuracy, promptness,<br><br>
                    and efficiency in carrying assign activities.</span></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">10</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
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
             <td   style="border: 1.0000pt solid windowtext; " valign="bottom">
                <p>
                    <span style="font-family:Verdana;font-size:10.0000pt;">The Graduate works effectively and willingly with others in a positive 
                    <br/> and supportive relationship and with team spirit<br/></span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">10</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
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
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                <p align="center" >
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">C. ATTITUDE </span></b>
                </p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" >
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">10</span></b></p>
            </td>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                  &nbsp;</td>
        </tr>
        <tr>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">
                        The Graduate reports to work regularly and finish assignments on time</span><b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;"></span></b></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">5</span></p>
            </td>
             <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
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
                 <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">The Graduate works hard all the time to accomplish assigned task </span>
                </p>
            </td>
            <td   style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">5</span></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
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
             <td "style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10.0000pt;">D. Technical Section Evaluation (At least 10 Activities)</span></b></p>
            </td>
            <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-size:10.0000pt;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 50</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
        </tr>
        <tr>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <span style="font-family:Verdana;font-size:10.0000pt;">
                        Total rating from activities section</span></p>
            </td>
             <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt; " valign="bottom">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
        </tr>
        <tr>
              <td style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-weight:bold;font-size:10pt;">TOTAL RATING</span></b></p>
           <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p class="MsoNormal">
                    <b><span style="font-family:Verdana;font-size:10.0000pt;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 100</span></b></p>
            </td>
            <td  style="border: 1.0000pt solid windowtext; padding: 0.0000pt 5.4000pt;" valign="bottom">
                <p align="center" class="MsoNormal">
                    &nbsp;</p>
            </td>
        </tr>
        </table>
        </asp:Panel>
          
    <br />
    <asp:Button runat="server" Text="Submit" Width="169px" BackColor="#BA0C25" Font-Bold="True" ForeColor="White" Height="30px"   CssClass="btnsub" OnClick="Btn1_Click" />
    &nbsp;
    
    <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
    
    <br />
    &nbsp;<br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" Style="font-family:Verdana;margin-left:19%;font-weight:bold;" runat="server" Text="To be Submitted by Section Head"></asp:Label>
    <br />
    <br />
    <br/>
    <asp:Button ID="Button2" style="font-family:Verdana;font-weight:bold;margin-left:20%;" runat="server"  BackColor="#BA0C25" ForeColor="White" Height="37px"  Text="Process" Width="168px" />
   
    <asp:Button ID="Rejbtn" style="font-family:Verdana; font-weight:bold; margin-left:38%;" runat="server" BackColor="#BA0C25" ForeColor="White" Height="37px" Text="Rejected" Width="168px"/>
&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br/>
    <asp:Label ID="Label3" Style="font-family:Verdana;margin-left:20%;" runat="server" Text="In case of rejection kindly give the reason"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="82px" Width="910px" style="margin-left:19%;"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <br />
    <br />
        <br/>
    <asp:Label ID="Label4" Style="font-family:Verdana;margin-left:20%;font-weight:bold;" runat="server" Text="To be Submitted by Group Head"></asp:Label>

    <br/>
        <br/>
    <asp:Button ID="Button4" style="font-family:Verdana;font-weight:bold;margin-left:20%;" runat="server"  BackColor="#BA0C25" ForeColor="White" Height="37px" CssClass="btnprocess" Text="Process" Width="168px" />
    
    <asp:Button ID="Rej" style="font-family:Verdana; font-weight:bold; margin-left:38%;" runat="server" BackColor="#BA0C25" ForeColor="White" Height="37px" Text="Rejected" Width="168px"/>
    <br/>
    <br/>
        <asp:Label ID="Label5" Style="font-family:Verdana;margin-left:20%;" runat="server" Text="In case of rejection kindly give the reason"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="82px" Width="910px" style="margin-left:19%;"></asp:TextBox>

</asp:Content>
