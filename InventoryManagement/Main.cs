using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Main : Form
    {
        Inventory inventory = new Inventory();

        public Main()
        {
            InitializeComponent();
            inventory.initializeInventory();
            displayGrids();
        }

        public void displayGrids() {
            products_gridView.Rows.Clear();
            parts_gridView.Rows.Clear();

            //populate each Part row with parts.
            for (int i = 0; i < inventory.allParts.Count; i++)
            {
                Part part = (Part)inventory.allParts[i];
                parts_gridView.Rows.Add(part.getPartID(), part.getName(), part.getInStock(), $"{part.getPrice():C}");
            }
            //populate each Product row with products.
            for (int i = 0; i < inventory.Products.Count; i++)
            {
                Product product = (Product)inventory.Products[i];
                products_gridView.Rows.Add(product.getProductID(), product.getName(), product.getInStock(), $"{product.getPrice():C}");
            }
        }

        public void displayOnClose(object sender, FormClosedEventArgs e) {
            displayGrids();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to end this program?", "Confirm Program's End",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes) { 
                this.Close();
            }
        }

        private void partsAdd_button_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(ref inventory);
            addPartForm.FormClosed += new FormClosedEventHandler(displayOnClose);
            addPartForm.Show();
        }

        private void partsModify_button_Click(object sender, EventArgs e)
        {
            string partID = parts_gridView.SelectedRows[0].Cells[0].Value.ToString();
            Part thisPart = inventory.lookupPart(Int32.Parse(partID));
            ModifyPart modifyPartForm = new ModifyPart(ref thisPart, ref inventory);
            modifyPartForm.FormClosed += new FormClosedEventHandler(displayOnClose);
            modifyPartForm.Show();
        }

        private void productsAdd_button_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(ref inventory);
            addProductForm.FormClosed += new FormClosedEventHandler(displayOnClose);
            addProductForm.Show();
        }

        private void productsModify_button_Click(object sender, EventArgs e)
        {
            string prodID = products_gridView.SelectedRows[0].Cells[0].Value.ToString();
            ModifyProduct modifyProductForm = new ModifyProduct(inventory.lookupProduct(Int32.Parse(prodID)), ref inventory);
            modifyProductForm.FormClosed += new FormClosedEventHandler(displayOnClose);
            modifyProductForm.Show();
        }

        private void partsDelete_button_Click(object sender, EventArgs e)
        {
            if (inventory.allParts.Count > 0) { 
                int partID = Int32.Parse(parts_gridView.SelectedRows[0].Cells[0].Value.ToString());
                Part removedPart = inventory.lookupPart(partID);
                if (removedPart != null) {
                    var confirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Part Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        inventory.deletePart(ref removedPart);
                    }
                }
            }
            displayGrids();
        }

        private void productsDelete_button_Click(object sender, EventArgs e)
        {
            if (inventory.Products.Count > 0) { 
                int prodID = Int32.Parse(products_gridView.SelectedRows[0].Cells[0].Value.ToString());
                var confirmation = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Product Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    inventory.removeProduct(prodID);
                }
            }
            displayGrids();
        }

        private void partSearch_button_Click(object sender, EventArgs e)
        {
            if (partSearch_box.Text == " " || partSearch_box.Text == "") {
                displayGrids();
            }
            else
            {
                try
                {
                    int partID = Int32.Parse(partSearch_box.Text);
                    Part desiredPart = inventory.lookupPart(partID);
                    parts_gridView.Rows.Clear();
                    parts_gridView.Rows.Add(desiredPart.getPartID(), desiredPart.getName(), desiredPart.getInStock(), $"{desiredPart.getPrice():C}");
                }
                catch (FormatException error)
                {
                    MessageBox.Show("The Part Number value entered must be a valid number.\n" + error.Message);
                }
                catch (NullReferenceException error) {
                    MessageBox.Show("The part number that you searched for is not in Inventory.\n" + error.Message);
                }
            }
        }

        private void productSearch_button_Click(object sender, EventArgs e)
        {
            if (productSearch_box.Text == " " || productSearch_box.Text == "")
            {
                displayGrids();
            }
            else
            {
                try
                {
                    int prodID = Int32.Parse(productSearch_box.Text);
                    Product desiredProduct = inventory.lookupProduct(prodID);
                    products_gridView.Rows.Clear();
                    products_gridView.Rows.Add(desiredProduct.getProductID(), desiredProduct.getName(), desiredProduct.getInStock(), $"{desiredProduct.getPrice():C}");
                }
                catch (FormatException error)
                {
                    MessageBox.Show("The Product Number value entered must be a valid number.\n" + error.Message);
                }
                catch (NullReferenceException error) {
                    MessageBox.Show("The Product number that you searched for is not in Inventory.\n" + error.Message);
                }
            }
        }
    }
}
