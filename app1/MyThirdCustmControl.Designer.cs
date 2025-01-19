namespace app1
{
    partial class MyThirdCustmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyThirdCustmControl));
            label1 = new Label();
            label2 = new Label();
            A = new TextBox();
            label3 = new Label();
            P = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            side1 = new Label();
            pole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(324, 14);
            label1.Name = "label1";
            label1.Size = new Size(108, 47);
            label1.TabIndex = 0;
            label1.Text = "KOŁO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(173, 32);
            label2.TabIndex = 1;
            label2.Text = "Podaj średnicę:";
            // 
            // A
            // 
            A.Location = new Point(213, 104);
            A.Name = "A";
            A.Size = new Size(100, 23);
            A.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 221);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 3;
            label3.Text = "POLE";
            // 
            // P
            // 
            P.AutoSize = true;
            P.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            P.Location = new Point(101, 221);
            P.Name = "P";
            P.Size = new Size(30, 32);
            P.TabIndex = 4;
            P.Text = "X";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(27, 144);
            button1.Name = "button1";
            button1.Size = new Size(286, 54);
            button1.TabIndex = 5;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // side1
            // 
            side1.AutoSize = true;
            side1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            side1.Location = new Point(641, 221);
            side1.Name = "side1";
            side1.Size = new Size(22, 32);
            side1.TabIndex = 7;
            side1.Text = "r";
            // 
            // pole
            // 
            pole.AutoSize = true;
            pole.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            pole.Location = new Point(581, 166);
            pole.Name = "pole";
            pole.Size = new Size(33, 40);
            pole.TabIndex = 8;
            pole.Text = "P";
            // 
            // MyThirdCustmControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pole);
            Controls.Add(side1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(P);
            Controls.Add(label3);
            Controls.Add(A);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MyThirdCustmControl";
            Size = new Size(817, 423);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox A;
        private Label label3;
        private Label P;
        private Button button1;
        private PictureBox pictureBox1;
        private Label side1;
        private Label pole;
    }
}
