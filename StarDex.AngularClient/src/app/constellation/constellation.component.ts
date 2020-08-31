import { Component, OnInit, Input } from '@angular/core';
import { ImageService } from '../services/image.service';
import { Observable } from 'rxjs';
import { Constellation } from '../models/constellation';

@Component({
  selector: 'app-constellation',
  templateUrl: './constellation.component.html',
  styleUrls: ['./constellation.component.css']
})
export class ConstellationComponent implements OnInit {
  @Input() showMe: boolean;
  @Input() constellation: Constellation;

  name: string;
  image$: Observable<string>;
  image: string;
  shouldOpen: boolean;
  buttonStyle: string;

  constructor(private img: ImageService) {
  }

  ngOnInit(): void {

    this.name = this.constellation.Name;
    this.image$ = this.img.getImageUrl(this.name);
    this.image$.subscribe((res) => {
      this.image = res;
    });
    this.shouldOpen = false;
    this.buttonStyle = 'top: ' + this.constellation.Top + 'px; left: ' + this.constellation.Left + 'px;';

  }

  toggleChild(): void {
    this.shouldOpen = !this.shouldOpen;
  }

}
