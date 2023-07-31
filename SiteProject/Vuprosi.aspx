<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Vuprosi.aspx.cs" Inherits="WebSiteSofiaUni.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="Въпроси"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Моля, задайте своя въпрос тук:"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Height="161px" Width="691px"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="Вашият е-мейл:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Width="216px"></asp:TextBox> <asp:Button ID="Button2" runat="server" Text="Изпращане" />
    <br />
    <asp:Label ID="Label5" runat="server" Font-Italic="True" Font-Size="Small" Text="**Ще получите отговор до 2 работни дни"></asp:Label>
    <br />
    
</asp:Content>
