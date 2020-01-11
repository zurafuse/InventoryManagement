using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory
    {
        public ArrayList Products = new ArrayList();
        public ArrayList allParts = new ArrayList();

        public void addProduct(Product newProduct) {
            Products.Add(newProduct);
        }
        public Boolean removeProduct(int productID) {
            for (int i = 0; i < Products.Count; i++) {
                Product thisProduct = (Product)Products[i];
                if (thisProduct.getProductID() == productID) {
                    Products.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void initializeInventory() {
            //this initial populating of data is intended to give the user a place to start.
            //add Parts to the Inventory object.
            allParts.Add(new Outsourced(0, "CPU Core i9-9900k", 499.99, 200, 1, 200, "Intel"));
            allParts.Add(new Outsourced(1, "CPU Core i3-8100", 100.00, 400, 10, 400, "Intel"));
            allParts.Add(new Outsourced(2, "Ryzen 7 2700x", 239.99, 300, 10, 300, "AMD"));
            allParts.Add(new Inhouse(3, "Zur CPU 7800", 99.99, 400, 20, 400, 4975));
            allParts.Add(new Inhouse(4, "Zur CPU 4500", 109.99, 500, 10, 500, 3800));
            allParts.Add(new Outsourced(5, "DDR4 Ram", 79.99, 400, 1, 400, "Ripjaws"));
            allParts.Add(new Inhouse(6, "SSD - 1TB", 150.00, 500, 10, 500, 0089));
            //add Products to the Inventory object.
            Products.Add(new Product(0, "Zurafuse Computer 8900", 499.99, 300, 1, 400));
            Products.Add(new Product(1, "Zur Game Console", 299.99, 300, 10, 300));
            Products.Add(new Product(2, "Zur Phone 7800x", 99.99, 200, 1, 300));
            //add parts to the products
            Product computer = (Product)Products[0];
            Product console = (Product)Products[1];
            Product phone = (Product)Products[2];
            computer.addAssociatedPart((Part)allParts[1]);
            computer.addAssociatedPart((Part)allParts[5]);
            computer.addAssociatedPart((Part)allParts[6]);
            console.addAssociatedPart((Part)allParts[3]);
            console.addAssociatedPart((Part)allParts[5]);
            console.addAssociatedPart((Part)allParts[6]);
            phone.addAssociatedPart((Part)allParts[4]);
            phone.addAssociatedPart((Part)allParts[5]);
            phone.addAssociatedPart((Part)allParts[6]);
        }

        public Product lookupProduct(int productID) {
            Product desiredProduct = null;
            for (int i = 0; i < Products.Count; i++)
            {
                Product thisProduct = (Product)Products[i];
                if (productID == thisProduct.getProductID()) {
                    desiredProduct = thisProduct;
                }
            }
            return desiredProduct;
        }
        public void updateProduct(int productID, ref Product modifiedProduct) {
            removeProduct(productID);
            addProduct(modifiedProduct);
        }
        public void addPart(Part newPart) {
            allParts.Add(newPart);
        }
        public Boolean deletePart(ref Part removedPart) {
           for (int i = 0; i < allParts.Count; i++)
            {
                Part thisPart = (Part)allParts[i];
                if (thisPart.getPartID() == removedPart.getPartID())
                {
                    allParts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Part lookupPart(int partID) {
            Part desiredPart = null;
            for (int i = 0; i < allParts.Count; i++) {
                Part thisPart = (Part)allParts[i];
                if (partID == thisPart.getPartID()) {
                    desiredPart = thisPart;
                }
            }
            return desiredPart;
        }
        public void updatePart(int partID, ref Part modifiedPart) {
            deletePart(ref modifiedPart);
            addPart(modifiedPart);
        }

    }
}
