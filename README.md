# Equipme Engineering Interview
Repository containing different topics and tasks for interviewing engineering candidates.

# Interview Scope

The equipme interview is not based on trivia questions. We try to emulate real working conditions, by discussing various topics in the context of the candidate's role. 
Also, we try to discuss challenges, which an engineering team will encounter when building a complex B2B SaaS application like equipme. 

# Goals

## General goals:

- Ensure that the candidate has the necessary professional qualifications for the corresponding role
- Checking whether the candidate has the necessary prerequisites to actively improve the equipme app
- Ensure that the candidate is a professional fit for the team
- Getting to know each other's working methods and philosophies

## Technical goals

The candidate should discuss several questions with the team. We are not searching for the one right answer, but the pros and cons should be discussed and weighed.
Also, the candidate should be able to discuss certain implementations and parts of the code.

# Discussion Topics

The list of topics is intended only as a guideline for an interview discussion. 

In no particular order:

- Project structure and layers (Controllers, Logic, Data & Model)
- Dependency injection & interfaces, coupling & cohesion
- Naming philosophy (Variables, methods, classes, namespaces, projects)
- RESTfull services, routes, query parameters, operations
- GraphQL, pros & cons, use cases
- Relational database systems, set theory, set operations, constraints & relations
- Data access, SQL, ORM-Mapper vs. pure SQL
- Transactions, data consistency and data security
- Authentication and authorization in web based applications
- Asynchronous operations (tasks, async & await, events & delegates), race conditions & critical sections 
- Distributed systems, queues, gRPC and messaging
- Hosting, docker, configuration management, kubernetes
- Infrastructure, DNS, TLS, Load balancing  
- Testing, unit tests, integration tests, end-to-end tests, code coverage, code quality

# Template project & tasks

The template project serves the purpose of presenting various tasks for the candidate. The candidate can decide which tasks they want to work on. None of the tasks are mandatory. 
Also, the project can be used by the candidate to present specific concepts or solution approaches. 

## Projects

The template project consists of the following projects:

- .net: Contains the template project based on the .NET Framework 7.0
- node: Contains the template project based on nodejs >= 18.17.0

Both projects contain the following folders:

- api: Contains the api project
- client: Contains the frontend project
- test: Contains the test project
- docs: Contains the documentation
- database: Contains the data model and the data access layer

## Project Tasks

The genaeral goal of the tasks is to discuss different aspects of the project and the code. The tasks are not intended to be solved in a specific way. 

To give the candidate a starting point, the following requirements are given:

- Implement a simple task\todo management list with the following features:
  - Create a new task
  - Update an existing task
  - Delete an existing task
  - List all tasks
- Implement\Design additional entities like users, comments etc.
- The api should be implemented as a RESTful OR GraphQL service
- The api should be implemented with .NET 7.0 Core or nodejs >= 18.17.0
- The client should be implemented as a single page application (SPA)
- The client should be implemented with React, Angular or Vue
- The client should be implemented with TypeScript
- The client should be implemented with a state management library (Redux, NgRx, Vuex etc.)
- The data model should be implemented with a relational database system (SQLite, SQL Server, PostgreSQL etc.)
- The data access layer should be implemented with an ORM mapper (Entity Framework, TypeORM, Sequelize etc.) OR with pure SQL

All tasks are optional. The candidate can decide which tasks they want to work on and to what extent. The candidate should explain the solution and the decisions he or she made.
Also we are interested in the candidate's opinion on the tasks and the project. As an example, the candidate could do the following:

- Implement a pure GraphQL OR REST api and mock the data (Ignoring the data model and the data access layer) and focus on all aspects of GraphQL OR REST
- Focus on the data model and the data access layer and api and ignore the client
- Implement the client and the api and mock the data (Ignoring the data model and the data access layer)
- Implement a simple full stack solution by focusing on a single task like "Create a new task" and show the result in the client

### Project Scope

The scope of the project\solution is not limited to the given requirements. The candidate can extend the project\solution with additional features and ideas. Also it
is important to consider the following aspects:

- Your ToDo-App will be used by A LOT of users!
- Your ToDo-App will be used by A LOT of users at the same time!
- Your ToDo-App will be used by A LOT of users at the same time on different devices!
- Your ToDo-App will be used by A LOT of users at the same time on different devices in different timezones!
- Your ToDo-App will be used by A LOT of users at the same time on different devices in different timezones in different countries!
- Your ToDo-App will be used by A LOT of users at the same time on different devices in different timezones in different countries on different continents!
- Your ToDo-App will be used by A LOT of users at the same time on different devices in different timezones in different countries on different continents on different planets (Ok...maybe that was too much)! 

### Additional ideas and suggestions

- Implement one ore more CRUD operations for the task or user resource\entity 
- Implement some kind of database persistence layer (in-memory, SQLite, PostgreSQL etc.)
- Implement a data access repository for the task resource 
- Implement a GET route with server side paging 
- Design a data model with more entities (customer, user, attachements, historization etc.)
- Add some kind of authentication and or authorization concept for the client and\or api  
- Add a test and quality assurance concept (unit tests, integration tests, end-to-end tests, code coverage, code quality etc.)

