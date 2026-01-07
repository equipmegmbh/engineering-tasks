import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user-service';

@Component({
  selector: 'app-user-list',
  imports: [],
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css'
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
