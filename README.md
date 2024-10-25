# Shopping Cart Application

## Overview
The Shopping Cart Application is a desktop application built using C# and Windows Forms that allows users to manage a shopping cart. Users can add items, view their cart, and proceed to checkout using various payment methods.

## Features
- Add products to the cart.
- View cart items.
- Remove products from the cart.
- Checkout process with payment method selection (Credit Card or Cash on Delivery).
- User input validation for customer details and payment information.

## Requirements
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- SQLite Database

## Packages Used
- **SQLite**: For database management to store product and cart information.
- **System.Windows.Forms**: For creating the GUI.

## Installation

1. **Clone the Repository**: 
   ```bash
   git clone https://github.com/EmanQazii/ShoppingCartAppProject.git

2. Open the Project:

- Launch Visual Studio.
- Go to `File` -> `Open` -> `Project/Solution`.
- Navigate to the cloned repository folder and open the `.sln` file.

3. Install Required Packages:

Ensure you have the SQLite package installed. You can do this by:

- Opening the Package Manager Console in Visual Studio (`Tools` -> `NuGet Package Manager` -> `Package Manager Console`).
- Running the following command:

   ```bash
   Install-Package System.Data.SQLite

4. Configure Database:

- Ensure the SQLite database file is in the project folder or correctly set up in your code.
- If necessary, update the connection string in your application to point to the correct database file.

## Running the Project

1. Build the Project:

- In Visual Studio, select `Build` -> `Build Solution`.

2. Run the Application:

- Press `F5` or click on the Start button to run the application.
- Follow the prompts to add products, view the cart, and complete the checkout process.
