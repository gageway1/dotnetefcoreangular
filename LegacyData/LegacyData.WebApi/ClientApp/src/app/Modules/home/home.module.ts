import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { SharedModule } from './../Shared/shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { ErrorRedirectComponent } from './error-redirect/error-redirect.component';



@NgModule({
  declarations: [
    HomeComponent,
    ErrorRedirectComponent
  ],
  imports: [
    HomeRoutingModule,
    SharedModule
  ]
})
export class HomeModule { }
