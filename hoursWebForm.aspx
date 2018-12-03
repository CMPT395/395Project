<%@ Page Language="VB" %>

<!DOCTYPE html>
<script runat="server">

    Protected Sub submitButton_Click(sender As Object, e As EventArgs)

    End Sub
</script>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        Monthly Hour Submission Form<br />
        <br />
        Please enter the numbers of hours worked this month.<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" Width="87px" />
        <br />
    </form>
</body>
</html>
