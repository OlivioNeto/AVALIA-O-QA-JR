using System.Configuration;

namespace PROJETO_QA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                lbPreco.Text = "Pesquisando";

                double preco = await ObterPrecoBitcoin();
                lbPreco.Text = preco.ToString("C");
            }
            catch
            {
                lbPreco.Text = "Erro ao consultar API, tente novamente mais tarde!";
            }
                
        }

        private async Task<double> ObterPrecoBitcoin() // async pois o método usa await, algo de de fora e Task double para devolver double
        {
            HttpClient clientHttp = new HttpClient(); // variavel para requisição
            var respostaHttp = await clientHttp.GetAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=brl");
            await respostaHttp.Content.ReadAsStringAsync();
        }
    }
}
