
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
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(746, 34);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem1,
            this.consultarToolStripMenuItem});
            this.inserirToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.inserirToolStripMenuItem.Text = "Ticket";
            // 
            // inserirToolStripMenuItem1
            // 
            this.inserirToolStripMenuItem1.Image = global::ControleTickets.Properties.Resources.task_list_square_add_regular_icon_203206;
            this.inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            this.inserirToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.inserirToolStripMenuItem1.Text = "Inserir";
            this.inserirToolStripMenuItem1.Click += new System.EventHandler(this.inserirToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::ControleTickets.Properties.Resources.search_interface_symbol;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // txt_HorasGastas
            // 
            this.txt_HorasGastas.Location = new System.Drawing.Point(365, 121);
            this.txt_HorasGastas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HorasGastas.Name = "txt_HorasGastas";
            this.txt_HorasGastas.Size = new System.Drawing.Size(128, 23);
            this.txt_HorasGastas.TabIndex = 20;
            // 
            // dt_HoraFinal
            // 
            this.dt_HoraFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraFinal.Location = new System.Drawing.Point(365, 91);
            this.dt_HoraFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_HoraFinal.Name = "dt_HoraFinal";
            this.dt_HoraFinal.Size = new System.Drawing.Size(128, 23);
            this.dt_HoraFinal.TabIndex = 19;
            this.dt_HoraFinal.ValueChanged += new System.EventHandler(this.dt_HoraFinal_ValueChanged);
            // 
            // dt_HoraInicio
            // 
            this.dt_HoraInicio.CustomFormat = "HH:mm";
            this.dt_HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraInicio.Location = new System.Drawing.Point(120, 92);
            this.dt_HoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_HoraInicio.Name = "dt_HoraInicio";
            this.dt_HoraInicio.Size = new System.Drawing.Size(121, 23);
            this.dt_HoraInicio.TabIndex = 18;
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(120, 124);
            this.dt_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(121, 23);
            this.dt_Data.TabIndex = 17;
            this.dt_Data.Value = new System.DateTime(2022, 2, 23, 21, 56, 50, 0);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(120, 64);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(373, 23);
            this.txt_Codigo.TabIndex = 16;
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraInicio.Location = new System.Drawing.Point(0, 95);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(105, 19);
            this.lbl_HoraInicio.TabIndex = 12;
            this.lbl_HoraInicio.Text = "Horário Inicial";
            // 
            // lbl_HorasGastas
            // 
            this.lbl_HorasGastas.AutoSize = true;
            this.lbl_HorasGastas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorasGastas.Location = new System.Drawing.Point(256, 126);
            this.lbl_HorasGastas.Name = "lbl_HorasGastas";
            this.lbl_HorasGastas.Size = new System.Drawing.Size(86, 15);
            this.lbl_HorasGastas.TabIndex = 15;
            this.lbl_HorasGastas.Text = "Total de Horas";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(48, 68);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(58, 19);
            this.lbl_Codigo.TabIndex = 11;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(66, 124);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(40, 19);
            this.lbl_Data.TabIndex = 14;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_HorarioFim
            // 
            this.lbl_HorarioFim.AutoSize = true;
            this.lbl_HorarioFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorarioFim.Location = new System.Drawing.Point(253, 92);
            this.lbl_HorarioFim.Name = "lbl_HorarioFim";
            this.lbl_HorarioFim.Size = new System.Drawing.Size(97, 19);
            this.lbl_HorarioFim.TabIndex = 13;
            this.lbl_HorarioFim.Text = "Horário Final";
            // 
            // txt_Decricao
            // 
            this.txt_Decricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Decricao.Location = new System.Drawing.Point(120, 173);
            this.txt_Decricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Decricao.Multiline = true;
            this.txt_Decricao.Name = "txt_Decricao";
            this.txt_Decricao.Size = new System.Drawing.Size(471, 213);
            this.txt_Decricao.TabIndex = 21;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descricao.Location = new System.Drawing.Point(24, 176);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(89, 19);
            this.lbl_descricao.TabIndex = 22;
            this.lbl_descricao.Text = "Descricação";
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(509, 118);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(82, 29);
            this.btn_Editar.TabIndex = 23;
            this.btn_Editar.Text = "Salvar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // DetalhesTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 443);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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