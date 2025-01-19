namespace app1
{
    partial class MyFourthCustmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyFourthCustmControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            A = new TextBox();
            B = new TextBox();
            button1 = new Button();
            label4 = new Label();
            P = new Label();
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
            label1.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 21);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 0;
            label1.Text = "PROSTOKĄT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj bok A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 140);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 2;
            label3.Text = "Podaj bok B:";
            // 
            // A
            // 
            A.Location = new Point(188, 96);
            A.Name = "A";
            A.Size = new Size(100, 23);
            A.TabIndex = 3;
            // 
            // B
            // 
            B.Location = new Point(188, 149);
            B.Name = "B";
            B.Size = new Size(100, 23);
            B.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(31, 187);
            button1.Name = "button1";
            button1.Size = new Size(257, 49);
            button1.TabIndex = 5;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 261);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 6;
            label4.Text = "POLE";
            label4.Click += label4_Click;
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(106, 261);
            P.Name = "P";
            P.Size = new Size(30, 32);
            P.TabIndex = 7;
            P.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(326, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(531, 121);
            side1.Name = "side1";
            side1.Size = new Size(30, 32);
            side1.TabIndex = 9;
            side1.Text = "A";
            // 
            // side2
            // 
            side2.AutoSize = true;
            side2.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side2.Location = new Point(350, 232);
            side2.Name = "side2";
            side2.Size = new Size(28, 32);
            side2.TabIndex = 10;
            side2.Text = "B";
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.Font = new Font("Malgun Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pole.Location = new Point(531, 232);
            pole.Name = "pole";
            pole.Size = new Size(28, 32);
            pole.TabIndex = 11;
            pole.Text = "P";
            // 
            // MyFourthCustmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pole);
            Controls.Add(side2);
            Controls.Add(side1);
            Controls.Add(pictureBox1);
            Controls.Add(P);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyFourthCustmControl";
            Size = new Size(817, 423);
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
        private Button button1;
        private Label label4;
        private Label P;
        private PictureBox pictureBox1;
        private Label side1;
        private Label side2;
        private Label pole;
    }
}
