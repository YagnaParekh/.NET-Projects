
namespace Lab5B
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Doctor = new System.Windows.Forms.Label();
            this.doctorCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playerTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.seriesTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstEpisodeTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.companionLB = new System.Windows.Forms.ListBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Query = new System.Windows.Forms.GroupBox();
            this.sqlRB = new System.Windows.Forms.RadioButton();
            this.linqRB = new System.Windows.Forms.RadioButton();
            this.statusLBL = new System.Windows.Forms.ToolStrip();
            this.imagePB = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagePB);
            this.groupBox1.Controls.Add(this.firstEpisodeTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ageTB);
            this.groupBox1.Controls.Add(this.seriesTB);
            this.groupBox1.Controls.Add(this.yearTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.playerTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.doctorCB);
            this.groupBox1.Controls.Add(this.Doctor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 584);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The Doctor";
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Location = new System.Drawing.Point(6, 49);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(96, 29);
            this.Doctor.TabIndex = 0;
            this.Doctor.Text = "Doctor :";
            // 
            // doctorCB
            // 
            this.doctorCB.FormattingEnabled = true;
            this.doctorCB.Location = new System.Drawing.Point(163, 49);
            this.doctorCB.Name = "doctorCB";
            this.doctorCB.Size = new System.Drawing.Size(348, 40);
            this.doctorCB.TabIndex = 1;
            this.doctorCB.SelectedIndexChanged += new System.EventHandler(this.doctorCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Played By:";
            // 
            // playerTB
            // 
            this.playerTB.Location = new System.Drawing.Point(163, 109);
            this.playerTB.Name = "playerTB";
            this.playerTB.Size = new System.Drawing.Size(348, 39);
            this.playerTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Series:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age to Start:";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(163, 174);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(100, 39);
            this.yearTB.TabIndex = 7;
            // 
            // seriesTB
            // 
            this.seriesTB.Location = new System.Drawing.Point(163, 236);
            this.seriesTB.Name = "seriesTB";
            this.seriesTB.Size = new System.Drawing.Size(100, 39);
            this.seriesTB.TabIndex = 8;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(163, 301);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(100, 39);
            this.ageTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Full Episode:";
            // 
            // firstEpisodeTB
            // 
            this.firstEpisodeTB.Location = new System.Drawing.Point(11, 539);
            this.firstEpisodeTB.Name = "firstEpisodeTB";
            this.firstEpisodeTB.Size = new System.Drawing.Size(500, 39);
            this.firstEpisodeTB.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.companionLB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(546, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 584);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Companios and their first episode this Doctor:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // companionLB
            // 
            this.companionLB.FormattingEnabled = true;
            this.companionLB.ItemHeight = 29;
            this.companionLB.Location = new System.Drawing.Point(6, 69);
            this.companionLB.Name = "companionLB";
            this.companionLB.Size = new System.Drawing.Size(476, 497);
            this.companionLB.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = " Exit     Ctrl + Q";
            // 
            // Query
            // 
            this.Query.Controls.Add(this.linqRB);
            this.Query.Controls.Add(this.sqlRB);
            this.Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query.Location = new System.Drawing.Point(1056, 437);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(224, 175);
            this.Query.TabIndex = 3;
            this.Query.TabStop = false;
            this.Query.Text = "Query";
            // 
            // sqlRB
            // 
            this.sqlRB.AutoSize = true;
            this.sqlRB.Location = new System.Drawing.Point(17, 49);
            this.sqlRB.Name = "sqlRB";
            this.sqlRB.Size = new System.Drawing.Size(185, 29);
            this.sqlRB.TabIndex = 0;
            this.sqlRB.TabStop = true;
            this.sqlRB.Text = "Solve using SQL";
            this.sqlRB.UseVisualStyleBackColor = true;
            // 
            // linqRB
            // 
            this.linqRB.AutoSize = true;
            this.linqRB.Location = new System.Drawing.Point(17, 123);
            this.linqRB.Name = "linqRB";
            this.linqRB.Size = new System.Drawing.Size(190, 29);
            this.linqRB.TabIndex = 1;
            this.linqRB.TabStop = true;
            this.linqRB.Text = "Solve using LINQ";
            this.linqRB.UseVisualStyleBackColor = true;
            // 
            // statusLBL
            // 
            this.statusLBL.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusLBL.Location = new System.Drawing.Point(0, 33);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(1292, 25);
            this.statusLBL.TabIndex = 4;
            this.statusLBL.Text = "toolStrip1";
            // 
            // imagePB
            // 
            this.imagePB.Location = new System.Drawing.Point(283, 174);
            this.imagePB.Name = "imagePB";
            this.imagePB.Size = new System.Drawing.Size(211, 350);
            this.imagePB.TabIndex = 12;
            this.imagePB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 675);
            this.Controls.Add(this.statusLBL);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Query.ResumeLayout(false);
            this.Query.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorCB;
        private System.Windows.Forms.Label Doctor;
        private System.Windows.Forms.TextBox firstEpisodeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox seriesTB;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox companionLB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox Query;
        private System.Windows.Forms.RadioButton linqRB;
        private System.Windows.Forms.RadioButton sqlRB;
        private System.Windows.Forms.ToolStrip statusLBL;
        private System.Windows.Forms.PictureBox imagePB;
    }
}

