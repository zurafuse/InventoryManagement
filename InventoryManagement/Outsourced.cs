using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Outsourced : Part
    {
        private String companyName;
        public Outsourced(int partID, String name, double price, int inventory, int min, int max, String companyName):base(partID, name, price, inventory, min, max)
        {
            this.companyName = companyName;
        }

        public void setCompanyName(String companyName) {
            this.companyName = companyName;
        }
        public String getCompanyName() {
            return companyName;
        }

    }
}
