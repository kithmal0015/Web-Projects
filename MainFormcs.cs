namespace C__Project
{
    public partial class MainFormcs : Form
    {
        public MainFormcs()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddMember addme = new AddMember();
            addme.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDelete Update = new UpdateDelete();
            Update.Show();
            this.Hide();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();
            bmi.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFormcs_Load(object sender, EventArgs e)
        {

        }
    }
}
