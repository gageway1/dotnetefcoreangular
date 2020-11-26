import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ToastrModule } from 'ngx-toastr';
import { NavMenuComponent } from '../NavMenu/nav-menu/navmenu-component/nav-menu.component';
import { AppComponent } from './app-component/app.component';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    AppRoutingModule,
    ToastrModule.forRoot({ positionClass: 'toast-bottom-right', closeButton: false, progressBar: true, }),
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [

  ],
  bootstrap: [AppComponent],
  exports: [

  ]
})
export class AppModule { }
