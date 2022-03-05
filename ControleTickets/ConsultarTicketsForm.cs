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
        private readonly ResultService resultService;
        private DateTime totalDiario;
        public ConsultarTicketsForm()
        {
            InitializeComponent();
            ticketService = new TicketService();
            resultService = new ResultService();
        }
        private void AtualizarGridView()
        {
            var result = ticketService.GetTickets();
            dgvTickets.Rows.Clear();
            DatagridViewFill(result);

        }
        private DateTime CalcularTotalHorasDiarias(DateTime total)
        { 
            totalDiario = totalDiario + total.TimeOfDay;
            return totalDiario;
        }
        private void DatagridViewFill(IEnumerable<Ticket> tickets)
        {
            dgvTickets.Rows.Clear();
            int contador = 0;
            foreach (var ticket in tickets)
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

            dtp_DataInicial.Value = DateTime.Now;
            Ticket ticket = new Ticket() { Date = Convert.ToDateTime(DateTime.Now.Date.ToShortDateString()) };
            var tickets = ticketService.GetByDate(ticket);
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
                if (result)
                {
                    MessageBox.Show("Ticket deletado com sucesso!", "Ticket Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exibir detalhes do ticket {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                totalDiario = Convert.ToDateTime(DateTime.Now.Date.Date.ToShortTimeString());
                if (!string.IsNullOrEmpty(txt_Codigo.Text))
                {
                    Ticket ticket = new Ticket()
                    {
                        Codigo = txt_Codigo.Text
                    };
                    var result = ticketService.Get(ticket);
                    DatagridViewFill(result);
                }
                else
                {
                    var dataInicial = dtp_DataInicial.Value;
                    Ticket ticket = new Ticket()
                    {
                        Date = dataInicial
                    };
                    var result = ticketService.GetByDate(ticket);
                    DatagridViewFill(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar tickets {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_CalcularTotalHoras_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTickets.Rows == null || dgvTickets.Rows.Count == 0)
                {
                    MessageBox.Show("Preencha a tabela com dados de tickets para o calculo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int contador = 0;
                List<Ticket> lstTickets = new List<Ticket>();
                var ticketId = txt_Codigo.Text;
                DateTime total = new DateTime();
                DateTime retorno = new DateTime();
                Result result = new Result();

                foreach (var item in dgvTickets.Rows)
                {
                    lstTickets.Add(new Ticket()
                    {
                        TicketID = Convert.ToInt32(dgvTickets.Rows[contador].Cells[0].Value),
                        Codigo = dgvTickets.Rows[contador].Cells[1].Value.ToString(),
                        HorarioDeInicio = Convert.ToDateTime(dgvTickets.Rows[contador].Cells[2].Value),
                        HoririoFinal = Convert.ToDateTime(dgvTickets.Rows[contador].Cells[3].Value),
                        TotalHorasGasto = Convert.ToDateTime(dgvTickets.Rows[contador].Cells[4].Value),
                        Date = Convert.ToDateTime(dgvTickets.Rows[contador].Cells[5].Value),
                        Descricao = dgvTickets.Rows[contador].Cells[6].Value.ToString(),
                    });
                    contador++;
                }
                
                foreach (var ticket in lstTickets)
                {
                    if (ticket.Codigo == ticketId)
                    {
                        total = total + ticket.TotalHorasGasto.Value.TimeOfDay;
                    }
                    
                }
                retorno = CalcularTotalHorasDiarias(total);
                if (dgvTickets.Columns.Contains("Total") && dgvTickets.Columns.Contains("Total_HorasDiario"))
                {
                    for (int i = 0; i < dgvTickets.Rows.Count; i++)
                    {
                        if (dgvTickets.Rows[i].Cells[1].Value.ToString() == ticketId)
                        {
                            dgvTickets.Rows[i].Cells[7].Value = total.ToShortTimeString();
                        }
                    }
                }
                else
                {
                    dgvTickets.Columns.Add("Total", "Total Horas");
                    dgvTickets.Columns.Add("Total_HorasDiario", "Horas Diaria");
                    for (int i = 0; i < dgvTickets.Rows.Count; i++)
                    {
                        if (dgvTickets.Rows[i].Cells[1].Value.ToString() == ticketId)
                        {
                            dgvTickets.Rows[i].Cells[7].Value = total.ToShortTimeString();
                        }
                    }
                    

                }

                dgvTickets.Rows[0].Cells[8].Value = retorno.ToShortTimeString();
               



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar calcular dados dos tickets {ex.Message}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Codigo.Text = "";
            }
        }
    }
}
