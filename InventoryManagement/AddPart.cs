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
    public partial class AddPart : Form
    {
        private Inventory inventory;

        public AddPart(ref Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourced_radio.Checked == true)
            {
                com_machID_label.Text = "Company Name";
            }
            else
            {
                com_machID_label.Text = "Machine ID";
            }
        }

        private int newPartID()
        {
            bool isDuplicate = false;
            int newID = inventory.allParts.Count - 1;
            do
            {
                newID++;
                isDuplicate = false;
                for (int i = 0; i < inventory.allParts.Count; i++)
                {
                    Part thisPart = (Part)inventory.allParts[i];
                    if (newID == thisPart.getPartID())
                    {
                        isDuplicate = true;
                    }
                }
            } while (isDuplicate == true);
            return newID;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }  
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try {
                if (outsourced_radio.Checked == true) {
                    Outsourced newPart = new Outsourced(newPartID(), name_textBox.Text,
                        Convert.ToDouble(price_textBox.Text), Int32.Parse(inv_textBox.Text),
                        Int32.Parse(min_textBox.Text), Int32.Parse(max_textBox.Text),
                        comName_machID_textBox.Text);
                    inventory.addPart(newPart);
                }
                else {
                    Inhouse newPart = new Inhouse(newPartID(), name_textBox.Text,
                        Convert.ToDouble(price_textBox.Text), Int32.Parse(inv_textBox.Text),
                        Int32.Parse(min_textBox.Text), Int32.Parse(max_textBox.Text),
                        Int32.Parse(comName_machID_textBox.Text));
                    inventory.addPart(newPart);
                }
                MessageBox.Show("Part has been added to inventory.");

                this.Close();
            }
            catch (FormatException error) {
                MessageBox.Show("Be sure that all fields were keyed in the correct format.\n" + error.Message);
            }
            catch (Exception error) {
                MessageBox.Show("We were not able to save this entry. Below is the error:\n" + error.Message);
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
            if (isNumber == false){
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
