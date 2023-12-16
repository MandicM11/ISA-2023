import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Credentials } from '../model/credentials.model';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  public credentials = new Credentials();
  public passwordHide: boolean = true;

  constructor(
    private authService: AuthService,
    private router: Router,
    private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

/*  login(): void {
    this.authService.login(this.credentials).subscribe(res => {
      this.router.navigate(['/']);
    },
    error => this.snackBar.open("Wrong username and/or password!", "Ok", {
      duration: 2000,
      panelClass: ['snack-bar']
    }));
  } */
}
