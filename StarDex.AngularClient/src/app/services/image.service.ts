import { Injectable } from '@angular/core';
import { RequestService } from '../services/request.service';
import { Observable } from 'rxjs';
import { ImageUrlData } from '../data/Image_data.model';

@Injectable({
  providedIn: 'root'
})

export class ImageService {

  constructor(private req: RequestService) { }

  getImageUrl(name: string): Observable<string> {
    return this.req.getImageUrl(name);
  }

}
