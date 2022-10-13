namespace Appli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "admin" && tbPassword.Text == "admin")
            {
                UserAccount ua = new UserAccount();
                ua.Show();
            }
        }
    }
}