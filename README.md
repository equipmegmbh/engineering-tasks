# Equipme Engineering Interview
Repository containing different topics and tasks for interviewing engineering candidates.

# Interview Scope

Evaluate the candidate’s ability to design scalable, maintainable frontend/backend systems and reason about trade-offs, performance, and team constraints.

# Discussion Topics

## Frontend

### Architecture

- Application structure (feature-based vs. layered vs. domain-driven)
- Micro-frontends vs. monolith: when and why
- State management strategy (NgRx, Component Store, Signals, RxJS-only)
- Shared UI libraries and design systems
- Dependency injection, interfaces, coupling & cohesion
- Internationalization

### Data Flow & State

- Server vs. client state separation
- Caching strategies (HTTP caching, in-memory, stale-while-revalidate)
- Handling real-time updates (polling, WebSockets)
- Async and await pattern

### Performance

- Lazy loading modules and standalone components
- Change detection strategy (Default vs. OnPush)
- Large lists (virtual scrolling)
- Bundle size optimization

### Security

- XSS prevention
- Authentication & authorization handling
- Oauth Vs. alternatives
- Token storage strategy

### Testing & Maintainability

- Unit vs. integration vs. e2e testing
- Versioning APIs and backward compatibility
- Handling technical debt over time

### Frameworks & Concepts

#### Angular

- Singals vs. RxJS
- Modules 
- Components, services, directives & Data Binding
- Reactive vs. Template driven forms
- Lifecycle hooks
- W3C accessibillity
- NgRx
- Observalbles
- Http interceptors
- Routing in SPAs 
- Internationalization

### Culture & Philosophy

- Working in a startup environment
- MVP & Iterate
- Speed VS. Quality and Maintainabillity  

### Follow-up Scenarios

Describe and design a "cart" and "order" module where a user can review his configured service and place a batch order.

Requirements:

- A service configuration consists of multiple entities like an offer, options and assignments
- Service can have dependencies to other services in the cart (Base services for example)
- How do you evaluate business rules and present the state to the user?
- What happens when you place a really big order (>1000 positions)

## Backend

- DDD, Layered archtitecture, feature driven design
- Dependency injection & interfaces, coupling & cohesion
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
- Testing, unit tests, integration tests, end-to-end tests, code coverage, code quality


## Senior & Solution Engineer

### System Architecture & Design

- Monolith vs. microservices: what has changed your opinion over time?
- Database schema management (Breaking changes, migration, management)

