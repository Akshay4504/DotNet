import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeroForm } from './hero-form/hero-form';
import { LoginForm } from './login-form/login-form';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HeroForm, LoginForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('templateforms');
}
