<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pokehunters.aspx.cs" Inherits="csharp3rdHandin.pokehunters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/foundation/6.2.4/foundation.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin: 0 auto; width: 600px;">
    <div>
    
       <h3>Pokehunters</h3>
    
    </div>
        <asp:ListBox ID="ListBoxPokehunters" runat="server" Height="182px" Width="898px"></asp:ListBox>
        <br />
        <br />        
        <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save to file" CssClass="button" />
         &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonRead" runat="server" OnClick="ButtonRead_Click" Text="Read from file" CssClass="button" />
         <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server">You only need to save to file when creating new Pokehunter</asp:Label>
        <br />
        <br />
         <asp:Button ID="ButtonCreate" runat="server" OnClick="ButtonCreate_Click" Text="Create" CssClass="success button" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update" CssClass="warning button" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" OnClick="ButtonDelete_Click" CssClass="alert button" />

          
       
        <br />
        <br />
        <asp:Label ID="LabelLogin" runat="server" Text="You have to log in"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxName" placeholder="Alias" runat="server" Width="200px"></asp:TextBox>

        <asp:TextBox ID="TextBoxPassword" placeholder="Password" runat="server" Width="200px"></asp:TextBox>

        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" CssClass="success button" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonLogout" runat="server" OnClick="ButtonLogout_Click" Text="Logout" CssClass="alert button" />
        <br />
        <asp:Label ID="LabelMessage0" runat="server"></asp:Label>

        <br />

        <asp:Button ID="ButtonBack" runat="server" OnClick="ButtonBack_Click" Text="Go back to Frontpage" CssClass="button" />

          
       
    </form>
</body>
</html>
