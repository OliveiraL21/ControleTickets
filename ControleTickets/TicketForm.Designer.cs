
namespace ControleTickets
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lbl_total_horas = new System.Windows.Forms.Label();
            this.lbl_valor_total_horas = new System.Windows.Forms.Label();
            this.lbl_qtdTickets = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(58, 426);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.consultarToolStripMenuItem});
            this.inserirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.inserirToolStripMenuItem.Text = "Ticket";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem1.Image")));
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.BackColor = System.Drawing.Color.White;
            this.lbl_Descricao.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descricao.ForeColor = System.Drawing.Color.Black;
            this.lbl_Descricao.Location = new System.Drawing.Point(61, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(754, 40);
            this.lbl_Descricao.TabIndex = 1;
            this.lbl_Descricao.Text = "Controle de Tickets";
            this.lbl_Descricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // lbl_total_horas
            // 
            this.lbl_total_horas.AutoSize = true;
            this.lbl_total_horas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_total_horas.Location = new System.Drawing.Point(83, 131);
            this.lbl_total_horas.Name = "lbl_total_horas";
            this.lbl_total_horas.Size = new System.Drawing.Size(127, 21);
            this.lbl_total_horas.TabIndex = 2;
            this.lbl_total_horas.Text = "Total de Horas: ";
            // 
            // lbl_valor_total_horas
            // 
            this.lbl_valor_total_horas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor_total_horas.Location = new System.Drawing.Point(216, 134);
            this.lbl_valor_total_horas.Name = "lbl_valor_total_horas";
            this.lbl_valor_total_horas.Size = new System.Drawing.Size(100, 21);
            this.lbl_valor_total_horas.TabIndex = 3;
            // 
            // lbl_qtdTickets
            // 
            this.lbl_qtdTickets.AutoSize = true;
            this.lbl_qtdTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qtdTickets.Location = new System.Drawing.Point(80, 171);
            this.lbl_qtdTickets.Name = "lbl_qtdTickets";
            this.lbl_qtdTickets.Size = new System.Drawing.Size(191, 21);
            this.lbl_qtdTickets.TabIndex = 4;
            this.lbl_qtdTickets.Text = "Quantidades de Tickets:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_quantidade.Location = new System.Drawing.Point(277, 174);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(100, 21);
            this.lbl_quantidade.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleTickets.Properties.Resources.work_station;
            this.pictureBox1.Location = new System.Drawing.Point(383, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_qtdTickets);
            this.Controls.Add(this.lbl_valor_total_horas);
            this.Controls.Add(this.lbl_total_horas);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Descricao;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lbl_total_horas;
        private System.Windows.Forms.Label lbl_valor_total_horas;
        private System.Windows.Forms.Label lbl_qtdTickets;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}