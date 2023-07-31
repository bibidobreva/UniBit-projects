<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ZashtitaNaLichniteDanni.aspx.cs" Inherits="WebSiteSofiaUni.ЗащитаНаЛичнитеДанниaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        margin-left: 0px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="Защита на личните данни"></asp:Label>
<br />
    <br>
    <br>
<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.uni-sofia.bg/index.php/bul/content/download/194346/1332652/version/1/file/%D0%97%D0%B0%D0%BF%D0%BE%D0%B2%D0%B5%D0%B4+%D0%B4%D0%BB%D1%8A%D0%B6%D0%BD%D0%BE%D1%81%D1%82%D0%BD%D0%BE+%D0%BB%D0%B8%D1%86%D0%B5+%D0%BB%D0%B8%D1%87%D0%BD%D0%B8+%D0%B4%D0%B0%D0%BD%D0%BD%D0%B8.pdf">Заповед на Ректора на Софийски университет &quot;Св. Кл. Охридски&quot; за определяне на длъжностно лице за защита на личните данни</asp:HyperLink>
<br />
    <br>
<asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Информация относно длъжностното лице по защита на личните данни"></asp:Label>
<br />

<asp:Table ID="Table1" runat="server" BorderStyle="Solid" BorderWidth="1px" CssClass="auto-style8" Height="61px" Width="508px">
    <asp:TableRow runat="server" BorderStyle="Solid">
        <asp:TableCell runat="server" BorderWidth="1px">Име</asp:TableCell>
        <asp:TableCell runat="server" BorderWidth="1px" ColumnSpan="1">проф. д-р Елиза Стефанова </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" BorderStyle="Solid">
        <asp:TableCell runat="server" BorderWidth="1px">Адрес за кореспонденция</asp:TableCell>
        <asp:TableCell runat="server" BorderWidth="1px">България, гр. София, район Средец, бул. „Цар Освободител“ № 15, Ректорат, стая 12 </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server" BorderStyle="Solid">
        <asp:TableCell runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px">Телефон</asp:TableCell>
        <asp:TableCell runat="server" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px">02/9308 423, 02/943 43 19 </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server" BorderWidth="1px">E-mail</asp:TableCell>
        <asp:TableCell runat="server" BorderWidth="1px">dpo@uni-sofia.bg</asp:TableCell>
    </asp:TableRow>
</asp:Table>
<br />
    <br>
<asp:TreeView ID="TreeView4" runat="server" ImageSet="Arrows">
    <Nodes>
        <asp:TreeNode NavigateUrl="https://www.uni-sofia.bg/index.php/bul/content/download/196249/1342621/version/4/file/Privacy+notice_Student_PhD_Candidates_Sofia+University_Short.pdf" Text="защита на данните на кандидатстващите в СУ (бакалаври, магистри и докторанти) " Value="защита на данните на кандидатстващите в СУ (бакалаври, магистри и докторанти) "></asp:TreeNode>
        <asp:TreeNode NavigateUrl="https://www.uni-sofia.bg/index.php/bul/content/download/196251/1342629/version/3/file/Privacy+notice_Students_PhD_Sofia+University_Short.pdf" Text=" защита на данните на учащите в СУ (бакалаври, магистри и докторанти)" Value=" защита на данните на учащите в СУ (бакалаври, магистри и докторанти)"></asp:TreeNode>
        <asp:TreeNode NavigateUrl="https://www.uni-sofia.bg/index.php/bul/otoriziran_dost_p/zaschita_na_lichnite_danni" Text="защита на данните на преподавателите/служителите в СУ" Value="защита на данните на преподавателите/служителите в СУ"></asp:TreeNode>
        <asp:TreeNode NavigateUrl="https://www.uni-sofia.bg/index.php/bul/content/download/241517/1598625/version/1/file/Privacy+notice_Sofia+University.pdf" Text=" Задължителна информация за правата на лицата по защита на личните данни на СУ „Св. Климент Охридски“" Value=" Задължителна информация за правата на лицата по защита на личните данни на СУ „Св. Климент Охридски“"></asp:TreeNode>
    </Nodes>
</asp:TreeView>
</asp:Content>
