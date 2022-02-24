
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Decricao = new System.Windows.Forms.TextBox();
            this.txt_HorasGastas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dt_HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dt_HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(79, 13);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(68, 23);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraInicio.Location = new System.Drawing.Point(24, 50);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(123, 23);
            this.lbl_HoraInicio.TabIndex = 1;
            this.lbl_HoraInicio.Text = "Horário Inicial";
            // 
            // lbl_HorarioFim
            // 
            this.lbl_HorarioFim.AutoSize = true;
            this.lbl_HorarioFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorarioFim.Location = new System.Drawing.Point(313, 46);
            this.lbl_HorarioFim.Name = "lbl_HorarioFim";
            this.lbl_HorarioFim.Size = new System.Drawing.Size(114, 23);
            this.lbl_HorarioFim.TabIndex = 2;
            this.lbl_HorarioFim.Text = "Horário Final";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(99, 88);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(48, 23);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_HorasGastas
            // 
            this.lbl_HorasGastas.AutoSize = true;
            this.lbl_HorasGastas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorasGastas.Location = new System.Drawing.Point(316, 91);
            this.lbl_HorasGastas.Name = "lbl_HorasGastas";
            this.lbl_HorasGastas.Size = new System.Drawing.Size(110, 20);
            this.lbl_HorasGastas.TabIndex = 4;
            this.lbl_HorasGastas.Text = "Total de Horas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Decricao);
            this.panel1.Controls.Add(this.txt_HorasGastas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dt_HoraFinal);
            this.panel1.Controls.Add(this.dt_HoraInicio);
            this.panel1.Controls.Add(this.dt_Data);
            this.panel1.Controls.Add(this.txt_Codigo);
            this.panel1.Controls.Add(this.lbl_HoraInicio);
            this.panel1.Controls.Add(this.lbl_HorasGastas);
            this.panel1.Controls.Add(this.lbl_Codigo);
            this.panel1.Controls.Add(this.lbl_Data);
            this.panel1.Controls.Add(this.lbl_HorarioFim);
            this.panel1.Location = new System.Drawing.Point(31, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 568);
            this.panel1.TabIndex = 5;
            // 
            // txt_Decricao
            // 
            this.txt_Decricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Decricao.Location = new System.Drawing.Point(161, 212);
            this.txt_Decricao.Multiline = true;
            this.txt_Decricao.Name = "txt_Decricao";
            this.txt_Decricao.Size = new System.Drawing.Size(668, 283);
            this.txt_Decricao.TabIndex = 11;
            // 
            // txt_HorasGastas
            // 
            this.txt_HorasGastas.Location = new System.Drawing.Point(441, 84);
            this.txt_HorasGastas.Name = "txt_HorasGastas";
            this.txt_HorasGastas.Size = new System.Drawing.Size(146, 27);
            this.txt_HorasGastas.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(161, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_HoraFinal
            // 
            this.dt_HoraFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraFinal.Location = new System.Drawing.Point(441, 44);
            this.dt_HoraFinal.Name = "dt_HoraFinal";
            this.dt_HoraFinal.Size = new System.Drawing.Size(146, 27);
            this.dt_HoraFinal.TabIndex = 8;
            // 
            // dt_HoraInicio
            // 
            this.dt_HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraInicio.Location = new System.Drawing.Point(161, 46);
            this.dt_HoraInicio.Name = "dt_HoraInicio";
            this.dt_HoraInicio.Size = new System.Drawing.Size(138, 27);
            this.dt_HoraInicio.TabIndex = 7;
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(161, 88);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(138, 27);
            this.dt_Data.TabIndex = 6;
            this.dt_Data.Value = new System.DateTime(2022, 2, 23, 21, 56, 50, 0);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(161, 9);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(138, 27);
            this.txt_Codigo.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 45);
            this.menuStrip1.TabIndex = 6;
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
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(285, 65);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(430, 45);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Cadastro de Atividades N3";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(69, 41);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // TicketCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 688);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketCadastroForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_HoraInicio;
        private System.Windows.Forms.Label lbl_HorarioFim;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_HorasGastas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_HorasGastas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dt_HoraFinal;
        private System.Windows.Forms.DateTimePicker dt_HoraInicio;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Decricao;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}