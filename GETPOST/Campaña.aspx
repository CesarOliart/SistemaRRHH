<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.master" CodeBehind="Campaña.aspx.vb" Inherits="GETPOST.Campaña" %>
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
               <td ><asp:Label runat="server" Text="Empresa :"></asp:Label></td>
               <td><asp:Dropdownlist runat="server" Id="cboEmpresa" ></asp:Dropdownlist></td>
           </tr>
        <tr>
            <td colspan ="2">
                <asp:Button runat="server" Id ="btnAceptar" />
            </td>
        </tr>
    </table>
</asp:Content>
