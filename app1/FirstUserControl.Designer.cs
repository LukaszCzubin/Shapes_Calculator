namespace app1
{
    partial class FirstUserControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstUserControl));
            label1 = new Label();
            label2 = new Label();
            A = new TextBox();
            B = new TextBox();
            button1 = new Button();
            label3 = new Label();
            P = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            side1 = new Label();
            side2 = new Label();
            pole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 70);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Podaj bok A:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 127);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj bok B:";
            label2.Click += label2_Click;
            // 
            // A
            // 
            A.Location = new Point(197, 79);
            A.Name = "A";
            A.Size = new Size(100, 23);
            A.TabIndex = 2;
            A.TextChanged += A_TextChanged;
            // 
            // B
            // 
            B.Location = new Point(197, 138);
            B.Name = "B";
            B.Size = new Size(100, 23);
            B.TabIndex = 3;
            B.TextChanged += B_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Malgun Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 187);
            button1.Name = "button1";
            button1.Size = new Size(267, 62);
            button1.TabIndex = 4;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 288);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 5;
            label3.Text = "POLE";
            label3.Click += label3_Click;
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(107, 278);
            P.Name = "P";
            P.Size = new Size(41, 45);
            P.TabIndex = 6;
            P.Text = "X";
            P.Click += P_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(250, 16);
            label4.Name = "label4";
            label4.Size = new Size(343, 37);
            label4.TabIndex = 7;
            label4.Text = "TRÓJKĄT PROSTOKĄTNY";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(375, 245);
            side1.Name = "side1";
            side1.Size = new Size(30, 32);
            side1.TabIndex = 9;
            side1.Text = "A";
            side1.Click += label5_Click;
            // 
            // side2
            // 
            side2.AutoSize = true;
            side2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side2.Location = new Point(541, 377);
            side2.Name = "side2";
            side2.Size = new Size(28, 32);
            side2.TabIndex = 10;
            side2.Text = "B";
            side2.Click += side2_Click;
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pole.Location = new Point(514, 278);
            pole.Name = "pole";
            pole.Size = new Size(28, 32);
            pole.TabIndex = 11;
            pole.Text = "P";
            pole.Click += pole_Click;
            // 
            // FirstUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pole);
            Controls.Add(side2);
            Controls.Add(side1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(P);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FirstUserControl";
            Size = new Size(817, 423);
            Load += FirstUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox A;
        private TextBox B;
        private Button button1;
        private Label label3;
        private Label P;
        private Label label4;
        private PictureBox pictureBox1;
        private Label side1;
        private Label side2;
        private Label pole;
    }
}
