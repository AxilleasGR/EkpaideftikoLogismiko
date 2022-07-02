namespace LogismikoMain
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonAcheivements = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.labelcat = new System.Windows.Forms.Label();
            this.buttonDVO = new System.Windows.Forms.Button();
            this.buttonLoo = new System.Windows.Forms.Button();
            this.buttonCla = new System.Windows.Forms.Button();
            this.buttonARS = new System.Windows.Forms.Button();
            this.dvO11 = new LogismikoMain.DVO1();
            this.stats1 = new LogismikoMain.Stats();
            this.acheivements1 = new LogismikoMain.Acheivements();
            this.help1 = new LogismikoMain.Help();
            this.panelstart = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelcategory = new System.Windows.Forms.Label();
            this.labelcurrentCAT = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.Logout_button = new System.Windows.Forms.Button();
            this.panelDropDown.SuspendLayout();
            this.panelstart.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 15;
            this.timerMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.buttonHelp);
            this.panelDropDown.Controls.Add(this.buttonAcheivements);
            this.panelDropDown.Controls.Add(this.buttonStats);
            this.panelDropDown.Controls.Add(this.buttonStart);
            this.panelDropDown.Controls.Add(this.MenuButton);
            this.panelDropDown.Location = new System.Drawing.Point(0, 0);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(243, 246);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(243, 77);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(243, 77);
            this.panelDropDown.TabIndex = 0;
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStats.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonStats.Location = new System.Drawing.Point(0, 118);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(243, 42);
            this.buttonStats.TabIndex = 2;
            this.buttonStats.Text = "Statistics";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonAcheivements
            // 
            this.buttonAcheivements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAcheivements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcheivements.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAcheivements.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonAcheivements.Location = new System.Drawing.Point(0, 160);
            this.buttonAcheivements.Name = "buttonAcheivements";
            this.buttonAcheivements.Size = new System.Drawing.Size(243, 42);
            this.buttonAcheivements.TabIndex = 3;
            this.buttonAcheivements.Text = "Acheivements";
            this.buttonAcheivements.UseVisualStyleBackColor = false;
            this.buttonAcheivements.Click += new System.EventHandler(this.buttonAcheivements_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonHelp.Location = new System.Drawing.Point(0, 202);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(243, 42);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonHelp_MouseClick);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonStart.Location = new System.Drawing.Point(0, 76);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(243, 42);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Exercise";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MenuButton.Image = global::EkpaideftikoLogismiko.Properties.Resources.Webp_net_resizeimage;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(243, 76);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.Text = "Menu";
            this.MenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(1020, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelcat
            // 
            this.labelcat.AutoSize = true;
            this.labelcat.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelcat.Location = new System.Drawing.Point(17, 24);
            this.labelcat.Name = "labelcat";
            this.labelcat.Size = new System.Drawing.Size(251, 30);
            this.labelcat.TabIndex = 0;
            this.labelcat.Text = "Choose a category:";
            // 
            // buttonDVO
            // 
            this.buttonDVO.BackColor = System.Drawing.Color.Gold;
            this.buttonDVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDVO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonDVO.Location = new System.Drawing.Point(24, 94);
            this.buttonDVO.Name = "buttonDVO";
            this.buttonDVO.Size = new System.Drawing.Size(908, 70);
            this.buttonDVO.TabIndex = 1;
            this.buttonDVO.Text = "Questions on Data types, Variables and Operators";
            this.buttonDVO.UseVisualStyleBackColor = false;
            this.buttonDVO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDVO_MouseClick);
            // 
            // buttonLoo
            // 
            this.buttonLoo.BackColor = System.Drawing.Color.Gold;
            this.buttonLoo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonLoo.Location = new System.Drawing.Point(24, 170);
            this.buttonLoo.Name = "buttonLoo";
            this.buttonLoo.Size = new System.Drawing.Size(908, 70);
            this.buttonLoo.TabIndex = 2;
            this.buttonLoo.Text = "Questions on Looping Statements";
            this.buttonLoo.UseVisualStyleBackColor = false;
            this.buttonLoo.Click += new System.EventHandler(this.buttonLoo_Click);
            // 
            // buttonCla
            // 
            this.buttonCla.BackColor = System.Drawing.Color.Gold;
            this.buttonCla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonCla.Location = new System.Drawing.Point(24, 246);
            this.buttonCla.Name = "buttonCla";
            this.buttonCla.Size = new System.Drawing.Size(908, 70);
            this.buttonCla.TabIndex = 3;
            this.buttonCla.Text = "Questions on Classes";
            this.buttonCla.UseVisualStyleBackColor = false;
            this.buttonCla.Click += new System.EventHandler(this.buttonCla_Click);
            // 
            // buttonARS
            // 
            this.buttonARS.BackColor = System.Drawing.Color.Gold;
            this.buttonARS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonARS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonARS.Location = new System.Drawing.Point(24, 322);
            this.buttonARS.Name = "buttonARS";
            this.buttonARS.Size = new System.Drawing.Size(908, 70);
            this.buttonARS.TabIndex = 4;
            this.buttonARS.Text = "Questions on Arrays and Strings";
            this.buttonARS.UseVisualStyleBackColor = false;
            this.buttonARS.Click += new System.EventHandler(this.buttonARS_Click);
            // 
            // dvO11
            // 
            this.dvO11.Location = new System.Drawing.Point(0, -13);
            this.dvO11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvO11.Name = "dvO11";
            this.dvO11.Size = new System.Drawing.Size(1211, 581);
            this.dvO11.TabIndex = 5;
            // 
            // stats1
            // 
            this.stats1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stats1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.stats1.Location = new System.Drawing.Point(4, -13);
            this.stats1.Margin = new System.Windows.Forms.Padding(4);
            this.stats1.Name = "stats1";
            this.stats1.Size = new System.Drawing.Size(1211, 581);
            this.stats1.TabIndex = 6;
            // 
            // acheivements1
            // 
            this.acheivements1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.acheivements1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.acheivements1.Location = new System.Drawing.Point(4, -4);
            this.acheivements1.Margin = new System.Windows.Forms.Padding(4);
            this.acheivements1.Name = "acheivements1";
            this.acheivements1.Size = new System.Drawing.Size(957, 566);
            this.acheivements1.TabIndex = 7;
            // 
            // help1
            // 
            this.help1.BackColor = System.Drawing.SystemColors.Control;
            this.help1.Enabled = false;
            this.help1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.help1.Location = new System.Drawing.Point(-10, -4);
            this.help1.Margin = new System.Windows.Forms.Padding(4);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(1211, 581);
            this.help1.TabIndex = 8;
            // 
            // panelstart
            // 
            this.panelstart.Controls.Add(this.help1);
            this.panelstart.Controls.Add(this.acheivements1);
            this.panelstart.Controls.Add(this.stats1);
            this.panelstart.Controls.Add(this.dvO11);
            this.panelstart.Controls.Add(this.buttonARS);
            this.panelstart.Controls.Add(this.buttonCla);
            this.panelstart.Controls.Add(this.buttonLoo);
            this.panelstart.Controls.Add(this.buttonDVO);
            this.panelstart.Controls.Add(this.labelcat);
            this.panelstart.Location = new System.Drawing.Point(260, 13);
            this.panelstart.Name = "panelstart";
            this.panelstart.Size = new System.Drawing.Size(957, 566);
            this.panelstart.TabIndex = 1;
            this.panelstart.Visible = false;
            this.panelstart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelstart_Paint);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonBack.Location = new System.Drawing.Point(12, 455);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(230, 75);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelcategory.Location = new System.Drawing.Point(18, 363);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(78, 19);
            this.labelcategory.TabIndex = 3;
            this.labelcategory.Text = "Category:";
            this.labelcategory.Visible = false;
            // 
            // labelcurrentCAT
            // 
            this.labelcurrentCAT.AutoSize = true;
            this.labelcurrentCAT.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelcurrentCAT.Location = new System.Drawing.Point(19, 404);
            this.labelcurrentCAT.Name = "labelcurrentCAT";
            this.labelcurrentCAT.Size = new System.Drawing.Size(0, 19);
            this.labelcurrentCAT.TabIndex = 4;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelusername.Location = new System.Drawing.Point(19, 259);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(0, 20);
            this.labelusername.TabIndex = 5;
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_button.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Logout_button.Location = new System.Drawing.Point(13, 536);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(230, 39);
            this.Logout_button.TabIndex = 7;
            this.Logout_button.Text = "LOG OUT";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EkpaideftikoLogismiko.Properties.Resources.csharp_e7b8fcd4ce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1229, 591);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelcurrentCAT);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panelstart);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Tutorials";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDropDown.ResumeLayout(false);
            this.panelstart.ResumeLayout(false);
            this.panelstart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonAcheivements;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button MenuButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelcat;
        private System.Windows.Forms.Button buttonDVO;
        private System.Windows.Forms.Button buttonLoo;
        private System.Windows.Forms.Button buttonCla;
        private System.Windows.Forms.Button buttonARS;
        private DVO1 dvO11;
        private Stats stats1;
        private Acheivements acheivements1;
        private Help help1;
        public System.Windows.Forms.Panel panelstart;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Label labelcurrentCAT;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Button Logout_button;
    }
}

