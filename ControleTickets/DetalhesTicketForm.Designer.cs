
namespace ControleTickets
{
    partial class DetalhesTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesTicketForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_HorasGastas = new System.Windows.Forms.TextBox();
            this.dt_HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dt_HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_HoraInicio = new System.Windows.Forms.Label();
            this.lbl_HorasGastas = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_HorarioFim = new System.Windows.Forms.Label();
            this.txt_Decricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(853, 45);
            this.menuStrip1.TabIndex = 8;
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
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
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
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizarToolStripMenuItem.Image")));
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(113, 41);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            // 
            // txt_HorasGastas
            // 
            this.txt_HorasGastas.Location = new System.Drawing.Point(417, 161);
            this.txt_HorasGastas.Name = "txt_HorasGastas";
            this.txt_HorasGastas.Size = new System.Drawing.Size(146, 27);
            this.txt_HorasGastas.TabIndex = 20;
            // 
            // dt_HoraFinal
            // 
            this.dt_HoraFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraFinal.Location = new System.Drawing.Point(417, 121);
            this.dt_HoraFinal.Name = "dt_HoraFinal";
            this.dt_HoraFinal.Size = new System.Drawing.Size(146, 27);
            this.dt_HoraFinal.TabIndex = 19;
            // 
            // dt_HoraInicio
            // 
            this.dt_HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraInicio.Location = new System.Drawing.Point(137, 123);
            this.dt_HoraInicio.Name = "dt_HoraInicio";
            this.dt_HoraInicio.Size = new System.Drawing.Size(138, 27);
            this.dt_HoraInicio.TabIndex = 18;
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(137, 165);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(138, 27);
            this.dt_Data.TabIndex = 17;
            this.dt_Data.Value = new System.DateTime(2022, 2, 23, 21, 56, 50, 0);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(137, 86);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(138, 27);
            this.txt_Codigo.TabIndex = 16;
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraInicio.Location = new System.Drawing.Point(0, 127);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(123, 23);
            this.lbl_HoraInicio.TabIndex = 12;
            this.lbl_HoraInicio.Text = "Horário Inicial";
            // 
            // lbl_HorasGastas
            // 
            this.lbl_HorasGastas.AutoSize = true;
            this.lbl_HorasGastas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorasGastas.Location = new System.Drawing.Point(292, 168);
            this.lbl_HorasGastas.Name = "lbl_HorasGastas";
            this.lbl_HorasGastas.Size = new System.Drawing.Size(110, 20);
            this.lbl_HorasGastas.TabIndex = 15;
            this.lbl_HorasGastas.Text = "Total de Horas";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(55, 90);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(68, 23);
            this.lbl_Codigo.TabIndex = 11;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(75, 165);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(48, 23);
            this.lbl_Data.TabIndex = 14;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_HorarioFim
            // 
            this.lbl_HorarioFim.AutoSize = true;
            this.lbl_HorarioFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorarioFim.Location = new System.Drawing.Point(289, 123);
            this.lbl_HorarioFim.Name = "lbl_HorarioFim";
            this.lbl_HorarioFim.Size = new System.Drawing.Size(114, 23);
            this.lbl_HorarioFim.TabIndex = 13;
            this.lbl_HorarioFim.Text = "Horário Final";
            // 
            // txt_Decricao
            // 
            this.txt_Decricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Decricao.Location = new System.Drawing.Point(137, 231);
            this.txt_Decricao.Multiline = true;
            this.txt_Decricao.Name = "txt_Decricao";
            this.txt_Decricao.Size = new System.Drawing.Size(668, 283);
            this.txt_Decricao.TabIndex = 21;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descricao.Location = new System.Drawing.Point(28, 234);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(103, 23);
            this.lbl_descricao.TabIndex = 22;
            this.lbl_descricao.Text = "Descricação";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Image = global::ControleTickets.Properties.Resources.botao_editar;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(590, 157);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(148, 49);
            this.btn_Editar.TabIndex = 23;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // DetalhesTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_Decricao);
            this.Controls.Add(this.txt_HorasGastas);
            this.Controls.Add(this.dt_HoraFinal);
            this.Controls.Add(this.dt_HoraInicio);
            this.Controls.Add(this.dt_Data);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_HoraInicio);
            this.Controls.Add(this.lbl_HorasGastas);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_HorarioFim);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalhesTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalhesTicketForm";
            this.Load += new System.EventHandler(this.DetalhesTicketForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_HorasGastas;
        private System.Windows.Forms.DateTimePicker dt_HoraFinal;
        private System.Windows.Forms.DateTimePicker dt_HoraInicio;
        private System.Windows.Forms.DateTimePicker dt_Data;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label lbl_HoraInicio;
        private System.Windows.Forms.Label lbl_HorasGastas;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_HorarioFim;
        private System.Windows.Forms.TextBox txt_Decricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Button btn_Editar;
    }
}