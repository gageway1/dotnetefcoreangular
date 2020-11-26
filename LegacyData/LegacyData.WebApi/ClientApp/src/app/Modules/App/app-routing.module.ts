import { HomeComponent } from './../home/home/home.component';
import { NavMenuComponent } from './../NavMenu/nav-menu/navmenu-component/nav-menu.component';
import { AppComponent } from './app-component/app.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('src/app/modules/home/home.module').then(m => m.HomeModule),
        pathMatch: 'full',
    },
    {
        path: 'passport',
        loadChildren: () => import('src/app/modules/passportinactive/passport-inactive.module').then(m => m.PassportInactiveModule),
    },
    {
        path: 'vta',
        loadChildren: () => import('src/app/modules/vtainactive/vtainactive.module').then(m => m.VTAInactiveModule),
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
