<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Heron.aspx.cs" Inherits="WebApp.Heron" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Площа трикутника за формулою Герона</title>
    <link href="Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <h1>Площа трикутника (формула Герона)</h1>
            <p class="task">
                Задано три сторони трикутника: a, b, c. Знайти площу:
                S = &radic;(p(p &minus; a)(p &minus; b)(p &minus; c)), де p = (a + b + c) / 2 &mdash; півпериметр.
            </p>

            <table class="inputs">
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="a = " AssociatedControlID="TextBox1" /></td>
                    <td><asp:TextBox ID="TextBox1" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="b = " AssociatedControlID="TextBox2" /></td>
                    <td><asp:TextBox ID="TextBox2" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="c = " AssociatedControlID="TextBox3" /></td>
                    <td><asp:TextBox ID="TextBox3" runat="server" /></td>
                </tr>
            </table>

            <asp:Button ID="Button1" runat="server" Text="Обчислити" OnClick="Button1_Click" />

            <p><asp:Label ID="Label4" runat="server" CssClass="result" /></p>

            <p class="nav"><a href="Default.aspx">&larr; До індивідуального завдання (варіант 10)</a></p>
        </div>
    </form>
</body>
</html>
