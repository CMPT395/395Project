<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HoursCollection.aspx.vb" Inherits="HoursCollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <strong>Monthly Hours Submission Form</strong><br />
            <br />
            Please enter your Contractor ID number<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Please enter the number of hours worked this month.<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submitButton" runat="server" Text="Submit" />

        </div>
    </form>
</body>
</html>
