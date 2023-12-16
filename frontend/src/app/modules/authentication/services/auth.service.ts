import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { BehaviorSubject, catchError, map, Observable, of } from 'rxjs';
import { Credentials } from '../model/credentials.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private apiUrl = 'https://localhost:7121';

  userClaims: any = null;
  private loginSource = new BehaviorSubject<boolean>(false);
  public loginObserver = this.loginSource.asObservable();

  httpOptions = {
    headers: { 'Content-Type': 'application/json' }
  };
  constructor(private http: HttpClient, private jwtHelper: JwtHelperService) {
    this.userClaims = this.jwtHelper.decodeToken();
    if(this.userClaims)
      this.loginSource.next(true);
   }

   login(loginRequest: Credentials): Observable<boolean> {
    return this.http.post<any>(this.apiUrl + '/api/Auth/login', loginRequest, this.httpOptions).pipe(
      map((res) => {
      //  localStorage.setItem('token', res.jwt);
       // this.userClaims = this.jwtHelper.decodeToken();
        this.loginSource.next(true);
        console.log(res);
        return true;
      })
    );
  }

  logout(): void {
    localStorage.clear();
    this.loginSource.next(false);
  }

  getUserRole(): string {
    return this.userClaims.role;
  }

  isLogged(): boolean {
    if (!this.jwtHelper.tokenGetter())
      return false;
    return true;
  }
}
