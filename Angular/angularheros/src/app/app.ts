import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MyHeros} from './my-heros/my-heros';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,MyHeros],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('angularheros');
}
