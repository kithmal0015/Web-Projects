using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace C__Project
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Sqlconnection Con = new Sqlconnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            /*Sqlconnection Con = new Sqlconnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");

            Con.Open();
            string sqery = "select * from MemberTb1";
            SqlDataAdapter sda = new SqlDataAdapter(sqery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();*/
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                Con.Open();
                string sqery = "select * from MemberTb1";
                SqlDataAdapter sda = new SqlDataAdapter(sqery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                MemberSDGV.DataSource = ds.Tables[0];
            }

        }
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormcs mainform = new MainFormcs();
            mainform.Show();
            this.Hide();
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void filterByName()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                Con.Open();
                string sqery = "select * from MemberTb1 where MName='" + SearchMember.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sqery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                MemberSDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
