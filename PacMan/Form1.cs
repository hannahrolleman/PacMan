using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Startbutton_Click(object sender, EventArgs e)
        {
            Startbutton.Visible = false; //makes button disapear
             
            Graphics formGraphics = this.CreateGraphics();
            Graphics fg = this.CreateGraphics();

            Pen drawPen = new Pen(Color.Blue, 10);
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0,70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250,20, 250, 300);

            drawPen.Color = Color.Yellow;
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            formGraphics.FillPie(drawBrush, 10, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 50, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 90, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 130, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 170, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 25, 35, 35, 30, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 25, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 50, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 75, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 100, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 125, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 150, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 175, 35, 35, 120, 300);

            Thread.Sleep(300);
            formGraphics.Clear(Color.Black);

            drawPen.Color = Color.Blue;//
            formGraphics.DrawLine(drawPen, 0, 20, 250, 20);
            formGraphics.DrawLine(drawPen, 0, 70, 200, 70);
            formGraphics.DrawLine(drawPen, 200, 70, 200, 300);
            formGraphics.DrawLine(drawPen, 250, 20, 250, 300);

            drawBrush.Color = Color.Yellow;
            formGraphics.FillPie(drawBrush, 210, 200, 35, 35, 120, 300);

            drawBrush.Color = Color.White; 
            Font drawFont = new Font("Arial", 12, FontStyle.Bold);
            fg.DrawString("Well done!", drawFont, drawBrush, 50, 200);
        }
    }
}
