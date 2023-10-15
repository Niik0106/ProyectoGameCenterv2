using System;
using System.Drawing;
using System.Windows.Forms;

public class GradientButton : Button
{
    private Color startColor = Color.Blue; // Color inicial del degradado
    private Color endColor = Color.Green; // Color final del degradado
    private Timer animationTimer = new Timer();
    private int animationSteps = 20; // Número de pasos de la animación

    public GradientButton()
    {
        animationTimer.Interval = 500; // Intervalo de tiempo de la animación (ajusta según tus necesidades)
        animationTimer.Tick += AnimationTimer_Tick;
        this.MouseDown += GradientButton_MouseDown;
    }

    private void GradientButton_MouseDown(object sender, MouseEventArgs e)
    {
        if (!animationTimer.Enabled)
        {
            animationTimer.Start();
        }
    }

    private void AnimationTimer_Tick(object sender, EventArgs e)
    {
        // Calcular el color intermedio en la animación de degradado
        int step = animationSteps - animationTimer.Interval;
        Color interpolatedColor = InterpolateColors(startColor, endColor, step, animationSteps);

        // Aplicar el color al fondo del botón
        this.BackColor = interpolatedColor;

        // Detener la animación cuando se alcanza el color final
        if (step <= 0)
        {
            animationTimer.Stop();
        }
    }

    private Color InterpolateColors(Color start, Color end, int step, int steps)
    {
        int r = (int)(start.R + (end.R - start.R) * step / steps);
        int g = (int)(start.G + (end.G - start.G) * step / steps);
        int b = (int)(start.B + (end.B - start.B) * step / steps);

        // Asegúrate de que los valores estén dentro del rango válido (0-255)
        r = Math.Max(0, Math.Min(255, r));
        g = Math.Max(0, Math.Min(255, g));
        b = Math.Max(0, Math.Min(255, b));

        return Color.FromArgb(r, g, b);
    }

}
