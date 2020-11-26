import { UserService } from './../../../Services/user.service';
import { DownloadCsvService } from './services/download-csv.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ReactiveFormsModule,
  ],
  exports: [
    ReactiveFormsModule,
    CommonModule,
    AngularFontAwesomeModule,
    HttpClientModule,
    FormsModule,
    AngularFontAwesomeModule,
  ],
  providers: [DownloadCsvService, UserService]
})
export class SharedModule { }
