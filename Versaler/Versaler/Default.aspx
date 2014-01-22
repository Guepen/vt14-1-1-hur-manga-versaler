<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Versaler!</h1>
        <asp:TextBox ID="Input" runat="server" TextMode="MultiLine"></asp:TextBox>
        <p></p>
        <asp:Label ID="Outmessage" runat="server" Text=""></asp:Label>
        <p></p>
        <asp:Button ID="Check" runat="server" Text="Bestän antalet versaler" OnClick="SendClick" />
        <asp:Button ID="Clear" runat="server" Text="Clear" OnClick ="ClearClick "/>
    </div>
    </form>
</body>
</html>
