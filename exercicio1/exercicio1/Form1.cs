namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                conexao com = new conexao();//chamo a classe conexao 
                if (com.GetConnection() == null)
                {
                    MessageBox.Show("Erro ao conectar!");
                }
                else
                {
                    MessageBox.Show("Conectado com sucesso!");
                }
                //qual erro geru
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexao co = new conexao();
            if (co.cadastrar(textBox1.Text, textBox2.Text, textBox3.Text) >= 1)
            {
                MessageBox.Show("Cadastro com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro no cadastro!");
            }

        }
    }
}
