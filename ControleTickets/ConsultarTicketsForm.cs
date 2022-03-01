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
    public partial class ConsultarTicketsForm : Form
    {
        private readonly TicketService ticketService;
        public ConsultarTicketsForm()
        {
            InitializeComponent();
            ticketService = new TicketService();
        }
        private void AtualizarGridView()
        {
            var result = ticketService.GetTickets();
            dgvTickets.Rows.Clear();
            DatagridViewFill(result);

        }
        private void DatagridViewFill(IEnumerable<Ticket> tickets)
        {
            dgvTickets.Rows.Clear();
            int contador = 0;
            foreach(var ticket in tickets)
            {
                dgvTickets.Rows.Add();
                dgvTickets.Rows[contador].Cells[0].Value = ticket.TicketID;
                dgvTickets.Rows[contador].Cells[1].Value = ticket.Codigo;
                dgvTickets.Rows[contador].Cells[2].Value = ticket.HorarioDeInicio.Value.ToShortTimeString();
                dgvTickets.Rows[contador].Cells[3].Value = ticket.HoririoFinal.Value.ToShortTimeString();
                dgvTickets.Rows[contador].Cells[4].Value = ticket.TotalHorasGasto.Value.ToShortTimeString();
                dgvTickets.Rows[contador].Cells[5].Value = ticket.Date.Date.ToShortDateString();
                dgvTickets.Rows[contador].Cells[6].Value = ticket.Descricao;
                contador++;
            }
        }
        private void ConsultarTicketsForm_Load(object sender, EventArgs e)
        {
            var tickets = ticketService.GetTickets();
            DatagridViewFill(tickets);
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
            TicketCadastroForm ticketCadastro = new TicketCadastroForm();

            ticketCadastro.ShowDialog();
            this.Close();
        }
#endregion

        private void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Codigo.Text = dgvTickets.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Codigo.Text))
                {
                    MessageBox.Show("Digite o código do ticket que deseja a excluir !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var result = ticketService.DeleteTicket(new Ticket()
                {
                    Codigo = txt_Codigo.Text,
                    TicketID = Convert.ToInt32(dgvTickets.SelectedRows[0].Cells[0].Value)
                });
                if(result)
                {
                    MessageBox.Show("Ticket deletado com sucesso!", "Ticket Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao tentar excluir o ticket {ex.Message}!", "ERRO AO EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Detalhes_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket()
                {
                    TicketID = Convert.ToInt32(dgvTickets.SelectedRows[0].Cells[0].Value),
                    Codigo = dgvTickets.SelectedRows[0].Cells[1].Value.ToString(),
                    HorarioDeInicio = Convert.ToDateTime(dgvTickets.SelectedRows[0].Cells[2].Value),
                    HoririoFinal = Convert.ToDateTime(dgvTickets.SelectedRows[0].Cells[3].Value),
                    TotalHorasGasto = Convert.ToDateTime(dgvTickets.SelectedRows[0].Cells[4].Value),
                    Date = Convert.ToDateTime(dgvTickets.SelectedRows[0].Cells[5].Value).Date,
                    Descricao = dgvTickets.SelectedRows[0].Cells[6].Value.ToString()
                };
                DetalhesTicketForm detalhesTicket = new DetalhesTicketForm(ticket);
                detalhesTicket.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao exibir detalhes do ticket {ex.Message}","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarGridView();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket ticket = new Ticket() 
                {
                    Codigo = txt_Codigo.Text
                };
                if (!string.IsNullOrEmpty(txt_Codigo.Text))
                {
                    var result = ticketService.Get(ticket);
                    DatagridViewFill(result);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao buscar tickets {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
