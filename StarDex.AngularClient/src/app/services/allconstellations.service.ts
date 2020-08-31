import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Constellation } from '../models/constellation';
import { RequestService } from './request.service';
import { Observable } from 'rxjs';
import { timer } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AllconstellationsService {

  obv$: Observable<string>;
  obvString: string;

  constructor(private http: HttpClient, private req: RequestService) { }

  getConstellations(): Observable<string> {

    return this.req.getJSON('https://domainserviceapi.azurewebsites.net/api/Constellation');

    /* this.obv$ = this.req.getJSON("https://domainserviceapi.azurewebsites.net/api/Constellation");

    this.obv$.subscribe((res) => {

      this.obvString = res;

    });

    console.log(this.obvString)

    let jObj: any = JSON.parse(this.obvString);

    return <Constellation[]>jObj; */

  }

}
