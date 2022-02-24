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
    public partial class TicketCadastroForm : Form
    {
        private TicketService ticketService;
        public TicketCadastroForm()
        {
            InitializeComponent();
            ticketService = new TicketService();
        }
        private TimeSpan TotalDeHorasGastas(TimeSpan horaInicio, TimeSpan horaFim)
        {
            var horaGasta = horaFim.Add( -horaInicio);
            return horaGasta;
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var horaGasta = TotalDeHorasGastas(dt_HoraInicio.Value.TimeOfDay, dt_HoraFinal.Value.TimeOfDay);
            txt_HorasGastas.Text = horaGasta.ToString("hh:mm:ss");
            var result = ticketService.InserirTicket(new Ticket 
            {
                Codigo = txt_Codigo.Text.ToUpper(),
                HorarioDeInicio = dt_HoraInicio.Value.TimeOfDay,
                HoririoFinal = dt_HoraFinal.Value.TimeOfDay,
                Date = dt_Data.Value,
                Descricao = txt_Decricao.Text,
                TotalHorasGasto = horaGasta
            });
            if(result)
            {
                MessageBox.Show("Registro de ticket inserido com sucesso !", "Inserção realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
