<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="WebApplication1.Test2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label id="lblMessage" runat="server" Font-Bold="true"></asp:label>
            <asp:GridView ID="grid" runat="server" Width="65%"></asp:GridView>
        </div>
    </form>
</body>
</html>
