<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VendorMaster.aspx.cs" Inherits="VendorMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div>
<center>
<table>
<tr>
<td>
<asp:Label ID="lbl1" runat="server" Text="Vendor Name" ></asp:Label>
</td>
<td>
<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
</td><td>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="RequiredFieldValidator" ControlToValidate="txtName"></asp:RequiredFieldValidator></td>
</tr>
</table>
<br />
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
    <asp:Button ID="Button1" runat="server" Text="Search" />
    <asp:Label ID="Label1" runat="server" Text="Data Saved"></asp:Label>
</center>
<br /><center>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="VenID" DataSourceID="SqlDataSource1" EnableModelValidation="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="VenID" HeaderText="VenID" InsertVisible="False" 
                ReadOnly="True" SortExpression="VenID" />
            <asp:BoundField DataField="VendorName" HeaderText="VendorName" 
                SortExpression="VendorName" />
        </Columns>
    </asp:GridView>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="VenID" DataSourceID="SqlDataSource2" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="VenID" HeaderText="VenID" InsertVisible="False" 
                ReadOnly="True" SortExpression="VenID" />
            <asp:BoundField DataField="VendorName" HeaderText="VendorName" 
                SortExpression="VendorName" />
        </Columns>
    </asp:GridView>
    </center>

</div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        DeleteCommand="DELETE FROM [VendorTable] WHERE [VenID] = @VenID" 
        InsertCommand="INSERT INTO [VendorTable] ([VendorName]) VALUES (@VendorName)" 
        SelectCommand="SELECT * FROM [VendorTable]" 
        UpdateCommand="UPDATE [VendorTable] SET [VendorName] = @VendorName WHERE [VenID] = @VenID">
        <DeleteParameters>
            <asp:Parameter Name="VenID" Type="Int64" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="VendorName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="VendorName" Type="String" />
            <asp:Parameter Name="VenID" Type="Int64" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT * FROM [VendorTable] WHERE ([VendorName] LIKE '%' + @VendorName + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtName" Name="VendorName" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
&nbsp;
</asp:Content>

