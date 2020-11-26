import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { User } from './../../../../Models/user';
import { UserService } from './../../../../Services/user.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  isExpanded = false;
  public authenticated = false;
  public user: User;
  constructor(
    private toast: ToastrService,
    private userService: UserService,
  ) { }


  ngOnInit(): void {
    this.userService.user.subscribe(result => {
    });
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public login(): void {
    this.userService.changeUser({ name: 'Gage Way', authenticated: true, permissions: [0, 1, 2], pic: 'VE85' });
    this.userService.user.subscribe(result => {
      this.user = result;
    });
  }

  public logOut(): void {
    this.userService.changeUser(null);
    this.userService.user.subscribe(result => {
      this.user = result;
    });
  }

}
