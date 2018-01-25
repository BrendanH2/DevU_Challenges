<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calcuator<br />
            <br />
            Width:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Heigth:&nbsp;
            <asp:TextBox ID="heigthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            Length:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
            <br />
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
            <br />
            <asp:RadioButton ID="nextDayRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingMethod" OnCheckedChanged="nextDayRadioButton_CheckedChanged" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
