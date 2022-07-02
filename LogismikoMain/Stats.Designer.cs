namespace LogismikoMain
{
    partial class Stats
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelt4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadStat = new System.Windows.Forms.Button();
            this.labelAnswers = new System.Windows.Forms.Label();
            this.labelmistakes = new System.Windows.Forms.Label();
            this.labelCatcompleted = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelWeakestCat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRATIO = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxCORR = new System.Windows.Forms.TextBox();
            this.textBoxMIS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Image = global::EkpaideftikoLogismiko.Properties.Resources.line;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(29, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(427, 96);
            this.label7.TabIndex = 0;
            this.label7.Text = "STATISTICS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(41, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total correct answers:";
            // 
            // labelt4
            // 
            this.labelt4.AutoSize = true;
            this.labelt4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelt4.Location = new System.Drawing.Point(41, 190);
            this.labelt4.Name = "labelt4";
            this.labelt4.Size = new System.Drawing.Size(148, 23);
            this.labelt4.TabIndex = 2;
            this.labelt4.Text = "Total Mistakes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(41, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Categories completed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(41, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total time spent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(41, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weakest Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(41, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categories Participated:";
            // 
            // buttonLoadStat
            // 
            this.buttonLoadStat.BackgroundImage = global::EkpaideftikoLogismiko.Properties.Resources.line;
            this.buttonLoadStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadStat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.buttonLoadStat.Location = new System.Drawing.Point(462, 88);
            this.buttonLoadStat.Name = "buttonLoadStat";
            this.buttonLoadStat.Size = new System.Drawing.Size(423, 31);
            this.buttonLoadStat.TabIndex = 7;
            this.buttonLoadStat.Text = "Load Statistics";
            this.buttonLoadStat.UseVisualStyleBackColor = true;
            this.buttonLoadStat.Click += new System.EventHandler(this.buttonLoadStat_Click);
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoSize = true;
            this.labelAnswers.Location = new System.Drawing.Point(271, 142);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(0, 21);
            this.labelAnswers.TabIndex = 8;
            // 
            // labelmistakes
            // 
            this.labelmistakes.AutoSize = true;
            this.labelmistakes.Location = new System.Drawing.Point(195, 192);
            this.labelmistakes.Name = "labelmistakes";
            this.labelmistakes.Size = new System.Drawing.Size(0, 21);
            this.labelmistakes.TabIndex = 9;
            // 
            // labelCatcompleted
            // 
            this.labelCatcompleted.AutoSize = true;
            this.labelCatcompleted.Location = new System.Drawing.Point(285, 292);
            this.labelCatcompleted.Name = "labelCatcompleted";
            this.labelCatcompleted.Size = new System.Drawing.Size(0, 21);
            this.labelCatcompleted.TabIndex = 10;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(217, 342);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 21);
            this.labelTime.TabIndex = 11;
            // 
            // labelWeakestCat
            // 
            this.labelWeakestCat.AutoSize = true;
            this.labelWeakestCat.Location = new System.Drawing.Point(243, 392);
            this.labelWeakestCat.Name = "labelWeakestCat";
            this.labelWeakestCat.Size = new System.Drawing.Size(0, 21);
            this.labelWeakestCat.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(41, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Answer\\Mistake ratio:";
            // 
            // labelRATIO
            // 
            this.labelRATIO.AutoSize = true;
            this.labelRATIO.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRATIO.Location = new System.Drawing.Point(267, 240);
            this.labelRATIO.Name = "labelRATIO";
            this.labelRATIO.Size = new System.Drawing.Size(0, 21);
            this.labelRATIO.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(294, 439);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 86);
            this.textBox1.TabIndex = 16;
            // 
            // textBoxCORR
            // 
            this.textBoxCORR.Enabled = false;
            this.textBoxCORR.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxCORR.Location = new System.Drawing.Point(352, 135);
            this.textBoxCORR.Name = "textBoxCORR";
            this.textBoxCORR.Size = new System.Drawing.Size(506, 28);
            this.textBoxCORR.TabIndex = 17;
            this.textBoxCORR.Visible = false;
            // 
            // textBoxMIS
            // 
            this.textBoxMIS.Enabled = false;
            this.textBoxMIS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxMIS.Location = new System.Drawing.Point(352, 185);
            this.textBoxMIS.Name = "textBoxMIS";
            this.textBoxMIS.Size = new System.Drawing.Size(506, 28);
            this.textBoxMIS.TabIndex = 18;
            this.textBoxMIS.Visible = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.textBoxMIS);
            this.Controls.Add(this.textBoxCORR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRATIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWeakestCat);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCatcompleted);
            this.Controls.Add(this.labelmistakes);
            this.Controls.Add(this.labelAnswers);
            this.Controls.Add(this.buttonLoadStat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelt4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stats";
            this.Size = new System.Drawing.Size(1211, 581);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelt4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.Label labelmistakes;
        private System.Windows.Forms.Label labelCatcompleted;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelWeakestCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelRATIO;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button buttonLoadStat;
        private System.Windows.Forms.TextBox textBoxCORR;
        private System.Windows.Forms.TextBox textBoxMIS;
    }
}
