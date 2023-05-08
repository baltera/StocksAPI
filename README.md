# StocksAPI
Project to explore .NET Core Web functionalities, while practicing engineering concepts such as clean architecture, unit testing, dependency injection, entity framework, among others. 

Business domain of the REST API build is the Stock Market. Being its main goal to provide filtered basic information for a given stock.

## Table of Contents
- [Project Structure](#project-structure)
    - [Built with](#built-with)
- [Building Steps](#building-steps)
    - [Base Project](#base-project)
    - [External API Connection](#external-api-connection)
    - [Persistence](#persistence)
- [Installation](#installation)
- [Contributing](#contributing)

## Project Structure
Directory is build based on a Clean Architecture pattern, several projects aggregate to a single layered solution. The structure of the application comes as a result of researching documentation, tutorials and repository examples found on the internet.

The layers decided to support this architecture are 4*:
- Domain
- Infrastructure
- Presentation
- Services

**Presented in an alphabetically rather than a priority/importance order.*

### Built with
Frameworks/libraries used in this project include:
- .NET 6.0
- xUnit  

Specific Nuget Packages used:
- Newtonsoft Json | version 13.0.3
- Entity Framework Core - SqlServer | version 6.0.16
- Entity Framework Core - Tools | version 6.0.16

## Building Steps
As stated before, the project is build following a Clean Architecture philosophy. The components being build on each layer are expected to be independent and, in this way, the order of construction can change between developers based on expertise, knowledge or simple preference.

For this project specifically, the order of construction is as follows:

### **Base Project**
First we created a .NET solution by using, either the IDE choosing an .NET Core Wep API Template, or through the CLI:
```
dotnet new solution
dotnet new webapi -o Stocks.Api
```
Then, we create a separate project for each of the layers.
```
dotnet new classlib -o Stocks.Domain
dotnet new classlib -o Stocks.Infrastructure
dotnet new classlib -o Stocks.Services
```
We add those projects to the solution.
```
dotnet sln add Stocks.Domain/Stocks.Domain.csproj
dotnet sln add Stocks.Infrastructure/Stocks.Infrastructure.csproj
dotnet sln add Stocks.Services/Stocks.Services.csproj
```
Finally we must include the required references between the projects.  
```
dotnet add Stocks.Api/Stocks.Api.csproj reference Stocks.Services/Stocks.Services.csproj

...
```
**For the sake of documentation, only one reference is included above*

### **External API Connection**
In order to to provide information about stocks, more specifically quotes on current markets, the API must obtain information from an external source The external API chosen is [Stockdata.org API](https://www.stockdata.org/documentation) (free tier). Provided that we are only consuming a few endpoints and the volume of transactions won't surpass the 100 requests/day limit.

Being the **Infrastructure Layer** the one in charge of interactions with the outer world (database persistence, mail sending, external identity services, external apis) this is the place where we are locating the connectivity function of our application. So we are going to be working on the path *StockAPI\Stocks.Infrastructure*. 

First, we create an implementation of the HttpClient to centralize the requirements of the external API (its key, its base URL, etc.). All of this inside a *Commons* folder to keep everything organized.
```
\Commons\StocksHttpClient.cs
```
Next, a class for the specific service is created, StockDataAPIService. This is going to contain the methods that interact with the external API. All of this, hoping to be later exposed in the Service Layer through interfaces.
```
\Services\StockDataAPIService.cs
```
In parallel, in order to handle the responses from the Stock Data API an object is required so we create one specifically for this purpose. Here we need to map each section of the JSON coming as a response from the API to a property in code.
```
\Models\StockDataResponse.cs
```

So inside the StockDataResponse.cs the structure will be two other classes that simulate the structure of the response JSON, like so:
```
StockDataResponse {
    MetaStockDataResponse, 
    List<QuoteStockDataResponse>
}
```

### **Persistence**
In the field of data persistence, the approach for this project is going to be a *Code First* one. We are going to model our reality using C# and then, by the help of some framework tools we are going to translate those lines of code in database structure.  
The tools selected are **Entity Framework Core (EF)** and the **Fluent API**. The combination of both will provide us with enough ways to delimit, name, abstract and build a robust relational structure to handle the data in our application.

*Previous Requirements*  
Using the NuGet Package Manager, install the following packages on the **Infrastructure Layer**:
- Entity Framework Core - SqlServer | version 6.0.16
- Entity Framework Core - Tools | version 6.0.16  

*Modeling*  
As the  **Domain Layer** objective is, we are going to include here every component that modelates the reality of the business context. In the case of our Stock API, we defined 3 main classes that can handle the basic information that we are expected to deliver to the end consumer.
```
├── Stocks.Domain
    ├── Models
        ├── Exchange.cs                      
        ├── Stock.cs
        └── StockQuote.cs
```
Moving on to the **Infrastructure Layer**, here we are going to define all the logic related to persist (db or external components) the reality modeled in the **Domain Layer**.  
Here the implementations are going to be the key, as this is how our application connects to the external world. Here is where we are going define the Fluent API logic.

In order to keep everything organized, we created a specific folder `Stocks.infrastructure\Persistence` and inside, we created the file responsible to handle the connection string to our database: `Data\ApplicationDBContext.cs`.

Now to create a *migration*, we should open the *Package Manager Console (PM)** and run the specific command for this task.
```
add-migration <significant_name> -OutputDir <path_for_migrations>
```
Which for the case of our first migration might look like this:
```
add-migration AddModelToDB_TblsExchangeNStockNStockQuote -OutputDir Persistence/Migrations
```
**Notice that dotnet CLI commands can be used here too. Check this [link](https://learn.microsoft.com/en-us/ef/core/cli/) for further reference.* 

And having our migration created, we must apply it to the database by running:
```

```
## Installation
Here some installation notes.

## Contributing
How to contribute to this repo.
