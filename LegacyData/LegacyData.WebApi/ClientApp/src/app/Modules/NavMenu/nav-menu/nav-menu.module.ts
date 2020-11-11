import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NavMenuComponent } from './navmenu-component/nav-menu.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    NavMenuComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
  ]
})
export class NavMenuModule { }
