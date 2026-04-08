import { Component } from '@angular/core';
import {HEROESList} from '../mock-heros';
import {Hero} from '../Hero';
import {CommonModule} from '@angular/common';
import { HeroDetails } from '../hero-details/hero-details'; 


@Component({
  selector: 'app-my-heros',
  imports: [CommonModule,HeroDetails],
  templateUrl: './my-heros.html',
  styleUrl: './my-heros.css',
})
export class MyHeros {
  selectedHero? : Hero;
  myheros? :Hero[]=HEROESList;

  onSelect(hero:Hero):void{
    this.selectedHero=hero;
  }
}
