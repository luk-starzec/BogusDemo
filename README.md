# BogusDemo

Example of using Bogus nuget package to generate fake data.  
Demonstrates how to generate different kind of data like personal, address, product informations, ids, prices and others.

## Models
1. OrderModel  
    Order details with informations about custommer and ordered items

    - Id (int)
    - Date (DateTime)
    - Status (EnumOrderStatus)
    - Customer (CustomerModel)
    - Items (List&lt;ItemModel&gt;)
<br><br>
2. CustomerModel  
    Informations about custommer

    - Id (int)
    - FirstName (string)
    - LastName (string)
    - Email (string)
    - Phone (string)
    - Addres (string)
    - City (string)
    - ZipCode (string)
    - Country (string)
<br><br>
2. ItemModel  
    Informations about ordered item

    - Id (Guid)
    - Name (string)
    - Color (string)
    - Price (decimal)
    - Currency (string)
    - Quantity (int)
    - TotalPrice (decimal)
