<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApp.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
     <p><asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="blue"></asp:Label></p>

<p>username : <asp:TextBox ID="txt1" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
    <p>First Name : <asp:TextBox ID="txt2" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
     <p>Last Name : <asp:TextBox ID="txt3" runat="server" TextMode="SingleLine" ></asp:TextBox></p>

        <p>Gender :<asp:Radiobuttonlist ID="rdbGender" runat="server">
               <asp:listitem Text="Male" Value="M"></asp:listItem>
               <asp:listitem Text="Female" Value="F"></asp:listitem>
               </asp:Radiobuttonlist>
        </p>

        <p> Country:
            <asp:DropDownList ID="ddlcountry" runat="server" AutoPostBack="true" >
                <asp:listitem Text="--country--" Value="0" />
               
                
            </asp:DropDownList>
        </p>
        <p>State:
            
            <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="true" >
                     <asp:listitem Text="--state--" Value="0"/>
                
                </asp:DropDownList>
        </p>
        <p>City:
            
            <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="true">
                <asp:listitem Text="--city--" Value="0"/>
                </asp:DropDownList>
        </p>

      
        <p>Technology(select only one):
            <asp:CheckBoxList ID="cbltech" runat="server" >
                <asp:listitem Text="SQL" Value="sql"/>
                 <asp:listitem Text="ASP.NET" Value=".net"/>
                 <asp:listitem Text="ADO.NET" Value="ado"/>
                 <asp:listitem Text="PYTHON" Value="py"/>
            </asp:CheckBoxList>
        </p>


<p> <asp:Button ID="btnsave" runat="server" Text="Save" onclick="btnsave_Click"/></p>



    </div>

</asp:Content>
