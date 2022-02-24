
namespace ControleTickets
{
    partial class ConsultarTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarTicketsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_DataFim = new System.Windows.Forms.Label();
            this.lbl_DataInicio = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dtp_DataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_DataInicial = new System.Windows.Forms.DateTimePicker();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 45);
            this.menuStrip1.TabIndex = 7;
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
            this.inserirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem.Image")));
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(88, 41);
            this.inserirToolStripMenuItem.Text = "Ticket";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("inserirToolStripMenuItem1.Image")));
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(43, 162);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTickets.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTickets.RowTemplate.Height = 29;
            this.dgvTickets.Size = new System.Drawing.Size(956, 382);
            this.dgvTickets.TabIndex = 8;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.Location = new System.Drawing.Point(387, 68);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(294, 46);
            this.lb_Titulo.TabIndex = 10;
            this.lb_Titulo.Text = "Consultar Tickets";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_DataFim);
            this.panel1.Controls.Add(this.lbl_DataInicio);
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.dtp_DataFinal);
            this.panel1.Controls.Add(this.dtp_DataInicial);
            this.panel1.Controls.Add(this.dgvTickets);
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 567);
            this.panel1.TabIndex = 11;
            // 
            // lbl_DataFim
            // 
            this.lbl_DataFim.AutoSize = true;
            this.lbl_DataFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataFim.Location = new System.Drawing.Point(41, 105);
            this.lbl_DataFim.Name = "lbl_DataFim";
            this.lbl_DataFim.Size = new System.Drawing.Size(91, 23);
            this.lbl_DataFim.TabIndex = 13;
            this.lbl_DataFim.Text = "Data Final";
            // 
            // lbl_DataInicio
            // 
            this.lbl_DataInicio.AutoSize = true;
            this.lbl_DataInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataInicio.Location = new System.Drawing.Point(32, 54);
            this.lbl_DataInicio.Name = "lbl_DataInicio";
            this.lbl_DataInicio.Size = new System.Drawing.Size(100, 23);
            this.lbl_DataInicio.TabIndex = 12;
            this.lbl_DataInicio.Text = "Data Inicial";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_Consultar.Location = new System.Drawing.Point(417, 92);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(118, 37);
            this.btn_Consultar.TabIndex = 11;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            // 
            // dtp_DataFinal
            // 
            this.dtp_DataFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataFinal.Location = new System.Drawing.Point(138, 102);
            this.dtp_DataFinal.Name = "dtp_DataFinal";
            this.dtp_DataFinal.Size = new System.Drawing.Size(250, 27);
            this.dtp_DataFinal.TabIndex = 10;
            this.dtp_DataFinal.Value = new System.DateTime(2022, 2, 24, 12, 58, 4, 0);
            // 
            // dtp_DataInicial
            // 
            this.dtp_DataInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataInicial.Location = new System.Drawing.Point(138, 54);
            this.dtp_DataInicial.Name = "dtp_DataInicial";
            this.dtp_DataInicial.Size = new System.Drawing.Size(250, 27);
            this.dtp_DataInicial.TabIndex = 9;
            this.dtp_DataInicial.Value = new System.DateTime(2022, 2, 24, 13, 3, 13, 0);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 41);
            this.toolStripMenuItem1.Text = "Sair";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ConsultarTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarTicketsForm";
            this.Load += new System.EventHandler(this.ConsultarTicketsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_DataFim;
        private System.Windows.Forms.Label lbl_DataInicio;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DateTimePicker dtp_DataFinal;
        private System.Windows.Forms.DateTimePicker dtp_DataInicial;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}