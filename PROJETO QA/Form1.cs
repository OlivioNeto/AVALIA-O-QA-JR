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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                lbPreco.Text = "Pesquisando";

                double preco = ObterPrecoBitcoin();
                lbPreco.Text = preco.ToString("C");
            }
            catch
            {
                lbPreco.Text = "Erro ao consultar API, tente novamente mais tarde!";
            }
                
        }

        private double ObterPrecoBitcoin()
        {
            double preco = 350000.75;
            return preco;
        }
    }
}
