namespace WF_Project1
{
    partial class a
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
            btnCalcularEdad = new Button();
            Nombre = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtAnio = new TextBox();
            lblResultado = new TextBox();
            SuspendLayout();
            // 
            // labelone
            // 
            labelone.AutoSize = true;
            labelone.Location = new Point(109, 65);
            labelone.Name = "labelone";
            labelone.Size = new Size(0, 20);
            labelone.TabIndex = 0;
            labelone.Click += label1_Click;
            // 
            // btnCalcularEdad
            // 
            btnCalcularEdad.Location = new Point(21, 139);
            btnCalcularEdad.Name = "btnCalcularEdad";
            btnCalcularEdad.Size = new Size(157, 29);
            btnCalcularEdad.TabIndex = 1;
            btnCalcularEdad.Text = "Calcular Edad";
            btnCalcularEdad.UseVisualStyleBackColor = true;
            btnCalcularEdad.Click += btnCalcularEdad_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(38, 26);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 2;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Año de nacimiento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(109, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(153, 69);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(125, 27);
            txtAnio.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(227, 129);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(125, 47);
            lblResultado.TabIndex = 6;
            // 
            // a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtAnio);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(btnCalcularEdad);
            Controls.Add(labelone);
            Name = "a";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelone;
        private Button btnCalcularEdad;
        private Label Nombre;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtAnio;
        private TextBox lblResultado;
    }
}
