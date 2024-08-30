<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_Grupo_7.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <div>
            Seleccione accesorios:<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
                <asp:ListItem>HD 500GB</asp:ListItem>
                <asp:ListItem>Grabador DVD</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
