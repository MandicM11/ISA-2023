import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
//import { HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  private apiUrl = 'https://localhost:7121'; 

  constructor(private http: HttpClient) {};

  getAllCompanies(): Observable<any[]> {
  
    return this.http.get<any[]>(this.apiUrl + '/api/Company');
  }
}
