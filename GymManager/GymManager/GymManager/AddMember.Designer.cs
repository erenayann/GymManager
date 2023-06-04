namespace GymManager
{
    partial class AddMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            PhoneTb = new TextBox();
            label5 = new Label();
            AgeTb = new TextBox();
            GenderCb = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            AmountTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(311, 23);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 2;
            label1.Text = "GYM MANAGER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(275, 34);
            label2.TabIndex = 3;
            label2.Text = "Add  New Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(251, 27);
            label3.TabIndex = 4;
            label3.Text = "Name and Surname :";
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Blue;
            NameTb.Location = new Point(283, 144);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(181, 32);
            NameTb.TabIndex = 5;
            NameTb.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(193, 27);
            label4.TabIndex = 6;
            label4.Text = "Phone Number :";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Blue;
            PhoneTb.Location = new Point(283, 218);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(181, 32);
            PhoneTb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(12, 307);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 8;
            label5.Text = "Age :";
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTb.ForeColor = Color.Blue;
            AgeTb.Location = new Point(283, 307);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(181, 32);
            AgeTb.TabIndex = 9;
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(283, 393);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(181, 31);
            GenderCb.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(12, 393);
            label6.Name = "label6";
            label6.Size = new Size(111, 27);
            label6.TabIndex = 11;
            label6.Text = "Gender :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(12, 470);
            label7.Name = "label7";
            label7.Size = new Size(213, 27);
            label7.TabIndex = 12;
            label7.Text = "Monthly Amount :";
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Blue;
            AmountTb.Location = new Point(283, 470);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(181, 32);
            AmountTb.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(283, 539);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(418, 539);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 15;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(793, 23);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(912, 608);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AmountTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(GenderCb);
            Controls.Add(AgeTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMember";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTb;
        private Label label4;
        private TextBox PhoneTb;
        private Label label5;
        private TextBox AgeTb;
        private ComboBox GenderCb;
        private Label label6;
        private Label label7;
        private TextBox AmountTb;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}