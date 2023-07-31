<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Novini.aspx.cs" Inherits="WebSiteSofiaUni.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style9 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="Актуални новини"></asp:Label>
                <br />
                <br />
    <table style="width:100%;" border="1">
        <tr>
            <td class="auto-style9">
                
                <asp:Label ID="Label" runat="server" Font-Bold="True" Text="Завърши първият випуск на съвместната магистърска програма на Софийския университет и Бухарския държавен университет"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Height="120px" ReadOnly="True" TextMode="MultiLine" Width="260px">На 28 април 2023 г. на тържествена церемония в Бухарския държавен университет, Узбекистан, бяха връчени българските и узбекистанските дипломи за завършено висше образование на абсолвентите-магистри от първия випуск на съвместната магистърска програма „Чужд език /английски/, литература, медии“ към Факултета по класически и нови филологии на Софийския университет „Св. Климент Охридски“ и Бухарския държавен университет.</asp:TextBox>
                
            </td>
            <td class="auto-style9" colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Завърши випуск 2022 г. на Факултета по журналистика и масова комуникация "></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Height="120px" TextMode="MultiLine" Width="260px">На тържествена церемония, която се проведе в Аулата в Ректората, 78 бакалаври и магистри от випуск 2022 г. на Факултета по журналистика и масова комуникация получиха дипломите си за завършено висше образование. 35 от тях завършват с успех отличен над 5.50. Пълните отличници са трима, които получиха значки „Отличник на Софийския университет“.</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="2">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Изложба „Нашите посланици в училище“ в галерия „Алма матер“"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" Height="120px" ReadOnly="True" TextMode="MultiLine" Width="260px">От 3 май 2023 г. галерия „Алма матер“ е домакин на изложбата „Нашите посланици в училище“. Експозицията с фотографии е посветена на религиозното образование и е част от академичния календар за честването на 135-годишнината от създаването на Софийския университет и 100-годишнината на Богословския факултет. </asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Ректорът на Софийския университет се срещна с делегация от Нигерия"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" Height="120px" ReadOnly="True" TextMode="MultiLine" Width="260px">Ректорът на Софийския университет проф. дфн Анастас Герджиков се срещна с правителствена и бизнес делегация от Нигерия. На събитието присъства д-р Майкъл Олауале – Кул, директор на Лагоската търговско-промишлена палата.</asp:TextBox>
            </td>
        </tr>
        </table>
</asp:Content>
