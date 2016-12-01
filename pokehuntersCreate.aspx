<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pokehuntersCreate.aspx.cs" Inherits="csharp3rdHandin.pokehuntersCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin:0 auto; width: 600px;">
    <div>
        <h3>Create a new Pokehunter</h3>
        <asp:TextBox ID="TextBoxAlias" placeholder="Alias" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxName" placeholder="Name" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxAge" placeholder="Age" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxPassword" placeholder="Password" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxEmail" placeholder="Email" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxFavPokemon" placeholder="Favourite Pokémon" runat="server" Width="200px"></asp:TextBox>

        <asp:Button ID="ButtonAdd" runat="server" Text="Add new Pokehunter" OnClick="ButtonAdd_Click" CssClass="success button" />
    
    </div>
        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go back" CssClass="button" />
    </form>
</body>
</html>
