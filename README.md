# C# Övning 5 - Garage 1.0 (Svenska)

## Ett första övergripande projekt

För att koppla samman mycket av det ni lärt er, så skall vi nu bygga en garage / Consoleapplikation. Denna applikation skall tillhandahålla den funktionalitet som ett system kan behöva om det skall användas för att simulera ett enkelt garage.

Det skall alltså gå att parkera fordon, hämta ut fordon, se efter vilka fordon som finns där och vilka egenskaper de har. Allt detta i en konsolapplikation med huvudmeny och undermenyer.

Anledningen till att ni skall programmera ett garage är att det är enkelt att förankra uppdelningen i det hela. Vi kan huvudsakligen dela upp ett garage i följande delar:

**Garaget:**
En representation av själva byggnaden. Garaget är en plats där en mängd av fordon kan förvaras.
Garaget kan alltså representeras som en samling av fordon.

**Fordon:**
Bilar, motorcyklar, enhjulingar eller vad för typ av fordon man nu vill ställa in i garaget.

Dessa är de två “objekttyper” som man ser i ett fysiskt garage.
Men tittar vi närmare bör det också finnas subklasser till fordon, alltså att varje fordonstyp är en egen subklass i systemet.

Utöver detta krävs det funktionalitet som hanterar att fordon ställs in i garaget, att fordon kan tas ut ur garaget, samt att vi kan få en presentation av vad som finns i garaget och söka i det.

I mer programmerings-vänliga termer skall vi alltså som **minimum** ha:

- En kollektion av fordon; klassen `Garage`.
- En fordonsklass, klassen `Vehicle`.
- Ett antal subklasser till fordon.
- Ett användargränssnitt som låter oss använda funktionaliteten hos ett garage. Här sker all interaktion med användaren.

## Kravspecifikation

Fordonen ska implementeras som klassen `Vehicle` och subklasser till den.

- `Vehicle` innehåller samtliga egenskaper som ska finnas i samtliga fordonstyper.
  - T.ex. registreringsnummer, färg, antal hjul och andra egenskaper ni kan komma på.
- Registreringsnumret är unikt.
- Det måste minst finnas följande subklasser:
  - `Motorcycle`
  - `Airplane`
  - `Car`
  - `Bus`
  - `Boat`

Dessa skall implementera minst en egen egenskap var, t.ex:

- `Number of Engines`
- `Cylinder volume`
- `Fueltype (Gasoline/Diesel)`
- `Number of seats`
- `Length`

Klassen behöver inte ärva från någon annan klass eller implementera något annat interface.

Samlingen av fordon ska internt i klassen hanteras som en array. Den interna arrayen ska var privat. Vid instansieringen av ett nytt garage måste kapaciteten anges som argument till konstruktorn.

🛑 **Vi ska EJ använda oss av en `List<Vehicle>` internt i Garage klassen!!!!**

## Funktionalitet

Det ska gå att:

- Lista samtliga parkerade fordon.
- Lista fordonstyper och hur många av varje som står i garaget.
- Lägga till och ta bort fordon ur garaget.
- Sätta en kapacitet (antal parkeringsplatser) vid instansieringen av ett nytt garage.
- Möjlighet att populera (sätta in bilar) i garaget med ett antal fordon från start.
- Hitta ett specifikt fordon via registreringsnumret. Det ska fungera med både `ABC123` samt `Abc123` eller `AbC123`.
- Söka efter fordon utifrån en egenskap eller flera (alla möjliga kombinationer från basklassen `Vehicle`).
  Exempelvis:
  - Alla svarta fordon med fyra hjul.
  - Alla motorcyklar som är rosa och har 3 hjul.
  - Alla lastbilar.
  - Alla röda fordon.
- Användaren ska få feedback på att saker gått bra eller dåligt. Till exempel när vi parkerat ett fordon vill vi få en bekräftelse på att fordonet är parkerat. Om det inte går vill användaren få veta varför.

Programmet ska vara en konsolapplikation med ett textbaserat användargränssnitt.

Från gränssnittet skall det gå att:

- Navigera till samtlig funktionalitet från garage via gränssnittet.
- Skapa ett garage med en användar-specificerad storlek.
- Det skall gå att stänga av applikationen från gränssnittet.

Applikationen skall fel hantera indata på ett robust sätt, så att den inte kraschar vid felaktig inmatning eller användning.

## Förslag på Extra funktionalitet (ej krav)

- Möjlighet att också kunna söka på de fordonsspecifika egenskaperna.
- Hantera flera garage som kan ha olika typer av fordon i sig, exempelvis en hangar, ett vanligt garage samt ett motorcykelgarage.

Detta kommer medföra att man ska kunna manövrera sig mellan de olika garagen i UI:t för att kunna göra de tidigare nämnda funktionerna. De ska ske på bara det garage som man för tillfället valt.

Det ska tydligt visas vilket garage man för närvarande arbetar med.

Ett garage består inte längre av fordon utan av parkeringsplatser som i sin tur kan hålla fordon.

Det går att via C# skriva och läsa till filsystemet från er applikation. Ta reda på hur man gör för att kunna spara ert garage (via meny eller automatiskt vid avstängning) och ladda in ert garage (via meny eller automatiskt vid start av applikationen).

