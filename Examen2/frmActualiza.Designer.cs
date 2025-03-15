namespace Examen2
{
    partial class frmActualiza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualiza));
            btnBorrar = new Button();
            label5 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtAMaterno = new TextBox();
            label1 = new Label();
            txtAPaterno = new TextBox();
            pictureBox1 = new PictureBox();
            lID = new Label();
            txtID = new TextBox();
            btnActualizar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Gray;
            btnBorrar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = SystemColors.Window;
            btnBorrar.Location = new Point(12, 547);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 40);
            btnBorrar.TabIndex = 23;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(138, 456);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 22;
            label5.Text = "CORREO";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(138, 484);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(298, 27);
            txtCorreo.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(138, 379);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 20;
            label4.Text = "TELEFONO";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(138, 407);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(298, 27);
            txtTelefono.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(138, 301);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 18;
            label3.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(138, 329);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(138, 222);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 16;
            label2.Text = "AP MATERNO";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Location = new Point(138, 250);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(298, 27);
            txtAMaterno.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(138, 139);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 14;
            label1.Text = "AP PATERNO";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Location = new Point(138, 167);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(298, 27);
            txtAPaterno.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 106);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lID
            // 
            lID.AutoSize = true;
            lID.BackColor = Color.Transparent;
            lID.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lID.ForeColor = SystemColors.Control;
            lID.Location = new Point(12, 63);
            lID.Name = "lID";
            lID.Size = new Size(40, 25);
            lID.TabIndex = 25;
            lID.Text = "ID";
            lID.Visible = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 91);
            txtID.Name = "txtID";
            txtID.Size = new Size(73, 27);
            txtID.TabIndex = 24;
            txtID.Visible = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Gray;
            btnActualizar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.Window;
            btnActualizar.Location = new Point(184, 547);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(169, 40);
            btnActualizar.TabIndex = 26;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gray;
            btnCerrar.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.Window;
            btnCerrar.Location = new Point(373, 547);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 40);
            btnCerrar.TabIndex = 27;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmActualiza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(535, 619);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(lID);
            Controls.Add(txtID);
            Controls.Add(btnBorrar);
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
            Name = "frmActualiza";
            Text = "frmActualiza";
            Load += frmActualiza_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Label label5;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtAMaterno;
        private Label label1;
        private TextBox txtAPaterno;
        private PictureBox pictureBox1;
        private Label lID;
        private TextBox txtID;
        private Button btnActualizar;
        private Button btnCerrar;
    }
}