
namespace ControleTickets
{
    partial class TicketCadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketCadastroForm));
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_HoraInicio = new System.Windows.Forms.Label();
            this.lbl_HorarioFim = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_HorasGastas = new System.Windows.Forms.Label();
            this.panel_content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_Decricao = new System.Windows.Forms.TextBox();
            this.txt_HorasGastas = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.dt_HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dt_HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_content.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(170, 115);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(58, 19);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraInicio.Location = new System.Drawing.Point(122, 158);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(105, 19);
            this.lbl_HoraInicio.TabIndex = 1;
            this.lbl_HoraInicio.Text = "Horário Inicial";
            // 
            // lbl_HorarioFim
            // 
            this.lbl_HorarioFim.AutoSize = true;
            this.lbl_HorarioFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorarioFim.Location = new System.Drawing.Point(375, 154);
            this.lbl_HorarioFim.Name = "lbl_HorarioFim";
            this.lbl_HorarioFim.Size = new System.Drawing.Size(97, 19);
            this.lbl_HorarioFim.TabIndex = 2;
            this.lbl_HorarioFim.Text = "Horário Final";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(196, 190);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(40, 19);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_HorasGastas
            // 
            this.lbl_HorasGastas.AutoSize = true;
            this.lbl_HorasGastas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorasGastas.Location = new System.Drawing.Point(383, 191);
            this.lbl_HorasGastas.Name = "lbl_HorasGastas";
            this.lbl_HorasGastas.Size = new System.Drawing.Size(98, 17);
            this.lbl_HorasGastas.TabIndex = 4;
            this.lbl_HorasGastas.Text = "Total de Horas";
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.White;
            this.panel_content.Controls.Add(this.label1);
            this.panel_content.Controls.Add(this.lbl_descricao);
            this.panel_content.Controls.Add(this.txt_Decricao);
            this.panel_content.Controls.Add(this.txt_HorasGastas);
            this.panel_content.Controls.Add(this.btn_Inserir);
            this.panel_content.Controls.Add(this.dt_HoraFinal);
            this.panel_content.Controls.Add(this.dt_HoraInicio);
            this.panel_content.Controls.Add(this.dt_Data);
            this.panel_content.Controls.Add(this.txt_Codigo);
            this.panel_content.Controls.Add(this.lbl_HoraInicio);
            this.panel_content.Controls.Add(this.lbl_HorasGastas);
            this.panel_content.Controls.Add(this.lbl_Codigo);
            this.panel_content.Controls.Add(this.lbl_Data);
            this.panel_content.Controls.Add(this.lbl_HorarioFim);
            this.panel_content.Controls.Add(this.menuStrip1);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(909, 575);
            this.panel_content.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastrar tarefas";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descricao.Location = new System.Drawing.Point(86, 254);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(89, 19);
            this.lbl_descricao.TabIndex = 12;
            this.lbl_descricao.Text = "Descricação";
            // 
            // txt_Decricao
            // 
            this.txt_Decricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Decricao.Location = new System.Drawing.Point(193, 251);
            this.txt_Decricao.Multiline = true;
            this.txt_Decricao.Name = "txt_Decricao";
            this.txt_Decricao.Size = new System.Drawing.Size(585, 306);
            this.txt_Decricao.TabIndex = 11;
            // 
            // txt_HorasGastas
            // 
            this.txt_HorasGastas.Location = new System.Drawing.Point(487, 187);
            this.txt_HorasGastas.Name = "txt_HorasGastas";
            this.txt_HorasGastas.Size = new System.Drawing.Size(128, 25);
            this.txt_HorasGastas.TabIndex = 10;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Inserir.FlatAppearance.BorderSize = 0;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inserir.ForeColor = System.Drawing.Color.White;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Inserir.Location = new System.Drawing.Point(635, 184);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(82, 29);
            this.btn_Inserir.TabIndex = 9;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // dt_HoraFinal
            // 
            this.dt_HoraFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraFinal.Location = new System.Drawing.Point(487, 153);
            this.dt_HoraFinal.Name = "dt_HoraFinal";
            this.dt_HoraFinal.Size = new System.Drawing.Size(128, 25);
            this.dt_HoraFinal.TabIndex = 8;
            this.dt_HoraFinal.ValueChanged += new System.EventHandler(this.dt_HoraFinal_ValueChanged);
            // 
            // dt_HoraInicio
            // 
            this.dt_HoraInicio.CustomFormat = "";
            this.dt_HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraInicio.Location = new System.Drawing.Point(242, 154);
            this.dt_HoraInicio.Name = "dt_HoraInicio";
            this.dt_HoraInicio.Size = new System.Drawing.Size(121, 25);
            this.dt_HoraInicio.TabIndex = 7;
            this.dt_HoraInicio.Value = new System.DateTime(2022, 7, 20, 22, 38, 0, 0);
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(242, 186);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(121, 25);
            this.dt_Data.TabIndex = 6;
            this.dt_Data.Value = new System.DateTime(2022, 2, 23, 21, 56, 50, 0);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(242, 111);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(373, 25);
            this.txt_Codigo.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(909, 27);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.ticketsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.ticketsToolStripMenuItem.Text = "Tarefas";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inserirToolStripMenuItem.Image = global::ControleTickets.Properties.Resources.task_list_square_add_regular_icon_203206;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consultarToolStripMenuItem.Image = global::ControleTickets.Properties.Resources.search_interface_symbol;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // TicketCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 575);
            this.Controls.Add(this.panel_content);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicketCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TicketCadastroForm_Load);
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_HoraInicio;
        private System.Windows.Forms.Label lbl_HorarioFim;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_HorasGastas;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.TextBox txt_HorasGastas;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.DateTimePicker dt_HoraFinal;
        private System.Windows.Forms.DateTimePicker dt_HoraInicio;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Decricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}