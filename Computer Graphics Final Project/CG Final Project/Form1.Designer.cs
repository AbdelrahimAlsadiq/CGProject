namespace CG_Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.methodText = new System.Windows.Forms.Label();
            this.FirstPoint = new System.Windows.Forms.Label();
            this.SecondPoint = new System.Windows.Forms.Label();
            this.ShapeSelection = new System.Windows.Forms.ComboBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.LineMethod = new System.Windows.Forms.ComboBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.X3 = new System.Windows.Forms.TextBox();
            this.ThirdPoint = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sy = new System.Windows.Forms.TextBox();
            this.Sx = new System.Windows.Forms.TextBox();
            this.Ty = new System.Windows.Forms.TextBox();
            this.Tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawingBoard = new System.Windows.Forms.PictureBox();
            this.LocationText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lineColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Shape:";
            // 
            // methodText
            // 
            this.methodText.AutoSize = true;
            this.methodText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodText.Location = new System.Drawing.Point(17, 72);
            this.methodText.Name = "methodText";
            this.methodText.Size = new System.Drawing.Size(79, 22);
            this.methodText.TabIndex = 2;
            this.methodText.Text = "Method:";
            // 
            // FirstPoint
            // 
            this.FirstPoint.AutoSize = true;
            this.FirstPoint.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPoint.Location = new System.Drawing.Point(17, 114);
            this.FirstPoint.Name = "FirstPoint";
            this.FirstPoint.Size = new System.Drawing.Size(169, 22);
            this.FirstPoint.TabIndex = 3;
            this.FirstPoint.Text = "Start Point (x1, y1):";
            // 
            // SecondPoint
            // 
            this.SecondPoint.AutoSize = true;
            this.SecondPoint.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPoint.Location = new System.Drawing.Point(16, 149);
            this.SecondPoint.Name = "SecondPoint";
            this.SecondPoint.Size = new System.Drawing.Size(159, 22);
            this.SecondPoint.TabIndex = 4;
            this.SecondPoint.Text = "End Point (x2, y2):";
            // 
            // ShapeSelection
            // 
            this.ShapeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeSelection.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeSelection.FormattingEnabled = true;
            this.ShapeSelection.Items.AddRange(new object[] {
            "Line",
            "Triangle",
            "Rectangle",
            "Circle"});
            this.ShapeSelection.Location = new System.Drawing.Point(293, 19);
            this.ShapeSelection.Name = "ShapeSelection";
            this.ShapeSelection.Size = new System.Drawing.Size(267, 29);
            this.ShapeSelection.TabIndex = 0;
            this.ShapeSelection.SelectedIndexChanged += new System.EventHandler(this.ShapeSelection_SelectedIndexChanged);
            // 
            // X1
            // 
            this.X1.BackColor = System.Drawing.Color.White;
            this.X1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.Location = new System.Drawing.Point(363, 107);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(93, 29);
            this.X1.TabIndex = 2;
            // 
            // Y1
            // 
            this.Y1.BackColor = System.Drawing.Color.White;
            this.Y1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y1.Location = new System.Drawing.Point(462, 107);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(98, 29);
            this.Y1.TabIndex = 3;
            // 
            // LineMethod
            // 
            this.LineMethod.DisplayMember = "1";
            this.LineMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineMethod.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineMethod.FormattingEnabled = true;
            this.LineMethod.Items.AddRange(new object[] {
            "Digital Differential Analyzer (DDA)",
            "Bresenham Line Algorithm",
            "Built-in Functions"});
            this.LineMethod.Location = new System.Drawing.Point(293, 65);
            this.LineMethod.Name = "LineMethod";
            this.LineMethod.Size = new System.Drawing.Size(267, 29);
            this.LineMethod.TabIndex = 1;
            this.LineMethod.SelectedIndexChanged += new System.EventHandler(this.LineMethod_SelectedIndexChanged);
            // 
            // X2
            // 
            this.X2.BackColor = System.Drawing.Color.White;
            this.X2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2.Location = new System.Drawing.Point(363, 142);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(93, 29);
            this.X2.TabIndex = 4;
            // 
            // Y2
            // 
            this.Y2.BackColor = System.Drawing.Color.White;
            this.Y2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y2.Location = new System.Drawing.Point(462, 142);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(98, 29);
            this.Y2.TabIndex = 5;
            // 
            // DrawButton
            // 
            this.DrawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DrawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.ForeColor = System.Drawing.Color.IndianRed;
            this.DrawButton.Location = new System.Drawing.Point(474, 571);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(115, 51);
            this.DrawButton.TabIndex = 11;
            this.DrawButton.Text = "Draw  ";
            this.DrawButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(353, 571);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 51);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Y3
            // 
            this.Y3.BackColor = System.Drawing.Color.White;
            this.Y3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y3.Location = new System.Drawing.Point(462, 177);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(98, 29);
            this.Y3.TabIndex = 6;
            // 
            // X3
            // 
            this.X3.BackColor = System.Drawing.Color.White;
            this.X3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X3.Location = new System.Drawing.Point(363, 177);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(93, 29);
            this.X3.TabIndex = 7;
            // 
            // ThirdPoint
            // 
            this.ThirdPoint.AutoSize = true;
            this.ThirdPoint.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPoint.Location = new System.Drawing.Point(16, 184);
            this.ThirdPoint.Name = "ThirdPoint";
            this.ThirdPoint.Size = new System.Drawing.Size(175, 22);
            this.ThirdPoint.TabIndex = 6;
            this.ThirdPoint.Text = "Third Point (X3, Y3):";
            // 
            // angle
            // 
            this.angle.BackColor = System.Drawing.Color.White;
            this.angle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angle.Location = new System.Drawing.Point(363, 86);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(197, 29);
            this.angle.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rotation Angle (θ):";
            // 
            // Sy
            // 
            this.Sy.BackColor = System.Drawing.Color.White;
            this.Sy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sy.Location = new System.Drawing.Point(462, 51);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(98, 29);
            this.Sy.TabIndex = 11;
            // 
            // Sx
            // 
            this.Sx.BackColor = System.Drawing.Color.White;
            this.Sx.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sx.Location = new System.Drawing.Point(363, 51);
            this.Sx.Name = "Sx";
            this.Sx.Size = new System.Drawing.Size(93, 29);
            this.Sx.TabIndex = 10;
            // 
            // Ty
            // 
            this.Ty.BackColor = System.Drawing.Color.White;
            this.Ty.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ty.Location = new System.Drawing.Point(462, 16);
            this.Ty.Name = "Ty";
            this.Ty.Size = new System.Drawing.Size(98, 29);
            this.Ty.TabIndex = 9;
            // 
            // Tx
            // 
            this.Tx.BackColor = System.Drawing.Color.White;
            this.Tx.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx.Location = new System.Drawing.Point(363, 16);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(93, 29);
            this.Tx.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Scaling Values (Sx, Sy):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Translation Values (Tx, Ty):";
            // 
            // DrawingBoard
            // 
            this.DrawingBoard.BackColor = System.Drawing.Color.White;
            this.DrawingBoard.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawingBoard.Location = new System.Drawing.Point(595, 12);
            this.DrawingBoard.Name = "DrawingBoard";
            this.DrawingBoard.Size = new System.Drawing.Size(657, 657);
            this.DrawingBoard.TabIndex = 5;
            this.DrawingBoard.TabStop = false;
            this.DrawingBoard.Click += new System.EventHandler(this.DrawingBoard_Click);
            this.DrawingBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseDown);
            this.DrawingBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingBoard_MouseMove);
            // 
            // LocationText
            // 
            this.LocationText.AutoSize = true;
            this.LocationText.BackColor = System.Drawing.Color.Silver;
            this.LocationText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationText.ForeColor = System.Drawing.Color.White;
            this.LocationText.Location = new System.Drawing.Point(391, 650);
            this.LocationText.Name = "LocationText";
            this.LocationText.Size = new System.Drawing.Size(17, 19);
            this.LocationText.TabIndex = 4;
            this.LocationText.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Drawing Shapes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "2D Transformations";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.ShapeSelection);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.methodText);
            this.panel1.Controls.Add(this.FirstPoint);
            this.panel1.Controls.Add(this.SecondPoint);
            this.panel1.Controls.Add(this.X1);
            this.panel1.Controls.Add(this.Y1);
            this.panel1.Controls.Add(this.LineMethod);
            this.panel1.Controls.Add(this.X2);
            this.panel1.Controls.Add(this.Y2);
            this.panel1.Controls.Add(this.ThirdPoint);
            this.panel1.Controls.Add(this.X3);
            this.panel1.Controls.Add(this.Y3);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 237);
            this.panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(462, 142);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(98, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.Tx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Ty);
            this.panel2.Controls.Add(this.Sx);
            this.panel2.Controls.Add(this.Sy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.angle);
            this.panel2.Location = new System.Drawing.Point(12, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 134);
            this.panel2.TabIndex = 0;
            // 
            // lineColor
            // 
            this.lineColor.BackColor = System.Drawing.Color.Black;
            this.lineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineColor.Location = new System.Drawing.Point(113, 507);
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(25, 25);
            this.lineColor.TabIndex = 15;
            this.lineColor.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Line Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(391, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Click On Board to get points";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(552, 584);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(427, 584);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineColor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LocationText);
            this.Controls.Add(this.DrawingBoard);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBoard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label methodText;
        private System.Windows.Forms.Label FirstPoint;
        private System.Windows.Forms.Label SecondPoint;
        private System.Windows.Forms.ComboBox ShapeSelection;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.ComboBox LineMethod;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.Label ThirdPoint;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.TextBox Sx;
        private System.Windows.Forms.TextBox Ty;
        private System.Windows.Forms.TextBox Tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox DrawingBoard;
        private System.Windows.Forms.Label LocationText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lineColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

