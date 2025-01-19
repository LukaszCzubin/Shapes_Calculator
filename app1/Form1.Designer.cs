namespace app1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            SidePanel = new Panel();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            firstUserControl1 = new FirstUserControl();
            label1 = new Label();
            label2 = new Label();
            mySecondCustmControl1 = new MySecondCustmControl();
            myThirdCustmControl1 = new MyThirdCustmControl();
            myFourthCustmControl1 = new MyFourthCustmControl();
            myFifthCustmControl1 = new myFifthCustmControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(231, 626);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 34);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 11;
            label3.Text = "MANDOOO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.RoyalBlue;
            SidePanel.Location = new Point(1, 91);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 100);
            SidePanel.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(231, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 70);
            panel3.TabIndex = 4;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 509);
            button5.Name = "button5";
            button5.Size = new Size(231, 98);
            button5.TabIndex = 4;
            button5.Text = "Rhombus";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 405);
            button4.Name = "button4";
            button4.Size = new Size(231, 98);
            button4.TabIndex = 3;
            button4.Text = "Rectangle";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 301);
            button3.Name = "button3";
            button3.Size = new Size(228, 98);
            button3.TabIndex = 2;
            button3.Text = "Circle";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 197);
            button2.Name = "button2";
            button2.Size = new Size(231, 98);
            button2.TabIndex = 1;
            button2.Text = "Trapeze";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 93);
            button1.Name = "button1";
            button1.Size = new Size(231, 98);
            button1.TabIndex = 0;
            button1.Text = "Triangle";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(231, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 10);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // firstUserControl1
            // 
            firstUserControl1.Location = new Point(246, 184);
            firstUserControl1.Name = "firstUserControl1";
            firstUserControl1.Size = new Size(817, 423);
            firstUserControl1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(352, 24);
            label1.Name = "label1";
            label1.Size = new Size(609, 65);
            label1.TabIndex = 5;
            label1.Text = "KALKULATOR KSZTAŁTÓW";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(564, 93);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 6;
            label2.Text = "ŁUKASZ CZUBIN";
            // 
            // mySecondCustmControl1
            // 
            mySecondCustmControl1.Location = new Point(246, 197);
            mySecondCustmControl1.Name = "mySecondCustmControl1";
            mySecondCustmControl1.Size = new Size(817, 423);
            mySecondCustmControl1.TabIndex = 7;
            // 
            // myThirdCustmControl1
            // 
            myThirdCustmControl1.Location = new Point(255, 184);
            myThirdCustmControl1.Name = "myThirdCustmControl1";
            myThirdCustmControl1.Size = new Size(817, 423);
            myThirdCustmControl1.TabIndex = 8;
            // 
            // myFourthCustmControl1
            // 
            myFourthCustmControl1.Location = new Point(255, 184);
            myFourthCustmControl1.Name = "myFourthCustmControl1";
            myFourthCustmControl1.Size = new Size(817, 423);
            myFourthCustmControl1.TabIndex = 9;
            // 
            // myFifthCustmControl1
            // 
            myFifthCustmControl1.Location = new Point(258, 184);
            myFifthCustmControl1.Name = "myFifthCustmControl1";
            myFifthCustmControl1.Size = new Size(817, 423);
            myFifthCustmControl1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1075, 626);
            Controls.Add(myFifthCustmControl1);
            Controls.Add(myFourthCustmControl1);
            Controls.Add(myThirdCustmControl1);
            Controls.Add(mySecondCustmControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstUserControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel SidePanel;
        private Panel panel3;
        private FirstUserControl firstUserControl1;
        private Label label1;
        private Label label2;
        private MySecondCustmControl mySecondCustmControl1;
        private MyThirdCustmControl myThirdCustmControl1;
        private MyFourthCustmControl myFourthCustmControl1;
        private myFifthCustmControl myFifthCustmControl1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}