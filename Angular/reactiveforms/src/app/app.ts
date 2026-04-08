import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {NameEditor} from "./name-editor/name-editor";
import {ProfileEditor} from "./profile-editor/profile-editor";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,NameEditor,ProfileEditor],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('reactiveforms');
}
