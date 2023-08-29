# CountryAPI
Welcome to the **Country Information API** project! This API serves as a wrapper for an external API, providing endpoints to retrieve country details, states, and cities based on user requests.

## Endpoints

### Get Country Details

**Endpoint:** `GET /api/country/{countryName}`

- Retrieve details about a specific country.
  
### Get Country States

**Endpoint:** `POST /api/country/CountryStates`

- Retrieve a list of states within a country.
- Expects a `Country name` in the request body.
- Returns relevant state information.

### Get State and Cities

**Endpoint:** `POST /api/country/CountryCities`

- Retrieve a list of cities within a country.
- Expects a `Country Name` in the request body.
- Returns relevant city information.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Basic knowledge of ASP.NET and C#
- Familiarity with HTTP requests and APIs

### Installation

1. Clone this repository to your local machine.
2. Navigate to the project directory using the command line.
3. Run the following command to build the project: `` dotnet build ``
4. Run the following command to start the API: `` dotnet run ``
