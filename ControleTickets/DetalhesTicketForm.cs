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

        private void DetalhesTicketForm_Load(object sender, EventArgs e)
        {
            txt_Codigo.Text = _ticket.Codigo;
            dt_HoraInicio.Value = Convert.ToDateTime(_ticket.HorarioDeInicio);
            dt_HoraFinal.Value = Convert.ToDateTime(_ticket.HoririoFinal);
            dt_Data.Value = _ticket.Date;
            txt_HorasGastas.Text = _ticket.TotalHorasGasto.ToString();
            txt_Decricao.Text = _ticket.Descricao;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var result = ticketService.EditTicket(new Ticket()
            {
                Codigo = txt_Codigo.Text,
                HorarioDeInicio = dt_HoraInicio.Value.TimeOfDay,
                HoririoFinal = dt_HoraFinal.Value.TimeOfDay,
                TotalHorasGasto = Convert.ToDateTime(txt_HorasGastas.Text).TimeOfDay,
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
