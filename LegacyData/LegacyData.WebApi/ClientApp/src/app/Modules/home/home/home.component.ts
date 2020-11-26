import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/Models/user';
import { UserService } from './../../../Services/user.service';
import { TileConsts } from './constants/TileConsts';
import { Tile } from './models/tile';
import { TileCategory } from './models/tile-category';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public user: User;
  public tileCategories: TileCategory[];

  globalInstance: any;

  constructor(
    private toast: ToastrService,
    private userService: UserService,
  ) {
  }

  ngOnInit(): void {
    let x = this.userService.user;
    this.tileCategories = TileConsts.Categories;
    if (!this.tileCategories) {
      this.toast.error('Couldn\'t load tiles', null, {
        positionClass: 'toast-bottom-right-large'
      });
    }
  }

  onClick(event) {
    console.log(event);
  }
}
