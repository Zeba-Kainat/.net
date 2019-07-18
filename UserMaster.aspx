<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserMaster.aspx.cs" Inherits="WebApp.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<br /><br />
    <h1>List of employee</h1>
     <p> <asp:Button ID="create" runat="server" Text="create" OnClick="create_Click"/>

          <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="grid1_RowCommand" OnRowDeleting="grid1_RowDeleting" DataKeyNames="usercode">    
              <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
  <Columns> 
      
 <asp:TemplateField>
                <HeaderTemplate>
                    User ID
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:TextBox ID="txtid" runat="server" Text= <%#Bind("userid") %>></asp:TextBox>
                

                </ItemTemplate>
          
            </asp:TemplateField>

 <asp:TemplateField>
                <HeaderTemplate>
                    First Name
                </HeaderTemplate>
                <ItemTemplate>
                          <asp:TextBox ID="txtfirstname" runat="server" Text=  '<%#Bind("firstname") %>'></asp:TextBox>
                </ItemTemplate>
          
            </asp:TemplateField>

 <asp:TemplateField>
                <HeaderTemplate>
                    Last Name
                </HeaderTemplate>
                <ItemTemplate>
                         <asp:TextBox ID="txtlastname" runat="server" Text=  <%#Bind("lastname") %>></asp:TextBox>
                </ItemTemplate>
          
            </asp:TemplateField>
 <asp:TemplateField>
                <HeaderTemplate>                                                                                                                                                                                                                                                                                                                                           
                    Competency
                </HeaderTemplate>
                <ItemTemplate>
 <asp:TextBox ID="txtcompetencyname" runat="server" Text=  <%#Bind("competencyname") %>></asp:TextBox>
                </ItemTemplate>
          
            </asp:TemplateField> 
      
       <asp:TemplateField>
                <HeaderTemplate>
                    Action
                </HeaderTemplate>
                <ItemTemplate>
                   <asp:LinkButton ID="btnView" runat="server"  CommandName="View" CommandArgument='<%#Eval("usercode")%>'>View</asp:LinkButton>
                     <asp:LinkButton ID="btnEdit" commandname="Edit" CommandArgument='<%#Eval("usercode")%>' runat="server" >Edit</asp:LinkButton>
                      <asp:LinkButton ID="btnDelete" runat="server"  CommandName="Delete">Delete</asp:LinkButton>
  </ItemTemplate>
  </asp:TemplateField>
  </Columns>
          
 </asp:GridView>

</asp:Content>
