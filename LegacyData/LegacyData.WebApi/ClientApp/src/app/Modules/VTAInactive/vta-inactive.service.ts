import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { VTA } from 'src/app/Models/vta';
import { ApiService } from 'src/app/Services/api.service';
import { BaseService } from 'src/app/Services/base.service';

@Injectable({
  providedIn: 'root'
})
export class VtaInactiveService extends BaseService {

  constructor(
    private apiService: ApiService,
    private http: HttpClient,
  ) {
    super();
  }

  public getVtaInactiveDataByEmployeeId(id: number): Observable<VTA[]> {
    const apiUrl = `${this.apiService.baseApiUrl}/getVtaInactiveAllDataById`;
    return this.http.get<VTA[]>(`${apiUrl}?id=${id}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record.');
        }));
  }

  public getFullVTAEntryById(id: number): Observable<VTA> {
    const apiUrl = `${this.apiService.baseApiUrl}/getVtaInactiveFullEntryById`;
    return this.http.get<VTA>(`${apiUrl}?id=${id}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record.');
        }));
  }

  public getVtaInactiveDataByName(firstName: string, lastName: string): Observable<VTA[]> {
    console.log(firstName + " " + lastName)
    const apiUrl = `${this.apiService.baseApiUrl}/getVtaInactiveAllDataByName`;
    let params = "";
    if (firstName && lastName) {
      params += `?firstName=${firstName}&lastName=${lastName}`
    }
    if (firstName && !lastName) {
      params += `?firstName=${firstName}`;
    }
    if (lastName && !firstName) {
      params += `?lastName=${lastName}`;
    }
    return this.http.get<VTA[]>(`${apiUrl}${params}`)
      .pipe(
        tap(() => {
          console.log('Fetched VTAInactiveAllData record(s).');
        }));
  }



}

