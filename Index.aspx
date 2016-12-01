<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="csharp3rdHandin.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <!-- Compressed CSS -->
<link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />

<!-- Compressed JavaScript -->
<script src="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; width: 600px;">
    
        <img src="pokemon_go_logo.png" width="400" />
        <br />
        <br />
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="ButtonPokehunters" runat="server" OnClick="ButtonPokehunters_Click" Text="Pokehunters" CssClass="button" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="ButtonOrganizers" runat="server" OnClick="ButtonOrganizers_Click" Text="Organizers" CssClass="button" />
        <br />
        <br />

    </form>
</body>
</html>
