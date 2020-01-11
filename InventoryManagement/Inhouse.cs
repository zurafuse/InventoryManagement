using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inhouse : Part
    {
        private int machineID;
        public Inhouse(int partID, String name, double price, int inventory, int min, int max, int machineID) : base(partID, name, price, inventory, min, max)
        {
            this.machineID = machineID;
        }

        public void setMachineID(int machineID) {
            this.machineID = machineID;
        }
        public int getMachineID() {
            return machineID;
        }

    }
}
