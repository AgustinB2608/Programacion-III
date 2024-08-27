<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo_7.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 20%;
            border-collapse: collapse;
        }
        .auto-style2 {
            width: 15%;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 108px;
        }
        .auto-style5 {
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp; Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad1" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Ingrese nombre del producto:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtProducto2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCantidad2" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="BtnAceptar" runat="server" Text="Generar Tabla" OnClick="BtnAceptar_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        
    </form>
</body>
</html>
