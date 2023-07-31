<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SportGallery.aspx.cs" Inherits="WebSiteSofiaUni.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="190px" BackColor="#FFFFCE" align="center">
        <asp:Image ID="Image6" runat="server" Height="190px" ImageAlign="Middle" ImageUrl="~/Pictures/dzhudo_1_reference.jpg" Width="242px" />
        
        <asp:Image ID="Image7" runat="server" Height="190px" ImageAlign="Middle" ImageUrl="~/Pictures/basketbol_2_reference.jpg" Width="200px" />
        
    </asp:Panel>
     <asp:Panel ID="Panel3" runat="server" Height="190px" BackColor="#FFD2F0" align="center">
         
         <asp:Image ID="Image3" runat="server" Height="190px" ImageUrl="~/Pictures/majoretki_1_reference.jpg" Width="231px" ImageAlign="Middle" />
         <asp:Image ID="Image4" runat="server" Height="190px" ImageUrl="~/Pictures/1_a_reference.jpg" Width="230px" ImageAlign="Middle" ValidateRequestMode="Enabled" />
         <asp:Image ID="Image5" runat="server" Height="190px" ImageUrl="~/Pictures/3_imagelarge.jpg" Width="171px" ImageAlign="Middle" />
        
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" BackColor="#D2F4FF" Height="190px" align="center">
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/Pictures/viber_image_2023_05_02_20_55_30_587_reference.jpg" Width="273px" ImageAlign="Middle" />
        <asp:Image ID="Image2" runat="server" Height="190px" ImageUrl="~/Pictures/viber_image_2023_05_02_20_55_24_025_reference.jpg" Width="271px" ImageAlign="Middle" />
        </asp:Panel>
</asp:Content>
