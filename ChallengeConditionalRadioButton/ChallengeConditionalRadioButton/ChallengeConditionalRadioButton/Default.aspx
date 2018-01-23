<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeConditionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preferences:<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="writingTool" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="writingTool" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="writingTool" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="writingTool" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Image ID="resultImage" runat="server" />
        </p>
    </form>
</body>
</html>
