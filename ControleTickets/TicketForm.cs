using Model.Service;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTickets
{
    public partial class TicketForm : Form
    {
        private readonly TicketService _ticketService; 
        public TicketForm()
        {
            InitializeComponent();
            _ticketService = new TicketService();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicketCadastroForm cadastroTicket = new TicketCadastroForm();
            cadastroTicket.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTicketsForm consultarTickets = new ConsultarTicketsForm();
            consultarTickets.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            try
            {
                var totalHoras = _ticketService.TotalHorasTrabalhadas();
                lbl_valor_total_horas.Text = totalHoras.ToString();

                var totalTickets = _ticketService.TotalTicketsRegistrados();
                lbl_quantidade.Text = totalTickets.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao trazer os dados iniciais ! \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            TicketCadastroForm cadastroTicket = new TicketCadastroForm();
            cadastroTicket.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultarTicketsForm consultarTickets = new ConsultarTicketsForm();
            consultarTickets.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
