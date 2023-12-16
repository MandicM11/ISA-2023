import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Credentials } from '../model/credentials.model';
import { AuthService } from '../services/auth.service';
import { OutletContext, Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
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

   login(): void {
    this.authService.login(this.credentials).subscribe(res => {
     this.router.navigate(['/companies']);
     console.log("uspesno");
    },
    error => {
      this.router.navigate(['/login']);
    });
  }
}
