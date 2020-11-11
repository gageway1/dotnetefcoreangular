import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PassportInactiveComponent } from './passport-inactive/passport-inactive.component';


const routes: Routes = [
  {
    path: '',
    component: PassportInactiveComponent,
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PassportInactiveRoutingModule { }
