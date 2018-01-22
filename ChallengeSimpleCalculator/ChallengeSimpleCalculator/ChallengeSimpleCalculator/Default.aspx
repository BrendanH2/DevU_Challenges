<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Simple Calulator</h2>
            <br />
            <span class="auto-style1">First Value:&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="value1TextBox" runat="server" Width="140px"></asp:TextBox>
            <br />
            <br />
            <span class="auto-style1">Second Value:</span>&nbsp;
            <asp:TextBox ID="value2TextBox" runat="server" Width="139px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" Height="55px" OnClick="additionButton_Click" style="font-weight: 700; font-size: x-large" Text="+" Width="55px" />
&nbsp;
            <asp:Button ID="subtractionButton" runat="server" Height="55px" OnClick="subtractionButton_Click" style="font-weight: 700; font-size: x-large" Text="-" Width="55px" />
&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" Height="55px" OnClick="multiplicationButton_Click" style="font-weight: 700; font-size: x-large" Text="*" Width="55px" />
&nbsp;
            <asp:Button ID="divisionButton" runat="server" Height="55px" OnClick="divisionButton_Click" style="font-weight: 700; font-size: x-large" Text="/" Width="55px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; font-size: large; background-color: #99CCFF"></asp:Label>
        </div>
    </form>
</body>
</html>
