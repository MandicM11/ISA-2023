import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CompanyService } from '../../services/company.service';
import { OnInit } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-company-list',
  standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './company-list.component.html',
  styleUrl: './company-list.component.scss'
})
export class CompanyListComponent implements OnInit {
  companiesWithEquipment: any[] = [];
  selectedEquipments: number[] = []; // Array to hold selected equipment ids
  showPanel = false;

  constructor(private companyService: CompanyService,private cdr: ChangeDetectorRef) { }

  ngOnInit(): void {
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


  onSelectButtonClick() {
    // Perform any additional logic before showing the panel if needed
    this.showPanel = true; // Set flag to show the panel
  }

   // Function to handle checkbox selection
   onCheckboxChange(event: any, equipmentId: number) {
    if (event.target.checked) {
      this.selectedEquipments.push(equipmentId); // Add to selectedEquipments array
    } else {
      const index = this.selectedEquipments.indexOf(equipmentId);
      if (index !== -1) {
        this.selectedEquipments.splice(index, 1); // Remove from selectedEquipments array
      }
    }
  }
}


