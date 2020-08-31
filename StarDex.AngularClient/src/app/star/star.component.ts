import { Component, OnInit, Input } from '@angular/core';
import { ImageService } from '../services/image.service';
import { Observable } from 'rxjs';
import { ImageUrlData } from '../data/Image_data.model';
import { Star } from '../models/star';

@Component({
  selector: 'app-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnInit {
  @Input() star: Star;

  name: string;
  image$: Observable<string>;
  image: string;
  shouldOpen: boolean;
  showdistance: boolean;
  showtemperature: boolean;
  showmass: boolean;

  constructor(private img: ImageService) { }

  ngOnInit(): void {

    this.name = this.star.Name;
    this.image$ = this.img.getImageUrl(this.name);
    this.image$.subscribe((res) => {
      this.image = res;
    });
    this.shouldOpen = false;

    if (this.star.Distance > 0){
      this.showdistance = true;
    }

    if (this.star.Temperature > 0){
      this.showtemperature = true;
    }

    if (this.star.Mass > 0){
      this.showmass = true;
    }

  }

  toggleChild(): void {
    this.shouldOpen = !this.shouldOpen;
  }

}
