using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKG
{
    public partial class FormFigure : Form
    {
        const int default_size = 40;

        int a;
        int v = 1;
        int s = 1;
        int dirR = 1;
        int dirX = 1;
        int dirY = 1;

        double xc, yc;
        double dx = 0.1;
        double dy = 0.1;
        double fi;
        double c_fi = 0;
        bool checkX, checkY;

        Point[] square = new Point[4];
        Point[] unknown = new Point[8];

        double[] x = new double[12];
        double[] y = new double[12];

        public FormFigure()
        {
            InitializeComponent();
        }

        private void FormFigure_Load(object sender, EventArgs e)
        {
            a = default_size;

            xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
            yc = Convert.ToInt32(pictureBox.Height - (a * Math.Sqrt(2) / 2));

            trackBarsize.Value = a;
            trackBarspeed.Value = v;
            trackBarrotation.Value = s;
        }

        private double[] x_rot(double[] x0, double[] y0)
        {
            double[] x1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x1[i] = (x0[i]) * Math.Cos(c_fi) - (y0[i]) * Math.Sin(c_fi);
            }
            return x1;
        }

        private double[] y_rot(double[] x0, double[] y0)
        {
            double[] y1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y1[i] = (y0[i]) * Math.Cos(c_fi) + (x0[i]) * Math.Sin(c_fi);
            }
            return y1;
        }

        private byte colorInc()
        {
            try
            {
                double col = 225 * (xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                    (pictureBox.Width - a * Math.Cos(Math.PI / 6));
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        private byte colorDec()
        {
            try
            {
                double col = -225 * ((xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                    (pictureBox.Width - a * Math.Cos(Math.PI / 6))) + 225;
                return Convert.ToByte(col);

            }
            catch
            {
                return 0;
            }
        }

        private void trackBarsize_Scroll(object sender, EventArgs e)
        {
            a = trackBarsize.Value;

            if (!timer.Enabled)
            {
                xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                yc = Convert.ToInt32(pictureBox.Height - (a * Math.Sqrt(2) / 2));

                ris();
            }
        }

        private void trackBarspeed_Scroll(object sender, EventArgs e)
        {
            v = trackBarspeed.Value;
        }

        private void trackBarRotationSpeed_Scroll(object sender, EventArgs e)
        {
            s = trackBarrotation.Value;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();

            xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
            yc = Convert.ToInt32(pictureBox.Height - (a * Math.Sqrt(2) / 2));

            dx = 0.1;
            dy = 0.1;
            c_fi = 0;

            textBoxStartingX.Clear();
            textBoxStartingY.Clear();
            textBoxStartingEnterCoordX.Clear();
            textBoxStartingEnterCoordY.Clear();

            ris();
        }

        private void buttondepict_Click(object sender, EventArgs e)
        {
            ris();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double hypotenuse = Math.Pow((Convert.ToInt32(textBoxStartingEnterCoordX.Text) - xc), 2) + Math.Pow((Convert.ToInt32(textBoxStartingEnterCoordY.Text) - yc), 2);
                dx = Math.Abs((Convert.ToInt32(textBoxStartingEnterCoordX.Text) - xc)) / Math.Sqrt(hypotenuse);
                dy = Math.Abs((Convert.ToInt32(textBoxStartingEnterCoordY.Text) - yc)) / Math.Sqrt(hypotenuse);

                if (Convert.ToInt32(textBoxStartingEnterCoordX.Text) > xc)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (Convert.ToInt32(textBoxStartingEnterCoordY.Text) > yc)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingX_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(textBoxStartingX.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingX.Text) + Convert.ToInt32(a * Math.Sqrt(2) / 2) > pictureBox.Width)
                {
                    xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                    ErrorText.Text = String.Format("Ошибка в ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    xc = Convert.ToInt32(textBoxStartingX.Text);
                    ErrorText.Text = String.Format("Ошибок нет...");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingY.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingY.Text) + Convert.ToInt32(a * Math.Sqrt(2) / 2) > pictureBox.Height)
                {
                    yc = Convert.ToInt32(pictureBox.Height - (a * Math.Sqrt(2) / 2));
                    ErrorText.Text = String.Format("Ошибка в  ''Y'' находится за координатной плоскостью.");
                }
                else
                {
                    yc = Convert.ToInt32(textBoxStartingY.Text);
                    ErrorText.Text = String.Format("Ошибок нет...");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingEnterCoordX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingX.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingX.Text) > pictureBox.Width)
                {
                    ErrorText.Text = String.Format("Ошибка в ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    ErrorText.Text = String.Format("Ошибок нет...");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingEnterCoordY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingY.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingY.Text) > pictureBox.Height)
                {
                    ErrorText.Text = String.Format("Ошибка в ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    ErrorText.Text = String.Format("Ошибок нет...");
                }
            }
            catch
            {

            }
        }

        private void buttonstir_Click(object sender, EventArgs e)
        {

            if (dx != 0.1 && dy != 0.1)
            {
                timer.Start();
                ErrorText.Text = String.Format("Ошибок нет...");
            }
            else
            {
                ErrorText.Text = String.Format("Направление не задано.");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void labelSize_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (x.Max() + xc > pictureBox.Width && checkX)
            {
                dirX = -1;
                checkX = false;

                if (dirY == -1)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (x.Min() + xc < 0 && !checkX)
            {
                dirX = 1;
                checkX = true;

                if (dirY == -1)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (y.Max() + yc > pictureBox.Height && checkY)
            {
                dirY = -1;
                checkY = false;

                if (dirX == -1)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (y.Min() + yc < 0 && !checkY)
            {
                dirY = 1;
                checkY = true;

                if (dirX == -1)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            c_fi += fi * s;
            fi = dirR * Math.PI / (180);

            xc = xc + dx * dirX * v;
            yc = yc + dy * dirY * v;

            ris();
        }

        private void pictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void buttondefault_Click(object sender, EventArgs e)
        {

            a = default_size;
            trackBarsize.Value = default_size;

            if (!timer.Enabled)
            {
                xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                yc = Convert.ToInt32(pictureBox.Height - (a * Math.Sqrt(2) / 2));

                ris();
            } 
        }

    
            private void ris()
            {
                Graphics g = pictureBox.CreateGraphics();

                Brush br1 = new SolidBrush(Color.FromArgb(colorInc(), 128, 0));
                Brush br2 = new SolidBrush(Color.FromArgb(colorDec(), 0, colorInc()));

                g.Clear(SystemColors.Control);

                x[0] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));
                y[0] = Convert.ToInt32(-(a / 2) * Math.Sin(Math.PI / 4));
                x[1] = Convert.ToInt32(+(a / 2) * Math.Cos(Math.PI / 4));
                y[1] = Convert.ToInt32(-(a / 2) * Math.Sin(Math.PI / 4));
                x[2] = Convert.ToInt32(+(a / 2) * Math.Cos(Math.PI / 4));
                y[2] = Convert.ToInt32(+(a / 2) * Math.Sin(Math.PI / 4));
                x[3] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));
                y[3] = Convert.ToInt32(+(a / 2) * Math.Sin(Math.PI / 4));
                //
                x[4] = Convert.ToInt32(0);
                y[4] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2));
                x[5] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2) * Math.Cos(Math.PI / 4));
                y[5] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2) * Math.Sin(Math.PI / 4));
                x[6] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2));
                y[6] = Convert.ToInt32(0);
                x[7] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2) * Math.Cos(Math.PI / 4));
                y[7] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2) * Math.Sin(Math.PI / 4));
                x[8] = Convert.ToInt32(0);
                y[8] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2));
                x[9] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2) * Math.Cos(Math.PI / 4));
                y[9] = Convert.ToInt32(+((a / Math.Sqrt(2)) / 2) * Math.Sin(Math.PI / 4));
                x[10] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2));
                y[10] = Convert.ToInt32(0);
                x[11] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2) * Math.Cos(Math.PI / 4));
                y[11] = Convert.ToInt32(-((a / Math.Sqrt(2)) / 2) * Math.Sin(Math.PI / 4));
                double[] temp = new double[16];
                temp = x;
                x = x_rot(temp, y);
                y = y_rot(temp, y);
                square[0] = new Point((int)(x[0] + xc), (int)(y[0] + yc));
                square[1] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
                square[2] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
                square[3] = new Point((int)(x[3] + xc), (int)(y[3] + yc));

                unknown[0] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
                unknown[1] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
                unknown[2] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
                unknown[3] = new Point((int)(x[7] + xc), (int)(y[7] + yc));
                unknown[4] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
                unknown[5] = new Point((int)(x[9] + xc), (int)(y[9] + yc));
                unknown[6] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
                unknown[7] = new Point((int)(x[11] + xc), (int)(y[11] + yc));

                g.FillEllipse(br1, Convert.ToInt32(xc - (a / 2)), Convert.ToInt32(yc - (a / 2)), a, a);
                g.FillPolygon(br2, square);
                g.FillPolygon(br1, unknown);
                
            }
        }

    } 
