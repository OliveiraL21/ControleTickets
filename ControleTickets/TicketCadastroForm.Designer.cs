
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
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_Decricao = new System.Windows.Forms.TextBox();
            this.txt_HorasGastas = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.dt_HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dt_HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dt_Data = new System.Windows.Forms.DateTimePicker();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_menu_inserir = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel_content.SuspendLayout();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(179, 79);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(58, 19);
            this.lbl_Codigo.TabIndex = 0;
            this.lbl_Codigo.Text = "Código";
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HoraInicio.Location = new System.Drawing.Point(131, 118);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(105, 19);
            this.lbl_HoraInicio.TabIndex = 1;
            this.lbl_HoraInicio.Text = "Horário Inicial";
            // 
            // lbl_HorarioFim
            // 
            this.lbl_HorarioFim.AutoSize = true;
            this.lbl_HorarioFim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorarioFim.Location = new System.Drawing.Point(384, 114);
            this.lbl_HorarioFim.Name = "lbl_HorarioFim";
            this.lbl_HorarioFim.Size = new System.Drawing.Size(97, 19);
            this.lbl_HorarioFim.TabIndex = 2;
            this.lbl_HorarioFim.Text = "Horário Final";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Data.Location = new System.Drawing.Point(205, 145);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(40, 19);
            this.lbl_Data.TabIndex = 3;
            this.lbl_Data.Text = "Data";
            // 
            // lbl_HorasGastas
            // 
            this.lbl_HorasGastas.AutoSize = true;
            this.lbl_HorasGastas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HorasGastas.Location = new System.Drawing.Point(392, 146);
            this.lbl_HorasGastas.Name = "lbl_HorasGastas";
            this.lbl_HorasGastas.Size = new System.Drawing.Size(98, 17);
            this.lbl_HorasGastas.TabIndex = 4;
            this.lbl_HorasGastas.Text = "Total de Horas";
            // 
            // panel_content
            // 
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
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(909, 495);
            this.panel_content.TabIndex = 5;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_descricao.Location = new System.Drawing.Point(193, 175);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(89, 19);
            this.lbl_descricao.TabIndex = 12;
            this.lbl_descricao.Text = "Descricação";
            // 
            // txt_Decricao
            // 
            this.txt_Decricao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Decricao.Location = new System.Drawing.Point(193, 206);
            this.txt_Decricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Decricao.Multiline = true;
            this.txt_Decricao.Name = "txt_Decricao";
            this.txt_Decricao.Size = new System.Drawing.Size(585, 271);
            this.txt_Decricao.TabIndex = 11;
            // 
            // txt_HorasGastas
            // 
            this.txt_HorasGastas.Location = new System.Drawing.Point(496, 143);
            this.txt_HorasGastas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HorasGastas.Name = "txt_HorasGastas";
            this.txt_HorasGastas.Size = new System.Drawing.Size(128, 23);
            this.txt_HorasGastas.TabIndex = 10;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Inserir.FlatAppearance.BorderSize = 0;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Inserir.ForeColor = System.Drawing.Color.White;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Inserir.Location = new System.Drawing.Point(646, 136);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(84, 33);
            this.btn_Inserir.TabIndex = 9;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // dt_HoraFinal
            // 
            this.dt_HoraFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraFinal.Location = new System.Drawing.Point(496, 113);
            this.dt_HoraFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_HoraFinal.Name = "dt_HoraFinal";
            this.dt_HoraFinal.Size = new System.Drawing.Size(128, 23);
            this.dt_HoraFinal.TabIndex = 8;
            this.dt_HoraFinal.ValueChanged += new System.EventHandler(this.dt_HoraFinal_ValueChanged);
            // 
            // dt_HoraInicio
            // 
            this.dt_HoraInicio.CustomFormat = "";
            this.dt_HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_HoraInicio.Location = new System.Drawing.Point(251, 114);
            this.dt_HoraInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_HoraInicio.Name = "dt_HoraInicio";
            this.dt_HoraInicio.Size = new System.Drawing.Size(121, 23);
            this.dt_HoraInicio.TabIndex = 7;
            this.dt_HoraInicio.Value = new System.DateTime(2022, 7, 20, 22, 38, 0, 0);
            // 
            // dt_Data
            // 
            this.dt_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Data.Location = new System.Drawing.Point(251, 142);
            this.dt_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Data.Name = "dt_Data";
            this.dt_Data.Size = new System.Drawing.Size(121, 23);
            this.dt_Data.TabIndex = 6;
            this.dt_Data.Value = new System.DateTime(2022, 2, 23, 21, 56, 50, 0);
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(251, 76);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(373, 23);
            this.txt_Codigo.TabIndex = 5;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(3, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(251, 44);
            this.lbl_Titulo.TabIndex = 7;
            this.lbl_Titulo.Text = "Cadastro de Atividades";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu_panel.Controls.Add(this.logo);
            this.menu_panel.Controls.Add(this.btn_voltar);
            this.menu_panel.Controls.Add(this.btn_consultar);
            this.menu_panel.Controls.Add(this.btn_menu_inserir);
            this.menu_panel.Controls.Add(this.lbl_Titulo);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(909, 44);
            this.menu_panel.TabIndex = 8;
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Image = global::ControleTickets.Properties.Resources.exit_free_icon_font1;
            this.btn_voltar.Location = new System.Drawing.Point(874, 3);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(32, 40);
            this.btn_voltar.TabIndex = 13;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.Location = new System.Drawing.Point(771, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(87, 44);
            this.btn_consultar.TabIndex = 10;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_menu_inserir
            // 
            this.btn_menu_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_menu_inserir.FlatAppearance.BorderSize = 0;
            this.btn_menu_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_inserir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_menu_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_menu_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_inserir.Location = new System.Drawing.Point(672, 0);
            this.btn_menu_inserir.Name = "btn_menu_inserir";
            this.btn_menu_inserir.Size = new System.Drawing.Size(87, 44);
            this.btn_menu_inserir.TabIndex = 9;
            this.btn_menu_inserir.Text = "Inserir";
            this.btn_menu_inserir.UseVisualStyleBackColor = false;
            this.btn_menu_inserir.Click += new System.EventHandler(this.btn_menu_inserir_Click);
            // 
            // logo
            // 
            this.logo.Image = global::ControleTickets.Properties.Resources.ticket_icon_icons_com_52351;
            this.logo.Location = new System.Drawing.Point(251, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(54, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // TicketCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 495);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.panel_content);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TicketCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketCadastroForm";
            this.Load += new System.EventHandler(this.TicketCadastroForm_Load);
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
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
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Decricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_menu_inserir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox logo;
    }
}