<%@ Page Language="C#" AutoEventWireup="true" CodeFile="carinfo.aspx.cs" Inherits="carinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Make"></asp:Label>
            <asp:TextBox ID="TextBox_make" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Model"></asp:Label>
            <asp:TextBox ID="TextBox_model" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="TextBox_price" runat="server"></asp:TextBox>
        </p>
        <p>
            
            <asp:Label ID="Label4" runat="server" Text="MPG"></asp:Label>
            
            <asp:TextBox ID="TextBox_mpg" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Insert_Car" runat="server" Text="Add Car" OnClick ="Add_Car" Redirect ="Default.aspx "/>
        </p>
    </form>
</body>
</html>
