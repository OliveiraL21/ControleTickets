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
        private void TicketForm_Load(object sender, EventArgs e)
        {
            try
            {
                var totalHoras = _ticketService.TotalHorasTrabalhadas();
                lbl_totalHoras.Text = totalHoras.ToString();

                var totalTickets = _ticketService.TotalTicketsRegistrados();
                lbl_qtd.Text = totalTickets.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao trazer os dados iniciais ! \n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            TicketCadastroForm cadastroForm = new TicketCadastroForm();
            cadastroForm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTicketsForm consultarTickets = new ConsultarTicketsForm();
            consultarTickets.Show();
        }
    }
}
