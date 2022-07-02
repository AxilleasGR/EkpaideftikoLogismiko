namespace LogismikoMain
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxPsw = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUsernme = new System.Windows.Forms.Label();
            this.labelpsw = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.labelwelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNewpass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnewaccount = new System.Windows.Forms.Label();
            this.textNewpass = new System.Windows.Forms.TextBox();
            this.textNewuser = new System.Windows.Forms.TextBox();
            this.buttonTEACHER = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTeacherLogIN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxName
            // 
            this.textboxName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textboxName.Location = new System.Drawing.Point(809, 132);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(308, 32);
            this.textboxName.TabIndex = 0;
            // 
            // textboxPsw
            // 
            this.textboxPsw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textboxPsw.Location = new System.Drawing.Point(809, 207);
            this.textboxPsw.Name = "textboxPsw";
            this.textboxPsw.PasswordChar = '*';
            this.textboxPsw.Size = new System.Drawing.Size(308, 32);
            this.textboxPsw.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonLogin.Location = new System.Drawing.Point(809, 274);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(117, 62);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUsernme
            // 
            this.labelUsernme.AutoSize = true;
            this.labelUsernme.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelUsernme.Location = new System.Drawing.Point(641, 131);
            this.labelUsernme.Name = "labelUsernme";
            this.labelUsernme.Size = new System.Drawing.Size(147, 30);
            this.labelUsernme.TabIndex = 3;
            this.labelUsernme.Text = "USERNAME:";
            // 
            // labelpsw
            // 
            this.labelpsw.AutoSize = true;
            this.labelpsw.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelpsw.Location = new System.Drawing.Point(641, 206);
            this.labelpsw.Name = "labelpsw";
            this.labelpsw.Size = new System.Drawing.Size(152, 30);
            this.labelpsw.TabIndex = 4;
            this.labelpsw.Text = "PASSWORD:";
            // 
            // buttonSignup
            // 
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonSignup.Location = new System.Drawing.Point(1000, 274);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(117, 62);
            this.buttonSignup.TabIndex = 5;
            this.buttonSignup.Text = "Sign Up";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // labelwelcome
            // 
            this.labelwelcome.AutoSize = true;
            this.labelwelcome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelwelcome.Location = new System.Drawing.Point(64, 39);
            this.labelwelcome.Name = "labelwelcome";
            this.labelwelcome.Size = new System.Drawing.Size(724, 34);
            this.labelwelcome.TabIndex = 6;
            this.labelwelcome.Text = "WELCOME, PLEASE LOG IN OR SIGN UP TO CONTINUE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textNewpass1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelnewaccount);
            this.panel1.Controls.Add(this.textNewpass);
            this.panel1.Controls.Add(this.textNewuser);
            this.panel1.Location = new System.Drawing.Point(625, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 475);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(360, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonback.Location = new System.Drawing.Point(36, 412);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(130, 39);
            this.buttonback.TabIndex = 7;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(32, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Re-type Password:";
            // 
            // textNewpass1
            // 
            this.textNewpass1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textNewpass1.Location = new System.Drawing.Point(200, 290);
            this.textNewpass1.Name = "textNewpass1";
            this.textNewpass1.PasswordChar = '*';
            this.textNewpass1.Size = new System.Drawing.Size(292, 28);
            this.textNewpass1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(32, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(32, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username :";
            // 
            // labelnewaccount
            // 
            this.labelnewaccount.AutoSize = true;
            this.labelnewaccount.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelnewaccount.Location = new System.Drawing.Point(30, 33);
            this.labelnewaccount.Name = "labelnewaccount";
            this.labelnewaccount.Size = new System.Drawing.Size(462, 34);
            this.labelnewaccount.TabIndex = 2;
            this.labelnewaccount.Text = "Fill in the form in order to sign up:";
            // 
            // textNewpass
            // 
            this.textNewpass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textNewpass.Location = new System.Drawing.Point(200, 222);
            this.textNewpass.Name = "textNewpass";
            this.textNewpass.PasswordChar = '*';
            this.textNewpass.Size = new System.Drawing.Size(292, 28);
            this.textNewpass.TabIndex = 1;
            // 
            // textNewuser
            // 
            this.textNewuser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textNewuser.Location = new System.Drawing.Point(200, 154);
            this.textNewuser.Name = "textNewuser";
            this.textNewuser.Size = new System.Drawing.Size(292, 28);
            this.textNewuser.TabIndex = 0;
            // 
            // buttonTEACHER
            // 
            this.buttonTEACHER.Location = new System.Drawing.Point(70, 537);
            this.buttonTEACHER.Name = "buttonTEACHER";
            this.buttonTEACHER.Size = new System.Drawing.Size(179, 31);
            this.buttonTEACHER.TabIndex = 8;
            this.buttonTEACHER.Text = "For teachers!";
            this.buttonTEACHER.UseVisualStyleBackColor = true;
            this.buttonTEACHER.Click += new System.EventHandler(this.buttonTEACHER_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTeacher.Controls.Add(this.button2);
            this.panelTeacher.Controls.Add(this.buttonTeacherLogIN);
            this.panelTeacher.Controls.Add(this.textBox2);
            this.panelTeacher.Controls.Add(this.textBox1);
            this.panelTeacher.Controls.Add(this.label5);
            this.panelTeacher.Controls.Add(this.label4);
            this.panelTeacher.Location = new System.Drawing.Point(66, 302);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(553, 229);
            this.panelTeacher.TabIndex = 9;
            this.panelTeacher.Visible = false;
            this.panelTeacher.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeacher_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTeacherLogIN
            // 
            this.buttonTeacherLogIN.Location = new System.Drawing.Point(27, 163);
            this.buttonTeacherLogIN.Name = "buttonTeacherLogIN";
            this.buttonTeacherLogIN.Size = new System.Drawing.Size(109, 39);
            this.buttonTeacherLogIN.TabIndex = 11;
            this.buttonTeacherLogIN.Text = "Log in";
            this.buttonTeacherLogIN.UseVisualStyleBackColor = true;
            this.buttonTeacherLogIN.Click += new System.EventHandler(this.buttonTeacherLogIN_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(137, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(292, 28);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(137, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 28);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(23, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(23, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "*Password must be Longer than 5 characters";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::EkpaideftikoLogismiko.Properties.Resources.csharp_e7b8fcd4ce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1229, 591);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.buttonTEACHER);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelwelcome);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.labelpsw);
            this.Controls.Add(this.labelUsernme);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textboxPsw);
            this.Controls.Add(this.textboxName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Tutorials";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxPsw;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUsernme;
        private System.Windows.Forms.Label labelpsw;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Label labelwelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNewpass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnewaccount;
        private System.Windows.Forms.TextBox textNewpass;
        private System.Windows.Forms.TextBox textNewuser;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonTEACHER;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTeacherLogIN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}