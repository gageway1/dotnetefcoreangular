import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PassportInactiveRoutingModule } from './passport-inactive-routing.module';
import { PassportInactiveComponent } from './passport-inactive/passport-inactive/passport-inactive.component';
import { SharedModule } from '../Shared/shared/shared.module';
import { PassportInactiveIdComponent } from './passport-inactive-id/passport-inactive-id.component';
import { PassportInactiveFullViewComponent } from './passport-inactive-full-view/passport-inactive-full-view.component';


@NgModule({
  declarations: [PassportInactiveComponent, PassportInactiveIdComponent, PassportInactiveFullViewComponent],
  imports: [
    PassportInactiveRoutingModule,
    SharedModule,
  ],
})
export class PassportInactiveModule { }
