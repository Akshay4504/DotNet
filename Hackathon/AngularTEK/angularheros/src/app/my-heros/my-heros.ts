import { Component } from '@angular/core';
//import { HEROSList } from '../mock-heros';
import { Hero } from '../Hero';
import { CommonModule } from '@angular/common';
//import { HeroDetails } from '../hero-details/hero-details';
import { HeroService } from '../hero-service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-my-heros',
  imports: [CommonModule, RouterLink],
  templateUrl: './my-heros.html',
  styleUrl: './my-heros.css',
})
export class MyHeros {
  selectedHero?:Hero;
  myheroes? :Hero[];//Data gets populated by calling service method

constructor(private  myHeroSvc: HeroService){

}
  ngOnInit(){
    this.ComponentgetHeros();
    //this.myheroes =this.myHeroSvc.GetHeros();
  }

  ComponentgetHeros():void{
    this.myHeroSvc.GetHeros()
      .subscribe( data => this.myheroes = data);
    ;
  }

  onSelect(hero: Hero):void{
    // this.selectedHero =hero;
    this.myHeroSvc.SaveSelectedHero(hero);
  }
}
