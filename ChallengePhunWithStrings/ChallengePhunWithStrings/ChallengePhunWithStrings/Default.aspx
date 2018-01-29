<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Challenge 1</h3>
            <br />
            Enter a Value below<br />
            <asp:TextBox ID="challenge1TextBox" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="resultLabel1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <h3>Challenge 2</h3>
            <p>Please enter a value in each box below</p>
            <asp:TextBox ID="challenge2TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge2TextBox2" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge2TextBox3" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge2TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="challenge2Button" runat="server" Text="OK! Challenge 2" OnClick="challenge2Button_Click" />
            <br />
            <br />
            <asp:Label ID="challenge2Label" runat="server"></asp:Label>
            <br />
            <br />
            <h3>Challenge 3</h3>
            <asp:TextBox ID="challenge3TextBox1" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge3TextBox2" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge3TextBox3" runat="server"></asp:TextBox>
&nbsp;
            <asp:TextBox ID="challenge3TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="challenge3Button" runat="server" OnClick="challenge3Button_Click" Text="OK! Challenge 3" />
            <br />
            <br />
            <asp:Label ID="challenge3Label" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <h3>Challenge 4 </h3>
            NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID ZHEIR COUNZRY.<br />
            <br />
            <asp:Button ID="challenge4Button" runat="server" Text="OK! Challenge 4" OnClick="challenge4Button_Click" />
            <br />
            <asp:Label ID="challenge4Label" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
