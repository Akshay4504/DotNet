import { Component } from '@angular/core';
import { Hero } from '../Hero';
import { CommonModule } from '@angular/common';
import { JsonPipe } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-hero-form',
  imports: [CommonModule, JsonPipe, FormsModule],
  templateUrl: './hero-form.html',
  styleUrl: './hero-form.css',
})
export class HeroForm {
  powers = ['Really Smart', 'Super Flexible', 'Super Hot', 'Weather Changer'];
  myHero =new Hero(18, 'Dr IQ', this.powers[0], 'Chuck Overstreet');

  submtted = false;

  onSubmit() { this.submtted = true; }
}
