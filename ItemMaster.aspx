<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ItemMaster.aspx.cs" Inherits="ItemMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script language="Javascript" type="text/javascript">

            function isNumber(evt) {
                var charCode = (evt.which) ? evt.which : event.keyCode
                if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
                    return false;

                return true;
            }
      
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<center>
<table>
<tr>
<td>
<asp:Label ID="lbl1" runat="server" Text="Item Name"></asp:Label>
</td><td>
<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lbl2" runat="server" Text="Balance Quantity"></asp:Label>
</td><td>
<asp:TextBox ID="txtBal" runat="server" onkeypress="return isNumber(event)" ></asp:TextBox>
</td>
</tr>

</table>
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" OnClientClick="isNumberKey()" />
    <asp:Button ID="Button1" runat="server" Text="Search" />
<asp:Label ID="lbl3" runat="server" Text="L" ></asp:Label>
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ItemID" DataSourceID="SqlDataSource1" 
        EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ItemID" />
            <asp:BoundField DataField="ItemName" HeaderText="ItemName" 
                SortExpression="ItemName" />
            <asp:BoundField DataField="BalanceQty" HeaderText="BalanceQty" 
                SortExpression="BalanceQty" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        SelectCommand="SELECT * FROM [ItemTable] WHERE ([ItemName] LIKE '%' + @ItemName + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="txtName" Name="ItemName" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
        DeleteCommand="DELETE FROM [ItemTable] WHERE [ItemID] = @ItemID" 
        InsertCommand="INSERT INTO [ItemTable] ([ItemName], [BalanceQty]) VALUES (@ItemName, @BalanceQty)" 
        SelectCommand="SELECT * FROM [ItemTable]" 
        UpdateCommand="UPDATE [ItemTable] SET [ItemName] = @ItemName, [BalanceQty] = @BalanceQty WHERE [ItemID] = @ItemID">
        <DeleteParameters>
            <asp:Parameter Name="ItemID" Type="Int64" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ItemName" Type="String" />
            <asp:Parameter Name="BalanceQty" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ItemName" Type="String" />
            <asp:Parameter Name="BalanceQty" Type="Int32" />
            <asp:Parameter Name="ItemID" Type="Int64" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ItemID" DataSourceID="SqlDataSource2" 
        EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="ItemID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ItemID" />
            <asp:BoundField DataField="ItemName" HeaderText="ItemName" 
                SortExpression="ItemName" />
            <asp:BoundField DataField="BalanceQty" HeaderText="BalanceQty" 
                SortExpression="BalanceQty" />
        </Columns>
    </asp:GridView>
</center>
</div>
</asp:Content>

