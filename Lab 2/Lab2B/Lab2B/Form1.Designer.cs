
using System;

namespace Lab2B
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
            this.Calculte = new System.Windows.Forms.Button();
            this.Hairdresser = new System.Windows.Forms.GroupBox();
            this.Ron_button = new System.Windows.Forms.RadioButton();
            this.Laura_button = new System.Windows.Forms.RadioButton();
            this.Sue_button = new System.Windows.Forms.RadioButton();
            this.Pat_button = new System.Windows.Forms.RadioButton();
            this.Jan_button = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.GroupBox();
            this.Extension_box = new System.Windows.Forms.CheckBox();
            this.Highlight_box = new System.Windows.Forms.CheckBox();
            this.Color_box = new System.Windows.Forms.CheckBox();
            this.Cut_box = new System.Windows.Forms.CheckBox();
            this.ClientVisits = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visit = new System.Windows.Forms.TextBox();
            this.Clienttype = new System.Windows.Forms.GroupBox();
            this.Senior_button = new System.Windows.Forms.RadioButton();
            this.Student_button = new System.Windows.Forms.RadioButton();
            this.Child_button = new System.Windows.Forms.RadioButton();
            this.Standard_button = new System.Windows.Forms.RadioButton();
            this.price_label = new System.Windows.Forms.Label();
            this.Hairdresser.SuspendLayout();
            this.Services.SuspendLayout();
            this.ClientVisits.SuspendLayout();
            this.Clienttype.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculte
            // 
            this.Calculte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculte.Location = new System.Drawing.Point(29, 725);
            this.Calculte.Name = "Calculte";
            this.Calculte.Size = new System.Drawing.Size(255, 68);
            this.Calculte.TabIndex = 0;
            this.Calculte.Text = "Calculate";
            this.Calculte.UseVisualStyleBackColor = true;
            this.Calculte.Click += new System.EventHandler(this.Calculte_Click);
            // 
            // Hairdresser
            // 
            this.Hairdresser.Controls.Add(this.Ron_button);
            this.Hairdresser.Controls.Add(this.Laura_button);
            this.Hairdresser.Controls.Add(this.Sue_button);
            this.Hairdresser.Controls.Add(this.Pat_button);
            this.Hairdresser.Controls.Add(this.Jan_button);
            this.Hairdresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hairdresser.Location = new System.Drawing.Point(23, 9);
            this.Hairdresser.Name = "Hairdresser";
            this.Hairdresser.Size = new System.Drawing.Size(438, 362);
            this.Hairdresser.TabIndex = 1;
            this.Hairdresser.TabStop = false;
            this.Hairdresser.Text = "HairDresser";
            this.Hairdresser.Enter += new System.EventHandler(this.Hairdresser_Enter);
            // 
            // Ron_button
            // 
            this.Ron_button.AutoSize = true;
            this.Ron_button.Location = new System.Drawing.Point(6, 180);
            this.Ron_button.Name = "Ron_button";
            this.Ron_button.Size = new System.Drawing.Size(229, 36);
            this.Ron_button.TabIndex = 4;
            this.Ron_button.TabStop = true;
            this.Ron_button.Text = "Ran Chambers";
            this.Ron_button.UseVisualStyleBackColor = true;
            // 
            // Laura_button
            // 
            this.Laura_button.AutoSize = true;
            this.Laura_button.Location = new System.Drawing.Point(7, 306);
            this.Laura_button.Name = "Laura_button";
            this.Laura_button.Size = new System.Drawing.Size(223, 36);
            this.Laura_button.TabIndex = 3;
            this.Laura_button.TabStop = true;
            this.Laura_button.Text = "Laura Renkins";
            this.Laura_button.UseVisualStyleBackColor = true;
            // 
            // Sue_button
            // 
            this.Sue_button.AutoSize = true;
            this.Sue_button.Location = new System.Drawing.Point(7, 243);
            this.Sue_button.Name = "Sue_button";
            this.Sue_button.Size = new System.Drawing.Size(179, 36);
            this.Sue_button.TabIndex = 2;
            this.Sue_button.TabStop = true;
            this.Sue_button.Text = "Sue Pallon";
            this.Sue_button.UseVisualStyleBackColor = true;
            // 
            // Pat_button
            // 
            this.Pat_button.AutoSize = true;
            this.Pat_button.Location = new System.Drawing.Point(7, 122);
            this.Pat_button.Name = "Pat_button";
            this.Pat_button.Size = new System.Drawing.Size(198, 36);
            this.Pat_button.TabIndex = 1;
            this.Pat_button.TabStop = true;
            this.Pat_button.Text = "Pat Johnson";
            this.Pat_button.UseVisualStyleBackColor = true;
            // 
            // Jan_button
            // 
            this.Jan_button.AutoSize = true;
            this.Jan_button.Location = new System.Drawing.Point(6, 54);
            this.Jan_button.Name = "Jan_button";
            this.Jan_button.Size = new System.Drawing.Size(188, 36);
            this.Jan_button.TabIndex = 0;
            this.Jan_button.TabStop = true;
            this.Jan_button.Text = "Jan Samely";
            this.Jan_button.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(410, 725);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(216, 68);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(752, 725);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(235, 68);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Services
            // 
            this.Services.Controls.Add(this.Extension_box);
            this.Services.Controls.Add(this.Highlight_box);
            this.Services.Controls.Add(this.Color_box);
            this.Services.Controls.Add(this.Cut_box);
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(595, 12);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(425, 317);
            this.Services.TabIndex = 5;
            this.Services.TabStop = false;
            this.Services.Text = "Services";
            this.Services.Enter += new System.EventHandler(this.Services_Enter);
            // 
            // Extension_box
            // 
            this.Extension_box.AutoSize = true;
            this.Extension_box.Location = new System.Drawing.Point(16, 259);
            this.Extension_box.Name = "Extension_box";
            this.Extension_box.Size = new System.Drawing.Size(181, 36);
            this.Extension_box.TabIndex = 3;
            this.Extension_box.Text = "Extensions";
            this.Extension_box.UseVisualStyleBackColor = true;
            // 
            // Highlight_box
            // 
            this.Highlight_box.AutoSize = true;
            this.Highlight_box.Location = new System.Drawing.Point(16, 188);
            this.Highlight_box.Name = "Highlight_box";
            this.Highlight_box.Size = new System.Drawing.Size(168, 36);
            this.Highlight_box.TabIndex = 2;
            this.Highlight_box.Text = "Highlights";
            this.Highlight_box.UseVisualStyleBackColor = true;
            // 
            // Color_box
            // 
            this.Color_box.AutoSize = true;
            this.Color_box.Location = new System.Drawing.Point(16, 119);
            this.Color_box.Name = "Color_box";
            this.Color_box.Size = new System.Drawing.Size(125, 36);
            this.Color_box.TabIndex = 1;
            this.Color_box.Text = "Colour";
            this.Color_box.UseVisualStyleBackColor = true;
            // 
            // Cut_box
            // 
            this.Cut_box.AutoSize = true;
            this.Cut_box.Location = new System.Drawing.Point(16, 52);
            this.Cut_box.Name = "Cut_box";
            this.Cut_box.Size = new System.Drawing.Size(85, 36);
            this.Cut_box.TabIndex = 0;
            this.Cut_box.Text = "Cut";
            this.Cut_box.UseVisualStyleBackColor = true;
            // 
            // ClientVisits
            // 
            this.ClientVisits.Controls.Add(this.label1);
            this.ClientVisits.Controls.Add(this.visit);
            this.ClientVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientVisits.Location = new System.Drawing.Point(595, 377);
            this.ClientVisits.Name = "ClientVisits";
            this.ClientVisits.Size = new System.Drawing.Size(425, 261);
            this.ClientVisits.TabIndex = 6;
            this.ClientVisits.TabStop = false;
            this.ClientVisits.Text = "Client Visits";
            this.ClientVisits.Enter += new System.EventHandler(this.ClientVisits_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Clients Visits";
            // 
            // visit
            // 
            this.visit.Location = new System.Drawing.Point(16, 159);
            this.visit.Name = "visit";
            this.visit.Size = new System.Drawing.Size(235, 39);
            this.visit.TabIndex = 0;
            // 
            // Clienttype
            // 
            this.Clienttype.Controls.Add(this.Senior_button);
            this.Clienttype.Controls.Add(this.Student_button);
            this.Clienttype.Controls.Add(this.Child_button);
            this.Clienttype.Controls.Add(this.Standard_button);
            this.Clienttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clienttype.Location = new System.Drawing.Point(29, 377);
            this.Clienttype.Name = "Clienttype";
            this.Clienttype.Size = new System.Drawing.Size(431, 292);
            this.Clienttype.TabIndex = 7;
            this.Clienttype.TabStop = false;
            this.Clienttype.Text = "Client Type";
            // 
            // Senior_button
            // 
            this.Senior_button.AutoSize = true;
            this.Senior_button.Location = new System.Drawing.Point(7, 226);
            this.Senior_button.Name = "Senior_button";
            this.Senior_button.Size = new System.Drawing.Size(242, 36);
            this.Senior_button.TabIndex = 3;
            this.Senior_button.TabStop = true;
            this.Senior_button.Text = "Senior (over 65)";
            this.Senior_button.UseVisualStyleBackColor = true;
            // 
            // Student_button
            // 
            this.Student_button.AutoSize = true;
            this.Student_button.Location = new System.Drawing.Point(7, 160);
            this.Student_button.Name = "Student_button";
            this.Student_button.Size = new System.Drawing.Size(139, 36);
            this.Student_button.TabIndex = 2;
            this.Student_button.TabStop = true;
            this.Student_button.Text = "Student";
            this.Student_button.UseVisualStyleBackColor = true;
            // 
            // Child_button
            // 
            this.Child_button.AutoSize = true;
            this.Child_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Child_button.Location = new System.Drawing.Point(7, 97);
            this.Child_button.Name = "Child_button";
            this.Child_button.Size = new System.Drawing.Size(302, 36);
            this.Child_button.TabIndex = 1;
            this.Child_button.TabStop = true;
            this.Child_button.Text = "Child (12 and Under)";
            this.Child_button.UseVisualStyleBackColor = true;
            // 
            // Standard_button
            // 
            this.Standard_button.AutoSize = true;
            this.Standard_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standard_button.Location = new System.Drawing.Point(7, 44);
            this.Standard_button.Name = "Standard_button";
            this.Standard_button.Size = new System.Drawing.Size(229, 36);
            this.Standard_button.TabIndex = 0;
            this.Standard_button.TabStop = true;
            this.Standard_button.Text = "Standard Adult";
            this.Standard_button.UseVisualStyleBackColor = true;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(441, 691);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(83, 20);
            this.price_label.TabIndex = 8;
            this.price_label.Text = "Total Price";
            this.price_label.Click += new System.EventHandler(this.price_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 805);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.Clienttype);
            this.Controls.Add(this.ClientVisits);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Hairdresser);
            this.Controls.Add(this.Calculte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Hairdresser.ResumeLayout(false);
            this.Hairdresser.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.ClientVisits.ResumeLayout(false);
            this.ClientVisits.PerformLayout();
            this.Clienttype.ResumeLayout(false);
            this.Clienttype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void price_label_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Calculte;
        private System.Windows.Forms.GroupBox Hairdresser;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.RadioButton Jan_button;
        private System.Windows.Forms.GroupBox ClientVisits;
        private System.Windows.Forms.TextBox visit;
        private System.Windows.Forms.GroupBox Clienttype;
        private System.Windows.Forms.RadioButton Laura_button;
        private System.Windows.Forms.RadioButton Sue_button;
        private System.Windows.Forms.RadioButton Pat_button;
        private System.Windows.Forms.RadioButton Student_button;
        private System.Windows.Forms.RadioButton Child_button;
        private System.Windows.Forms.RadioButton Standard_button;
        private System.Windows.Forms.RadioButton Senior_button;
        private System.Windows.Forms.CheckBox Cut_box;
        private System.Windows.Forms.CheckBox Color_box;
        private System.Windows.Forms.CheckBox Highlight_box;
        private System.Windows.Forms.CheckBox Extension_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Ron_button;
        private System.Windows.Forms.Label price_label;
    }
}

