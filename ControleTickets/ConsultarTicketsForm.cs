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
    public partial class ConsultarTicketsForm : Form
    {
        private readonly TicketService ticketService;
        public ConsultarTicketsForm()
        {
            InitializeComponent();
            ticketService = new TicketService();
        }

        private void ConsultarTicketsForm_Load(object sender, EventArgs e)
        {
            var tickets = ticketService.GetTickets();
            dgvTickets.DataSource = tickets;
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicketCadastroForm ticketCadastro = new TicketCadastroForm();

            ticketCadastro.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
