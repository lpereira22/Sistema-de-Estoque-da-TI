using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Cms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Controle_de_Estoque_TI
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        ConexaoBD conexaoBD = new ConexaoBD();
        public Form1()
        {
            InitializeComponent();
            ultimaMovimentacao.Location = new Point(13, 46);
            itensCadastrados.Location = new Point(13, 35);
            AtualizarTotalItens();
            AtualizarItensDeEstoqueBaixo();
            AtualizarItensDeCategoriaDiferente();
            CarregarDadosItensCadastrados();



        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            AtualizarTotalItens();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            CadastrarItem.Visible = true;
            itensCadastrados.Location = new Point(13, 277);
        }

        private void CancelarItem_Click(object sender, EventArgs e)
        {
            CadastrarItem.Visible = false;
            itensCadastrados.Location = new Point(13, 35);
        }

        private void itensCadastrados_Enter(object sender, EventArgs e)
        {
            if (CadastrarItem.Visible == false)
            {
                itensCadastrados.Location = new Point(13, 15);
            }
        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void historicoMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            registraMovimento.Visible = true;
            ultimaMovimentacao.Location = new Point(13, 232);

        }

        private void registraMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void ultimaMovimentacao_Enter(object sender, EventArgs e)
        {

        }

        private void cancelarMovimentacao_Click(object sender, EventArgs e)
        {
            registraMovimento.Visible = false;
            ultimaMovimentacao.Location = new Point(13, 46);
        }

        private string CadastrarNovoItem()
        {
            try
            {
                string nome = textBox1.Text;
                string categoria = textBox2.Text;
                bool status = comboBox1.Text == "Ativo" ? true : false;
                int quantidade = int.Parse(textBox4.Text);
                int quantidadeMinima = int.Parse(textBox5.Text);
                string local = textBox6.Text;
                string descricao = textBox7.Text;

                using (MySqlConnection conexao = conexaoBD.GetConnection())
                {
                    if (conexao != null)
                    {
                        string query = "INSERT INTO Item (nome,categoria,status,quantidade,quantidade_minima,local_estacao,descricao) VALUES (@nome,@categoria,@status,@quantidade,@quantidadeMinima,@local,@descricao);";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@categoria", categoria);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@quantidade", quantidade);
                            cmd.Parameters.AddWithValue("@quantidadeMinima", quantidadeMinima);
                            cmd.Parameters.AddWithValue("@local", local);
                            cmd.Parameters.AddWithValue("@descricao", descricao);

                            cmd.ExecuteNonQuery();

                        }
                    }
                    AtualizarTotalItens();
                    AtualizarItensDeEstoqueBaixo();
                    AtualizarItensDeCategoriaDiferente();
                    return "Dados Salvo com sucesso!";
                }
                //Item itemNovo = new Item(nome, categoria, status, quantidade, quantidadeMinima, local, descricao);
            }
            catch (MySqlException ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // criar item - nome
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// criar item - status
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)// cria item - quantidade
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//cria item, quantidade minima
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)// criar item - local
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalvarItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CadastrarNovoItem());
            ApagarCamposCadastro();
            CarregarDadosItensCadastrados();
        }

        private void ApagarCamposCadastro()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelTotalItens_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarTotalItens()
        {
            using (MySqlConnection conexao = conexaoBD.GetConnection())
            {
                try
                {
                    if (conexao != null)
                    {
                        string query = "select count(*) from Item;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            int total = Convert.ToInt32(cmd.ExecuteScalar());

                            LabelTotalItens.Text = total.ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com banco de dados: " + ex.Message);
                }
            }
        }

        //private void AtualizarLoad()
        //{
        //    timer.Interval = 10000; // 10.000 ms = 10 segundos
        //    timer.Tick += Timer_Tick;
        //    timer.Start();
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarItensDeEstoqueBaixo()
        {
            using (MySqlConnection conexao = conexaoBD.GetConnection())
            {
                try
                {
                    if (conexao != null)
                    {
                        string query = "select count(*) from Item where quantidade < quantidade_minima;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            int total = Convert.ToInt32(cmd.ExecuteScalar());

                            labelEstoqueBaixo.Text = total.ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com banco de dados: " + ex.Message);
                }
            }
        }

        private void AtualizarItensDeCategoriaDiferente()
        {
            using (MySqlConnection conexao = conexaoBD.GetConnection())
            {
                try
                {
                    if (conexao != null)
                    {
                        string query = "select count(Distinct categoria) from Item;";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {
                            int total = Convert.ToInt32(cmd.ExecuteScalar());

                            LabelTiposCadastrados.Text = total.ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com banco de dados: " + ex.Message);
                }
            }
        }

        public void CarregarDadosItensCadastrados()
        {
            try
            {
                using (MySqlConnection conexao = conexaoBD.GetConnection())
                {
                    string query = "select id,nome,categoria,status,quantidade,quantidade_minima from Item;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView3.Rows.Add(
                                    reader["id"],
                                    reader["nome"],
                                    reader["categoria"],
                                    Convert.ToInt32(reader["status"]),
                                    reader["quantidade"],
                                    reader["quantidade_minima"]
                                    );
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = conexaoBD.GetConnection())
                {
                    string query = "update Item set ";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexao = conexaoBD.GetConnection())
                {
                    string query = "delete";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
