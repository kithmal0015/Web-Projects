using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace C__Project
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        //Sqlconnection Con = new Sqlconnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                Con.Open();
                string query = "select * from MemberTb1";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                MemberSDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            /*Con.Open();
            string query = "select * from MemberTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();*/
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }
        int Key = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TrainingCb.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AgeTb.Text = "";
            PhoneTb.Text = "";
            TrainingCb.Text = "";
            AmountTb.Text = "";
            GenderCb.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MainFormcs mainform = new MainFormcs();
            mainform.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select The Member To Be Delete");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "Delete from MemberTb1 where MId = @MId";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.Add("@MId", SqlDbType.Int).Value = Key;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Deleted Successfully");
                        Con.Close();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }*/


            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM MemberTb1 Where MId = @MId", Con); // Pass the connection to the SqlCommand constructor
            cmd.Parameters.AddWithValue("@MId", textBox1.Text);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Member Deleted Successfully");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE MemberTb1 SET MName=@MName, MPhone=@MPhone, MGen=@MGen, MAge=@MAge, MAmount=@MAmount, MTiming=@MTiming WHERE MId=@MId", conn);
                cmd.Parameters.AddWithValue("@MName", NameTb.Text);
                cmd.Parameters.AddWithValue("@MPhone", PhoneTb.Text);
                cmd.Parameters.AddWithValue("@MGen", GenderCb.Text);
                cmd.Parameters.AddWithValue("@MAge", AgeTb.Text);
                cmd.Parameters.AddWithValue("@MAmount", AmountTb.Text);
                cmd.Parameters.AddWithValue("@MTiming", TrainingCb.Text);
                // Replace Key with your actual key value
                cmd.Parameters.AddWithValue("@MId", Key);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Member Successfully Updated");
            }

            /* using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
             {
                 if (Key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || GenderCb.Text == "" || TrainingCb.Text == "")
                 {
                     MessageBox.Show("Missing Information");
                 }
                 else
                 {
                     try
                     {
                         Con.Open();
                         String query = "Update MemberTb1 Set MName.'" + NameTb.Text + "', MPhone.'" + PhoneTb.Text + "',MGen.'" + GenderCb.Text + "',MAge." + AgeTb.Text + ",MAmount." + AmountTb.Text + ",MTiming.'" + TrainingCb.Text + "' where MId." + Key + ";";
                         SqlCommand cmd = new SqlCommand(query, Con);
                         cmd.ExecuteNonQuery();
                         MessageBox.Show("Member Update Successfully");
                         Con.Close();
                     }
                     catch (Exception Ex)
                     {
                         MessageBox.Show(Ex.Message);
                     }

                 }
             }

            try
            {
                using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    Con.Open();
                    String query = "Update MemberTb1 Set MName=@MName, MPhone=@MPhone, MGen=@MGen, MAge=@MAge, MAmount=@MAmount, MTiming=@MTiming where MId=@MId";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Add parameters and set their values
                    cmd.Parameters.AddWithValue("@MName", NameTb.Text);
                    cmd.Parameters.AddWithValue("@MPhone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@MGen", GenderCb.Text);
                    cmd.Parameters.AddWithValue("@MAge", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@MAmount", AmountTb.Text);
                    cmd.Parameters.AddWithValue("@MTiming", TrainingCb.Text);
                    cmd.Parameters.AddWithValue("@MId", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member updated successfully.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }*/
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\KDU PROJECTS\3RD SEM(39)\3rd sem notes\3rd sem notes\Rapid Application Development (3 Credit)\Asingments\Assigment 02\Project\C# Project\GymDb.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                Con.Open();
                string query = "select * from MemberTb1 ";
                SqlCommand cmd = new SqlCommand(query, Con);
                //cmd.Parameters.AddWithValue("@MId", Key); // Add the @MId parameter here
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                MemberSDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void AgeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

