import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Greet } from './greet/greet';
import { Interpolation } from './interpolation/interpolation';
import { Binding } from './binding/binding';
import { MyForm } from './my-form/my-form';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,Greet,Interpolation,Binding,MyForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('helloAngularworld');
}
