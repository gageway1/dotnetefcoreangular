import { UserService } from './../../../Services/user.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { User } from 'src/app/Models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit, OnDestroy {
  title = 'app';
  constructor(
  ) { }



  ngOnInit(): void {

  }

  ngOnDestroy(): void {

  }
}
