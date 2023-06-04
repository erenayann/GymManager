namespace GymManager
{
    partial class ViewMember
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
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            MemberDGV = new DataGridView();
            ViewMemberBox = new TextBox();
            SearchMember = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(207, 34);
            label2.TabIndex = 31;
            label2.Text = "View Member";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 32;
            label1.Text = "GYM MANAGER";
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(873, 12);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 33;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MemberDGV
            // 
            MemberDGV.BackgroundColor = Color.White;
            MemberDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDGV.GridColor = SystemColors.ControlText;
            MemberDGV.Location = new Point(12, 124);
            MemberDGV.Name = "MemberDGV";
            MemberDGV.RowHeadersWidth = 51;
            MemberDGV.RowTemplate.Height = 29;
            MemberDGV.Size = new Size(968, 467);
            MemberDGV.TabIndex = 34;
            // 
            // ViewMemberBox
            // 
            ViewMemberBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ViewMemberBox.ForeColor = Color.Blue;
            ViewMemberBox.Location = new Point(12, 76);
            ViewMemberBox.Name = "ViewMemberBox";
            ViewMemberBox.Size = new Size(167, 32);
            ViewMemberBox.TabIndex = 35;
            // 
            // SearchMember
            // 
            SearchMember.BackColor = Color.Blue;
            SearchMember.FlatAppearance.BorderSize = 0;
            SearchMember.FlatStyle = FlatStyle.Flat;
            SearchMember.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchMember.ForeColor = Color.White;
            SearchMember.Location = new Point(204, 76);
            SearchMember.Name = "SearchMember";
            SearchMember.Size = new Size(224, 33);
            SearchMember.TabIndex = 36;
            SearchMember.Text = "View Member";
            SearchMember.UseVisualStyleBackColor = false;
            SearchMember.Click += SearchMember_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(434, 76);
            button2.Name = "button2";
            button2.Size = new Size(120, 33);
            button2.TabIndex = 37;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // ViewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 637);
            Controls.Add(button2);
            Controls.Add(SearchMember);
            Controls.Add(ViewMemberBox);
            Controls.Add(MemberDGV);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewMember";
            Load += ViewMember_Load;
            ((System.ComponentModel.ISupportInitialize)MemberDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button3;
        private DataGridView MemberDGV;
        private TextBox ViewMemberBox;
        private Button SearchMember;
        private Button button2;
    }
}