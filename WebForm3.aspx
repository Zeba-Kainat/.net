<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div>
     <p><asp:Label ID="lblMessage" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="Red"></asp:Label></p>
            <p>Employee Name : <asp:TextBox ID="txtname" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Employee address: <asp:TextBox ID="txtadd" runat="server" TextMode="Multiline"></asp:TextBox></p>
            <p>city : <asp:TextBox ID="TextBox1" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Mobile:   <asp:TextBox ID="TextBox2" runat="server" TextMode="singleline"></asp:TextBox></p>
            <p>Email : <asp:TextBox ID="TextBox3" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Date Of Joining : <asp:TextBox ID="TextBox4" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Grade: <asp:TextBox ID="TextBox5" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            
    <p>Department : <asp:Dropdownlist ID="ddldept" runat="server" AutoPostBack="true">
                <asp:listitem Text="--select--" Value="0"/>
                <asp:listitem Text="Finance" Value="FIN"/>
                <asp:listitem Text="Technical" Value="TECH"/>
                <asp:listitem Text="Analyst" Value="ANA"/>
                 </asp:Dropdownlist>
                </p>

             
            <p>Designation : <asp:TextBox ID="TextBox7" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
            <p>Gender :<asp:Radiobuttonlist ID="rdbGender" runat="server">
               <asp:listitem Text="Male" Value="M"></asp:listItem>
               <asp:listitem Text="Female" Value="F"></asp:listitem>
                   </asp:Radiobuttonlist>
           </p>
   <p>Profile Picture  :  <asp:FileUpload ID="file1" runat="server" />
    
    <asp:Image ID="img1" runat="server"/>
    </p>       

             <p>Salary : <asp:TextBox ID="TextBox10" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
    <p> <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />

    </p>
              </div>
      
               </asp:Content>







