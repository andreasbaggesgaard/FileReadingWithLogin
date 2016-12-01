<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pokehuntersDelete.aspx.cs" Inherits="csharp3rdHandin.pokehuntersDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; width:500px;">
 
        <h3>Delete Pokéhunter</h3>
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Red"></asp:Label>

        <asp:ListBox ID="ListBoxPokehunters" runat="server" Height="189px" Width="809px"></asp:ListBox>
        <p>
            <asp:TextBox ID="TextBoxAlias" placeholder="Alias to be deleted" runat="server" Width="200px"></asp:TextBox>

            <asp:Button ID="ButtonDelete" runat="server" OnClick="ButtonDelete_Click" Text="Delete pokehunter" CssClass="alert button" />
        </p>
        <p>
            <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go back" CssClass="button" />
        </p>


    
  
    </form>
</body>
</html>
