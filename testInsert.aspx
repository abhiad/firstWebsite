<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testInsert.aspx.cs" Inherits="testInsert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<center>
<table><tr>
<td>
<asp:Label ID="lbl1" runat="server" Text="Name"></asp:Label>
</td>
<td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
</tr>
    <tr>
<td>
<asp:Label ID="lbl2" runat="server" Text="Name"></asp:Label>
</td>
<td><asp:TextBox ID="txtmob" runat="server"></asp:TextBox></td>
</tr>
</table>
<br />
<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click" />

</center>    
    </div>
    </form>
</body>
</html>
