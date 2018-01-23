<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalendarChallenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Select a Date:
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <br />
            <br />
            Please Select Another Date:<br />
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Math" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
