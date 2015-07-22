<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeePage.aspx.cs" Inherits="Userpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 74%;
            height: 265px;
        }
        .style6
        {
            width: 472px;
        }
        .style7
        {
            width: 609px;
        }
        .style8
        {
            width: 558px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br /><center>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
            RepeatDirection="Horizontal" Font-Size="Large">
            <asp:ListItem Value="Apply" Selected="True">Apply for Visa</asp:ListItem>
            <asp:ListItem Value="Renew">Renew Visa</asp:ListItem>
        </asp:RadioButtonList>
        </center>
        <center>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/EmployeeMessagePage.aspx">View Applied Visas</asp:HyperLink>
        </center>  
    </p>
    <p>
        &nbsp;</p>
        <center>
    <table cellpadding="4" cellspacing="9" class="style3">
        <tr>
            <td class="style8">
                Full Name</td>
            <td class="style7">
                <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Date Of Birth (yyyy-dd-mm)</td>
            <td class="style7">
                <asp:TextBox ID="TextBox2" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="Enter Date Of Birth" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Email ID</td>
            <td class="style7">
                <asp:TextBox ID="TextBox3" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="Enter Email ID username@mail.com" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Phone Number</td>
            <td class="style7">
                <asp:TextBox ID="TextBox4" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="Enter Phone number" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td id="Gend" class="style8">
                Gender</td>
            <td class="style7">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="RadioButtonList2" ErrorMessage="Select Gender" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Address</td>
            <td class="style7">
                <asp:TextBox ID="TextBox6" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="TextBox6" ErrorMessage="Enter Address" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Country</td>
            <td class="style7">
                <asp:TextBox ID="TextBox7" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="TextBox7" ErrorMessage="Enter Country's Name" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Destination</td>
            <td class="style7">
                <asp:TextBox ID="TextBox8" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="TextBox8" ErrorMessage="Enter Destination" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                Start Date (yyyy-dd-mm)</td>
            <td class="style7">
                <asp:TextBox ID="TextBox9" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="TextBox9" ErrorMessage="Enter Start Date" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                End Date (yyyy-mm-dd)</td>
            <td class="style7">
                <asp:TextBox ID="TextBox10" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="TextBox10" ErrorMessage="Enter End Date" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Apply" 
                    Width="86px" />
            </td>
            <td class="style7">
                <asp:Button ID="Button1" runat="server" Text="Renew" onclick="Button1_Click"   
                    Width="86px" Visible="False"/>
            </td>
            <td class="style6">
                &nbsp;</td>
        </tr>
    </table>
    </center>
</asp:Content>

