namespace GUI
{
    partial class Main
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
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button9 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(344, 27);
            button6.Name = "button6";
            button6.Size = new Size(163, 61);
            button6.TabIndex = 5;
            button6.Text = "Roles";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(576, 61);
            button3.Name = "button3";
            button3.Size = new Size(138, 35);
            button3.TabIndex = 9;
            button3.Text = "Login/Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(576, 102);
            button2.Name = "button2";
            button2.Size = new Size(138, 35);
            button2.TabIndex = 8;
            button2.Text = "Personal Info";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(576, 143);
            button1.Name = "button1";
            button1.Size = new Size(138, 35);
            button1.TabIndex = 7;
            button1.Text = "Setting";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(6, 27);
            button4.Name = "button4";
            button4.Size = new Size(163, 61);
            button4.TabIndex = 3;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(18, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 185);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admins";
            // 
            // button5
            // 
            button5.Location = new Point(175, 27);
            button5.Name = "button5";
            button5.Size = new Size(163, 61);
            button5.TabIndex = 4;
            button5.Text = "Permissions";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button9);
            groupBox2.Location = new Point(18, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(520, 193);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Managements";
            // 
            // button7
            // 
            button7.Location = new Point(176, 27);
            button7.Name = "button7";
            button7.Size = new Size(163, 61);
            button7.TabIndex = 6;
            button7.Text = "Members";
            button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(6, 27);
            button9.Name = "button9";
            button9.Size = new Size(163, 61);
            button9.TabIndex = 4;
            button9.Text = "Family";
            button9.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 453);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý gia phả";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private GroupBox groupBox1;
        private Button button5;
        private GroupBox groupBox2;
        private Button button7;
        private Button button9;
    }
}