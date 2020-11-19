import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Passport } from 'src/app/Models/passport';
import { ApiService } from 'src/app/Services/api.service';
import { BaseService } from 'src/app/Services/base.service';

@Injectable({
  providedIn: 'root'
})
export class PassportInactiveService extends BaseService {

  constructor(
    private apiService: ApiService,
    private http: HttpClient,
  ) {
    super();
  }


  public getPassportDataById(id: number): Observable<Passport[]> {
    const apiUrl = `${this.apiService.baseApiUrl}/passportInactiveAllDataById`;
    return this.http.get<Passport[]>(`${apiUrl}?id=${id}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record.');
        }));
  }

  public getFullPassportEntryById(id: number): Observable<Passport> {
    const apiUrl = `${this.apiService.baseApiUrl}/getPassportInactiveFullEntryById`;
    return this.http.get<Passport>(`${apiUrl}?id=${id}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record.');
        }));
  }

  public getPassportInactiveDataByName(firstName: string, lastName: string): Observable<Passport[]> {
    console.log(firstName + ' ' + lastName);
    const apiUrl = `${this.apiService.baseApiUrl}/passportInactiveAllDataByName`;
    let params = '';
    if (firstName && lastName) {
      params += `?firstName=${firstName}&lastName=${lastName}`;
    }
    if (firstName && !lastName) {
      params += `?firstName=${firstName}`;
    }
    if (lastName && !firstName) {
      params += `?lastName=${lastName}`;
    }
    return this.http.get<Passport[]>(`${apiUrl}${params}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record(s).');
        }));
  }



}
