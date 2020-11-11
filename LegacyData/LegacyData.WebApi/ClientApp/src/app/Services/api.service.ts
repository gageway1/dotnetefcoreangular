import { Injectable } from '@angular/core';
import { ConfigService } from './config.service';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private config: ConfigService) {
    this.baseApiUrl = `https://localhost:44368/api`;
  }

  public baseApiUrl: string;

}
