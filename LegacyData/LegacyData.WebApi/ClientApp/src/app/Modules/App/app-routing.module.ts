import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        loadChildren: () => import('src/app/Modules/PassportInactive/passport-inactive.module').then(m => m.PassportInactiveModule),
        pathMatch: 'full'
    },
    {
        path: 'passport',
        loadChildren: () => import('src/app/Modules/PassportInactive/passport-inactive.module').then(m => m.PassportInactiveModule),
    },
    {
        path: 'vta',
        loadChildren: () => import('src/app/Modules/vtainactive/vtainactive.module').then(m => m.VTAInactiveModule),
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
