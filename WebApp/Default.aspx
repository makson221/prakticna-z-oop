<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Варіант 10. Координатна чверть точки</title>
    <link href="Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h1>Визначення координатної чверті</h1>
            <p class="task">
                Варіант 10. Дано координати точки, що не лежить на координатних осях OX та OY.
                Визначити номер координатної чверті, в якій знаходиться дана точка.
            </p>

            <table class="inputs">
                <tr>
                    <td><asp:Label ID="lblX" runat="server" Text="x = " AssociatedControlID="txtX" /></td>
                    <td><asp:TextBox ID="txtX" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblY" runat="server" Text="y = " AssociatedControlID="txtY" /></td>
                    <td><asp:TextBox ID="txtY" runat="server" /></td>
                </tr>
            </table>

            <asp:Button ID="btnCalculate" runat="server" Text="Визначити чверть" OnClick="btnCalculate_Click" />

            <p><asp:Label ID="lblResult" runat="server" CssClass="result" /></p>

            <div class="plane">
                <div id="q2" runat="server" class="q">II</div>
                <div id="q1" runat="server" class="q">I</div>
                <div id="q3" runat="server" class="q">III</div>
                <div id="q4" runat="server" class="q">IV</div>
            </div>

            <p class="nav"><a href="Heron.aspx">Приклад з методички: площа трикутника за формулою Герона &rarr;</a></p>
        </div>
    </form>
</body>
</html>
