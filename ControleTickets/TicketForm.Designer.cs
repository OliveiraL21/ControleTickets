
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
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lbl_total_horas = new System.Windows.Forms.Label();
            this.lbl_valor_total_horas = new System.Windows.Forms.Label();
            this.lbl_qtdTickets = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Descricao.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descricao.ForeColor = System.Drawing.Color.White;
            this.lbl_Descricao.Location = new System.Drawing.Point(3, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(220, 40);
            this.lbl_Descricao.TabIndex = 1;
            this.lbl_Descricao.Text = "Controle de Tickets";
            this.lbl_Descricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_total_horas.Location = new System.Drawing.Point(25, 59);
            this.lbl_total_horas.Name = "lbl_total_horas";
            this.lbl_total_horas.Size = new System.Drawing.Size(127, 21);
            this.lbl_total_horas.TabIndex = 2;
            this.lbl_total_horas.Text = "Total de Horas: ";
            // 
            // lbl_valor_total_horas
            // 
            this.lbl_valor_total_horas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor_total_horas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_valor_total_horas.Location = new System.Drawing.Point(146, 60);
            this.lbl_valor_total_horas.Name = "lbl_valor_total_horas";
            this.lbl_valor_total_horas.Size = new System.Drawing.Size(49, 21);
            this.lbl_valor_total_horas.TabIndex = 3;
            this.lbl_valor_total_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_qtdTickets
            // 
            this.lbl_qtdTickets.AutoSize = true;
            this.lbl_qtdTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qtdTickets.Location = new System.Drawing.Point(22, 99);
            this.lbl_qtdTickets.Name = "lbl_qtdTickets";
            this.lbl_qtdTickets.Size = new System.Drawing.Size(191, 21);
            this.lbl_qtdTickets.TabIndex = 4;
            this.lbl_qtdTickets.Text = "Quantidades de Tickets:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_quantidade.Location = new System.Drawing.Point(210, 102);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(100, 21);
            this.lbl_quantidade.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleTickets.Properties.Resources.work_station;
            this.pictureBox1.Location = new System.Drawing.Point(388, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inserir.Location = new System.Drawing.Point(666, 8);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(84, 30);
            this.btn_inserir.TabIndex = 7;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatAppearance.BorderSize = 0;
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_consultar.ForeColor = System.Drawing.Color.White;
            this.btn_consultar.Location = new System.Drawing.Point(763, 8);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(76, 30);
            this.btn_consultar.TabIndex = 8;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu_panel.Controls.Add(this.logo);
            this.menu_panel.Controls.Add(this.btn_voltar);
            this.menu_panel.Controls.Add(this.lbl_Descricao);
            this.menu_panel.Controls.Add(this.btn_consultar);
            this.menu_panel.Controls.Add(this.btn_inserir);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(884, 44);
            this.menu_panel.TabIndex = 9;
            // 
            // logo
            // 
            this.logo.Image = global::ControleTickets.Properties.Resources.ticket_icon_icons_com_52351;
            this.logo.Location = new System.Drawing.Point(229, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(54, 44);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 14;
            this.logo.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.FlatAppearance.BorderSize = 0;
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.Image = global::ControleTickets.Properties.Resources.exit_free_icon_font1;
            this.btn_voltar.Location = new System.Drawing.Point(852, 4);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(32, 40);
            this.btn_voltar.TabIndex = 14;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_quantidade);
            this.Controls.Add(this.lbl_qtdTickets);
            this.Controls.Add(this.lbl_valor_total_horas);
            this.Controls.Add(this.lbl_total_horas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Descricao;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lbl_total_horas;
        private System.Windows.Forms.Label lbl_valor_total_horas;
        private System.Windows.Forms.Label lbl_qtdTickets;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox logo;
    }
}