import { HomeModule } from './../../home/home.module';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RouterModule } from '@angular/router';
import { NavMenuComponent } from './navmenu-component/nav-menu.component';
import { HomeComponent } from '../../home/home/home.component';


@NgModule({
  declarations: [
    NavMenuComponent,
  ],
  imports: [
    CommonModule,
    RouterModule,
    AngularFontAwesomeModule,
  ]
})
export class NavMenuModule { }
