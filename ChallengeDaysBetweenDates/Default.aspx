<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>How many days have elapsed?</h1>
        <br />
        Select one date:<br />
        <asp:Calendar ID="firstCalendar" runat="server">
            <OtherMonthDayStyle Font-Strikeout="True" ForeColor="Red" Wrap="True" />
        </asp:Calendar>
        <br />
        <br />
        Select a second date:<br />
        <asp:Calendar ID="secondCalendar" runat="server">
            <OtherMonthDayStyle Font-Strikeout="True" ForeColor="Red" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
