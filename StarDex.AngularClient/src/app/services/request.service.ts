import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Constellation } from '../models/constellation';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { ImageUrlData } from '../data/Image_data.model';

@Injectable({
  providedIn: 'root'
})

export class RequestService {

  constructor(private http: HttpClient) {  }

  getImageUrl(name: string): Observable<string> {

    return this.http.get('http://imageservicerevadex.azurewebsites.net/api/Image/' + name, {responseType: 'text'});

  }

  getJSON(url: string): Observable<string> {

    return this.http.get(url, {responseType: 'text'});

  }

  /* functions for getting planet/star/const info */
}
