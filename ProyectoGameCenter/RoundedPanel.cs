using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 50; // Radio de las esquinas redondeadas

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        // Dibujar el fondo
        g.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

        // Dibujar las esquinas redondeadas
        using (GraphicsPath path = RoundedRectangle(ClientRectangle, CornerRadius))
        {
            Region = new Region(path);
        }
    }

    private GraphicsPath RoundedRectangle(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;
        Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

        // Arco superior izquierdo
        path.AddArc(arc, 180, 90);

        // Arco superior derecho
        arc.X = rect.Right - diameter;
        path.AddArc(arc, 270, 90);

        // Arco inferior derecho
        arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // Arco inferior izquierdo
        arc.X = rect.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
