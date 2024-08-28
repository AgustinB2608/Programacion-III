<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2_A.aspx.cs" Inherits="TP2_Grupo_7.Ejercicio2_A" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Apellido:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Ciudad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="ddlCiudades" runat="server">
                <asp:ListItem Value="Zona norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value="Zona oeste">San Miguel</asp:ListItem>
                <asp:ListItem Value="Zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Temas:<br />
            <asp:CheckBoxList ID="cblTemas" runat="server" CssClass="auto-style1">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnResumen" runat="server" Text="Ver resumen" OnClick="btnResumen_Click" />
        </div>
    </form>
</body>
</html>
