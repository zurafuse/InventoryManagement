﻿namespace InventoryManagement
{
    partial class AddPart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPart));
            this.title_label = new System.Windows.Forms.Label();
            this.inHouse_radio = new System.Windows.Forms.RadioButton();
            this.outsourced_radio = new System.Windows.Forms.RadioButton();
            this.name_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.inv_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.com_machID_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.inv_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.max_textBox = new System.Windows.Forms.TextBox();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.comName_machID_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title_label.Location = new System.Drawing.Point(37, 35);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(79, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Add Part";
            // 
            // inHouse_radio
            // 
            this.inHouse_radio.AutoSize = true;
            this.inHouse_radio.Location = new System.Drawing.Point(186, 38);
            this.inHouse_radio.Name = "inHouse_radio";
            this.inHouse_radio.Size = new System.Drawing.Size(68, 17);
            this.inHouse_radio.TabIndex = 2;
            this.inHouse_radio.Text = "In-House";
            this.inHouse_radio.UseVisualStyleBackColor = true;
            // 
            // outsourced_radio
            // 
            this.outsourced_radio.AutoSize = true;
            this.outsourced_radio.Checked = true;
            this.outsourced_radio.Location = new System.Drawing.Point(345, 38);
            this.outsourced_radio.Name = "outsourced_radio";
            this.outsourced_radio.Size = new System.Drawing.Size(80, 17);
            this.outsourced_radio.TabIndex = 3;
            this.outsourced_radio.TabStop = true;
            this.outsourced_radio.Text = "Outsourced";
            this.outsourced_radio.UseVisualStyleBackColor = true;
            this.outsourced_radio.CheckedChanged += new System.EventHandler(this.outsourcedRadio_CheckedChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(81, 137);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(81, 315);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(27, 13);
            this.max_label.TabIndex = 5;
            this.max_label.Text = "Max";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(81, 254);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(57, 13);
            this.price_label.TabIndex = 6;
            this.price_label.Text = "Price/Cost";
            // 
            // inv_label
            // 
            this.inv_label.AutoSize = true;
            this.inv_label.Location = new System.Drawing.Point(81, 193);
            this.inv_label.Name = "inv_label";
            this.inv_label.Size = new System.Drawing.Size(51, 13);
            this.inv_label.TabIndex = 7;
            this.inv_label.Text = "Inventory";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(401, 315);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(24, 13);
            this.min_label.TabIndex = 8;
            this.min_label.Text = "Min";
            // 
            // com_machID_label
            // 
            this.com_machID_label.AutoSize = true;
            this.com_machID_label.Location = new System.Drawing.Point(81, 375);
            this.com_machID_label.Name = "com_machID_label";
            this.com_machID_label.Size = new System.Drawing.Size(82, 13);
            this.com_machID_label.TabIndex = 9;
            this.com_machID_label.Text = "Company Name";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(81, 80);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 10;
            this.ID_label.Text = "ID";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Enabled = false;
            this.ID_textBox.Location = new System.Drawing.Point(186, 77);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(128, 20);
            this.ID_textBox.TabIndex = 11;
            this.ID_textBox.Text = "(Auto-Generated)";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(186, 134);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(128, 20);
            this.name_textBox.TabIndex = 12;
            // 
            // inv_textBox
            // 
            this.inv_textBox.Location = new System.Drawing.Point(186, 190);
            this.inv_textBox.Name = "inv_textBox";
            this.inv_textBox.Size = new System.Drawing.Size(128, 20);
            this.inv_textBox.TabIndex = 13;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(186, 251);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(128, 20);
            this.price_textBox.TabIndex = 14;
            // 
            // max_textBox
            // 
            this.max_textBox.Location = new System.Drawing.Point(186, 312);
            this.max_textBox.Name = "max_textBox";
            this.max_textBox.Size = new System.Drawing.Size(146, 20);
            this.max_textBox.TabIndex = 15;
            this.max_textBox.TextChanged += new System.EventHandler(this.max_textBox_TextChanged);
            // 
            // min_textBox
            // 
            this.min_textBox.Location = new System.Drawing.Point(450, 312);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(128, 20);
            this.min_textBox.TabIndex = 16;
            this.min_textBox.TextChanged += new System.EventHandler(this.min_textBox_TextChanged);
            // 
            // comName_machID_textBox
            // 
            this.comName_machID_textBox.Location = new System.Drawing.Point(186, 372);
            this.comName_machID_textBox.Name = "comName_machID_textBox";
            this.comName_machID_textBox.Size = new System.Drawing.Size(223, 20);
            this.comName_machID_textBox.TabIndex = 17;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(334, 426);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 18;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(503, 426);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 491);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.comName_machID_textBox);
            this.Controls.Add(this.min_textBox);
            this.Controls.Add(this.max_textBox);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.inv_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.com_machID_label);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.inv_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.outsourced_radio);
            this.Controls.Add(this.inHouse_radio);
            this.Controls.Add(this.title_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.RadioButton inHouse_radio;
        private System.Windows.Forms.RadioButton outsourced_radio;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label inv_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label com_machID_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox inv_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox max_textBox;
        private System.Windows.Forms.TextBox min_textBox;
        private System.Windows.Forms.TextBox comName_machID_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}