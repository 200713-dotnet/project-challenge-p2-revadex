import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RequestService } from './request.service';

@Injectable({
  providedIn: 'root'
})
export class AllplanetsService {

  obv$: Observable<string>;
  obvString: string;

  constructor(private http: HttpClient, private req: RequestService) { }

  getPlanets(): Observable<string> {

    return this.req.getJSON('https://domainserviceapi.azurewebsites.net/api/Planet');

  }
}
