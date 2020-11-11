import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('src/app/Modules/Home/home-module/home.module').then(m => m.HomeModule),
        pathMatch: 'full'
    },
    {
        path: 'passport',
        loadChildren: () => import('src/app/Modules/PassportInactive/passport-inactive/passport-inactive.module').then(m => m.PassportInactiveModule),
    },
    {
        path: 'vta',
        loadChildren: () => import('src/app/Modules/vtainactive/vtainactive/vtainactive.module').then(m => m.VTAInactiveModule),
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
