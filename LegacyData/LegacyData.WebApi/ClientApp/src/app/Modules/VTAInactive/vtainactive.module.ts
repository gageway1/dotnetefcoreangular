import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VTAInactiveRoutingModule } from './vtainactive-routing.module';
import { SharedModule } from '../Shared/shared/shared.module';
import { VtaInactiveIdComponent } from './vta-inactive-id/vta-inactive-id.component';
import { VtaInactiveComponent } from './vtainactive/vta-inactive/vta-inactive.component';
import { VTAInactiveFullViewComponent } from './vtainactive-full-view/vtainactive-full-view.component';



@NgModule({
  declarations: [
    VtaInactiveComponent,
    VtaInactiveIdComponent,
    VTAInactiveFullViewComponent
  ],
  imports: [
    VTAInactiveRoutingModule,
    SharedModule,
  ]
})
export class VTAInactiveModule { }
