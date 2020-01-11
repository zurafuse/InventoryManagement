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
    public partial class AddProduct : Form
    {
        private Product product;
        private Inventory inventory;

        public AddProduct(ref Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            product = new Product(newProdID(), "", 0, 0, 0, 0);
            displayGrids();
        }

        private void displayGrids()
        {
            addParts_gridView.Rows.Clear();
            deletePart_gridView.Rows.Clear();

            //populate each Part row with parts.
            for (int i = 0; i < inventory.allParts.Count; i++)
            {
                Part part = (Part)inventory.allParts[i];
                addParts_gridView.Rows.Add(part.getPartID(), part.getName(), part.getInStock(), $"{part.getPrice():C}");
            }
            //populate the associated parts in the bottom grid view
            for (int i = 0; i < product.associatedParts.Count; i++)
            {
                Part part = (Part)product.associatedParts[i];
                deletePart_gridView.Rows.Add(part.getPartID(), part.getName(), part.getInStock(), $"{part.getPrice():C}");
            }
        }

        //AutoGenerate new ID, ensuring that it is not a duplicate.
        private int newProdID() {
            bool isDuplicate = false;
            int newID = inventory.Products.Count;
            do
            {
                isDuplicate = false;
                for (int i = 0; i < inventory.Products.Count; i++)
                {
                    if (i == newID) {
                        isDuplicate = true;
                    }
                }
                newID++;
            } while (isDuplicate == true);
            return newID;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                product.setName(name_textBox.Text);
                product.setInStock(Int32.Parse(inv_textBox.Text));
                product.setPrice(Convert.ToDouble(price_textBox.Text));
                product.setMax(Int32.Parse(max_textBox.Text));
                product.setMin(Int32.Parse(min_textBox.Text));
                inventory.addProduct(product);
                MessageBox.Show("Product has been added to inventory.");

                this.Close();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Be sure that all fields were keyed in the correct format.\n" + error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show("We were not able to save this entry. Below is the error:\n" + error.Message);
            }
        }

        private void cancel_button_Click_1(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void partsAdd_button_Click(object sender, EventArgs e)
        {
            int partID = Int32.Parse(addParts_gridView.SelectedRows[0].Cells[0].Value.ToString());
            product.addAssociatedPart(inventory.lookupPart(partID));
            displayGrids();
        }

        private void partsDelete_button_Click(object sender, EventArgs e)
        {
            int partID = Int32.Parse(deletePart_gridView.SelectedRows[0].Cells[0].Value.ToString());
            var confirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Part Deletion",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                product.removeAssociatedPart(partID);
            }
            displayGrids();
        }

        private void partSearch_button_Click(object sender, EventArgs e)
        {
            if (partSearch_box.Text.ToString() == " " || partSearch_box.Text.ToString() == "")
            {
                displayGrids();
            }
            else {
                addParts_gridView.Rows.Clear();
                deletePart_gridView.Rows.Clear();
                int partID = Int32.Parse(partSearch_box.Text.ToString());
                Part part = inventory.lookupPart(partID);
                if (part != null) {
                    addParts_gridView.Rows.Add(part.getPartID(), part.getName(), part.getInStock(), $"{part.getPrice():C}");
                }
                Part associatedPart = product.lookupAssociatedPart(partID);
                if (associatedPart != null) {
                    deletePart_gridView.Rows.Add(associatedPart.getPartID(), associatedPart.getName(), associatedPart.getInStock(), $"{associatedPart.getPrice():C}");
                }
            }
        }

        private void max_textBox_TextChanged(object sender, EventArgs e)
        {
            if (max_textBox.Text == "")
            {
                max_textBox.Text = "0";
            }
            int num = 0;
            string testNum = max_textBox.Text;
            bool isNumber = int.TryParse(testNum, out num);
            if (isNumber == false)
            {
                MessageBox.Show("The Max value must be numberic.");
                max_textBox.Undo();
            }
        }

        private void min_textBox_TextChanged(object sender, EventArgs e)
        {
            if (min_textBox.Text == "")
            {
                min_textBox.Text = "0";
            }
            int num = 0;
            string testNum = min_textBox.Text;
            bool isNumber = int.TryParse(testNum, out num);
            if (isNumber == false)
            {
                MessageBox.Show("The Min value must be numberic.");
                min_textBox.Undo();
            }
        }
    }
}
