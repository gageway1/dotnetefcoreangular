import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PassportInactiveRoutingModule } from './passport-inactive-routing.module';
import { PassportInactiveComponent } from './passport-inactive/passport-inactive.component';
import { SharedModule } from '../../Shared/shared/shared.module';
import { ToastrModule } from 'ngx-toastr';


@NgModule({
  declarations: [PassportInactiveComponent],
  imports: [
    CommonModule,
    PassportInactiveRoutingModule,
    SharedModule,
  ],
})
export class PassportInactiveModule { }
