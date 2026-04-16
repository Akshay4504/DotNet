import { Host, Injectable } from '@angular/core';
import { HEROSList } from './mock-heros';
import { Hero } from './Hero';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class HeroService {
  selectedHero?:Hero;

  GetHeros():Observable<Hero[]>{
    return of(HEROSList);
  }

  GetTopHeros():Observable<Hero[]>{
    return of(HEROSList.slice(1,5));
  }

  // GetSelectedHero(): Hero {
  // return this.selectedHero!;
  // }
  
SaveSelectedHero(hero: Hero): void {
    this.selectedHero = hero;
  }

  GetHeroId(id: number): Observable<Hero> {
    let myH:Hero={id:0,name:''};
    HEROSList.forEach(item => {
      if(item.id === id){
        myH = item;
      } 
    });
    return of(myH);
  }
}
