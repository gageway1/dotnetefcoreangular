import { VTAInactiveFullViewComponent } from './vtainactive-full-view/vtainactive-full-view.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VtaInactiveIdComponent } from './vta-inactive-id/vta-inactive-id.component';
import { VtaInactiveComponent } from './vtainactive/vta-inactive/vta-inactive.component';


const routes: Routes = [
  {
    path: '',
    component: VtaInactiveComponent,
    pathMatch: 'full'
  },
  {
    path: 'id',
    component: VtaInactiveIdComponent,
  },
  {
    path: 'id/fullView',
    component: VTAInactiveFullViewComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VTAInactiveRoutingModule { }
