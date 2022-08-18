# Conrad Energy Task

The solution has 3 parts.

1. NationalGridData Extract
   This project is used to populate the database from a csv download
   
2. CondardEnergyAPI
   This project is used to feed the data to the UI
   
3. ConradEnergyBlazor
   Blazor Web Assembly front end to view the data from the api
   
   
The project uses SQL Server and this will need to be running to setup.

- Open the solution in Visual Studio and run a build
- Select the ConradEnergyAPI project as the default start project
- Open the appsettings.json file of the ConradEnergyAPI project and edit the connection string to your local as required
- Navigate to the Tools, NuGet Package Manager, Package Manager Console
- In the Package Manager Console select the ConradEneryAPI as the default project
- Type ```Update-Database -Context ApplicationDbContext``` to create the database and add the Auth setup
- Select the NationalGridDataExtract project as the default start project
- Open the appsettings.json file of the NationalGridDataExtract project and edit the connection string to your local as required (needs to be the same as the API)
- In the Package Manager Console select the NationalGridDataExtract as the default project
- Type ```Update-Database -Project ConradEnergy.EFCore``` to update the database and add the data tables
- With the NationalGridDataExtract still set as the default start project, press F5 or run the project.  This will download the ElectricityDemand data csv file from the National Grid
- Once the task has completed, set the ConradEneryAPI as the default start project
- When the Swagger UI appears, click on the Auth/Register endpoint
- Click on the ```Try it out``` button
- In the request body, enter a username and password (the password must be a minimum of 6 characters in length) and click on ```Execute```
- The response body should now display ```User created successfully!```.  These are your login details for the UI
- Now set the ConradEnergyAPI and ConradEneryBlazor projects as default start up
- Once the Blazor UI loads, attempt to click on the ```Electricity Demands``` link in the left nav.  This should not allow you to access without logging in
- Login by clicking on the ```Login``` button in the header using the username and password
- Navigate back to the ```Electricity Demands``` page and click the ```Filter``` button.  Data should appear
- You can change the dates and number of records to display and filter again, or using the paging buttons at the bottom of the list
