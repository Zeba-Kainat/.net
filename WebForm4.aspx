<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApp.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <br /><br />
    <h1>List of employee</h1>
    
    <asp:GridView ID="grid1" runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowEditing="grid1_RowEditing" OnRowCancelingEdit="grid1_RowCancelingEdit" OnRowUpdating="grid1_RowUpdating">
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
                    Employee Name
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Eval("emp_name") %>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtName" runat="server" Text= <%#Bind("emp_name") %>></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

              <asp:TemplateField>
                <HeaderTemplate>
                    Employee Email
                </HeaderTemplate>
                <ItemTemplate>
              <asp:Label ID="Label1" runat="server" Text='<%#Eval("email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <HeaderTemplate>
                    Contact#
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Eval("Mobile") %>
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:TextBox ID="txtMobile" runat="server" Text= <%#Bind("Mobile") %>></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <HeaderTemplate>
                    Gender
                </HeaderTemplate>
                <ItemTemplate>
                    <%#Eval("Gender") %>
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField>
              
                <ItemTemplate>
                    <img src='<%#Eval("Profile_picture")%>' title="click me" />
                   
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField>
                <HeaderTemplate>
                    Action
                </HeaderTemplate>
                <ItemTemplate>
                   <asp:LinkButton ID="btnEdit" runat="server"  CommandName="Edit">Edit</asp:LinkButton>
                    
                </ItemTemplate>
                 <EditItemTemplate>
                      <asp:LinkButton ID="btnUpdate" runat="server"  CommandName="Update">Update</asp:LinkButton>
                      <asp:LinkButton ID="btnCancel" runat="server"  CommandName="Cancel">Cancel</asp:LinkButton>
                 </EditItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>


</asp:Content>
