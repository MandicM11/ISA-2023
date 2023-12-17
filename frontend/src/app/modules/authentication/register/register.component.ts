import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterRequest } from '../model/register-request.model';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'register',
  standalone: true,
  imports: [CommonModule,FormsModule,ReactiveFormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss'
})
export class RegisterComponent {
   public credentials = new RegisterRequest();
   constructor(
    private authService: AuthService,
    private router: Router) { }


    register(): void {
      this.authService.register(this.credentials).subscribe(res => {
       this.router.navigate(['/login']);
       console.log("uspesno");
      },
      error => {
        this.router.navigate(['/register']);
      });
    }
}
