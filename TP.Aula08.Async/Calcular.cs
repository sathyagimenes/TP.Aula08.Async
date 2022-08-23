using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.Aula08.Async
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            btnCalcular.Enabled = false;
            await CalcularFolha();
            await CalcularImpostos();
            await CalcularReceitas();
            await CalcularDespesas();
            stopwatch.Stop();
            lblTempo.Text = $"Tempo de processamento: {stopwatch.Elapsed.Seconds} segundos";
            btnCalcular.Enabled = true;
        }

        private async Task CalcularFolha()
        {
            lblFolha.ForeColor = Color.Red;
            lblFolha.Text = "Calculando folha de pagamento... Aguarde...";
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblFolha.ForeColor = Color.Green;
            lblFolha.Text = "Folha de pagamento: R$10.000,00";
        }

        private async Task CalcularImpostos()
        {
            lblImpostos.ForeColor = Color.Red;
            lblImpostos.Text = "Calculando Impostos... Aguarde...";
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblImpostos.ForeColor = Color.Green;
            lblImpostos.Text = "Impostos: R$2.000,00";
        }
        private async Task CalcularReceitas()
        {
            lblReceitas.ForeColor = Color.Red;
            lblReceitas.Text = "Calculando Receitas... Aguarde...";
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblReceitas.ForeColor = Color.Green;
            lblReceitas.Text = "Receitas: R$20.000,00";
        }
        private async Task CalcularDespesas()
        {
            lblDespesas.ForeColor = Color.Red;
            lblDespesas.Text = "Calculando Despesas... Aguarde...";
            await Task.Delay(TimeSpan.FromSeconds(2));
            lblDespesas.ForeColor = Color.Green;
            lblDespesas.Text = "Despesas: R$5.000,00";
        }
    }
}
