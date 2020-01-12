# InventoryManagement
Inventory Management System (written in C#)

## How to Get Started
1 Download or clone the project. Extract the zip file and use Visual Studio to open the project file “InventoryManagement.sln”.

2 In Visual Studio, press F5 or the “Start” icon to start the program.

3 Press the “Add” button to add parts or products. Press the “Delete” button to remove a part or product.

4 When adding or modifying part, observe how the label for Company Name or Machine Number changes depending on if the user has selected the “In House” or “Outsourced” radio buttons. This also determines if the “Part” will be an Inhouse or Outsourced object. (Both Inhouse and Outsourced classes inherit from the abstract Part class)

5 To search for a product or part, enter the numeric part ID or product ID in the search box and press the “Search” button.
6 Press the “Modify” button to modify existing parts or products.

### Important: Since the lookup functions defined in the requirements required an integer as an input parameter, you may only search by Product ID. Otherwise, you will get no results.

## Classes and Forms
### Per Instructions, the following classes were created:
1 Part.cs

2 Product.cs

3 Inhouse.cs

4 Outsourced.cs

5 Inventory.cs

6 Program.cs was created by Visual Studio by default to house the Main() function.

### The following forms were created:
1 Main

2 AddPart

3 AddProduct

4 ModifyPart

5 ModifyProduct
