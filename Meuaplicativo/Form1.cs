using Meuaplicativo.Models;

namespace Meuaplicativo
{
    public partial class Form1 : Form
    {
      
        private List<Pessoa> pessoas = new List<Pessoa>();
        public Form1()
        {
            //Estrutura de inicalização de objets 
            InitializeComponent();


            //Estrutura de construção da tabela utilizando dataGridView
            dgPessoa.Columns.Add("colNome", "Nome");
            dgPessoa.Columns.Add("colEndereco", "Endereço");
            dgPessoa.Columns.Add("colCpf", "CPF");


            //Inicialização de estrutura tabela utilizando dataGridView
            dgPessoa.CellClick += dgPessoa_CellContentClick;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //coleta de dados para manipulação
            string nome = txtNome.Text;
            string endereco = txtendereco.Text;
            string cpf = txtcpf.Text;

            Pessoa novaPessoa = new Pessoa
            {
                Nome = nome,
                Endereco = endereco,
                Cpf = cpf
            };
            pessoas.Add(novaPessoa);
            dgPessoa.Rows.Clear();

            foreach (var pessoa in pessoas)
            {
                dgPessoa.Rows.Add(pessoa.Nome,pessoa.Endereco,pessoa.Cpf);

            }
            LimpaText();

        }

        private void dgPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //construção do eveto de click da tabela
            if (e.RowIndex >= 0 && e.RowIndex < dgPessoa.Rows.Count) {
                DataGridViewRow row = dgPessoa.Rows[e.RowIndex];
                txtNome.Text = row.Cells["colNome"].Value.ToString();
                txtendereco.Text = row.Cells["colEndereco"].Value.ToString();
                txtcpf.Text = row.Cells["colCpf"].Value.ToString();


            }
        }

        private void LimpaText()
        {
            txtNome.Clear();
            txtendereco.Clear();
            txtcpf.Clear();
        }
    }
}
