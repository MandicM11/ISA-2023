import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject, catchError, map, Observable, of } from 'rxjs';
import { environment } from '../../../../environments/environment';
import { Credentials } from '../model/credentials.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl = 'https://localhost:7121/';
  userClaims: any = null;
  private loginSource = new BehaviorSubject<boolean>(false);
  public loginObserver = this.loginSource.asObservable();

  httpOptions = {
    headers: { 'Content-Type': 'application/json' }
  };
  //constructor(private http: HttpClient) {};

  constructor(private http: HttpClient, private jwtHelper: JwtHelperService) {
    this.userClaims = this.jwtHelper.decodeToken();
    if(this.userClaims)
      this.loginSource.next(true);
   }
  getAllCompanies(): Observable<any[]> {

    return this.http.get<any[]>(this.apiUrl + '/api/Company');
  }
}
