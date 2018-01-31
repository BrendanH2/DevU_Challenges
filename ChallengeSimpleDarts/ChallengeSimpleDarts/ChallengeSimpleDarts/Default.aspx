<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="okButton" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
