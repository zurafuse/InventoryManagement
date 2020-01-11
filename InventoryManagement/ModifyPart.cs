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
    public partial class ModifyPart : Form
    {
        private Part part;
        private Inventory inventory;
        private int index;

        public ModifyPart(ref Part part, ref Inventory inventory)
        {
            InitializeComponent();
            this.part = part;
            this.inventory = inventory;
            index = getIndex(part.getPartID());
            initializeFields();
        }

        private void initializeFields()
        {
            ID_textBox.Text = part.getPartID().ToString();
            name_textBox.Text = part.getName().ToString();
            inv_textBox.Text = part.getInStock().ToString();
            price_textBox.Text = part.getPrice().ToString();
            max_textBox.Text = part.getMax().ToString();
            min_textBox.Text = part.getMin().ToString();
            if (part.GetType().ToString() == "InventoryManagement.Outsourced")
            {
                outsourced_radio.Checked = true;
                Outsourced newPart = (Outsourced)part;
                comName_machID_textBox.Text = newPart.getCompanyName();
            }
            else
            {
                inHouse_radio.Checked = true;
                Inhouse newPart = (Inhouse)part;
                comName_machID_textBox.Text = newPart.getMachineID().ToString();
            }
        }

        private int getIndex(int partID) {
            int index = -1;
            for (int i = 0; i < inventory.allParts.Count; i++) {
                Part thisPart = (Part)inventory.allParts[i];
                if (thisPart.getPartID() == partID) {
                    index = i;
                    break;
                }
            }
            return index;
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

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                part.setName(name_textBox.Text);
                part.setInStock(Int32.Parse(inv_textBox.Text));
                part.setPrice(Convert.ToDouble(price_textBox.Text));
                part.setMax(Int32.Parse(max_textBox.Text));
                part.setMin(Int32.Parse(min_textBox.Text));
                if (outsourced_radio.Checked == true)
                {
                    if (part.GetType().ToString() == "InventoryManagement.Inhouse")
                    {
                        part = new Outsourced(part.getPartID(), part.getName(), part.getPrice(),
                            part.getInStock(), part.getMin(), part.getMax(), comName_machID_textBox.Text);
                        inventory.deletePart(ref part);
                        inventory.addPart(part);
                    }
                    Outsourced outsourced = (Outsourced)part;
                    outsourced.setCompanyName(comName_machID_textBox.Text);
                }
                else
                {
                    if (part.GetType().ToString() == "InventoryManagement.Outsourced")
                    {
                        part = new Inhouse(part.getPartID(), part.getName(), part.getPrice(),
                            part.getInStock(), part.getMin(), part.getMax(), Int32.Parse(comName_machID_textBox.Text));
                        inventory.deletePart(ref part);
                        inventory.addPart(part);
                    }
                    Inhouse inhouse = (Inhouse)part;
                    inhouse.setMachineID(Int32.Parse(comName_machID_textBox.Text));
                }
                inventory.updatePart(part.getPartID(), ref part);
                MessageBox.Show("Part has been updated.");

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

        private void cancel_button_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void max_textBox_TextChanged(object sender, EventArgs e)
        {
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
