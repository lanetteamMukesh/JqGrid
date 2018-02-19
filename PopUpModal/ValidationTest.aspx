<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationTest.aspx.cs" Inherits="ValidationTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" novalidate>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" required></asp:TextBox>
      <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required..." ControlToValidate="TextBox1"></asp:RequiredFieldValidator>--%>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
