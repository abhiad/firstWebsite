<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DepartmentMaster.aspx.cs" Inherits="DepartmentMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<center>

<asp:Table ID="table" runat="server" CellSpacing="2" CellPadding="2" HorizontalAlign="Center" BorderStyle="Dotted">
<asp:TableRow>
<asp:TableCell>
Department Name
</asp:TableCell><asp:TableCell>
   
</asp:TableCell>
</asp:TableRow>


</asp:Table>
<table>
<tr><td> <asp:TextBox runat="server" id="txtName" >
    </asp:TextBox></td></tr>
</table>
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
    <asp:Button
    ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT * FROM [DepartmentTable]" 
        DeleteCommand="DELETE FROM [DepartmentTable] WHERE [DeptId] = @DeptId" 
        InsertCommand="INSERT INTO [DepartmentTable] ([DepartmentName]) VALUES (@DepartmentName)" 
        UpdateCommand="UPDATE [DepartmentTable] SET [DepartmentName] = @DepartmentName WHERE [DeptId] = @DeptId">
        <DeleteParameters>
            <asp:Parameter Name="DeptId" Type="Int64" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="DepartmentName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="DepartmentName" Type="String" />
            <asp:Parameter Name="DeptId" Type="Int64" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        
        SelectCommand="SELECT * FROM [DepartmentTable] WHERE ([DepartmentName] LIKE '%' + @DepartmentName + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtName" Name="DepartmentName" 
                PropertyName="Text" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</center>
<center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="DeptId" DataSourceID="SqlDataSource1" 
        EnableModelValidation="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="DeptId" HeaderText="DeptId" InsertVisible="False" 
                ReadOnly="True" SortExpression="DeptId" />
            <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" 
                SortExpression="DepartmentName" />
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="DeptId" DataSourceID="SqlDataSource2" 
        EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="DeptId" HeaderText="DeptId" InsertVisible="False" 
                ReadOnly="True" SortExpression="DeptId" />
            <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" 
                SortExpression="DepartmentName" />
        </Columns>
    </asp:GridView>
</center>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Enter Department Name" ControlToValidate="txtName"></asp:RequiredFieldValidator>
</div>
</asp:Content>

