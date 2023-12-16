import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { NavbarComponent } from "./navbar/navbar.component";
import { RegisterComponent } from './modules/authentication/register/register.component';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss'],
    imports: [CommonModule, NavbarComponent,RegisterComponent,RouterOutlet, RouterLink, RouterLinkActive]
})
export class AppComponent {
  title = 'Medical equipment';
}
