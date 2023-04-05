<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertStudent.aspx.cs" Inherits="YourNamespace.InsertStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Student</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Insert New Student</h2>
            <label for="txtName">Name: </label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            <label for="txtAddress">Address: </label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />
            <label for="txtEmail">Email: </label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />
            <label for="txtMobile">Mobile No: </label>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox><br /><br />
            <label for="rblGender">Gender: </label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Text="Male" Value="M"></asp:ListItem>
                <asp:ListItem Text="Female" Value="F"></asp:ListItem>
            </asp:RadioButtonList><br /><br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>
