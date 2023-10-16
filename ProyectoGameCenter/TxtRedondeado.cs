using System;

using System.Drawing;
using System.Windows.Forms;

namespace ProyectoGameCenter
{
    public class RoundedTextBox : TextBox
    {
        private const int WM_PAINT = 0xF;

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Multiline = true;
            this.AutoSize = false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    g.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }
}
