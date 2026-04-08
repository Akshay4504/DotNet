import { Component } from '@angular/core';
import {Input} from '@angular/core';
import { Hero } from '../Hero';
import { HeroService } from '../hero-service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-hero-details',
  imports: [],
  templateUrl: './hero-details.html',
  styleUrl: './hero-details.css',
})
export class HeroDetails {
  //data passed from parent component via tag
  //@Input() myHero? : Hero;
  myHero?:any;
  constructor(private myHeroSvc:HeroService,
    private route:ActivatedRoute)
    {  }
    ngOnInit()
    {
      this.ComponentgetHero();

    }
    ComponentgetHero():void{
      const id=Number(this.route.snapshot.paramMap.get('id'));
      this.myHeroSvc.GetHeroById(id);
    }
  )
}
