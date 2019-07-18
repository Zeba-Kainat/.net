<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="WebApp.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <p>userid:  <asp:Label ID="lbluserid" runat="server"  ></asp:Label></p>
    <p>First Name:  <asp:Label ID="lblfirstname" runat="server" ></asp:Label></p>
     <p>Middle Name:  <asp:Label ID="lblmiddlename" runat="server"></asp:Label></p>
    <p>Last Name:  <asp:Label ID="lbllastname" runat="server"></asp:Label></p>
    <p>Gender: <asp:Label ID="lblgender" runat="server" ></asp:Label></p>
    <p>Competency: <asp:Label ID="lblcompetency" runat="server" ></asp:Label></p>
     <p>Country:  <asp:Label ID="lblcountry" runat="server" ></asp:Label></p>
         <p>State:  <asp:Label ID="lblstate" runat="server" ></asp:Label></p>
        <p>City:  <asp:Label ID="lblcity" runat="server" ></asp:Label></p>
        <p>Status: <asp:Label ID="lblstatus" runat="server"></asp:Label></p>

</asp:Content>
