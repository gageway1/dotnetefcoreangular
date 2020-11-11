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


  public getPassportDataById(id: number): Observable<Passport> {
    const apiUrl = `${this.apiService.baseApiUrl}/passportInactiveAllDataById`;
    return this.http.get<Passport>(`${apiUrl}?id=${id}`)
      .pipe(
        tap(() => {
          console.log('Fetched PassportInactiveAllData record.');
        }));
  }


}
