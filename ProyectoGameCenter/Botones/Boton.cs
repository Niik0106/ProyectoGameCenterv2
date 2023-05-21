using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ProyectoGameCenter.Botones
{
    public class Boton: Button
    {
        //Campos
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleVioletRed;

        //Propiedades
        [Category("New Desing Buttons")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("New Desing Buttons")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("New Desing Buttons")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("New Desing Buttons")]
        public Color BackgroundColor
        {
            get { return this.BackColor;}
            set { this.BackColor = value;}
        }
        [Category("New Desing Buttons")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public Boton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        //Metodos
        private GraphicsPath GetFigurePath(RectangleF rec, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width-radius, rec.Y, radius, radius, 270, 90);
            path.AddArc(rec.Width-radius, rec.Height-radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF recSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF recBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (BorderRadius > 2) //Boton Redondeado
            {
                using (GraphicsPath pathSurface = GetFigurePath(recSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(recBorder, BorderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Superficie del Boton
                    this.Region = new Region(pathSurface);
                    //Dibujar Borde HD
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Borde del Boton
                    if (BorderSize >= 1)
                    {
                        //Dibujar Control Borde
                        pevent.Graphics.DrawPath(penBorder, pathBorder);    
                    }
                }
            }
            else //Boton Normal
            {
                this.Region = new Region(recSurface);
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height-1);
                    }
                }
            }
        
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }

    }
}
