namespace FridayProject
{
    partial class SignUp
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            passwordTxt = new TextBox();
            usernameTxt = new TextBox();
            nameTxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(passwordTxt);
            groupBox1.Controls.Add(usernameTxt);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 18F);
            groupBox1.Location = new Point(0, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(221, 322);
            button2.Name = "button2";
            button2.Size = new Size(152, 46);
            button2.TabIndex = 7;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(379, 322);
            button1.Name = "button1";
            button1.Size = new Size(152, 46);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 12F);
            passwordTxt.Location = new Point(161, 256);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(370, 34);
            passwordTxt.TabIndex = 5;
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 12F);
            usernameTxt.Location = new Point(161, 167);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(370, 34);
            usernameTxt.TabIndex = 4;
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 12F);
            nameTxt.Location = new Point(161, 75);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(370, 34);
            nameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "Full Name :";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(groupBox1);
            Name = "SignUp";
            Text = "Sign Up";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passwordTxt;
        private TextBox usernameTxt;
        private TextBox nameTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}