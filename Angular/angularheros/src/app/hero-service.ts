import { Injectable } from '@angular/core';
import { Hero } from './Hero';
import { HEROESList } from './mock-heros';

@Injectable({
  providedIn: 'root',
})
export class HeroService {
}

GetSelectedHero(): Hero|any{
  return this.selectedHero
}

GetHeroById(id:number):Observable<Hero>{
  let myh: Hero={id:0,name:''}

}
