<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebApplication1.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:label ID="lblname" runat="server" Text="Name"></asp:label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:label ID="lblcity" runat="server" Text="City"></asp:label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
            <asp:label ID="lblsalary" runat="server" Text="Salary"></asp:label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnViewData" runat="server" Text="View" OnClick="btnViewData_Click" />
        </div>
    </form>
</body>
</html>
