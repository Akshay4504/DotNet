import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {HeroForm} from './hero-form/hero-form';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,HeroForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('template-forms');
}
