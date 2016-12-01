<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="organizersDelete.aspx.cs" Inherits="csharp3rdHandin.organizersDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; width: 600px;">
     
        <h3>Delete Organizers and Pokehunters</h3>

        <asp:Label ID="LabelMessage" runat="server"></asp:Label>

        <asp:ListBox ID="ListBoxOrganizers" runat="server" Height="189px" Width="780px" style="margin-right: 0px"></asp:ListBox>
        <p>
            <asp:TextBox ID="TextBoxAlias" placeholder="Alias to be deleted" runat="server" Width="200px"></asp:TextBox>

            <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" CssClass="alert button" />
        </p>
            <asp:Button ID="ButtonBack" runat="server" Text="Go back" OnClick="ButtonBack_Click" CssClass="button" />

    </form>
</body>
</html>
