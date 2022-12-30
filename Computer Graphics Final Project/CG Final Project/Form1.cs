using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Final_Project
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black, 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            methodText.Hide();
            LineMethod.Hide();
            ThirdPoint.Hide();
            trackBar1.Hide();
            Y2.Show();
            X3.Hide();
            Y3.Hide();
        }
        
        private PointF rotateRect(PointF p1, PointF p2)
        {
            double deg = (Math.PI * Convert.ToDouble(angle.Text) / 180);
            p2.X -= p1.X;
            p2.Y -= p1.Y;

            double sin = Math.Round(Math.Sin(deg), 2);
            double cos = Math.Round(Math.Cos(deg), 2);

            double newSecondpointX = p2.X * cos - p2.Y * sin;
            double newSecondpointY = p2.X * sin + p2.Y * cos;


            p2.X = (float)newSecondpointX + p1.X;
            p2.Y = (float)newSecondpointY + p1.Y;

            return p2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
            ShapeSelection.SelectedIndex = 0;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                DrawingBoard.Refresh();
                float firstpointX = Convert.ToInt32(X1.Text), firstpointY = Convert.ToInt32(Y1.Text),
                    secondpointX = Convert.ToInt32(X2.Text), secondpointY = 0,
                    thirdpointX = 0, thirdpointY = 0;
                if (ShapeSelection.SelectedItem != "Circle")
                {
                    secondpointY = Convert.ToInt32(Y2.Text);
                }

                if (ShapeSelection.SelectedItem == "Triangle") 
                {
                    thirdpointX = (float)Convert.ToDouble(X3.Text);
                    thirdpointY = (float)Convert.ToDouble(Y3.Text);
                }

                // Translation
                if (Tx.Text != "")
                {
                    firstpointX += (float)Convert.ToDouble(Tx.Text);
                    if (ShapeSelection.SelectedItem.ToString() != "Circle")
                    {
                        secondpointX += (float)Convert.ToDouble(Tx.Text);
                    }
                    thirdpointX += (float)Convert.ToDouble(Tx.Text);
                }

                if (Ty.Text != "")
                {
                    firstpointY += (float)Convert.ToDouble(Ty.Text);
                    secondpointY += (float)Convert.ToDouble(Ty.Text);
                    thirdpointY += (float)Convert.ToDouble(Ty.Text);
                }

                // Scaling
                if (Sx.Text != "")
                {
                    firstpointX *= (float)Convert.ToDouble(Sx.Text);
                    secondpointX *= (float)Convert.ToDouble(Sx.Text);
                    thirdpointX *= (float)Convert.ToDouble(Sx.Text);
                }

                if (Sy.Text != "")
                {
                    firstpointY *= (float)Convert.ToDouble(Sy.Text);
                    secondpointY *= (float)Convert.ToDouble(Sy.Text);
                    thirdpointY *= (float)Convert.ToDouble(Sy.Text);
                }

                // rotation
                if (angle.Text != "")
                {
                    if (ShapeSelection.SelectedItem == "Circle")
                    {
                        MessageBox.Show("Circle Cannot Be Rounded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (ShapeSelection.SelectedItem == "Rectangle")
                    {

                    }
                    else
                    {
                        double deg = Math.PI * Convert.ToDouble(angle.Text) / 180.0;
                        secondpointX -= firstpointX;
                        secondpointY -= firstpointY;
                        thirdpointX -= firstpointX;
                        thirdpointY -= firstpointY;

                        double sin = Math.Round(Math.Sin(deg), 2);
                        double cos = Math.Round(Math.Cos(deg), 2);

                        double newSecondpointX = secondpointX * cos - secondpointY * sin;
                        double newSecondpointY = secondpointX * sin + secondpointY * cos;
                        double newThirdpointX = thirdpointX * cos - thirdpointY * sin;
                        double newThirdpointY = thirdpointX * sin + thirdpointY * cos;

                        secondpointX = (float)newSecondpointX + firstpointX;
                        secondpointY = (float)newSecondpointY + firstpointY;
                        thirdpointX = (float)newThirdpointX + firstpointX;
                        thirdpointY = (float)newThirdpointY + firstpointY;
                    }            
                }

                if (ShapeSelection.SelectedItem == "Line")
                {
                    if (LineMethod.SelectedItem == "Digital Differential Analyzer (DDA)")
                    {
                        int x1 = (int)firstpointX, y1 = (int)firstpointY, x2 = (int)secondpointX, y2 = (int)secondpointY;
                        int dx = x2 - x1, dy = y2 - y1, steps, xf, yf;
                        float xIncrement, yIncrement, x = x1, y = y1;

                        if (Math.Abs(dx) > Math.Abs(dy))
                            steps = Math.Abs(dx);
                        else
                            steps = Math.Abs(dy);

                        xIncrement = dx / (float)steps;
                        yIncrement = dy / (float)steps;

                        Point[] points = new Point[steps];

                        for (int i = 0; i < steps; i++)
                        {
                            x += xIncrement;
                            xf = (int)x;
                            y += yIncrement;
                            yf = (int)y;
                            points[i] = new Point(xf, yf);
                        }
                        DrawingBoard.CreateGraphics().DrawLines(pen, points);
                    }
                    else if (LineMethod.SelectedItem == "Bresenham Line Algorithm")
                    {
                        firstpointX = (int)Math.Round(firstpointX);
                        firstpointY = (int)Math.Round(firstpointY);
                        secondpointX = (int)Math.Round(secondpointX);
                        secondpointY = (int)Math.Round(secondpointY);

                        bool steep = Math.Abs(secondpointY - firstpointY) > Math.Abs(secondpointX - firstpointX);
                        if (steep)
                        {
                            int t;
                            t = (int)firstpointX;
                            firstpointX = firstpointY;
                            firstpointY = t;
                            t = (int)secondpointX;
                            secondpointX = secondpointY;
                            secondpointY = t;
                        }
                        if (firstpointX > secondpointX)
                        {
                            int t;
                            t = (int)firstpointX;
                            firstpointX = secondpointX;
                            secondpointX = t;
                            t = (int)firstpointY;
                            firstpointY = secondpointY;
                            secondpointY = t;
                        }
                        int dx = (int)(secondpointX - firstpointX);
                        int dy = (int)Math.Abs(secondpointY - firstpointY);
                        int error = dx / 2;
                        int ystep = (firstpointY < secondpointY) ? 1 : -1;
                        int y = (int)firstpointY;
                        PointF[] points = new PointF[dx + 1];
                        int counter = 0;
                        for (int x = (int)firstpointX; x <= secondpointX; x++)
                        {
                            points[counter] = new PointF((steep ? y : x), (steep ? x : y));
                            error = error - dy;
                            if (error < 0)
                            {
                                y += ystep;
                                error += dx;
                            }
                            counter++;
                        }
                        DrawingBoard.CreateGraphics().DrawLines(pen, points);

                    }
                    else if (LineMethod.SelectedItem == "Built-in Functions")
                    {
                        PointF p1 = new PointF(firstpointX, firstpointY);
                        PointF p2 = new PointF(secondpointX, secondpointY);

                        DrawingBoard.CreateGraphics().DrawLine(pen, p1, p2);
                    }
                }
                else if (ShapeSelection.SelectedItem == "Rectangle")
                {
                    PointF[] points = new PointF[5];
                    points[0] = new PointF(firstpointX, firstpointY);
                    points[1] = new PointF(secondpointX, firstpointY);
                    points[2] = new PointF(secondpointX, secondpointY);
                    points[3] = new PointF(firstpointX, secondpointY);
                    points[4] = new PointF(firstpointX, firstpointY);

                    if (angle.Text != "")
                    {
                        points[1] = rotateRect(points[0], points[1]);
                        points[2] = rotateRect(points[0], points[2]);
                        points[3] = rotateRect(points[0], points[3]);
                        points[4] = rotateRect(points[0], points[4]);
                    }
                    DrawingBoard.CreateGraphics().DrawLines(pen, points);
                }
                else if (ShapeSelection.SelectedItem == "Triangle")
                {
                    PointF[] points = new PointF[3];
                    points[0] = new PointF(firstpointX, firstpointY);
                    points[1] = new PointF(secondpointX, secondpointY);
                    points[2] = new PointF(thirdpointX, thirdpointY);
                    DrawingBoard.CreateGraphics().DrawPolygon(pen, points);
                }
                else if (ShapeSelection.SelectedItem == "Circle")
                {
                    int x = (int)secondpointX, y = 0;
                    int radius = (int)secondpointX;
                    DrawingBoard.CreateGraphics().DrawEllipse(pen, firstpointX - (radius / 2), firstpointY - (radius / 2), radius, radius);
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Enter A Valid Points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DrawingBoard.Refresh();
            X1.Text = "";
            X2.Text = "";
            X3.Text = "";
            Y1.Text = "";
            Y2.Text = "";
            Y3.Text = "";
            Tx.Text = "";
            Ty.Text = "";
            Sx.Text = "";
            Sy.Text = "";
            angle.Text = "";
        }

        private void ShapeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShapeSelection.SelectedItem.ToString() == "Line")
            {
                reset();
                FirstPoint.Text = "Start Point (x1, y1):";
                SecondPoint.Text = "End Point (x2, y2):";
                methodText.Show();
                LineMethod.Show();
                LineMethod.SelectedIndex = 0;
            }
            else if (ShapeSelection.SelectedItem.ToString() == "Rectangle")
            {
                reset();
                LineMethod.Hide();
                methodText.Hide();
                FirstPoint.Text = "Top-left Point (x1, y1):";
                SecondPoint.Text = "Bottom-right Point (x2, y2):";
            }
            else if (ShapeSelection.SelectedItem.ToString() == "Triangle")
            {
                reset();
                FirstPoint.Text = "First Point (x1, y1):";
                SecondPoint.Text = "Second Point (x2, y2):";
                ThirdPoint.Show();
                X3.Show();
                Y3.Show();
            }
            else if (ShapeSelection.SelectedItem.ToString() == "Circle")
            {
                reset();
                Y2.Hide();
                FirstPoint.Text = "Center Point (x, y):";
                trackBar1.Show();
                SecondPoint.Text = "The Radius of the Circle (r):";
            }
        }

        private void DrawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            LocationText.Text = e.Location + "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            pen = new Pen(cd.Color,2);
            lineColor.BackColor = cd.Color;
        }

        private void DrawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (X1.Text == "" && Y1.Text == "")
            {
                X1.Text = e.Location.X + "";
                Y1.Text = e.Location.Y + "";
            }
            else if (X2.Text == "" && Y2.Text == "")
            {
                if (ShapeSelection.SelectedItem == "Circle")
                {
                    MessageBox.Show("Enter Radius Value Manually.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                X2.Text = e.Location.X + "";
                Y2.Text = e.Location.Y + "";
            }
            else if (X3.Text == "" && Y3.Text == "")
            {
                X3.Text = e.Location.X + "";
                Y3.Text = e.Location.Y + "";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            X2.Text = trackBar1.Value + "";
        }

        private void LineMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrawingBoard_Click(object sender, EventArgs e)
        {

        }
    }
}