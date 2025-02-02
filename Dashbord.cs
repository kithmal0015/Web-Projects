namespace C__Project
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 946)
            {
                timer1.Stop();
                Login lForm= new Login();
                lForm.Show();
                this.Hide();
            }
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
