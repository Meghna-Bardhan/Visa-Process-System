<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeMessagePage.aspx.cs" Inherits="EmployeeMessagePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <center>
            Visa ID :&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="VID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Status:
        <asp:Label ID="Label2" runat="server" Text="Status" Font-Size="Medium" 
                ForeColor="#663300"></asp:Label>
        </center>
    </p>
</asp:Content>

