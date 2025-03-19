<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PACIENTES.aspx.cs" Inherits="CLINICAUH.Views.PACIENTES" %>


<!DOCTYPE html>
<html>
<head>
    <title>Gestión de Pacientes</title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body>
    <form runat="server">
        <h2>Lista de Pacientes</h2>
        <asp:GridView ID="gridPacientes" runat="server"></asp:GridView>
        <br />
        <asp:Button ID="btnCargar" runat="server" Text="Cargar Pacientes" OnClick="btnCargar_Click" />
    </form>
</body>
</html>

