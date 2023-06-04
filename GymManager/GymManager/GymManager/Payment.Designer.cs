namespace GymManager
{
    partial class Payment
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
            button3 = new Button();
            AmountTb = new TextBox();
            label7 = new Label();
            label3 = new Label();
            Period = new DateTimePicker();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            NameCb = new ComboBox();
            PaymentDGV = new DataGridView();
            SearchPayment = new Button();
            SearchMember = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 33;
            label1.Text = "GYM MANAGER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(137, 34);
            label2.TabIndex = 34;
            label2.Text = "Payment";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(793, 9);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 35;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Blue;
            AmountTb.Location = new Point(12, 291);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(181, 32);
            AmountTb.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(12, 251);
            label7.Name = "label7";
            label7.Size = new Size(201, 27);
            label7.TabIndex = 38;
            label7.Text = "Monthly Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(239, 27);
            label3.TabIndex = 36;
            label3.Text = "Name and Surname";
            // 
            // Period
            // 
            Period.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Period.Location = new Point(12, 377);
            Period.Name = "Period";
            Period.Size = new Size(181, 32);
            Period.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(12, 338);
            label4.Name = "label4";
            label4.Size = new Size(194, 27);
            label4.TabIndex = 41;
            label4.Text = "Payment Month";
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(127, 439);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);
            button2.TabIndex = 43;
            button2.Text = "Reset";
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
            button1.Location = new Point(12, 439);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 42;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameCb
            // 
            NameCb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "Male", "Female" });
            NameCb.Location = new Point(12, 203);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(181, 31);
            NameCb.TabIndex = 45;
            NameCb.SelectedIndexChanged += NameCb_SelectedIndexChanged;
            // 
            // PaymentDGV
            // 
            PaymentDGV.BackgroundColor = Color.White;
            PaymentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDGV.GridColor = SystemColors.ControlText;
            PaymentDGV.Location = new Point(257, 159);
            PaymentDGV.Name = "PaymentDGV";
            PaymentDGV.RowHeadersWidth = 51;
            PaymentDGV.RowTemplate.Height = 29;
            PaymentDGV.Size = new Size(643, 437);
            PaymentDGV.TabIndex = 46;
            // 
            // SearchPayment
            // 
            SearchPayment.BackColor = Color.Blue;
            SearchPayment.FlatAppearance.BorderSize = 0;
            SearchPayment.FlatStyle = FlatStyle.Flat;
            SearchPayment.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchPayment.ForeColor = Color.White;
            SearchPayment.Location = new Point(592, 108);
            SearchPayment.Name = "SearchPayment";
            SearchPayment.Size = new Size(109, 37);
            SearchPayment.TabIndex = 47;
            SearchPayment.Text = "Search";
            SearchPayment.UseVisualStyleBackColor = false;
            SearchPayment.Click += SearchPayment_Click;
            // 
            // SearchMember
            // 
            SearchMember.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchMember.ForeColor = Color.Blue;
            SearchMember.Location = new Point(392, 113);
            SearchMember.Name = "SearchMember";
            SearchMember.Size = new Size(181, 32);
            SearchMember.TabIndex = 48;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 608);
            Controls.Add(SearchMember);
            Controls.Add(SearchPayment);
            Controls.Add(PaymentDGV);
            Controls.Add(NameCb);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Period);
            Controls.Add(AmountTb);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox AmountTb;
        private Label label7;
        private Label label3;
        private DateTimePicker Period;
        private Label label4;
        private Button button2;
        private Button button1;
        private ComboBox NameCb;
        private DataGridView PaymentDGV;
        private Button SearchPayment;
        private TextBox SearchMember;
    }
}