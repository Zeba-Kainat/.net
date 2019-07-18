<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div>
     <p><asp:Label ID="lblMessage" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="Red"></asp:Label></p>
            <p>User Name : <asp:TextBox ID="txtEmail" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Password:   <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox></p>
            <p> <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click"/></p>
        </div>
      
</asp:Content>
