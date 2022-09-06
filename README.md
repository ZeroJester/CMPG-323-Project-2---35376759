# CMPG-323-Project-2---35376759

## How to register?
1. Click on the "/api/Authenticate/register" or "/api/Authenticate/register-admin"  tab under the Authenticate endpoint
2. Click on the "Try it out" button
3. Enter required values
4. Click on the "Execute" button
5. Your account has now been registered

## How to Authorize?
(details provided for the purpose of testing the API)
1. Go to the following link: https://connectedoffice35376759.azurewebsites.net/swagger/index.html
2. Click on the "/api/Authenticate/login" tab under the Authenticate endpoint
3. Click on the "Try it out" button
4. Type the following credentials in their respective input areas: Username = Admin  ;Password = Admin@123
5. Click on the "Execute" button
6. Copy the token given at the first response body
7. Click on the "Authorize" button on the top right of the page
8. Type "Bearer" in the value box followed by your token that you copied
9. Click on the "Authorize" button
10. Click on the "Close" button
11. You are now authorized to use any controller endpoint



## How to use endpoints?
1. Click on the desired endpoint tab
2. Enter requisite data (if necessary)
3. Click on the "Execute" button


## Endpoints and Additional Aspects
### Authenticate
1. /api/Authenticate/login
2. /api/Authenticate/register
3. /api/Authenticate/register-admin

### Categories
1. /api/Categories
2. /api/Categories/{id}
3. /api/Categories/Edit/{id}
4. /api/Categories/Add
5. /api/Categories/Delete{id}
6. /api/Categories/Category/{id}
7. /api/Categories/NumberOfZones/{id}

### Devices
1. /api/Devices
2. /api/Devices/{id}
3. /api/Devices/Edit/{id}
4. /api/Devices/Add
5. /api/Devices/Delete{id}

### Zones
1. /api/Zones
2. /api/Zones/{id}
3. /api/Zones/Edit/{id}
4. /api/Zones/Add
5. /api/Zones/Delete{id}
6. /api/Zones/Devices/{id}

### Additional Aspects
1. Every controller needs authorization before using it
2. Try-catch statements to catch basic errors
3. Added private verification methods to verify existence of objects



#### Project Description
This project focusses on the development of an API. The API acts as an intermediary between the database and the endpoints on the website. The goal of the API is to ensure safety and integrity of data, but to also allow multiple users to interact with the data in the database. This is a much safer method than to directly access the database and edit the values inside the database in this way. The API allows access to the database (if authorized) so that many different employees are able to use the data in the database.


(reference list document is in the project folder as "Project2-Links.txt")
