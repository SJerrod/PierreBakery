# _Pierre's Bakery_

#### _Many to Many Database Relationship Project with Identity Authentication for Epicodus_ 
#### _DATE 01.15.2021_

#### By _**Jerrod Styrk**_

## Description

This application will help a Bakery Owner keep track the Treats and Flavors they have to offer. They will be able to login giving them special permissions such as the user can Create/Delete/Edit treats or flavors. Users without an account can check treats to see what flavors are availible for each treat and they can check flavors to see which treats are availible for each flavor.

## Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core
* MySQL
* MySQL Workbench

Open by Downloading or Cloning
- [Click to view Github repository](https://github.com/SJerrod/PierreBakery.Solution.git) Or simply paste the following url into your prefered browser https://github.com/SJerrod/PierreBakery.Solution.git
- To Clone repository simply click the green Code button and copy the url.
- Using a prefered terminal use the command `git clone paste-url-here` in which ever directory you wish.
- Open the newly cloned repo with your text editor.
- In the terminal run command `cd PierreBakery`
- In the terminal run command `dotnet restore`
- In the terminal run command `dotnet build`
- In the terminal run command `dotnet run`

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the main `PierreBakery` directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=jerrod_styrk;uid=root;pwd=<YourPassword>;"
  }
}
```

* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Type `dotnet ef database update` into the terminal to create your database tables.

<!-- SQL Database Design
<center>
<img style="width: 50% height: 50%" src="./ReadMeAssets/sqlSchemaFactory.png">
</center> -->

## Known Bugs


## Support and contact details

* Please feel free to reach out to <jstyrk@citadel.edu>

## Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* [Bootstrap Components](https://getbootstrap.com/docs/3.3/components/)
* C#
* Razor
* Entity Framework Core
* MySql
* MySql Workbench

</details>

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Jerrod Styrk_**