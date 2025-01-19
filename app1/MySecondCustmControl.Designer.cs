namespace app1
{
    partial class MySecondCustmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySecondCustmControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            A = new TextBox();
            B = new TextBox();
            H = new TextBox();
            button1 = new Button();
            label5 = new Label();
            P = new Label();
            pictureBox1 = new PictureBox();
            side1 = new Label();
            side2 = new Label();
            side3 = new Label();
            pole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(350, 19);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 0;
            label1.Text = "TRAPEZ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 66);
            label2.Name = "label2";
            label2.Size = new Size(146, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj Bok A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 2;
            label3.Text = "Podaj Bok B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 174);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 3;
            label4.Text = "Podaj H:";
            // 
            // A
            // 
            A.Location = new Point(174, 75);
            A.Name = "A";
            A.Size = new Size(100, 23);
            A.TabIndex = 4;
            // 
            // B
            // 
            B.Location = new Point(173, 125);
            B.Name = "B";
            B.Size = new Size(100, 23);
            B.TabIndex = 5;
            // 
            // H
            // 
            H.Location = new Point(173, 183);
            H.Name = "H";
            H.Size = new Size(100, 23);
            H.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(21, 221);
            button1.Name = "button1";
            button1.Size = new Size(252, 66);
            button1.TabIndex = 7;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 321);
            label5.Name = "label5";
            label5.Size = new Size(68, 32);
            label5.TabIndex = 8;
            label5.Text = "POLE";
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(140, 306);
            P.Name = "P";
            P.Size = new Size(42, 47);
            P.TabIndex = 9;
            P.Text = "X";
            P.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(523, 145);
            side1.Name = "side1";
            side1.Size = new Size(29, 32);
            side1.TabIndex = 11;
            side1.Text = "A";
            // 
            // side2
            // 
            side2.AutoSize = true;
            side2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side2.Location = new Point(553, 372);
            side2.Name = "side2";
            side2.Size = new Size(28, 32);
            side2.TabIndex = 12;
            side2.Text = "B";
            // 
            // side3
            // 
            side3.AutoSize = true;
            side3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side3.Location = new Point(595, 268);
            side3.Name = "side3";
            side3.Size = new Size(31, 32);
            side3.TabIndex = 13;
            side3.Text = "H";
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pole.Location = new Point(500, 268);
            pole.Name = "pole";
            pole.Size = new Size(27, 32);
            pole.TabIndex = 14;
            pole.Text = "P";
            // 
            // MySecondCustmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pole);
            Controls.Add(side3);
            Controls.Add(side2);
            Controls.Add(side1);
            Controls.Add(pictureBox1);
            Controls.Add(P);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(H);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MySecondCustmControl";
            Size = new Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox A;
        private TextBox B;
        private TextBox H;
        private Button button1;
        private Label label5;
        private Label P;
        private PictureBox pictureBox1;
        private Label side1;
        private Label side2;
        private Label side3;
        private Label pole;
    }
}
