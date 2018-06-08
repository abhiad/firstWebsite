<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ItemTransaction.aspx.cs" Inherits="ItemTransaction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<center>
<table border="2" cellpadding="4" cellspacing="4">
<tr>
<td>
<asp:Label ID="lbl1" runat="server" Text="Transaction Mode"></asp:Label>
</td>
<td>
<asp:DropDownList ID="ddl" runat="server" 
        onselectedindexchanged="ddl_SelectedIndexChanged" AutoPostBack="True">
<asp:ListItem>Purchase</asp:ListItem>
<asp:ListItem>Issue</asp:ListItem>

</asp:DropDownList>
</td><td><asp:Label ID="lblNo" runat="server" Text="Purchase/Issue No."></asp:Label></td><td>
    <asp:Label ID="lblpurchno" runat="server" Text="purc"></asp:Label>
    <asp:Label ID="LblIssueNo" runat="server" Text="issue"></asp:Label></td>

<td><asp:Label ID="Label4" runat="server" Text="Date"></asp:Label></td>
<td><asp:Label ID="Label5" runat="server" Text="Date"></asp:Label></td></tr>
<tr>
<td>
<asp:Label ID="Label1" runat="server" Text="Vendor / Department"></asp:Label>
</td>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server" 
        DataSourceID="SqlDataSource1" DataTextField="VendorName" DataValueField="VenID">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server" 
        DataSourceID="SqlDataSource2" DataTextField="DepartmentName" 
        DataValueField="DeptId">
    </asp:DropDownList>
</td>
<td><asp:Label ID="Label2" runat="server" Text="Item Name"></asp:Label></td>
<td>
    <asp:DropDownList ID="DropDownList3" runat="server" 
        DataSourceID="SqlDataSource3" DataTextField="ItemName" DataValueField="ItemID">
    </asp:DropDownList>
    </td><td><asp:Label ID="lblItem" runat="server" Text="Quantity"></asp:Label></td><td><asp:TextBox ID="txtQty" runat="server"></asp:TextBox></td>
</tr>
</table>
<br />
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource4" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="ItemName" HeaderText="ItemName" 
                SortExpression="ItemName" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
                SortExpression="Quantity" />
            <asp:BoundField DataField="DepartmentName" HeaderText="DepartmentName" 
                SortExpression="DepartmentName" />
            <asp:BoundField DataField="VendorName" HeaderText="VendorName" 
                SortExpression="VendorName" />
            <asp:BoundField DataField="Mode" HeaderText="Mode" SortExpression="Mode" />
        </Columns>
    </asp:GridView>
</center>
</div>
<div>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT * FROM [VendorTable]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT * FROM [DepartmentTable]"></asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT [ItemID], [ItemName] FROM [ItemTable]">
    </asp:SqlDataSource>

    <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT ItemTable.ItemName, ItemTransaction.Quantity, DepartmentTable.DepartmentName, VendorTable.VendorName, ItemTransaction.Mode FROM ItemTransaction INNER JOIN ItemTable ON ItemTransaction.ItemID = ItemTable.ItemID INNER JOIN VendorTable ON ItemTransaction.VendorID = VendorTable.VenID INNER JOIN DepartmentTable ON ItemTransaction.DepartmentID = DepartmentTable.DeptId">
    </asp:SqlDataSource>

</div>

</asp:Content>

