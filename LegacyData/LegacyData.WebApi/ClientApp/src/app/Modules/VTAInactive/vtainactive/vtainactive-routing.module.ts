import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VtaInactiveComponent } from './vta-inactive/vta-inactive.component';


const routes: Routes = [
  {
    path: '',
    component: VtaInactiveComponent,
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VTAInactiveRoutingModule { }
