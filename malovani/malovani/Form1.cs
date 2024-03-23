using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani
{
    public partial class Form1 : Form
    {
        bool penDown;
        int X, Y, lastX, lastY, penWidth, ObjectWidth, ObjectHeigt;
        string Object;
        Color color;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            lastX = X;
            lastY = Y;
            X = e.X;
            Y = e.Y;
            Pen pen = new Pen(color, penWidth);
            Brush brush = new SolidBrush(color);
            if (penDown == true && Object == "pencil")
            {
                gr.DrawLine(pen, lastX, lastY, X, Y);
                gr.FillEllipse(brush, X - (penWidth / 2), Y - (penWidth / 2), penWidth, penWidth);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gr = panel1.CreateGraphics();
            X = e.X;
            Y = e.Y;
            ObjectWidth = (int)numericUpDownObjectWidth.Value;
            ObjectHeigt = (int)numericUpDownObjectHeight.Value;
            Pen pen = new Pen(color, 1);
            Brush brush = new SolidBrush(color);
            if (checkBoxFilling.Checked == true)
            {
                if (Object == "elips")
                {
                    gr.FillEllipse(brush, X - (ObjectWidth / 2), Y - (ObjectHeigt / 2), ObjectWidth, ObjectHeigt);
                    //gr.FillEllipse(brush, X - (penWeight / 2), Y - (penWeight / 2), penWeight, penWeight);
                }
                if (Object == "rectangle")
                {
                    gr.FillRectangle(brush, X - (ObjectWidth / 2), Y - (ObjectHeigt / 2), ObjectWidth, ObjectHeigt);
                    //gr.FillEllipse(brush, X - (penWeight / 2), Y - (penWeight / 2), penWeight, penWeight);
                }
            }
            else
            {
                if (Object == "elips")
                {
                    gr.DrawEllipse(pen, X - (ObjectWidth / 2), Y - (ObjectHeigt / 2), ObjectWidth, ObjectHeigt);
                    //gr.FillEllipse(brush, X - (penWeight / 2), Y - (penWeight / 2), penWeight, penWeight);
                }
                if (Object == "rectangle")
                {
                    gr.DrawRectangle(pen, X - (ObjectWidth / 2), Y - (ObjectHeigt / 2), ObjectWidth, ObjectHeigt);
                    //gr.FillEllipse(brush, X - (penWeight / 2), Y - (penWeight / 2), penWeight, penWeight);
                }
            }
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            Object = "pencil";
            color = panel1.BackColor;
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Object = "pencil";
            color = Color.Black;
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {
            color = Color.Pink;
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void buttonBackWhite_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void buttonBackBlack_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            color = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.BlueViolet;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.LightBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Coral;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkMagenta;
        }

        private void buttonElips_Click(object sender, EventArgs e)
        {
            Object = "elips";
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Object = "rectangle";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            penDown = false;
        }

        public Form1()
        {
            InitializeComponent();
            penDown = false;
            color = Color.Black;
            Object = "pencil";
            panel1.BackColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            penDown = true;
            penWidth = (int)numericUpDownWidth.Value;
        }
    }
}
