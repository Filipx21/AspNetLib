<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbName" runat="server" Height="42px" OnTextChanged="tbName_TextChanged" Width="286px" AutoPostBack="True"></asp:TextBox>
            <br />
            <asp:Button ID="btn1" runat="server" Height="41px" OnClick="Button1_Click" Text="Button" Width="139px" />
        </div>
    </form>
</body>
</html>
