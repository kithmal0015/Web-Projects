using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Project
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormcs mainform = new MainFormcs();
            mainform.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtAge.Text = "";
            txtResult.Text = "";
            txtWeight.Text = "";
            GenderCb.Text = "";
            txtShow.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;
            radCm.Checked = false;
            radMe.Checked = false;
        }

        private void btnCalulate_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(txtWeight.Text);
            float height = float.Parse(txtHeight.Text);
            float result = 0;

            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else if (radLb.Checked)
            {
                result = (float)(weight / 2.20) / (height * height);
            }
            /*if (radCm.Checked)
            {
                result = height / 100;
            }
            else if(radMe.Checked)
            {
                result = height * 100;
            }*/

            txtResult.Text = "Your BMI is: " + result.ToString();

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txtResult.Text;
            int startIndex = text.IndexOf(":") + 1;
            string subString = text.Substring(startIndex);
            float result;

            if (float.TryParse(subString, out result))
            {
                if (result < 18.0)
                {
                    txtShow.Text = ("Full Set 10*3\r\nSumo set 10*3\r\nLeg Extraction 8*3 \r\nleg Press 8*3\r\nOver Head 8*3\r\nDumble press 10*3\r\nbubal curl 10*3\r\nDumble curl \r\n\r\n(You Have To Train Day after Day)\r\n\r\n");
                }
                else if (result >= 18.0 && result <= 25.0)
                {
                    txtShow.Text = ("Wromup Trashing 10 (mints)\r\nChest burble press 8*4\r\n (high Weight >12Kg)\r\nChest Dumble press 8*4\r\nIncline Dumble press 8*4\r\nCable set 10*3\r\nOver head 8*4\r\nOne aurum 8*4\r\nroop Press 8*4\r\n10 Mints Run\r\nStretching\r\n\r\n(You Have To Train Two Days)\r\n");
                }
                else if (result > 25.0 && result <= 30.0)
                {
                    txtShow.Text = ("Wromup Trashing 10 (mints)\r\nDeff set 15*3\r\nChest burble press 8*3\r\n (high Weight >17.5Kg)\r\nChest Dumble press 8*3\r\nIncline Dumble press 8*3\r\nDecline bench press 8*3\r\nCable set 10*4\r\nOver head 8*3\r\nOne aurum 8*3\r\nroop Press 8*3\r\n10 Mints Run\r\nStretching\r\n\r\n(You Have To Train Tree Days)\r\n");
                }
                else
                {
                    txtShow.Text = ("ABS Beach 20*3\r\nABS Machin 30*3\r\nDumble Side set 50*3\r\nChest Dumble press Droop set(<10Kg)\r\nIncline Dumble press Droop set(<10Kg) \r\nDecline bench press Droop set(<10Kg)\r\nDumble curl 10*4\r\nBurble curl 10*4\r\nleat Pull Down 10*3\r\nBack pull 10*3\r\nLeg curl 10*4\r\nLeg extraction 10*4 \r\n15 Mints Run\r\nStretching\r\n\r\n(You Have To Train Daily)");
                }
                if (int.TryParse(txtAge.Text, out int age))
                {
                    if (age < 20)
                    {
                        MessageBox.Show("You Can't Train Because Your Age is Under 20", "Age Check");
                    }
                    else
                    {
                        MessageBox.Show("You are eligible to train!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid age!", "Error");
                }
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Shedule1 shel = new Shedule1();
            shel.Show();
            this.Hide();
        }
    }
}

     

