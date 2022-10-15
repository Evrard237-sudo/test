namespace Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "admin" && tbUsername.Text == "admin"){
                UserAccount ua = new UserAccount();
                ua.Show();
            }

        }
    }
}