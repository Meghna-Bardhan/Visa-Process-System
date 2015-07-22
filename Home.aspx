<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            text-align: center;
        }
        .style9
        {
            width: 100%;
        }
        .style10
        {
            width: 599px;
        }
        .style8
        {
            font-family: Constantia;
        }
        .style6
        {
            font-size: large;
        }
        .style12
        {
            height: 16px;
        }
        .style13
        {
            height: 16px;
            width: 185px;
        }
        .style14
        {
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    
        <br />
        <br />

       
        <div style = "float:right" >
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
   <div style="font-size:large;" class="style5">
       <center>
           <table class="style9" >
               <tr>
                   <td class="style10" rowspan="8">
                    <div style="font-size:large;" class="style5">
                         <br class="style8" /> <span class="style6"><span class="style8">Welcome to Visa Processing System. 
                                        </span>
                        <br class="style8" />
                        <br class="style8" />
                               <span class="style8"><em>Please Login to Continue.</em></span><br class="style8" />
                        <br class="style8" />
                        <br class="style8" />
                                <span class="style8">New User??!! Register in the Link below.<br />
                         <br />

       <asp:HyperLink ID="HyperLink1" runat="server" 
            Font-Size="XX-Large" Font-Bold="True" Font-Underline="True" 
            style="text-align: center" NavigateUrl="~/centralregistration.aspx">Register Here</asp:HyperLink></span></span> 
        </div>
        </td>

          <td colspan="2">
                       <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                           Font-Underline="True" Text="LOGIN HERE"></asp:Label>
                   </td>
          </tr>


               <tr>
                   <td class="style13">
                   </td>
                   <td class="style12">
                   </td>
               </tr>

               <tr>
                   <td class="style14">
                       <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="User Type:"></asp:Label>
                   </td>
                   <td>
                                      

                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem Value="Manager">HR Manager</asp:ListItem>
                                        <asp:ListItem Value="Executive">HR Executive</asp:ListItem>
                                        <asp:ListItem>Employee</asp:ListItem>
                                        <asp:ListItem Selected="True" Value="null">--Select--</asp:ListItem>
                                    </asp:DropDownList>
                                      

                                    </td>
               </tr>


               <tr>
                   <td class="style14">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" 
                                            Font-Bold="True">User Name:</asp:Label>
                                        </td>
                   <td>
                                        <asp:TextBox ID="UserName" runat="server" Font-Size="Small"></asp:TextBox>
                                        
                                        </td>
               </tr>

               <tr>
                   <td class="style14">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" 
                                            Font-Bold="True">Password:</asp:Label>
                                    </td>
                   <td>
                                        <asp:TextBox ID="Password" runat="server" Font-Size="Small" TextMode="Password"></asp:TextBox>
                                        
                                        </td>
               </tr>
               <tr>
                   <td class="style14" colspan="2">
                                        &nbsp;</td>
               </tr>


               <tr>
                   <td class="style14" colspan="2">
                                        
                                    </td>
               </tr>


               <tr>
                   <td class="style14">
                       &nbsp;</td>
                   <td>
                                        <asp:Button ID="LoginButton" runat="server" 
                           CommandName="Login" Text="Log In" Font-Size="Medium" onclick="LoginButton_Click" />
                                   
                     </td>
               </tr>
           </table>

           <br /> </center>
       <br />
       <br />
       
    </div>
              
        
   
</asp:Content>


