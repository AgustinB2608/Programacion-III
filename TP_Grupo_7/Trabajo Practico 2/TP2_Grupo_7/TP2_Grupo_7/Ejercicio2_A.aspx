<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2_A.aspx.cs" Inherits="TP2_Grupo_7.Ejercicio2_A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Ciudad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Gral. Pacheco</asp:ListItem>
                <asp:ListItem>San Miguel</asp:ListItem>
                <asp:ListItem>Boedo</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
