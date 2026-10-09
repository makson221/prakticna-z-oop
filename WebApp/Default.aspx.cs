using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            ResetQuadrants();

            double x, y;
            if (!InputParser.TryParseNumber(txtX.Text, out x)
                || !InputParser.TryParseNumber(txtY.Text, out y))
            {
                ShowError("Введіть коректні числа x та y (наприклад: 3 або -2,5).");
                return;
            }

            Point2D point = new Point2D(x, y);
            if (point.IsOnAxis)
            {
                ShowError("Точка (" + x + "; " + y + ") лежить на координатній осі "
                    + "і не належить жодній чверті. За умовою x ≠ 0 та y ≠ 0.");
                return;
            }

            int quadrant = point.GetQuadrant();
            string roman = Point2D.ToRoman(quadrant);

            lblResult.CssClass = "result ok";
            lblResult.Text = "Точка (" + x + "; " + y + ") знаходиться в " + quadrant
                + "-й координатній чверті (" + roman + ").";

            HighlightQuadrant(quadrant);
        }

        private void ShowError(string message)
        {
            lblResult.CssClass = "result error";
            lblResult.Text = message;
        }

        private void ResetQuadrants()
        {
            foreach (HtmlGenericControl cell in new[] { q1, q2, q3, q4 })
                cell.Attributes["class"] = "q";
        }

        private void HighlightQuadrant(int quadrant)
        {
            HtmlGenericControl[] cells = { q1, q2, q3, q4 };
            cells[quadrant - 1].Attributes["class"] = "q active";
        }
    }
}
