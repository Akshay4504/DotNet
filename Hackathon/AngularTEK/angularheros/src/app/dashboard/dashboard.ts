import { Component } from '@angular/core';
import { Hero } from '../Hero';
import { HeroService } from '../hero-service';
import { RouterLink } from "@angular/router";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dashboard',
  imports: [RouterLink, CommonModule],
  templateUrl: './dashboard.html',
  styleUrl: './dashboard.css',
})
export class Dashboard {
  myheroes: Hero[] = [];

  constructor(private myHeroSvc: HeroService) {}

  ngOnInit() {
    this.ComponentgetHeroes();
  }

  ComponentgetHeroes(): void {
    this.myHeroSvc.GetTopHeros()
    .subscribe(hlist => this.myheroes = hlist);

    console.log(this.myheroes);
  }
}

