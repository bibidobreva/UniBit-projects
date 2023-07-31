<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Studenti.aspx.cs" Inherits="WebSiteSofiaUni.Студенти" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="Академичен календар"></asp:Label>
    <br />
    
    <asp:TextBox ID="TextBox2" runat="server" Height="230px" TextMode="MultiLine" Width="696px" ReadOnly="True" AutoPostBack="True" BackColor="#EBF2FC" Enabled="False" EnableTheming="False" EnableViewState="False" ValidateRequestMode="Disabled" Wrap="False">Учебна година 2022/2023

 

ЗАПОВЕД № РД 19-174 / 26.05.2022 г.

На основание чл. 39, ал. 2 от Закона за висше образование

НАРЕЖДАМ

учебната 2022/2023 година да протече при следния график на учебния процес</asp:TextBox>
    <br />
    
    <asp:Label ID="Label5" runat="server" Text="I. Зимен семестър" Font-Bold="True"></asp:Label>
    <br />
    <asp:Table ID="Table1" runat="server" BorderStyle="Solid" BorderWidth="1px" Height="61px" Width="98px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True">ПРОДЪЛЖИТЕЛНОСТ НА ЗИМНИЯ СЕМЕСТЪР</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True">ИЗПИТНА СЕСИЯ</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">РЕДОВНО ОБУЧЕНИЕ  03.10.2022 - 20.01.2023</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">23.01.2023 - 17.02.2023 </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">ЗАДОЧНО ОБУЧЕНИЕ 05.09.2022 - 30.09.2022</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">07.11.2022 - 02.12.2022</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <br />
    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="II. Летен семестър"></asp:Label>
    <br />
    <asp:Table ID="Table2" runat="server" BorderStyle="Solid" BorderWidth="1px" Width="301px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True">ПРОДЪЛЖИТЕЛНОСТ НА ЛЕТНИЯ СЕМЕСТЪР</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True">ИЗПИТНА СЕСИЯ</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">РЕДОВНО ОБУЧЕНИЕ 20.02.2023 - 09.06.2023</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">12.06.2023 - 07.07.2023 </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">ЗАДОЧНО ОБУЧЕНИЕ 23.01.2023 - 17.02.2023</asp:TableCell>
            <asp:TableCell runat="server" BorderStyle="Solid" BorderWidth="1px">20.03.2023 - 07.04.2023</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
