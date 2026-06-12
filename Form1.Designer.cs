namespace WF_Project1
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
            labelone = new Label();
            button1 = new Button();
            txtNombre = new TextBox();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            txtNumero = new Label();
            lblNumero = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelone
            // 
            labelone.AutoSize = true;
            labelone.Location = new Point(109, 65);
            labelone.Name = "labelone";
            labelone.Size = new Size(130, 20);
            labelone.TabIndex = 0;
            labelone.Text = "ingreas tu nombre";
            labelone.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Location = new Point(403, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "saludar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Info;
            txtNombre.Location = new Point(254, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(420, 223);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "aumentar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(616, 194);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 11, 0, 0, 0 });
            // 
            // txtNumero
            // 
            txtNumero.AutoSize = true;
            txtNumero.Location = new Point(338, 281);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(17, 20);
            txtNumero.TabIndex = 5;
            txtNumero.Text = "0";
            txtNumero.Click += txtNumero_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(338, 232);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(50, 20);
            lblNumero.TabIndex = 6;
            lblNumero.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Controls.Add(labelone);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelone;
        private Button button1;
        private TextBox txtNombre;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label txtNumero;
        private Label lblNumero;
    }
}
