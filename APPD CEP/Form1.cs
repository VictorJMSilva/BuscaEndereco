using CEPBLL;
namespace APPD_CEP
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

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            ConsultaCep consulta = new ConsultaCep();
            CEP cep = consulta.Consultar(txtCEP.Text);
            txtEndereco.Text = cep.Logradouro;
            txtCidade.Text = $"{cep.Localidade}/ {cep.Uf}"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}