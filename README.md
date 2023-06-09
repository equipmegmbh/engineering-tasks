# Equipme Backend Engineering Interview
Repository containing different topics and tasks for interviewing engineering candidates.

# Scope

The equipme interview is not based on trivia questions. We try to emulate real working conditions, by discussing various topics in the context of the candidate's role. 
Also, we try to discuss challenges, which an engineering team will encounter when building a complex B2B SaaS application like equipme. 

# Goals

## Overall goals:

- Ensure that the candidate has the necessary professional qualifications for the corresponding role
- Checking whether the candidate has the necessary prerequisites to actively improve the equipme app
- Ensure that the candidate is a professional fit for the team
- Getting to know each other's working methods and philosophies

## Technical milestones and goals

The candidate should discuss several questions with the team. We are not searching for the one right answer, but the pros and cons should be discussed and weighed.
Also, the candidate should be able to discuss certain implementations and parts of the code which are marked in test project.

# Discussion Topics

The list of topics is intended only as a guideline for an interview discussion. 

In no particular order:

- Project structure and layers (Controllers, Logic, Data & Model)
- Dependency injection & interfaces
- Naming philosophy (Variables, methods, classes, namespaces, projects)
- RESTfull services, routes, query parameters, operations
- Relational database systems, set theory, set operations, constraints & relations
- Data access, SQL, ORM-Mapper vs. pure SQL
- Transactions, data consistency and data security
- Authentication and authorization in web based applications
- Asynchronous operations (tasks, async & await, events & delegates), race conditions & critical sections 
- Distributed systems, queues, gRPC and messaging
- Hosting, docker, configuration management, kubernetes
- Infrastructure, DNS, TLS, Load balancing  

# Template project & tasks

The template project serves the purpose of presenting various tasks for the candidate. The candidate can decide which tasks they want to work on. None of the tasks are mandatory. 
Also, the project can be used by the candidate to present specific concepts or solution approaches. 

## Tasks

Tasks can be found in the comments directly in the project. Additional ideas\suggestions:

- Implement one ore more CRUD operations for the product resource 
- Implement some kind of database persistence layer (in-memory, SQLite etc.)
- Implement a data access repository for the product resource 
- Implement a GET route with server side paging 
- Extend the data model with more entities (customer, supplier, order, historization etc.)
- Add some kind of authentication and or authorization concept   

