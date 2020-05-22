# _Pierre's Vendor Order Tracker_

#### _Basic web application to store Orders under specific Vendors. 5/22/2020_

### Made by DJ Zevenbergen
## Description

_This C#/.NET Core MVC application allows the user to create vendors, and then create orders to be categorized under those specific vendors. It allows the user to see specific details about any order on click. It uses BDD to guide the design of the UI and TDD to guide the design of the Models logic._


## Setup/Installation Requirements

* Clone repository from GitHub in terminal or console
* ensure that C#/.netcore2.2 is installed on your computer
* in the terminal navigate to the project's root directory
* use "dotnet restore VendorOrderTracker" and "dotnet restore VendorOrderTracker.Tests" if you wish to use the tests
* to start the application use "dotnet build VendorOrderTracker" and "dotnet run VendorOrderTracker"
* if you want to test, locate to the WordCounter.Tests directory and run "dotnet test"


## Specs

1. User is presented with a homepage, and given the option to see go to the Vendors page
  * Input: "Go to vendors page"
  * Output: "/vendors"
2. User can create a new Vendor
  * Input: "create new Vendor"
  * Output: "/vendors/new"
3. User fills out Vendor form and is redirected to now populated Vendors page
  * Input: "Jane's Cafe" "located downtown. usually orders every 3 days" "submit vendor"
  * Output: "/vendors" "Janes's Cafe"
4. User can click on a Vendor to see details incl. all orders by that Vendor and the Vendor's description
  * Input: "Click 'Jane's cafe'"
  * Output: "Jane's Cafe"
            "Located downtown. usually orders every 3 days"
            "Orders:"
            "No Orders Yet"
            "Add Order?"
5. User can click Add Order on a specific Vendor's page
  * Input: "Add Order"
  * Output: "/vendors/{id}/orders/new"
6. User fills out a form and is redirected to the Vendor that they were working on 
  * Input: "Croissants" "Wants these croissants slightly underdone" "40" "$80.00" "5/25/2020"
  * Output: "/vendors/{id}"

## Support

_Open an issue_


## Built With
C#/ASP.NET Core 

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_DJ Zevenbergen_**
