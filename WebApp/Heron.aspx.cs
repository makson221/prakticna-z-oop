using System;
using System.Web.UI;

namespace WebApp
{
    public partial class Heron : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!InputParser.TryParseNumber(TextBox1.Text, out a)
                || !InputParser.TryParseNumber(TextBox2.Text, out b)
                || !InputParser.TryParseNumber(TextBox3.Text, out c))
            {
                Label4.CssClass = "result error";
                Label4.Text = "Введіть коректні числові значення сторін a, b, c.";
                return;
            }

            if (!Triangle.CanExist(a, b, c))
            {
                Label4.CssClass = "result error";
                Label4.Text = "Трикутник зі сторонами " + a + ", " + b + ", " + c
                    + " не існує (кожна сторона має бути додатною "
                    + "і меншою за суму двох інших).";
                return;
            }

            Triangle triangle = new Triangle(a, b, c);
            double s = triangle.Area();

            Label4.CssClass = "result ok";
            Label4.Text = "S = " + Math.Round(s, 4);
        }
    }
}
