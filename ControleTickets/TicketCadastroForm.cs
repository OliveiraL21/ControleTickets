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
            var horaGasta = horaFim.Add(-horaInicio);
            return horaGasta;
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var horaGasta = TotalDeHorasGastas(dt_HoraInicio.Value.TimeOfDay, dt_HoraFinal.Value.TimeOfDay);
                txt_HorasGastas.Text = horaGasta.ToString(@"hh\:mm");
                var result = ticketService.InserirTicket(new Ticket
                {
                    Codigo = txt_Codigo.Text.ToUpper(),
                    HorarioDeInicio = Convert.ToDateTime(dt_HoraInicio.Value.TimeOfDay),
                    HoririoFinal = Convert.ToDateTime(dt_HoraFinal.Value.TimeOfDay),
                    Date = dt_Data.Value,
                    Descricao = txt_Decricao.Text,
                    TotalHorasGasto = Convert.ToDateTime(horaGasta)
                });
                if (result)
                {
                    MessageBox.Show("Registro de ticket inserido com sucesso !", "Inserção realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar inserir o ticket na base: {ex.Message}");
            }
            finally
            {
                txt_Codigo.Text = "";
                dt_HoraInicio.Value = Convert.ToDateTime(DateTime.Now.TimeOfDay);
                dt_HoraFinal.Value = Convert.ToDateTime(DateTime.Now.TimeOfDay);
                dt_Data.Value = DateTime.Now;
                txt_Decricao.Text = "";

            }
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTicketsForm consultarTickets = new ConsultarTicketsForm();
            consultarTickets.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TicketCadastroForm_Load(object sender, EventArgs e)
        {
            dt_Data.Value = DateTime.Now;
            dt_HoraInicio.Value = Convert.ToDateTime(DateTime.Now.TimeOfDay);
            dt_HoraFinal.Value = Convert.ToDateTime(DateTime.Now.TimeOfDay);
        }
    }
}
