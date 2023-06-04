namespace GymManager
{
    partial class UpdateDelete
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
            button2 = new Button();
            button1 = new Button();
            AmountTb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            GenderCb = new ComboBox();
            AgeTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            label4 = new Label();
            NameTb = new TextBox();
            label3 = new Label();
            MemberDGV = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberDGV).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(127, 502);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);
            button2.TabIndex = 27;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 502);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 26;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Blue;
            AmountTb.Location = new Point(12, 442);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(160, 32);
            AmountTb.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(12, 407);
            label7.Name = "label7";
            label7.Size = new Size(160, 21);
            label7.TabIndex = 24;
            label7.Text = "Monthly Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(12, 321);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 23;
            label6.Text = "Gender";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(12, 356);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(160, 31);
            GenderCb.TabIndex = 22;
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTb.ForeColor = Color.Blue;
            AgeTb.Location = new Point(12, 260);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(160, 32);
            AgeTb.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 20;
            label5.Text = "Age";
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Blue;
            PhoneTb.Location = new Point(12, 179);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(160, 32);
            PhoneTb.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 18;
            label4.Text = "Phone Number";
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Blue;
            NameTb.Location = new Point(12, 99);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(160, 32);
            NameTb.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 16;
            label3.Text = "Name and Surname";
            // 
            // MemberDGV
            // 
            MemberDGV.BackgroundColor = Color.White;
            MemberDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDGV.GridColor = SystemColors.ControlText;
            MemberDGV.Location = new Point(229, 75);
            MemberDGV.Name = "MemberDGV";
            MemberDGV.RowHeadersWidth = 51;
            MemberDGV.RowTemplate.Height = 29;
            MemberDGV.Size = new Size(751, 467);
            MemberDGV.TabIndex = 28;
            MemberDGV.CellContentClick += MemberDGV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 29;
            label1.Text = "GYM MANAGER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(220, 34);
            label2.TabIndex = 30;
            label2.Text = "Update/Delete";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(873, 9);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 31;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(76, 548);
            button4.Name = "button4";
            button4.Size = new Size(96, 40);
            button4.TabIndex = 32;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 637);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MemberDGV);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)MemberDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox AmountTb;
        private Label label7;
        private Label label6;
        private ComboBox GenderCb;
        private TextBox AgeTb;
        private Label label5;
        private TextBox PhoneTb;
        private Label label4;
        private TextBox NameTb;
        private Label label3;
        private DataGridView MemberDGV;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}