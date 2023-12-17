import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterOutlet } from '@angular/router';
import { AuthService } from '../modules/authentication/services/auth.service';
import { Observable, shareReplay } from 'rxjs';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule,RouterOutlet],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent {
  isExpanded: boolean = false;
  isLogged: boolean = false;
  constructor(
    private breakpointObserver: BreakpointObserver,
    private router: Router,
    private authService: AuthService) {}

    ngOnInit(): void {
      this.authService.loginObserver.subscribe((val) => {
        this.isLogged = val;
      });
    }

    logout(): void {
      this.authService.logout();
      this.router.navigate(['/login']);
    }
  register(): void {
    this.router.navigate(['/register']);
  }
  companies(): void {
    this.router.navigate(['/companies']);
  }
}
