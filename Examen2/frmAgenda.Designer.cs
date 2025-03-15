namespace Examen2
{
    partial class frmAgenda
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
            dgvAgenda = new DataGridView();
            menuStrip1 = new MenuStrip();
            iNSERTARToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(0, 60);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.RowHeadersWidth = 51;
            dgvAgenda.Size = new Size(809, 448);
            dgvAgenda.TabIndex = 0;
            dgvAgenda.CellClick += dgvAgenda_CellClick;
            dgvAgenda.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCyan;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNSERTARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(809, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNSERTARToolStripMenuItem
            // 
            iNSERTARToolStripMenuItem.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iNSERTARToolStripMenuItem.Name = "iNSERTARToolStripMenuItem";
            iNSERTARToolStripMenuItem.Size = new Size(144, 29);
            iNSERTARToolStripMenuItem.Text = "INSERTAR";
            iNSERTARToolStripMenuItem.Click += iNSERTARToolStripMenuItem_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 494);
            Controls.Add(dgvAgenda);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAgenda";
            Text = "AGENDA";
            Activated += frmAgenda_Activated;
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAgenda;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNSERTARToolStripMenuItem;
    }
}