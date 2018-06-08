<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Purchase.aspx.cs" Inherits="Purchase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<br />
<div style="text-align: center">
<asp:Label ID="Label2" runat="server" Text="Purchase" Font-Size="Larger" 
        ForeColor="#FF0066"></asp:Label>
</div>
<br />
<div>

    <table class="style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblDate" runat="server" Text="Date"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="P No."></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPno" runat="server" Text="P No."></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Vendor"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    DataSourceID="SqlDataSource1" DataTextField="VendorName" DataValueField="VenID">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Item Name"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    DataSourceID="SqlDataSource2" DataTextField="ItemName" DataValueField="ItemID">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lbl_BQty" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" onclick="btnSave_Click" Text="SAVE" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
                    SelectCommand="SELECT * FROM [VendorTable]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:StockDBConnectionString %>" 
                    SelectCommand="SELECT [ItemID], [ItemName] FROM [ItemTable]">
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</div>
</asp:Content>

