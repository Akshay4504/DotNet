import { Component } from '@angular/core';
import { HeroService } from '../hero-service';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
})
export class Dashboard {
  myheroes:Hero[]=[];
  constructor(private myHeroSvc:HeroService){}

  
}
