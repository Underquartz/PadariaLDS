namespace PadariaKairos
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro1 = new FormCadastro();
            formCadastro1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main = new FormMain();
            main.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSenha.Text = "";
        }
    }
}
