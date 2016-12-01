<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pokehuntersUpdate.aspx.cs" Inherits="csharp3rdHandin.pokehuntersUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
</head>
<body>
    <form id="form1" runat="server" style="margin:0 auto; width:600px;">
    <div>


        <h3>Update Pokehunter</h3>


    </div>
        <p>
            <asp:ListBox ID="ListBoxHunters" runat="server" Height="210px" Width="925px"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="LabelMessage" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <asp:TextBox ID="TextBoxOldEmail" placeholder="Email to be changed" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxNewEmail" placeholder="New email name" runat="server" Width="200px"></asp:TextBox>

        <asp:Button ID="ButtonChangeEmail" runat="server" OnClick="ButtonChangeEmail_Click" Text="Change email" CssClass="success button" />
        <br />
        <br />
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go back" CssClass="button" />
    </form>
</body>
</html>
