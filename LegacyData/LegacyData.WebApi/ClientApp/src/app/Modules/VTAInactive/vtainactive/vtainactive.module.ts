import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VTAInactiveRoutingModule } from './vtainactive-routing.module';
import { VtaInactiveComponent } from './vta-inactive/vta-inactive.component';
import { SharedModule } from '../../Shared/shared/shared.module';


@NgModule({
  declarations: [VtaInactiveComponent],
  imports: [
    CommonModule,
    VTAInactiveRoutingModule,
    SharedModule
  ]
})
export class VTAInactiveModule { }
