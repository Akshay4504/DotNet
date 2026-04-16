import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
// import { StudentService } from './services/student-service';
// import { StudentsList } from './components/students-list/students-list';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,  RouterLink],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Angular2WebApi');
}
