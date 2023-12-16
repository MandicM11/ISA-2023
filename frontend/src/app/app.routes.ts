import { Routes } from '@angular/router';
import { LoginComponent } from './modules/authentication/login/login.component';
import { RegisterComponent } from './modules/authentication/register/register.component';
import { NavbarComponent } from './navbar/navbar.component';
import { CompanyListComponent } from './modules/company-list/company-list.component';
export const routes: Routes = [
   // {path:'', pathMatch: 'full', redirectTo: 'navbar'},
    {path:'navbar', component: NavbarComponent},
    {path:'register', component: RegisterComponent},
    {path:'login', component: LoginComponent},
    {path:'companies', component: CompanyListComponent }
    
];
