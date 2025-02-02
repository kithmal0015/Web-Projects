using System.Data;
using System.Data.SqlClient;
namespace C__Project
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        //Sqlconnection Con = new Sqlconnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        Con.Open();

                        string query = "insert into MemberTb1 values('" + NameTb.Text + "','" + PhoneTb.Text + "','" + GenderCb.SelectedItem.ToString() + "'," + AgeTb.Text + "," + AmountTb.Text + ",'" + TrainingCb.SelectedItem.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Successfully Added");
                        Con.Close();
                        AmountTb.Text = "";
                        AgeTb.Text = "";
                        NameTb.Text = "";
                        PhoneTb.Text = "";
                        GenderCb.Text = "";
                        TrainingCb.Text = "";

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TrainingCb.Text = "";
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainFormcs mainform = new MainFormcs();
            mainform.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



