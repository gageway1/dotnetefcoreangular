import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PassportInactiveIdComponent } from './passport-inactive-id/passport-inactive-id.component';
import { PassportInactiveComponent } from './passport-inactive/passport-inactive/passport-inactive.component';


const routes: Routes = [
  {
    path: '',
    component: PassportInactiveComponent,
    pathMatch: 'full'
  },
  {
    path: 'id',
    component: PassportInactiveIdComponent,
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PassportInactiveRoutingModule { }
