<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KaryawanInput.aspx.cs" Inherits="SistemKaryawan.KaryawanInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td><asp:Label ID="Label4" runat="server" Text="ID"></asp:Label></td>
                <td></td>
                <td><asp:TextBox ID="TxtID" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Nama"></asp:Label></td>
                <td></td>
                <td><asp:TextBox ID="TxtNama" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Jabatan"></asp:Label></td>
                <td></td>
                <td><asp:TextBox ID="TxtJabatan" runat="server"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="Divisi"></asp:Label></td>
                <td></td>
                <td><asp:TextBox ID="TxtDivisiJabatan" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Hak Karyawan"></asp:Label></td>
                <td><asp:TextBox ID="TxtHakKaryawan" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
