<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="organizersUpdate.aspx.cs" Inherits="csharp3rdHandin.organizersUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Compressed CSS -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />

<!-- Compressed JavaScript -->
<script src="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin: 0 auto; width: 600px;">
        <h3>Update Organizers and Pokehunters</h3>
    
        <p>
            <asp:ListBox ID="ListBoxOrganizers" runat="server" Height="206px" Width="790px"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxOldEmail" placeholder="Email to be changed" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxNewEmail" placeholder="New email name" runat="server" Width="200px"></asp:TextBox>

        <asp:Button ID="ButtonChangeEmail" runat="server" Text="Change email" OnClick="ButtonChangeEmail_Click" CssClass="success button" />
        <br />
        <br />
        <asp:Button ID="ButtonBack" runat="server" Text="Go back" OnClick="ButtonBack_Click" CssClass="button" />
        </div>
    </form>
    
</body>
</html>
