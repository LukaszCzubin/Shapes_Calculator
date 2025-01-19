namespace app1
{
    partial class myFifthCustmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myFifthCustmControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            A = new TextBox();
            B = new TextBox();
            button1 = new Button();
            label4 = new Label();
            P = new Label();
            pictureBox1 = new PictureBox();
            side2 = new Label();
            side1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(339, 20);
            label1.Name = "label1";
            label1.Size = new Size(102, 40);
            label1.TabIndex = 0;
            label1.Text = "ROMB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 89);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj przekątną E:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 138);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 2;
            label3.Text = "Podaj przekątną F:";
            // 
            // A
            // 
            A.Location = new Point(245, 98);
            A.Name = "A";
            A.Size = new Size(109, 23);
            A.TabIndex = 3;
            // 
            // B
            // 
            B.Location = new Point(245, 149);
            B.Name = "B";
            B.Size = new Size(109, 23);
            B.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(36, 187);
            button1.Name = "button1";
            button1.Size = new Size(318, 55);
            button1.TabIndex = 5;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 269);
            label4.Name = "label4";
            label4.Size = new Size(68, 32);
            label4.TabIndex = 6;
            label4.Text = "POLE";
            label4.Click += label4_Click;
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(110, 269);
            P.Name = "P";
            P.Size = new Size(29, 32);
            P.TabIndex = 7;
            P.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(416, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // side2
            // 
            side2.AutoSize = true;
            side2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side2.Location = new Point(659, 242);
            side2.Name = "side2";
            side2.Size = new Size(26, 32);
            side2.TabIndex = 9;
            side2.Text = "F";
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(580, 200);
            side1.Name = "side1";
            side1.Size = new Size(26, 32);
            side1.TabIndex = 10;
            side1.Text = "E";
            // 
            // myFifthCustmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(side1);
            Controls.Add(side2);
            Controls.Add(pictureBox1);
            Controls.Add(P);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "myFifthCustmControl";
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
        private Label side2;
        private Label side1;
    }
}
