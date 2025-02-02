namespace C__Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            checkBox01 = new CheckBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            UidTb = new TextBox();
            PassTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(638, 302);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(638, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(687, 499);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 5;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(801, 499);
            button2.Name = "button2";
            button2.Size = new Size(108, 38);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(937, 574);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // checkBox01
            // 
            checkBox01.AutoSize = true;
            checkBox01.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox01.Location = new Point(845, 413);
            checkBox01.Name = "checkBox01";
            checkBox01.Size = new Size(71, 23);
            checkBox01.TabIndex = 8;
            checkBox01.Text = "Show";
            checkBox01.UseVisualStyleBackColor = true;
            checkBox01.CheckedChanged += checkBox01_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(694, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(165, 154);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(637, 178);
            label1.Name = "label1";
            label1.Size = new Size(288, 84);
            label1.TabIndex = 10;
            label1.Text = "\"The Gym Is the Arena Where \r\nExcuses are Left at the Door \r\nand Champions are Make\"\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UidTb
            // 
            UidTb.Location = new Point(707, 302);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(202, 27);
            UidTb.TabIndex = 11;
            // 
            // PassTb
            // 
            PassTb.Location = new Point(707, 371);
            PassTb.Name = "PassTb";
            PassTb.Size = new Size(202, 27);
            PassTb.TabIndex = 12;
            PassTb.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 569);
            Controls.Add(PassTb);
            Controls.Add(UidTb);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(checkBox01);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Management System";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private CheckBox checkBox01;
        private PictureBox pictureBox4;
        private Label label1;
        private TextBox UidTb;
        private TextBox PassTb;
    }
}
