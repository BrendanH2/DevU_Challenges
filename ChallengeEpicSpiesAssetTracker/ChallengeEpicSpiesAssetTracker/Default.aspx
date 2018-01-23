<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="logoImage" runat="server" Height="190px" />
        <br />
        <br />
        <h2 class="auto-style1"><strong>Asset Performance Tracker</strong></h2>
        <br />
        <br />
        Asset Name: <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:
        <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge:
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
