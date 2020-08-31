import { Component, OnInit } from '@angular/core';
import { ImageService } from '../services/image.service';
import { Constellation } from '../models/constellation';
import { Planet } from '../models/planet';
import { AllconstellationsService } from '../services/allconstellations.service';
import { timer, Observable } from 'rxjs';
import { ConstellationComponent } from '../constellation/constellation.component';
import { AllplanetsService } from '../services/allplanets.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  selectedConstellation: string;
  constellations: Constellation[];
  obv$: Observable<string>;
  obv2$: Observable<string>;
  planets: Planet[];
  mapurl: string;
  display: string;
  display2: number;
  mapStyle: string;

  constructor(private img: ImageService, private allconst: AllconstellationsService, private allplanets: AllplanetsService) { }

  ngOnInit(): void {
    this.mapurl = 'http://www.radicalcartography.net/stars4.png';
    this.obv$ = this.allconst.getConstellations();
    this.obv$.subscribe((res) => {

      this.display = res;
      this.constellations = JSON.parse(this.display) as Constellation[];

    });

    this.obv2$ = this.allplanets.getPlanets();
    this.obv2$.subscribe((res) => {

      this.planets = JSON.parse(res) as Planet[];

    });

    this.mapStyle = 'width: 100%; height: auto; position: relative;';

  }



}
