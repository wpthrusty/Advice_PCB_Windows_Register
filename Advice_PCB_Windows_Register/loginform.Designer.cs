namespace Advice_PCB_Windows_Register
{
    partial class loginform
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
            this.login_btn = new System.Windows.Forms.Button();
            this.login_exit = new System.Windows.Forms.Button();
            this.login_usernametext = new System.Windows.Forms.TextBox();
            this.login_passwordtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(157, 68);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // login_exit
            // 
            this.login_exit.Location = new System.Drawing.Point(238, 68);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(75, 23);
            this.login_exit.TabIndex = 1;
            this.login_exit.Text = "Exit";
            this.login_exit.UseVisualStyleBackColor = true;
            // 
            // login_usernametext
            // 
            this.login_usernametext.Location = new System.Drawing.Point(71, 16);
            this.login_usernametext.Name = "login_usernametext";
            this.login_usernametext.Size = new System.Drawing.Size(242, 20);
            this.login_usernametext.TabIndex = 2;
            // 
            // login_passwordtext
            // 
            this.login_passwordtext.Location = new System.Drawing.Point(71, 42);
            this.login_passwordtext.Name = "login_passwordtext";
            this.login_passwordtext.Size = new System.Drawing.Size(242, 20);
            this.login_passwordtext.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_passwordtext);
            this.Controls.Add(this.login_usernametext);
            this.Controls.Add(this.login_exit);
            this.Controls.Add(this.login_btn);
            this.Name = "loginform";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button login_exit;
        private System.Windows.Forms.TextBox login_usernametext;
        private System.Windows.Forms.TextBox login_passwordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}