# StocksAPI
Project to explore .NET Core Web functionalities, while practicing engineering concepts such as clean architecture, unit testing, dependency injection, entity framework, among others. 

Business domain of the REST API build is the Stock Market. Being its main goal to provide filtered basic information for a given stock.

## Table of Contents
- [Project Structure](#project-structure)
    - [Built with](#built-with)
- [Building Steps](#building-steps)
    - [Base Project](#base-project)
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

### Base Project
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

## Installation
Here some installation notes.

## Contributing
How to contribute to this repo.
