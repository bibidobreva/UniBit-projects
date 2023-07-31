<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Priem.aspx.cs" Inherits="WebSiteSofiaUni.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <center>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="318px" ImageAlign="AbsMiddle" ImageUrl="~/Pictures/ksk_2023.jpg" PostBackUrl="~/BakavavurProgrami.aspx" Width="208px" BorderColor="White" BorderStyle="Ridge" BorderWidth="20px" />
        <asp:ImageButton ID="ImageButton2" runat="server" Height="313px" ImageAlign="AbsMiddle" PostBackUrl="~/MagisturskiProgrami.aspx" Width="218px" BorderColor="White" BorderStyle="Ridge" BorderWidth="20px" ImageUrl="~/Pictures/21111111111111111111111111.jpg" /> </center>
    <br />
        <center>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/GodishniTaksi.aspx">Годишни такси за учебната 2022/2023 г.</asp:HyperLink></center>
    </p>
</asp:Content>
