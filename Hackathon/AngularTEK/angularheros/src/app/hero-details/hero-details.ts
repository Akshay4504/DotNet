import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Hero } from '../Hero';
import { HeroService } from '../hero-service';

@Component({
  selector: 'app-hero-details',
  imports: [],
  templateUrl: './hero-details.html',
  styleUrl: './hero-details.css',
})
export class HeroDetails implements OnInit {

  myHero?: Hero;

  constructor(
    private myHeroSvc: HeroService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.ComponentgetHero();
  }

  ComponentgetHero(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.myHeroSvc.GetHeroId(id)
      .subscribe((h1) => this.myHero = h1);
  }
}
