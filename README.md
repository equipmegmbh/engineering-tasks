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

- Attack Surface Vectors in SPAs
- OWASP Top 10
- Broken Access Control
- Cross Site Scripting (XSS) prevention
- Authentication & authorization handling
- Oauth Vs. alternatives

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

# Code Task

```
// user-list.component.ts
import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-user-list',
  template: `
    <div>
      <h2>Users</h2>

      <input
        type="text"
        placeholder="Search users"
        (input)="onSearch($event.target.value)"
      />

      <ul>
        <li *ngFor="let user of users">
          {{ user.name }} – {{ user.email }}
        </li>
      </ul>
    </div>
  `
})

export class UserListComponent implements OnInit {
  users: any[] = [];
  searchTerm = '';

  constructor(private userService: UserService) {}

  ngOnInit(): void {
    this.loadUsers();
  }

  loadUsers(): void {
    this.userService.getUsers().subscribe(users => {
      this.users = users.filter(u =>
        u.name.toLowerCase().includes(this.searchTerm.toLowerCase())
      );
    });
  }

  onSearch(term: string): void {
    this.searchTerm = term;
    this.loadUsers();
  }
}
```

```
// user.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class UserService {
  constructor(private http: HttpClient) {}

  getUsers() {
    return this.http.get<any[]>('/api/users');
  }
}
```

1. Architecture & Data Flow

- What does the code do? 
- What are the problems with calling getUsers() on every keystroke?
- How would you redesign the data flow to avoid unnecessary HTTP requests?
- Should filtering happen in the component, service, or backend?
- Http client: Can you explain the basic structure of an http request (verbs, body, parameter, headers)?
- 

2. Performance & Change Detection

- How does this behave with a large user list?
- What change detection strategy would you choose here and why?
- Would OnPush help? What changes would be required?

3. RxJS & Subscriptions

- What issues do you see with the current subscription handling?
- How would you prevent memory leaks?
- Would you use switchMap, debounceTime, or shareReplay here?

4. Typing & Code Quality

- What are the risks of using any[]?
- How would you improve type safety?
- How would you make this component more testable?

5. UX & Edge Cases

- How does this handle slow networks or errors?
- How would you show loading and error states?
- What happens if two requests return out of order?
- Expected Senior-Level Improvements (Not Shown to Candidate)

**A strong candidate may suggest:**

- Converting the component to observable-driven state
- Debouncing search input with RxJS
- Caching results in the service
- Introducing OnPush change detection
- Using async pipe instead of manual subscriptions
- Separating server state from view state


