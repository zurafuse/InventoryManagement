namespace InventoryManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.title_label = new System.Windows.Forms.Label();
            this.parts_title = new System.Windows.Forms.Label();
            this.partSearch_button = new System.Windows.Forms.Button();
            this.partSearch_box = new System.Windows.Forms.TextBox();
            this.partsAdd_button = new System.Windows.Forms.Button();
            this.partsModify_button = new System.Windows.Forms.Button();
            this.partsDelete_button = new System.Windows.Forms.Button();
            this.productsDelete_button = new System.Windows.Forms.Button();
            this.productsModify_button = new System.Windows.Forms.Button();
            this.productsAdd_button = new System.Windows.Forms.Button();
            this.productSearch_box = new System.Windows.Forms.TextBox();
            this.productSearch_button = new System.Windows.Forms.Button();
            this.products_label = new System.Windows.Forms.Label();
            this.parts_gridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products_gridView = new System.Windows.Forms.DataGridView();
            this.exit_button = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.parts_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title_label.Location = new System.Drawing.Point(34, 30);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(256, 20);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Inventory Management System";
            // 
            // parts_title
            // 
            this.parts_title.AutoSize = true;
            this.parts_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parts_title.Location = new System.Drawing.Point(24, 98);
            this.parts_title.Name = "parts_title";
            this.parts_title.Size = new System.Drawing.Size(48, 18);
            this.parts_title.TabIndex = 2;
            this.parts_title.Text = "Parts";
            // 
            // partSearch_button
            // 
            this.partSearch_button.Location = new System.Drawing.Point(102, 96);
            this.partSearch_button.Name = "partSearch_button";
            this.partSearch_button.Size = new System.Drawing.Size(75, 23);
            this.partSearch_button.TabIndex = 3;
            this.partSearch_button.Text = "Search";
            this.partSearch_button.UseVisualStyleBackColor = true;
            this.partSearch_button.Click += new System.EventHandler(this.partSearch_button_Click);
            // 
            // partSearch_box
            // 
            this.partSearch_box.Location = new System.Drawing.Point(192, 99);
            this.partSearch_box.Name = "partSearch_box";
            this.partSearch_box.Size = new System.Drawing.Size(278, 20);
            this.partSearch_box.TabIndex = 4;
            // 
            // partsAdd_button
            // 
            this.partsAdd_button.Location = new System.Drawing.Point(136, 253);
            this.partsAdd_button.Name = "partsAdd_button";
            this.partsAdd_button.Size = new System.Drawing.Size(75, 23);
            this.partsAdd_button.TabIndex = 5;
            this.partsAdd_button.Text = "Add";
            this.partsAdd_button.UseMnemonic = false;
            this.partsAdd_button.UseVisualStyleBackColor = true;
            this.partsAdd_button.Click += new System.EventHandler(this.partsAdd_button_Click);
            // 
            // partsModify_button
            // 
            this.partsModify_button.Location = new System.Drawing.Point(231, 253);
            this.partsModify_button.Name = "partsModify_button";
            this.partsModify_button.Size = new System.Drawing.Size(75, 23);
            this.partsModify_button.TabIndex = 6;
            this.partsModify_button.Text = "Modify";
            this.partsModify_button.UseVisualStyleBackColor = true;
            this.partsModify_button.Click += new System.EventHandler(this.partsModify_button_Click);
            // 
            // partsDelete_button
            // 
            this.partsDelete_button.Location = new System.Drawing.Point(325, 253);
            this.partsDelete_button.Name = "partsDelete_button";
            this.partsDelete_button.Size = new System.Drawing.Size(75, 23);
            this.partsDelete_button.TabIndex = 7;
            this.partsDelete_button.Text = "Delete";
            this.partsDelete_button.UseVisualStyleBackColor = true;
            this.partsDelete_button.Click += new System.EventHandler(this.partsDelete_button_Click);
            // 
            // productsDelete_button
            // 
            this.productsDelete_button.Location = new System.Drawing.Point(754, 251);
            this.productsDelete_button.Name = "productsDelete_button";
            this.productsDelete_button.Size = new System.Drawing.Size(75, 23);
            this.productsDelete_button.TabIndex = 14;
            this.productsDelete_button.Text = "Delete";
            this.productsDelete_button.UseVisualStyleBackColor = true;
            this.productsDelete_button.Click += new System.EventHandler(this.productsDelete_button_Click);
            // 
            // productsModify_button
            // 
            this.productsModify_button.Location = new System.Drawing.Point(659, 251);
            this.productsModify_button.Name = "productsModify_button";
            this.productsModify_button.Size = new System.Drawing.Size(75, 23);
            this.productsModify_button.TabIndex = 13;
            this.productsModify_button.Text = "Modify";
            this.productsModify_button.UseVisualStyleBackColor = true;
            this.productsModify_button.Click += new System.EventHandler(this.productsModify_button_Click);
            // 
            // productsAdd_button
            // 
            this.productsAdd_button.Location = new System.Drawing.Point(564, 251);
            this.productsAdd_button.Name = "productsAdd_button";
            this.productsAdd_button.Size = new System.Drawing.Size(75, 23);
            this.productsAdd_button.TabIndex = 12;
            this.productsAdd_button.Text = "Add";
            this.productsAdd_button.UseMnemonic = false;
            this.productsAdd_button.UseVisualStyleBackColor = true;
            this.productsAdd_button.Click += new System.EventHandler(this.productsAdd_button_Click);
            // 
            // productSearch_box
            // 
            this.productSearch_box.Location = new System.Drawing.Point(673, 98);
            this.productSearch_box.Name = "productSearch_box";
            this.productSearch_box.Size = new System.Drawing.Size(278, 20);
            this.productSearch_box.TabIndex = 11;
            // 
            // productSearch_button
            // 
            this.productSearch_button.Location = new System.Drawing.Point(582, 96);
            this.productSearch_button.Name = "productSearch_button";
            this.productSearch_button.Size = new System.Drawing.Size(75, 23);
            this.productSearch_button.TabIndex = 10;
            this.productSearch_button.Text = "Search";
            this.productSearch_button.UseVisualStyleBackColor = true;
            this.productSearch_button.Click += new System.EventHandler(this.productSearch_button_Click);
            // 
            // products_label
            // 
            this.products_label.AutoSize = true;
            this.products_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_label.Location = new System.Drawing.Point(500, 96);
            this.products_label.Name = "products_label";
            this.products_label.Size = new System.Drawing.Size(76, 18);
            this.products_label.TabIndex = 9;
            this.products_label.Text = "Products";
            // 
            // parts_gridView
            // 
            this.parts_gridView.AllowUserToAddRows = false;
            this.parts_gridView.AllowUserToDeleteRows = false;
            this.parts_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.parts_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parts_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.inventoryLevel,
            this.costPerUnit});
            this.parts_gridView.Location = new System.Drawing.Point(22, 125);
            this.parts_gridView.MultiSelect = false;
            this.parts_gridView.Name = "parts_gridView";
            this.parts_gridView.ReadOnly = true;
            this.parts_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parts_gridView.Size = new System.Drawing.Size(448, 122);
            this.parts_gridView.TabIndex = 15;
            // 
            // partID
            // 
            this.partID.DataPropertyName = "getPartID";
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "getName";
            this.partName.HeaderText = "Part Name";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // inventoryLevel
            // 
            this.inventoryLevel.DataPropertyName = "getInStock";
            this.inventoryLevel.HeaderText = "InventoryLevel";
            this.inventoryLevel.Name = "inventoryLevel";
            this.inventoryLevel.ReadOnly = true;
            // 
            // costPerUnit
            // 
            this.costPerUnit.DataPropertyName = "getPrice";
            this.costPerUnit.HeaderText = "Cost/Price per Unit";
            this.costPerUnit.Name = "costPerUnit";
            this.costPerUnit.ReadOnly = true;
            // 
            // products_gridView
            // 
            this.products_gridView.AllowUserToAddRows = false;
            this.products_gridView.AllowUserToDeleteRows = false;
            this.products_gridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.products_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.products_gridView.Location = new System.Drawing.Point(503, 125);
            this.products_gridView.MultiSelect = false;
            this.products_gridView.Name = "products_gridView";
            this.products_gridView.ReadOnly = true;
            this.products_gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.products_gridView.Size = new System.Drawing.Size(448, 122);
            this.products_gridView.TabIndex = 16;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(805, 311);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(90, 32);
            this.exit_button.TabIndex = 17;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 358);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.products_gridView);
            this.Controls.Add(this.parts_gridView);
            this.Controls.Add(this.productsDelete_button);
            this.Controls.Add(this.productsModify_button);
            this.Controls.Add(this.productsAdd_button);
            this.Controls.Add(this.productSearch_box);
            this.Controls.Add(this.productSearch_button);
            this.Controls.Add(this.products_label);
            this.Controls.Add(this.partsDelete_button);
            this.Controls.Add(this.partsModify_button);
            this.Controls.Add(this.partsAdd_button);
            this.Controls.Add(this.partSearch_box);
            this.Controls.Add(this.partSearch_button);
            this.Controls.Add(this.parts_title);
            this.Controls.Add(this.title_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.parts_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label parts_title;
        private System.Windows.Forms.Button partSearch_button;
        private System.Windows.Forms.TextBox partSearch_box;
        private System.Windows.Forms.Button partsAdd_button;
        private System.Windows.Forms.Button partsModify_button;
        private System.Windows.Forms.Button partsDelete_button;
        private System.Windows.Forms.Button productsDelete_button;
        private System.Windows.Forms.Button productsModify_button;
        private System.Windows.Forms.Button productsAdd_button;
        private System.Windows.Forms.TextBox productSearch_box;
        private System.Windows.Forms.Button productSearch_button;
        private System.Windows.Forms.Label products_label;
        private System.Windows.Forms.DataGridView products_gridView;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridView parts_gridView;
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

