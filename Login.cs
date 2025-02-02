namespace C__Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "12345")
            {
                MainFormcs mainform = new MainFormcs();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Id or Password");
            }
        }

        private void checkBox01_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox01.Checked == true)
            {
                PassTb.UseSystemPasswordChar = false;
            }
            else
            {
                PassTb.UseSystemPasswordChar = true;
            }
        }

        private void checkBox01_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox01.Checked == true)
            {
                PassTb.UseSystemPasswordChar = false;
            }
            else
            {
                PassTb.UseSystemPasswordChar = true;
            }
        }
    }
}
