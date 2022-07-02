namespace LogismikoMain
{
    partial class Help
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.labelCont = new System.Windows.Forms.Label();
            this.panelContents = new System.Windows.Forms.Panel();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonUsing = new System.Windows.Forms.Button();
            this.buttonPurpose = new System.Windows.Forms.Button();
            this.buttonCont = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelPurpose = new System.Windows.Forms.Panel();
            this.panelUsing = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelForTeachers = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelAcheivements = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContents.SuspendLayout();
            this.panelPurpose.SuspendLayout();
            this.panelUsing.SuspendLayout();
            this.panelForTeachers.SuspendLayout();
            this.panelAcheivements.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCont
            // 
            this.labelCont.AutoSize = true;
            this.labelCont.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCont.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCont.Location = new System.Drawing.Point(14, 15);
            this.labelCont.Name = "labelCont";
            this.labelCont.Size = new System.Drawing.Size(222, 96);
            this.labelCont.TabIndex = 0;
            this.labelCont.Text = "HELP";
            this.labelCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelContents
            // 
            this.panelContents.Controls.Add(this.buttonTeachers);
            this.panelContents.Controls.Add(this.buttonUnlock);
            this.panelContents.Controls.Add(this.buttonStats);
            this.panelContents.Controls.Add(this.buttonUsing);
            this.panelContents.Controls.Add(this.buttonPurpose);
            this.panelContents.Controls.Add(this.buttonCont);
            this.panelContents.Location = new System.Drawing.Point(30, 123);
            this.panelContents.MaximumSize = new System.Drawing.Size(164, 306);
            this.panelContents.MinimumSize = new System.Drawing.Size(164, 53);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(164, 53);
            this.panelContents.TabIndex = 2;
            this.panelContents.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContents_Paint);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.Color.Thistle;
            this.buttonTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeachers.Location = new System.Drawing.Point(0, 261);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(164, 49);
            this.buttonTeachers.TabIndex = 6;
            this.buttonTeachers.Text = "For teachers";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.BackColor = System.Drawing.Color.Thistle;
            this.buttonUnlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnlock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUnlock.Location = new System.Drawing.Point(0, 209);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(164, 52);
            this.buttonUnlock.TabIndex = 5;
            this.buttonUnlock.Text = "Acheivements";
            this.buttonUnlock.UseVisualStyleBackColor = false;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.Thistle;
            this.buttonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStats.Location = new System.Drawing.Point(0, 157);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(164, 52);
            this.buttonStats.TabIndex = 4;
            this.buttonStats.Text = "Statistics";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonStats_MouseClick);
            // 
            // buttonUsing
            // 
            this.buttonUsing.BackColor = System.Drawing.Color.Thistle;
            this.buttonUsing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsing.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsing.Location = new System.Drawing.Point(0, 105);
            this.buttonUsing.Name = "buttonUsing";
            this.buttonUsing.Size = new System.Drawing.Size(164, 52);
            this.buttonUsing.TabIndex = 3;
            this.buttonUsing.Text = "Using the app";
            this.buttonUsing.UseVisualStyleBackColor = false;
            this.buttonUsing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonUsing_MouseClick);
            // 
            // buttonPurpose
            // 
            this.buttonPurpose.BackColor = System.Drawing.Color.Thistle;
            this.buttonPurpose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPurpose.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPurpose.Location = new System.Drawing.Point(0, 53);
            this.buttonPurpose.Name = "buttonPurpose";
            this.buttonPurpose.Size = new System.Drawing.Size(164, 52);
            this.buttonPurpose.TabIndex = 2;
            this.buttonPurpose.Text = "Purpose";
            this.buttonPurpose.UseVisualStyleBackColor = false;
            this.buttonPurpose.Click += new System.EventHandler(this.buttonPurpose_Click);
            // 
            // buttonCont
            // 
            this.buttonCont.BackColor = System.Drawing.Color.MediumOrchid;
            this.buttonCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCont.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCont.Image = global::EkpaideftikoLogismiko.Properties.Resources.Webp_net_resizeimage;
            this.buttonCont.Location = new System.Drawing.Point(0, 0);
            this.buttonCont.Name = "buttonCont";
            this.buttonCont.Size = new System.Drawing.Size(164, 53);
            this.buttonCont.TabIndex = 1;
            this.buttonCont.Text = "Contents:";
            this.buttonCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCont.UseVisualStyleBackColor = false;
            this.buttonCont.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelPurpose
            // 
            this.panelPurpose.Controls.Add(this.panelUsing);
            this.panelPurpose.Controls.Add(this.panelForTeachers);
            this.panelPurpose.Controls.Add(this.panelAcheivements);
            this.panelPurpose.Controls.Add(this.panelStats);
            this.panelPurpose.Controls.Add(this.label2);
            this.panelPurpose.Controls.Add(this.label1);
            this.panelPurpose.Location = new System.Drawing.Point(242, 15);
            this.panelPurpose.Name = "panelPurpose";
            this.panelPurpose.Size = new System.Drawing.Size(932, 550);
            this.panelPurpose.TabIndex = 3;
            this.panelPurpose.Visible = false;
            // 
            // panelUsing
            // 
            this.panelUsing.Controls.Add(this.label10);
            this.panelUsing.Controls.Add(this.label9);
            this.panelUsing.Location = new System.Drawing.Point(3, 0);
            this.panelUsing.Name = "panelUsing";
            this.panelUsing.Size = new System.Drawing.Size(920, 550);
            this.panelUsing.TabIndex = 4;
            this.panelUsing.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(840, 294);
            this.label10.TabIndex = 1;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(9, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 34);
            this.label9.TabIndex = 0;
            this.label9.Text = "Using the Application";
            // 
            // panelForTeachers
            // 
            this.panelForTeachers.Controls.Add(this.label8);
            this.panelForTeachers.Controls.Add(this.label7);
            this.panelForTeachers.Location = new System.Drawing.Point(6, 3);
            this.panelForTeachers.Name = "panelForTeachers";
            this.panelForTeachers.Size = new System.Drawing.Size(923, 550);
            this.panelForTeachers.TabIndex = 4;
            this.panelForTeachers.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(704, 126);
            this.label8.TabIndex = 1;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "For Teachers";
            // 
            // panelAcheivements
            // 
            this.panelAcheivements.Controls.Add(this.label6);
            this.panelAcheivements.Controls.Add(this.label5);
            this.panelAcheivements.Location = new System.Drawing.Point(3, 3);
            this.panelAcheivements.Name = "panelAcheivements";
            this.panelAcheivements.Size = new System.Drawing.Size(929, 550);
            this.panelAcheivements.TabIndex = 2;
            this.panelAcheivements.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(917, 273);
            this.label6.TabIndex = 1;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acheivements/Unlockabes";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.label4);
            this.panelStats.Controls.Add(this.label3);
            this.panelStats.Location = new System.Drawing.Point(3, 3);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(932, 547);
            this.panelStats.TabIndex = 4;
            this.panelStats.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(684, 483);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(25, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(897, 357);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purpose of the application:";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelPurpose);
            this.Controls.Add(this.panelContents);
            this.Controls.Add(this.labelCont);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Help";
            this.Size = new System.Drawing.Size(1211, 581);
            this.Load += new System.EventHandler(this.Help_Load);
            this.panelContents.ResumeLayout(false);
            this.panelPurpose.ResumeLayout(false);
            this.panelPurpose.PerformLayout();
            this.panelUsing.ResumeLayout(false);
            this.panelUsing.PerformLayout();
            this.panelForTeachers.ResumeLayout(false);
            this.panelForTeachers.PerformLayout();
            this.panelAcheivements.ResumeLayout(false);
            this.panelAcheivements.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCont;
        private System.Windows.Forms.Button buttonCont;
        private System.Windows.Forms.Panel panelContents;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonUnlock;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonUsing;
        private System.Windows.Forms.Button buttonPurpose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelPurpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAcheivements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelForTeachers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelUsing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
