<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DividirCadena(si).aspx.cs" Inherits="Ej_LlenarDDL.DividirCadena_si_" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox><br />
        <asp:Label ID="lblcantmails" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lblresulta" runat="server" Text=""></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:GridView ID="gvlista" runat="server">
        </asp:GridView>
        <asp:GridView ID="gvcoincid" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
