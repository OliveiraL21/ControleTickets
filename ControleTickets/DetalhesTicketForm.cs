using Model;
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
    public partial class DetalhesTicketForm : Form
    {
        private Ticket _ticket;
        private readonly TicketService ticketService;
        public DetalhesTicketForm()
        {
            InitializeComponent();
        }
        public DetalhesTicketForm(Ticket ticket)
        {
            InitializeComponent();
            ticketService = new TicketService();
            _ticket = ticket;
        }
        #region Front-end
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TicketCadastroForm cadastroTicket = new TicketCadastroForm();
            cadastroTicket.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTicketsForm consultarTickets = new ConsultarTicketsForm();
            consultarTickets.ShowDialog();
        }
#endregion
       
        private void DetalhesTicketForm_Load(object sender, EventArgs e)
        {
            txt_Codigo.Text = _ticket.Codigo;
            dt_HoraInicio.Value = Convert.ToDateTime(_ticket.HorarioDeInicio.Value.ToShortTimeString());
            dt_HoraFinal.Value = Convert.ToDateTime(_ticket.HorarioFinal.Value.ToShortTimeString());
            dt_Data.Value = _ticket.Date;
            txt_HorasGastas.Text = _ticket.TotalHorasGasto.Value.ToString("HH:mm");
            txt_Decricao.Text = _ticket.Descricao;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var result = ticketService.EditTicket(new Ticket()
            {
                TicketID = _ticket.TicketID,
                Codigo = txt_Codigo.Text,
                HorarioDeInicio = Convert.ToDateTime(dt_HoraInicio.Value.ToShortTimeString()),
                HorarioFinal = Convert.ToDateTime(dt_HoraFinal.Value.ToShortTimeString()),
                TotalHorasGasto = Convert.ToDateTime(txt_HorasGastas.Text),
                Date = dt_Data.Value,
                Descricao = txt_Decricao.Text

            });
            if (result)
            {
                MessageBox.Show("Ticket editado com sucesso !", "Edição concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
