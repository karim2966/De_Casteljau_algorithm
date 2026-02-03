using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ite_homework_karim_296610
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Coordinates and point counts
        int[] PX = new int[25];
        int[] PY = new int[25];
        int PointIndex = 0;
        // Draw button status
        bool status = false;
        // De Casteljau algorithm button status
        bool BtnDeCas1 = false;
        public Form()
        {
            InitializeComponent();
            //
            panel.MouseClick += panel_MouseClick;
        }

        public float DeCasteljau(float t, float[] coefficients)
        {
            float[] beta = coefficients;
            int n = beta.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    beta[j] = beta[j] * (1 - t) + beta[j + 1] * t;
                }
            }
            return beta[0];
        }
        // Determine the maximum number in an array
        public int MaxPoint(int[] PXY)
        {
            int[] P = PXY;
            int MaxNum = P[0];
            for (int i = 0; i < PointIndex - 1; i++)
            {
                if (P[i + 1] > MaxNum)
                {
                    MaxNum = P[i + 1];
                }
            }
            return MaxNum;
        }
        // Determine the minimum number in an array
        public int MinPoint(int[] PXY)
        {
            int[] P = PXY;
            int MinNum = P[0];
            for (int i = 0; i < PointIndex - 1; i++)
            {
                if (P[i + 1] <= MinNum)
                {
                    MinNum = P[i + 1];
                }
            }
            return MinNum;
        }
        // Change the draw button status
        private void BtnDrawPoint_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                status = true;
                BtnDeCas1 = false;
            }
        }
        // Drawing
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            // Line
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Black;
            // Draw points and coordinates
            for (int i = 0; i < PointIndex; i++)
            {
                g.FillEllipse(Brushes.Yellow, PX[i] - 6, PY[i] - 6, 10, 10);
                string coordinates = string.Format("({0}),({1})", PX[i], PY[i]);
                g.DrawString(coordinates, font, brush, PX[i] + 5, PY[i] - 10);
            }
            // Draw De Casteljau points and rectangle
            if (BtnDeCas1)
            {
                for (int i = 2; i <= PointIndex; i++)
                {
                    // Take coordinates of points and increment point by point
                    float[] betaX = new float[i];
                    float[] betaY = new float[i];
                    // Copy the coordinates of the points
                    for (int p = 0; p < i; p++)
                    {
                        betaX[p] = PX[p];
                        betaY[p] = PY[p];
                    }

                    // Draw De Casteljau points
                    for (int j = 0; j <= 200; j++)
                    {
                        float t = j / 200f; // Decimal division
                        g.FillEllipse(Brushes.Red, DeCasteljau(t, betaX) - 3, DeCasteljau(t, betaY) - 3, 3, 3);
                    }
                }
                // Determine the coordinates of the rectangle points
                Point point1 = new Point(MinPoint(PX), MaxPoint(PY));
                Point point2 = new Point(MaxPoint(PX), MaxPoint(PY));
                Point point3 = new Point(MaxPoint(PX), MinPoint(PY));
                Point point4 = new Point(MinPoint(PX), MinPoint(PY));
                // Draw the rectangle
                Pen pen = new Pen(Color.Blue, 2);
                g.DrawLine(pen, point1, point2);
                g.DrawLine(pen, point2, point3);
                g.DrawLine(pen, point3, point4);
                g.DrawLine(pen, point4, point1);
                pen.Dispose();
            }
        }
        // Activate the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            PX = new int[25];
            PY = new int[25];
            PointIndex = 0;
            status = false;
            BtnDeCas1 = false;
            panel.Invalidate();
        }
        // Screen click
        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (status == true && PointIndex < 25)
            {
                PX[PointIndex] = e.X;
                PY[PointIndex] = e.Y;
                PointIndex++;
                panel.Invalidate();
            }
            else if (status == false)
            {
                MessageBox.Show("Press the button (Draw Points)", "Watch out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == true && PointIndex >= 25)
            {
                MessageBox.Show("The number of points exceeded to (25)", "Watch out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Activate De Casteljau algorithm
        private void BtnDeCas_Click(object sender, EventArgs e)
        {
            if (PointIndex > 1)
            {
                status = false;
                BtnDeCas1 = true;
                panel.Invalidate();
            }
            else if (PointIndex <= 1)
            {
                MessageBox.Show("The number of points must be greater than 1 ", "Watch out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
