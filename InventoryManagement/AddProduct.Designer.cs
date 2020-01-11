namespace InventoryManagement
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.max_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.inv_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.inv_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.addParts_gridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsDelete_button = new System.Windows.Forms.Button();
            this.partsAdd_button = new System.Windows.Forms.Button();
            this.partSearch_box = new System.Windows.Forms.TextBox();
            this.partSearch_button = new System.Windows.Forms.Button();
            this.deletePart_gridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addParts_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePart_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(758, 383);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 38;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click_1);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(627, 383);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 37;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // min_textBox
            // 
            this.min_textBox.Location = new System.Drawing.Point(136, 252);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(128, 20);
            this.min_textBox.TabIndex = 35;
            this.min_textBox.TextChanged += new System.EventHandler(this.min_textBox_TextChanged);
            // 
            // max_textBox
            // 
            this.max_textBox.Location = new System.Drawing.Point(136, 210);
            this.max_textBox.Name = "max_textBox";
            this.max_textBox.Size = new System.Drawing.Size(128, 20);
            this.max_textBox.TabIndex = 34;
            this.max_textBox.TextChanged += new System.EventHandler(this.max_textBox_TextChanged);
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(136, 168);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(128, 20);
            this.price_textBox.TabIndex = 33;
            // 
            // inv_textBox
            // 
            this.inv_textBox.Location = new System.Drawing.Point(136, 131);
            this.inv_textBox.Name = "inv_textBox";
            this.inv_textBox.Size = new System.Drawing.Size(128, 20);
            this.inv_textBox.TabIndex = 32;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(136, 95);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(128, 20);
            this.name_textBox.TabIndex = 31;
            // 
            // ID_textBox
            // 
            this.ID_textBox.Enabled = false;
            this.ID_textBox.Location = new System.Drawing.Point(136, 58);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(128, 20);
            this.ID_textBox.TabIndex = 30;
            this.ID_textBox.Text = "(Auto-Generated)";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(31, 61);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(18, 13);
            this.ID_label.TabIndex = 29;
            this.ID_label.Text = "ID";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Location = new System.Drawing.Point(31, 255);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(24, 13);
            this.min_label.TabIndex = 27;
            this.min_label.Text = "Min";
            // 
            // inv_label
            // 
            this.inv_label.AutoSize = true;
            this.inv_label.Location = new System.Drawing.Point(31, 134);
            this.inv_label.Name = "inv_label";
            this.inv_label.Size = new System.Drawing.Size(51, 13);
            this.inv_label.TabIndex = 26;
            this.inv_label.Text = "Inventory";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(31, 171);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(31, 13);
            this.price_label.TabIndex = 25;
            this.price_label.Text = "Price";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Location = new System.Drawing.Point(31, 213);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(27, 13);
            this.max_label.TabIndex = 24;
            this.max_label.Text = "Max";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(31, 98);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 23;
            this.name_label.Text = "Name";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title_label.Location = new System.Drawing.Point(28, 23);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(108, 20);
            this.title_label.TabIndex = 20;
            this.title_label.Text = "Add Product";
            // 
            // addParts_gridView
            // 
            this.addParts_gridView.AllowUserToAddRows = false;
            this.addParts_gridView.AllowUserToDeleteRows = false;
            this.addParts_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.addParts_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addParts_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.inventoryLevel,
            this.costPerUnit});
            this.addParts_gridView.Location = new System.Drawing.Point(385, 39);
            this.addParts_gridView.MultiSelect = false;
            this.addParts_gridView.Name = "addParts_gridView";
            this.addParts_gridView.ReadOnly = true;
            this.addParts_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addParts_gridView.Size = new System.Drawing.Size(448, 122);
            this.addParts_gridView.TabIndex = 45;
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // inventoryLevel
            // 
            this.inventoryLevel.HeaderText = "InventoryLevel";
            this.inventoryLevel.Name = "inventoryLevel";
            this.inventoryLevel.ReadOnly = true;
            // 
            // costPerUnit
            // 
            this.costPerUnit.HeaderText = "Price per Unit";
            this.costPerUnit.Name = "costPerUnit";
            this.costPerUnit.ReadOnly = true;
            // 
            // partsDelete_button
            // 
            this.partsDelete_button.Location = new System.Drawing.Point(758, 341);
            this.partsDelete_button.Name = "partsDelete_button";
            this.partsDelete_button.Size = new System.Drawing.Size(75, 23);
            this.partsDelete_button.TabIndex = 44;
            this.partsDelete_button.Text = "Delete";
            this.partsDelete_button.UseVisualStyleBackColor = true;
            this.partsDelete_button.Click += new System.EventHandler(this.partsDelete_button_Click);
            // 
            // partsAdd_button
            // 
            this.partsAdd_button.Location = new System.Drawing.Point(758, 167);
            this.partsAdd_button.Name = "partsAdd_button";
            this.partsAdd_button.Size = new System.Drawing.Size(75, 23);
            this.partsAdd_button.TabIndex = 42;
            this.partsAdd_button.Text = "Add";
            this.partsAdd_button.UseMnemonic = false;
            this.partsAdd_button.UseVisualStyleBackColor = true;
            this.partsAdd_button.Click += new System.EventHandler(this.partsAdd_button_Click);
            // 
            // partSearch_box
            // 
            this.partSearch_box.Location = new System.Drawing.Point(555, 13);
            this.partSearch_box.Name = "partSearch_box";
            this.partSearch_box.Size = new System.Drawing.Size(278, 20);
            this.partSearch_box.TabIndex = 41;
            // 
            // partSearch_button
            // 
            this.partSearch_button.Location = new System.Drawing.Point(465, 10);
            this.partSearch_button.Name = "partSearch_button";
            this.partSearch_button.Size = new System.Drawing.Size(75, 23);
            this.partSearch_button.TabIndex = 40;
            this.partSearch_button.Text = "Search";
            this.partSearch_button.UseVisualStyleBackColor = true;
            this.partSearch_button.Click += new System.EventHandler(this.partSearch_button_Click);
            // 
            // deletePart_gridView
            // 
            this.deletePart_gridView.AllowUserToAddRows = false;
            this.deletePart_gridView.AllowUserToDeleteRows = false;
            this.deletePart_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.deletePart_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletePart_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.deletePart_gridView.Location = new System.Drawing.Point(385, 213);
            this.deletePart_gridView.MultiSelect = false;
            this.deletePart_gridView.Name = "deletePart_gridView";
            this.deletePart_gridView.ReadOnly = true;
            this.deletePart_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletePart_gridView.Size = new System.Drawing.Size(448, 122);
            this.deletePart_gridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "InventoryLevel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 427);
            this.Controls.Add(this.deletePart_gridView);
            this.Controls.Add(this.addParts_gridView);
            this.Controls.Add(this.partsDelete_button);
            this.Controls.Add(this.partsAdd_button);
            this.Controls.Add(this.partSearch_box);
            this.Controls.Add(this.partSearch_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.min_textBox);
            this.Controls.Add(this.max_textBox);
            this.Controls.Add(this.price_textBox);
            this.Controls.Add(this.inv_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.inv_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.title_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addParts_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePart_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox min_textBox;
        private System.Windows.Forms.TextBox max_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.TextBox inv_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label inv_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.DataGridView addParts_gridView;
        private System.Windows.Forms.Button partsDelete_button;
        private System.Windows.Forms.Button partsAdd_button;
        private System.Windows.Forms.TextBox partSearch_box;
        private System.Windows.Forms.Button partSearch_button;
        private System.Windows.Forms.DataGridView deletePart_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}