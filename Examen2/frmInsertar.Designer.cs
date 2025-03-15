namespace Examen2
{
    partial class frmInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertar));
            pictureBox1 = new PictureBox();
            txtAPaterno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAMaterno = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            btnInsertar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(66, 179);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(298, 27);
            txtAPaterno.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(66, 151);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 2;
            label1.Text = "AP PATERNO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(66, 234);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 4;
            label2.Text = "AP MATERNO";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(66, 262);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(298, 27);
            txtAMaterno.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(66, 313);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 6;
            label3.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 341);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(66, 402);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 8;
            label4.Text = "TELEFONO";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(66, 430);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(298, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(66, 479);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 10;
            label5.Text = "CORREO";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(66, 507);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(298, 27);
            txtCorreo.TabIndex = 9;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Gray;
            btnInsertar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = SystemColors.Window;
            btnInsertar.Location = new Point(66, 578);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(150, 40);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += button1_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.Window;
            btnCerrar.Location = new Point(228, 578);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(136, 40);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(416, 655);
            Controls.Add(btnCerrar);
            Controls.Add(btnInsertar);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtAMaterno);
            Controls.Add(label1);
            Controls.Add(txtAPaterno);
            Controls.Add(pictureBox1);
            Name = "frmInsertar";
            Text = "Insertar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtAPaterno;
        private Label label1;
        private Label label2;
        private TextBox txtAMaterno;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtCorreo;
        private Button btnInsertar;
        private Button btnCerrar;
    }
}