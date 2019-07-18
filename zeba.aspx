<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zeba.aspx.cs" Inherits="WebApp.zeba" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <div>
       <p><asp:Label ID="lblMessage" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="Red"></asp:Label></p>
            <p>User Name : <asp:TextBox ID="txtEmail" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Password:   <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox></p>
            <p> <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click"/></p>
        </div>
      
    </form>
</body>
</html>
  </asp:Content>