Olika fordon tar olika stor plats, t.ex. en bil tar 1 plats, en båt tar 2 platser, ett flygplan kräver 3 platser osv. En motorcykel tar endast 1/3 dels plats.

När man parkerar ska endast de fordon som garaget har plats för visas som alternativ.

Läsa in storleken på garaget via konfiguration.

Valfri funktionalitet ni tycker borde finnas.

**Lycka till!**

# C# Övning 5 - Garage 1.0 (Engelska)

## A First Comprehensive Project

To bring together much of what you have learned, you will now build a **garage / Console Application**.

This application should provide the functionality that a system would need if it were used to simulate a simple garage.

It should be possible to **park vehicles, retrieve vehicles, see which vehicles are currently in the garage, and see their properties**. All of this should be implemented in a **Console Application** with a **main menu and submenus**.

The reason for programming a garage is that it is easy to establish a clear structure. We can mainly divide a garage into the following parts:

**Garage:** A representation of the actual building. The garage is a place where a number of vehicles can be stored. The garage can therefore be represented as a **collection of vehicles**.

**Vehicle:** Cars, motorcycles, unicycles, or whatever type of vehicle you want to store in the garage.

These are the two **object types** that we see in a physical garage. However, if we look more closely, there should also be **subclasses of Vehicle**, meaning that each vehicle type should be its own subclass in the system.

In addition to this, functionality is required to handle vehicles being placed in the garage, vehicles being removed from the garage, as well as presenting and searching for what is currently in the garage.

In more programming-friendly terms, we should therefore have, at a minimum:

- 🛑A **collection of vehicles**; the `Garage` class.
- 🛑A **vehicle class**; the `Vehicle` class.
- A number of **subclasses of Vehicle**.
- 🛑A **user interface** that allows us to use the functionality of a garage. All interaction with the user takes place here.

# Requirements Specification

The vehicles should be implemented as the `Vehicle` class and subclasses of it.

- 🛑`Vehicle` contains all properties that should exist in all vehicle types.
  - For example: **registration number, color, number of wheels**, and other properties you can think of.
- 🛑The **registration number must be unique**.
- 🛑At least the following subclasses must exist:
  - `Motorcycle`
  - `Airplane`
  - `Car`
  - `Bus`
  - `Boat`
- 🛑These should each implement at least **one property of their own**, for example:
- `NumberOfEngines`
- `CylinderVolume`
- `FuelType` (`Gasoline` / `Diesel`)
- `NumberOfSeats`
- `Length`

The class does not need to inherit from any other class or implement any other interface.

🛑The collection of vehicles must internally be handled as an **array** inside the `Garage` class.

🛑The internal array must be **private**.

When instantiating a new `Garage`, the **capacity** must be specified as an argument to the constructor.

🛑**We MUST NOT use `List<Vehicle>` internally in the `Garage` class!!!!**

# Functionality

It must be possible to:

- List all parked vehicles.
- List the vehicle types and how many of each type are currently in the garage.
- Add and remove vehicles from the garage.
- Set a capacity (number of parking spaces) when instantiating a new garage.
- Populate the garage with a number of vehicles from the start.
- Find a specific vehicle using its registration number.
  - This must work with both `ABC123` and `Abc123` or `AbC123`.
- Search for vehicles based on one or more properties, including all possible combinations from the base class `Vehicle`.

For example:

- All black vehicles with four wheels.
- All motorcycles that are pink and have three wheels.
- All trucks.
- All red vehicles.

The user should receive **feedback** indicating whether an operation was successful or unsuccessful.

For example, when we park a vehicle, we want to receive confirmation that the vehicle has been parked. If it cannot be parked, the user should be informed of **why**.

The program should be a **Console Application** with a **text-based user interface**.

From the interface, it should be possible to:

- Navigate to all garage functionality through the interface.
- Create a garage with a **user-specified capacity**.
- Shut down the application from the interface.

The application should handle user input **robustly**, so that it does not crash because of invalid input or incorrect usage.

# Suggested Extra Functionality _(Not Required)_

## Search by Vehicle-Specific Properties

Add the possibility of searching based on the properties specific to each vehicle type.

## Multiple Garages

Handle multiple garages that can contain different types of vehicles, for example:

- A hangar
- A regular garage
- A motorcycle garage

This means that the user should be able to navigate between the different garages in the UI and perform the previously mentioned functions only on the garage that is currently selected.

It should be clearly displayed which garage the user is currently working with.

## Parking Spaces

A garage no longer consists directly of vehicles, but instead consists of **parking spaces**, which can in turn contain vehicles.

## Save and Load the Garage

It is possible to use C# to **write to and read from the file system** from your application.

Find out how to save your garage:

- Through a menu, or
- Automatically when the application is shut down.

And how to load your garage:

- Through a menu, or
- Automatically when the application starts.

## Different Vehicle Sizes

Different vehicles occupy different amounts of space.

For example:

- A car takes **1 space**.
- A boat takes **2 spaces**.
- An airplane requires **3 spaces**.
- A motorcycle takes only **1/3 of a space**.

When parking a vehicle, only vehicles that the garage currently has enough space for should be displayed as available options.

## Configuration

Read the garage size/capacity from a **configuration file**.

## Optional Functionality

Any other functionality that you think should be included.

**Good luck!**
