<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orgranizersCreate.aspx.cs" Inherits="csharp3rdHandin.orgranizersCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; width: 600px;">
    <h3>Create a new Organizer</h3>

        <asp:TextBox ID="TextBoxAlias" placeholder="Alias" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxName" placeholder="Name" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxAge" placeholder="Age" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxPassword" placeholder="Password" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxEmail" placeholder="Email" runat="server" Width="200px"></asp:TextBox>

        <asp:Button ID="ButtonAdd" runat="server" Text="Add new Organizer" OnClick="ButtonAdd_Click" CssClass="success button" />
    <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
    
        <asp:Button ID="ButtonBack" runat="server" Text="Go back" OnClick="ButtonBack_Click" CssClass="button" />
    </form>
</body>
</html>
