<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApp.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
   <p><asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="Red"></asp:Label></p>
    <p>username : <asp:TextBox ID="txt1" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
    <p> <asp:Button ID="check" runat="server" Text="Submit" onclick="check_Click"/></p>


</div>
</asp:Content>
