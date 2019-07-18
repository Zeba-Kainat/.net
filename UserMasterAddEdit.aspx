<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserMasterAddEdit.aspx.cs" Inherits="WebApp.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="div2" runat="server" visible="true">
        <p><asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="Medium" ForeColor="blue"></asp:Label></p>
         <p>userid : <asp:TextBox ID="txtid" runat="server" TextMode="SingleLine" OnTextChanged="txtid_TextChanged"></asp:TextBox></p>
        <asp:RequiredFieldValidator runat="server" id="reqName" controltovalidate="txtid" errormessage="Please enter username!"  ForeColor="Red" Display="Dynamic"/>
    
    
   
    
   
        

    <p>First Name : <asp:TextBox ID="txtfirstname" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
        <asp:RequiredFieldValidator runat="server" id="reqfirstname" controltovalidate="txtfirstname" errormessage="Please enter firstname!"  ForeColor="Red" Display="Dynamic"/>

    <p>Middle Name : <asp:TextBox ID="txtmiddlename" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
     <p>Last Name : <asp:TextBox ID="txtlastname" runat="server" TextMode="SingleLine" ></asp:TextBox></p>
        <asp:RequiredFieldValidator runat="server" id="reqlastname" controltovalidate="txtlastname" errormessage="Please enter lastname!"  ForeColor="Red" Display="Dynamic"/>



   <p>Gender :
       <asp:Radiobuttonlist ID="rdbGender" runat="server">
             <asp:listitem Text="Male" ></asp:listItem>
               <asp:listitem Text="Female" ></asp:listitem> 
       </asp:Radiobuttonlist>
   </p>
<asp:RequiredFieldValidator runat="server" id="reqgender" controltovalidate="rdbGender" errormessage="Please enter gender!"  ForeColor="Red" Display="Dynamic"/>


         <p>Competency:
                  <asp:DropDownList ID="ddlcompetency" runat="server" AutoPostBack="true"  AppendDataBoundItems="true">
               
            </asp:DropDownList>
        </p>
<asp:RequiredFieldValidator id="reqcompetency" Text="(Required)" InitialValue="none" ControlToValidate="ddlcompetency" Runat="server" /> 

        <p> Country:
             <asp:DropDownList ID="ddlcountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" >  
                <asp:listitem Text="--country--" Value="0" />
            </asp:DropDownList>
        </p>
<asp:RequiredFieldValidator runat="server" id="reqcountry"   controltovalidate="ddlcountry" errormessage="Please enter country!"  ForeColor="Red" Display="Dynamic"/>

        <p>State:
             <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="true" onselectedindexchanged="ddlstate_SelectedIndexChanged">
                 <asp:listitem Text="--state--" Value="0"/>
             </asp:DropDownList>
        </p>
<asp:RequiredFieldValidator runat="server" id="reqstate" controltovalidate="ddlstate" errormessage="Please enter state!"  ForeColor="Red" Display="Dynamic"/>
        <p>City:
             <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="true">
                <asp:listitem Text="--city--" Value="0"/>
             </asp:DropDownList>
        </p>
<asp:RequiredFieldValidator runat="server" id="reqcity" controltovalidate="ddlcity" errormessage="Please enter city!"  ForeColor="Red" Display="Dynamic"/>

        <p>Status:
             <asp:DropDownList ID="ddlstatus" runat="server" AutoPostBack="false">
                <asp:listitem Text="--select--" Value="0"/>
             </asp:DropDownList>
        </p>
<asp:RequiredFieldValidator runat="server" id="reqstatus" controltovalidate="ddlstatus" errormessage="Please enter status!"  ForeColor="Red" Display="Dynamic"/>


<p> <asp:Button ID="btn_save" runat="server" Text="Save" onclick="btn_save_Click"/>
 <asp:Button ID="btn_reset" runat="server" Text="Reset" OnClick="btn_reset_Click"/>
    <asp:Button ID="btn_update" runat="server" Text="Update" Visible="false" OnClick="btn_update_Click"/></p>


    </div>
</asp:Content>
