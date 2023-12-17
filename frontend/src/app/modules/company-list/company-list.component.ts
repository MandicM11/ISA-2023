import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CompanyService } from '../../services/company.service';
import { OnInit } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AuthService } from '../authentication/services/auth.service';


@Component({
  selector: 'app-company-list',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './company-list.component.html',
  styleUrl: './company-list.component.scss'
})
export class CompanyListComponent implements OnInit {
  companiesWithEquipment: any[] = [];
  userId=0;
  constructor(private companyService: CompanyService,private cdr: ChangeDetectorRef,private authService: AuthService) { }

  ngOnInit(): void {
    this.userId=this.authService.userId;
    console.log(this.userId);
    this.loadCompanies();
  }

  loadCompanies() {
    this.companyService.getCompaniesWithEquipment().subscribe(
      (data: any[]) => {
        this.companiesWithEquipment = data;
        this.cdr.detectChanges();


      },
      (error) => {
        console.error('Error fetching data:', error);
      }
    );
  }

  selectEquipment() {
    console.log('radi');
  }
}


