using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {
        public ArrayList associatedParts = new ArrayList();
        private int productID;
        private String name;
        private double price;
        private int inStock;
        private int min;
        private int max;

        public Product(int prodID, String name, double price, int inventory, int min, int max) {
            productID = prodID;
            this.name = name;
            this.price = price;
            inStock = inventory;
            this.min = min;
            this.max = max;
        }

        public void setName(String name){
            this.name = name;
        }
        public String getName() {
            return name;
        }
        public void setPrice(double price) {
            this.price = price;
        }
        public double getPrice() {
            return price;
        }
        public void setInStock(int inStock) {
            this.inStock = inStock;
        }
        public int getInStock() {
            return inStock;
        }
        public void setMin(int min) {
            this.min = min;
        }
        public int getMin() {
            return min;
        }
        public void setMax(int max) {
            this.max = max;
        }
        public int getMax() {
            return max;
        }
        public void addAssociatedPart(Part newPart) {
            associatedParts.Add(newPart);
        }
        public Boolean removeAssociatedPart(int partID) {
            if (getIndex(partID) != -1)
            {
                associatedParts.RemoveAt(getIndex(partID));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part lookupAssociatedPart(int partID) {
            Part desiredPart = null;
            for (int i = 0; i < associatedParts.Count; i++) {
                Part thisPart = (Part)associatedParts[i];
                if (thisPart.getPartID() == partID)
                {
                    desiredPart = thisPart;
                }
            }
            return desiredPart;
        }

        public int getIndex(int partID)
        {
            int index = -1;
            for (int i = 0; i < associatedParts.Count; i++)
            {
                Part thisPart = (Part)associatedParts[i];
                if (thisPart.getPartID() == partID) {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void setProductID(int productID) {
            this.productID = productID;
        }
        public int getProductID() {
            return productID;
        }


    }
}
