import { Component, OnInit, Input } from '@angular/core';
import { ImageService } from '../services/image.service';
import { ImageUrlData } from '../data/Image_data.model';
import { Observable } from 'rxjs';
import { Planet } from '../models/planet';


@Component({
  selector: 'app-planet',
  templateUrl: './planet.component.html',
  styleUrls: ['./planet.component.css']
})
export class PlanetComponent implements OnInit {
  @Input() planet: Planet;

  name: string;
  image$: Observable<string>;
  image: string;
  shouldOpen: boolean;

  constructor(private img: ImageService) { }

  ngOnInit(): void {

    this.name = this.planet.Name;
    this.image$ = this.img.getImageUrl(this.name);
    this.image$.subscribe((res) => {
      this.image = res;
    });

    this.shouldOpen = false;

  }

  toggleChild(): void {
    this.shouldOpen = !this.shouldOpen;
  }

}
