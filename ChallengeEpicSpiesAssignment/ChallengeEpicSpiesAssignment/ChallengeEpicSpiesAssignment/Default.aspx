<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;
            <asp:Image ID="logoImage" runat="server" Height="190px" />
            <br />
            <h2>Spy New Assignment Form </h2>
            <br />
            <br />
            Spy Code Name:
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name:
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date of Previous Assignment:<br />
            <asp:Calendar ID="previousAssignmentEndCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <br />
            Start Date of New Assignment:<br />
            <asp:Calendar ID="startNewAssignmentCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <br />
            Projected End Date of New Assignment:
            <br />
            <asp:Calendar ID="projectedEndNewAssignmentCalendar" runat="server"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Assign Spy" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
