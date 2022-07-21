
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.TicketId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHorasGasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_CalcularTotalDiario = new System.Windows.Forms.Button();
            this.btn_CalcularTotalHoras = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Detalhes = new System.Windows.Forms.Button();
            this.lbl_Acoes = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_DataInicio = new System.Windows.Forms.Label();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.dtp_DataInicial = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.minimizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(953, 34);
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
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(77, 30);
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
            this.consultarToolStripMenuItem.Image = global::ControleTickets.Properties.Resources.Search_find_locate_321;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 30);
            this.toolStripMenuItem1.Text = "Sair";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizarToolStripMenuItem.Image")));
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(94, 30);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TicketId,
            this.Codigo,
            this.HoraInicio,
            this.HorarioFinal,
            this.TotalHorasGasta,
            this.Data,
            this.Descricao});
            this.dgvTickets.Location = new System.Drawing.Point(38, 122);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTickets.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTickets.RowTemplate.Height = 29;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(836, 286);
            this.dgvTickets.TabIndex = 8;
            this.dgvTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellClick);
            // 
            // TicketId
            // 
            this.TicketId.HeaderText = "Id";
            this.TicketId.MinimumWidth = 6;
            this.TicketId.Name = "TicketId";
            this.TicketId.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Horário de Inicio";
            this.HoraInicio.MinimumWidth = 6;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HorarioFinal
            // 
            this.HorarioFinal.HeaderText = "Horário Final";
            this.HorarioFinal.MinimumWidth = 6;
            this.HorarioFinal.Name = "HorarioFinal";
            this.HorarioFinal.ReadOnly = true;
            // 
            // TotalHorasGasta
            // 
            this.TotalHorasGasta.HeaderText = "Total de Horas Gastas";
            this.TotalHorasGasta.MinimumWidth = 6;
            this.TotalHorasGasta.Name = "TotalHorasGasta";
            this.TotalHorasGasta.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.Location = new System.Drawing.Point(339, 51);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(237, 37);
            this.lb_Titulo.TabIndex = 10;
            this.lb_Titulo.Text = "Consultar Tickets";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_Codigo);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.lbl_DataInicio);
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.dtp_DataInicial);
            this.panel1.Controls.Add(this.dgvTickets);
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 449);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_CalcularTotalDiario);
            this.panel2.Controls.Add(this.btn_CalcularTotalHoras);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Atualizar);
            this.panel2.Controls.Add(this.btn_Detalhes);
            this.panel2.Controls.Add(this.lbl_Acoes);
            this.panel2.Location = new System.Drawing.Point(876, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 351);
            this.panel2.TabIndex = 17;
            // 
            // btn_CalcularTotalDiario
            // 
            this.btn_CalcularTotalDiario.BackColor = System.Drawing.Color.Transparent;
            this.btn_CalcularTotalDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CalcularTotalDiario.Image = global::ControleTickets.Properties.Resources.tempo;
            this.btn_CalcularTotalDiario.Location = new System.Drawing.Point(17, 203);
            this.btn_CalcularTotalDiario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CalcularTotalDiario.Name = "btn_CalcularTotalDiario";
            this.btn_CalcularTotalDiario.Size = new System.Drawing.Size(38, 40);
            this.btn_CalcularTotalDiario.TabIndex = 23;
            this.btn_CalcularTotalDiario.UseVisualStyleBackColor = false;
            this.btn_CalcularTotalDiario.Click += new System.EventHandler(this.btn_CalcularTotalDiario_Click);
            // 
            // btn_CalcularTotalHoras
            // 
            this.btn_CalcularTotalHoras.BackColor = System.Drawing.Color.Transparent;
            this.btn_CalcularTotalHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CalcularTotalHoras.Image = global::ControleTickets.Properties.Resources.adicionar;
            this.btn_CalcularTotalHoras.Location = new System.Drawing.Point(17, 161);
            this.btn_CalcularTotalHoras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CalcularTotalHoras.Name = "btn_CalcularTotalHoras";
            this.btn_CalcularTotalHoras.Size = new System.Drawing.Size(38, 38);
            this.btn_CalcularTotalHoras.TabIndex = 21;
            this.btn_CalcularTotalHoras.UseVisualStyleBackColor = false;
            this.btn_CalcularTotalHoras.Click += new System.EventHandler(this.btn_CalcularTotalHoras_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.AutoEllipsis = true;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = global::ControleTickets.Properties.Resources.excluir;
            this.btn_Delete.Location = new System.Drawing.Point(17, 249);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(38, 34);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Atualizar.Image")));
            this.btn_Atualizar.Location = new System.Drawing.Point(17, 117);
            this.btn_Atualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(38, 38);
            this.btn_Atualizar.TabIndex = 20;
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Detalhes
            // 
            this.btn_Detalhes.BackColor = System.Drawing.Color.Transparent;
            this.btn_Detalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Detalhes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Detalhes.Image")));
            this.btn_Detalhes.Location = new System.Drawing.Point(17, 73);
            this.btn_Detalhes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Detalhes.Name = "btn_Detalhes";
            this.btn_Detalhes.Size = new System.Drawing.Size(38, 38);
            this.btn_Detalhes.TabIndex = 19;
            this.btn_Detalhes.UseVisualStyleBackColor = false;
            this.btn_Detalhes.Click += new System.EventHandler(this.btn_Detalhes_Click);
            // 
            // lbl_Acoes
            // 
            this.lbl_Acoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Acoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Acoes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Acoes.Location = new System.Drawing.Point(0, 24);
            this.lbl_Acoes.Name = "lbl_Acoes";
            this.lbl_Acoes.Size = new System.Drawing.Size(74, 38);
            this.lbl_Acoes.TabIndex = 0;
            this.lbl_Acoes.Text = "Ações";
            this.lbl_Acoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(28, 13);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(58, 19);
            this.lbl_Codigo.TabIndex = 15;
            this.lbl_Codigo.Text = "Código";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(121, 10);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(120, 23);
            this.txt_Codigo.TabIndex = 14;
            // 
            // lbl_DataInicio
            // 
            this.lbl_DataInicio.AutoSize = true;
            this.lbl_DataInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataInicio.Location = new System.Drawing.Point(28, 40);
            this.lbl_DataInicio.Name = "lbl_DataInicio";
            this.lbl_DataInicio.Size = new System.Drawing.Size(83, 19);
            this.lbl_DataInicio.TabIndex = 12;
            this.lbl_DataInicio.Text = "Data Inicial";
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_Consultar.Location = new System.Drawing.Point(360, 36);
            this.btn_Consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(103, 28);
            this.btn_Consultar.TabIndex = 11;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // dtp_DataInicial
            // 
            this.dtp_DataInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataInicial.Location = new System.Drawing.Point(121, 40);
            this.dtp_DataInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DataInicial.Name = "dtp_DataInicial";
            this.dtp_DataInicial.Size = new System.Drawing.Size(219, 23);
            this.dtp_DataInicial.TabIndex = 9;
            this.dtp_DataInicial.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // ConsultarTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultarTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarTicketsForm";
            this.Load += new System.EventHandler(this.ConsultarTicketsForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_DataInicio;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.DateTimePicker dtp_DataInicial;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHorasGasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Acoes;
        private System.Windows.Forms.Button btn_Detalhes;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_CalcularTotalHoras;
        private System.Windows.Forms.Button btn_CalcularTotalDiario;
    }
}