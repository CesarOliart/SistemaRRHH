<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="Empresa.aspx.vb" Inherits="GETPOST.Empresa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
        <td>
           <asp:Label runat="server" Text="Descripcion" />
        </td>
            <td
                >
                <asp:TextBox runat="server" Id="txtDescripcion" />
            </td>
            </tr>
        <tr>
            <td colspan ="2">
                <asp:Button runat="server" Id ="btnAceptar" />
            </td>
        </tr>
    </table>
</asp:Content>
