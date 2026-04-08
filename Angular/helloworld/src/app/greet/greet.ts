import { Component } from '@angular/core';

@Component({
  selector: 'app-greet',
  imports: [],
  templateUrl: './greet.html',
  styleUrl: './greet.css',
})
export class Greet {
  public name:string="welcome to Angular";

  constructor(){ }

  greet(){
    alert('Show button clicked');
  }
  OnDivClick(){
    alert('Div Clicked');
  }
}
