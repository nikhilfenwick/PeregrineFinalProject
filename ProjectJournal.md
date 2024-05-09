# April 2024 Project

The April 2024 Capstone Project for Peregrine.

# 09/05/2024

Testing and going over application today. 

1. Bug Found - Attempting to register an account. 
2. Bug Fixed - All backend foundational work complete, will work on UI now.  

# 08/05/2024

Todays work - 

1. Build the authentication server - Completed
2. Add the authentication to the coupon API project - Completed
3. Add the authentication to the web app UI website project - Completed
4. Add the log in page to the web app UI project - Completed
5. Add the register page to the web app UI project - Completed

# 07/05/2024

Todays work - 

1. public BarberCoupon Put([FromBody] BarberCoupon barberCoupon).  - Complete 
2. public BarberCoupon Put([FromBody] BarberCoupon barberCoupon) - Completed
3. public BarberCoupon Delete(int id) - Completed
4. public BarberCoupon GetByCode(int id) - Completed

Note - I have the backend API MicroService producing data. 
I have the website frontend UI app consuming the backend API. 

# 06/05/2024

Next Goal - 

1. Update BarberCouponAPI to use Dtos just like BarberConnect Web App UI Project. 
2. Make the BarberCouponIndex working (right now I are getting data but JSON decoding is not happening, because of the Dto problem in API)

Already DTO Enabled - 

1. public ResponseDTO GetListofBarberCoupons() - Completed
2. public string APICheck() - Completed
3. public BarberCoupon Post([FromBody] BarberCoupon barberCoupon) - Completed
4. public BarberCoupon Put([FromBody] BarberCoupon barberCoupon) - Completed
5. public BarberCoupon Delete(int id) - Completed
6. public BarberCoupon GetByCode(int id) - Completed
7. Update BarberCouponAPI to use Dtos just like BarberConnect Web App UI Project - This entire step is now completed. 

Note - With the latest code improvement, BarberConnectWebAppUI is showing all the coupons in the index page. 

Next Plan - 

1. public string APICheck() - Completed
2. public BarberCoupon Post([FromBody] BarberCoupon barberCoupon) - Completed
3. public BarberCoupon Put([FromBody] BarberCoupon barberCoupon) - Completed
4. public BarberCoupon Delete(int id) - Completed
5. public BarberCoupon GetByCode(int id) - Completed

Next Plan After Above Complete - 

1. Build the authentication server - 
2. Add the authentication to the coupon API project - 
3. Add the authentication to the web app UI website project - 
4. Add the log in page to the web app UI project - 
5. Add the register page to the web app UI project - 

# 03/05/2024

Next goal - 

1. To build the Website to consume the barber coupon API. 

``` "Kestrel": {
    "Endpoints": {
      "Http": {
        "Url": "http://localhost:7004"
      },
      "Https": {
        "Url": "https://localhost:7005"
      }
    }
  }, 
  ```
These coupon API settings must match. 

``` "ServiceUrls": {
    "CouponAPI": "https://localhost:7005",
    "AuthAPI": "https://localhost:7002"
  }
  ```
  These values should match constantly. These are like door numbers, if they do not match they will not be able to talk to eachother. 
  
1. https://localhost:5401/BarberCoupon/barbercouponindex - Working 

Basic controller and basic UI (MVC) is ready.

Next - Connecting the UI project with the barber coupon API, and putting the data into the M - Model. 

Singleton design pattern, being used in interface which has one single implementation for entire project. 

1. https://localhost:5401/BarberCoupon/BarberCouponDummy - To test. 
2. https://localhost:7005/api/BarberCoupons/GetAllBarberCoupons - Test

Next - 

1. UI Web Project, BarberConnect, is able to talk to the BarberCouponAPI. 
2. Get all barber coupons is working. 
3. BarberConnect already has Dto. Data Transfer Object. 

Next - 

1. Update BarberCouponAPI to use Dtos just like BarberConnect Web App UI Project. 
2. Make the BarberCouponIndex working (right now I am getting data but JSON decoding is not happening, because of the Dto problem in API)

Note -

1. Barber Coupon API is using DTOs. 
2. Web app UI project is able to show all the coupons after consuming the coupon API get all coupons endpoint. 

# 02/05/2024 

Today: Adding CRUD for Barber Coupon. 

``` {
  "barberCouponId": 4,
  "barberCouponCode": "DISCOUNT10PERCENT",
  "discountAmount": 10,
  "minAmount": 5
} ```

 ``` {
  "barberCouponId": 0,
  "barberCouponCode": "string",
  "discountAmount": 0,
  "minAmount": 0
} 
```

CouponAPI CRUD working. 

Next - Need to plan tomorrow. 

# 01/05/2024

Next  - 

BarberServicesCouponAPI - Project Folder.

1. https://github.com/nikhilfenwick/FinalProject - Private Github Repository to share with Trevor at some point. 
2. https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli -  How to install nuget packages to .Net Core
3. https://www.nuget.org/ - This is where I have to come to get nuget packages.

Dotnet Nuget Packages Used - 

1. dotnet add package AutoMapper -  Adding AutoMapper package.
2. dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer - Adding AuthenticationJwtBearer
3. dotnet add package Microsoft.EntityFrameworkCore.Design -  Adding Entity Framework Core
4. dotnet add package Microsoft.EntityFrameworkCore.Sqlite -  Adding SQLite package 
5. dotnet add package Microsoft.EntityFrameworkCore.Tools - Adding EntityFrameworkCore
6. dotnet add package Swashbuckle.AspNetCore - Adding Swashbuckle 
7. dotnet add package Newtonsoft.Json - Adding Newtonsoft
8. dotnet add package System.IdentityModel.Tokens.Jwt -  Adding IdentityModel

Note - API Controller Working, Entity Framework Working, Swagger Working. 
Next - Add CRUD for Barber Coupon. 

# 30/04/2024

1. https://medium.com/projectwt/running-visual-studio-windows-projects-on-vs-code-windows-mac-9a7068defed0
2. https://medium.com/projectwt/revisiting-c-net-8-0-and-micro-services-update-5-e10652add731
3. Creating a repository for my Final Project - https://github.com/nikhilfenwick/FinalProject 
4. Creating a web API with ASP.Net core - https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio
5. Creating a MVC Web App - https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio

Use this in the readme.md file - 

1. User Dashboard: Upon logging in, users can access a personalized dashboard where they can view and manage their upcoming appointments, past bookings, and account details.
2. Barber Selection: Users have the flexibility to choose from a list of available barbers, viewing their profiles and specialties to make informed booking decisions.

# 29/04/2024

Commencing with project, installing files and setting up workspace - 

1. https://stackoverflow.com/questions/40675162/install-a-nuget-package-in-visual-studio-code 
2. https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
3. https://sqlitebrowser.org/dl/ - This is for browsing the SQLLite Data. 


