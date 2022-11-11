
namespace Lab3B
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
            this.add_service_button = new System.Windows.Forms.Button();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.total_price_textbox = new System.Windows.Forms.TextBox();
            this.charged_listbox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.services_listbox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.price_listbox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hair_dresser_combobox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_service_button
            // 
            this.add_service_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_service_button.Location = new System.Drawing.Point(117, 666);
            this.add_service_button.Name = "add_service_button";
            this.add_service_button.Size = new System.Drawing.Size(265, 60);
            this.add_service_button.TabIndex = 7;
            this.add_service_button.Text = "Add Service";
            this.add_service_button.UseVisualStyleBackColor = true;
            this.add_service_button.Click += new System.EventHandler(this.add_service_button_Click);
            // 
            // Calculate_button
            // 
            this.Calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_button.Location = new System.Drawing.Point(388, 666);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(368, 60);
            this.Calculate_button.TabIndex = 8;
            this.Calculate_button.Text = "Calculate Total Price";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(762, 666);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(273, 60);
            this.reset_button.TabIndex = 9;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(1041, 666);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(250, 60);
            this.Exit_button.TabIndex = 10;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 615);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Price : ";
            // 
            // total_price_textbox
            // 
            this.total_price_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price_textbox.Location = new System.Drawing.Point(1067, 612);
            this.total_price_textbox.Name = "total_price_textbox";
            this.total_price_textbox.Size = new System.Drawing.Size(164, 39);
            this.total_price_textbox.TabIndex = 13;
            // 
            // charged_listbox
            // 
            this.charged_listbox.FormattingEnabled = true;
            this.charged_listbox.ItemHeight = 32;
            this.charged_listbox.Location = new System.Drawing.Point(6, 45);
            this.charged_listbox.Name = "charged_listbox";
            this.charged_listbox.Size = new System.Drawing.Size(357, 484);
            this.charged_listbox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.charged_listbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(683, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 566);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charged Items";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.services_listbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(335, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 566);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // services_listbox
            // 
            this.services_listbox.FormattingEnabled = true;
            this.services_listbox.ItemHeight = 32;
            this.services_listbox.Location = new System.Drawing.Point(6, 44);
            this.services_listbox.Name = "services_listbox";
            this.services_listbox.Size = new System.Drawing.Size(330, 484);
            this.services_listbox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.price_listbox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1067, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 566);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price";
            // 
            // price_listbox
            // 
            this.price_listbox.FormattingEnabled = true;
            this.price_listbox.ItemHeight = 32;
            this.price_listbox.Location = new System.Drawing.Point(6, 44);
            this.price_listbox.Name = "price_listbox";
            this.price_listbox.Size = new System.Drawing.Size(233, 516);
            this.price_listbox.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hair_dresser_combobox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 566);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select a Hair-Dresser :";
            // 
            // hair_dresser_combobox
            // 
            this.hair_dresser_combobox.FormattingEnabled = true;
            this.hair_dresser_combobox.Location = new System.Drawing.Point(6, 45);
            this.hair_dresser_combobox.Name = "hair_dresser_combobox";
            this.hair_dresser_combobox.Size = new System.Drawing.Size(305, 40);
            this.hair_dresser_combobox.TabIndex = 0;
            this.hair_dresser_combobox.SelectedIndexChanged += new System.EventHandler(this.hair_dresser_combobox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 738);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.total_price_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.add_service_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_service_button;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox total_price_textbox;
        private System.Windows.Forms.ListBox charged_listbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox services_listbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox price_listbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox hair_dresser_combobox;
    }
}

