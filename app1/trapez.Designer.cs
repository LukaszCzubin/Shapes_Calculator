namespace app1
{
    partial class trapez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trapez));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            A = new TextBox();
            B = new TextBox();
            label4 = new Label();
            H = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            side1 = new Label();
            side2 = new Label();
            wysokosc = new Label();
            label8 = new Label();
            P = new Label();
            pole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(358, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 65);
            label1.TabIndex = 0;
            label1.Text = "TRAPEZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 109);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj bok A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 154);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Podaj bok B:";
            // 
            // A
            // 
            A.Location = new Point(188, 118);
            A.Name = "A";
            A.Size = new Size(72, 23);
            A.TabIndex = 3;
            // 
            // B
            // 
            B.Location = new Point(188, 163);
            B.Name = "B";
            B.Size = new Size(72, 23);
            B.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 197);
            label4.Name = "label4";
            label4.Size = new Size(152, 32);
            label4.TabIndex = 5;
            label4.Text = "Podaj bok H:";
            // 
            // H
            // 
            H.Location = new Point(188, 208);
            H.Name = "H";
            H.Size = new Size(72, 23);
            H.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(35, 242);
            button1.Name = "button1";
            button1.Size = new Size(225, 51);
            button1.TabIndex = 7;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(458, 242);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.BackColor = SystemColors.ControlLightLight;
            side1.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(630, 242);
            side1.Name = "side1";
            side1.Size = new Size(30, 32);
            side1.TabIndex = 9;
            side1.Text = "A";
            side1.Click += label5_Click;
            // 
            // side2
            // 
            side2.AutoSize = true;
            side2.BackColor = SystemColors.ControlLightLight;
            side2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side2.Location = new Point(651, 470);
            side2.Name = "side2";
            side2.Size = new Size(28, 32);
            side2.TabIndex = 10;
            side2.Text = "B";
            // 
            // wysokosc
            // 
            wysokosc.AutoSize = true;
            wysokosc.BackColor = Color.FromArgb(255, 192, 192);
            wysokosc.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            wysokosc.Location = new Point(537, 349);
            wysokosc.Name = "wysokosc";
            wysokosc.Size = new Size(31, 32);
            wysokosc.TabIndex = 11;
            wysokosc.Text = "H";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(35, 337);
            label8.Name = "label8";
            label8.Size = new Size(76, 32);
            label8.TabIndex = 12;
            label8.Text = "POLE:";
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(117, 329);
            P.Name = "P";
            P.Size = new Size(28, 40);
            P.TabIndex = 13;
            P.Text = "f";
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.BackColor = Color.FromArgb(255, 192, 192);
            pole.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pole.Location = new Point(642, 349);
            pole.Name = "pole";
            pole.Size = new Size(28, 32);
            pole.TabIndex = 14;
            pole.Text = "P";
            // 
            // trapez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pole);
            Controls.Add(P);
            Controls.Add(label8);
            Controls.Add(wysokosc);
            Controls.Add(side2);
            Controls.Add(side1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(H);
            Controls.Add(label4);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trapez";
            Size = new Size(964, 531);
            Load += trapez_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox A;
        private TextBox B;
        private Label label4;
        private TextBox H;
        private Button button1;
        private PictureBox pictureBox1;
        private Label side1;
        private Label side2;
        private Label wysokosc;
        private Label label8;
        private Label P;
        private Label pole;
    }
}
